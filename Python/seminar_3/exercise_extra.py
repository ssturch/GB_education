# Реализуйте алгоритм задания случайных чисел без использования встроенного генератора псевдослучайных чисел. 
# БЕЗ КАКИХ ЛИБО РАНДОМОВ
# С помощью загрузки процессора
import psutil
import math

def RandomDigit(dig):
    a = 0
    while a == 0:
        a = sum(psutil.cpu_percent(interval=0.1, percpu=True))
    b = psutil.cpu_count()
    c = math.log(a, b)
    d = int(str(c).split(".")[1])
    res = d % (dig)
    return res

print(RandomDigit(10))

