# Реализуйте алгоритм задания случайных чисел без использования встроенного генератора псевдослучайных чисел. ]
# БЕЗ КАКИХ ЛИБО РАНДОМОВ
# С помощью системного времени и значений ввода-вывода физ. дисков
import psutil
import math

def RandomDigit(dig):
    a = psutil.boot_time()
    b = psutil.disk_io_counters()
    c = (b[0] + b[1] + b[2] + b[3])/(b[4] * b[5])
    d = math.log(a, c)
    e = int(str(d).split(".")[1])
    res = e % (dig)
    return res

print(RandomDigit(10))

