# Приложение для обработки массивов

Это приложение обрабатывает массивы целых чисел и находит пары `(a_i, a_{i+1})`, такие что:
- `a_i` делится на 3 без остатка.
- `a_{i+1}` меньше 0.

## Использование

1. Поместите входные данные в файл `input.txt`. Каждая строка должна содержать список целых чисел, разделенных запятыми.
   Пример:
   3,-1,6,2,9,-3,12,-5,15,-7,18,-9,21,-11,24,-13,27,-15,30,-17,33,-19,36,-21,39,-23,42,-25,45,-27,48,-29,51,-31,54,-33,57,-35,60,-37
   1,2,4,5,7,8,10,11,13,14,16,17,19,20,22,23,25,26,28,29,31,32,34,35,37,38,40,41,43,44,46,47,49,50,52,53,55,56,58,59
   -3,-2,-6,-5,-9,-8,-12,-11,-15,-14,-18,-17,-21,-20,-24,-23,-27,-26,-30,-29,-33,-32,-36,-35,-39,-38,-42,-41,-45,-44,-48,-47,-51,-50,-54,-53,-57,-56,-60,-59
   0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
