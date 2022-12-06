num = int(input('Informe um numero: '))
n = num // 1 % 10
d = num // 10 % 10
c = num // 100 % 10
print('Analisando o numero{}'.format(num))
print('Unidade: {}'.format(n))
print('Dezena: {}'.format(d))
print('Centena: {}'.format(c))
