# Вычислить число ПИ c заданной точностью *d*

isError = True
while isError == True:
    accuracyInput = input("Введите необходимую точность вычисления, от 0.1 до 0.0000000001: ")
    if accuracyInput.isdigit() != True and (0.0000000001 <= float(accuracyInput) <= 0.1): isError = False
    else: print("Ошибка ввода, повторите ввод!")

accuracy = len(accuracyInput.split(".")[1]) #Вычисляем кол-во знаков после точки

resEuler = 0
for i in range (1,1000000): resEuler += 1 / i**2

resPi = round((resEuler * 6) ** 0.5, accuracy)

print(f"Число ПИ = {resPi}")




