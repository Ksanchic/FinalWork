 ## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм решения задачи представлен 3 способами: 
Task 1 - с вводом элементов массива с клавиатуры

Task 2 и Task 3  исходный массив задается на старте 
 Общий алгоритм решения:
Внутри цикла проверяем условие - длина строки меньше или равна трем( <=3 ), если да элемент первого массива заносится в count элемент второго массива. 
После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. 
Повторяем пункты до тех пор пока не достигнем конца исходного массива, удовлетворяющего заданным условиям
В результате возвращаем новый заполненый массив 

## Блок-схема для алогритма task2, task3
![image](https://user-images.githubusercontent.com/119183210/209567934-09559579-18ba-4433-b90d-354cc914deb1.png)
## Блок-схема для решения task1

![Diagram drawio](https://user-images.githubusercontent.com/119183210/209569158-6063257a-32d5-457b-8c0a-77ca930ed5a9.png)
## Программа:

Для запуска программы перейдите в папку task1, task2 и task3 и запустите команду через терминал:

dotnet run 

Далее введите для task1 введите значения через пробел, например:

 3  hello  :-)  56  world
 
Пример вывода программы:

[3, hello, :-), 56, world] -> [3, :-), 56]
