import random

n = input('Em que numero eu pensei?')
r = random.randint(0, 5)
if n == r:
    print('Voce acertou')
else:
    print('Voce errou')
