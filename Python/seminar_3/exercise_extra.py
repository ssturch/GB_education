# Реализуйте алгоритм задания случайных чисел без использования встроенного генератора псевдослучайных чисел. ]
# БЕЗ КАКИХ ЛИБО РАНДОМОВ
import psutil
import math

def RandomDigit(dig):
    a = sum(psutil.cpu_percent(interval=1, percpu=True))
    b = psutil.cpu_count()
    c = math.log(a, b)
    d = int(str(c).split(".")[1])
    res = d % (dig)
    return res

print(RandomDigit(100))

