
soma = 0

for i in range(1, 4):
    print(i)
    nota = int(input(f"Digite a sua nota apenas valores de 1 a 10. |{i}|:"))
    soma = soma + nota
somaf = soma / 3

print("Sua media final é... {}".format(somaf))

if somaf >= 7:
    print("Voce passou parabens")

elif somaf == 6:
    print("Voce esta de recuperaçao")

else:
    print("Voce reprovou")
