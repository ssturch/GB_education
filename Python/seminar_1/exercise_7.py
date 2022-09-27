#Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
quarter = input("Введите номер четверти 2D плоскости, I, II, III или IV: ")
strPart = "В данной четверти:" 
match quarter:
    case 'I':
        print(f"{strPart}")
        print("X ∈ (0 ; +∞)")
        print("Y ∈ (0 ; +∞)")
    case 'II':
        print(f"{strPart}")
        print("X ∈ (-∞ ; 0)")
        print("Y ∈ (0 ; +∞)")
    case 'III':
        print(f"{strPart}")
        print("X ∈ (-∞ ; 0)")
        print("Y ∈ (-∞ ; 0)")
    case 'IV':
        print(f"{strPart}")
        print("X ∈ (0 ; +∞)")
        print("Y ∈ (-∞ ; 0)")
    case _:
        print("Неверно указана четверть!")

