salario = float(input('Qual é o salario do Funcionario? R$'))
novo = salario + (salario * 15 / 100)
print('Um funcionario que ganhava R${:.2f}, com 15% de aumento, passa a receber R${:.2F}'.format(salario, novo))

#DIGITE O SALARIO DO FUNCIONARIO PARA DESCOBRIR O VALOR DE ALMENTO DE 15%