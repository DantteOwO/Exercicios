largura =  float(input('Largura da parede: '))
altura = float(input('Altura da parede: '))
area = largura * altura
print('Sua parede tem a dimensão de {}x{} e sua área é de {} metros quadrados.' .format(largura, altura, area))
tinta = area / 2
print('Para pintar essa parede, vocé vai precisar de {}L de tinta'.format(tinta))