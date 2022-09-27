#Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

def userCoordinateInput():
    x = int(input("Введите значение X: "))
    y = int(input("Введите значение Y: "))
    return [x, y]

def calculateLengthByPoints(x1, x2, y1, y2):
    length = ((x1 - x2) ** 2 + (y1 - y2) ** 2) ** (0.5)
    return length

print("Введите координаты точки А:")
coordPointA = userCoordinateInput()
print("Введите координаты точки В:")
coordPointB = userCoordinateInput()

result = calculateLengthByPoints(coordPointA[0], coordPointB[0], coordPointA[1], coordPointB[1])
print(f"Длина отрезка AB = {round(result, 3)}")