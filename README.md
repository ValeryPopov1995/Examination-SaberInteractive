# Examination-SaberInteractive
Test assignment for the position of game logic programmer at Saber Interactive studio
Тестовое задание на должность программиста игровой логики студии Saber Interactive

# Задание 1 ([Результат](https://github.com/ValeryPopov1995/Examination-SaberInteractive/blob/master/ListNode%20Serialization/Examination%20-%20ListNode%20Serialization/ListRand.cs))

Реализуйте функции сериализации и десериализации двусвязного списка, заданного следующим образом:

    class ListNode
    {
        public ListNode Prev;
        public ListNode Next;
        public ListNode Rand; // произвольный элемент внутри списка
        public string Data;
    }

    class ListRand
    {
        public ListNode Head;
        public ListNode Tail;
        public int Count;

        public void Serialize(FileStream s)
        {
        }

        public void Deserialize(FileStream s)
        {
        }
    }
    
Примечание: сериализация подразумевает сохранение и восстановление полной структуры списка, включая взаимное соотношение его элементов между собой — в том числе ссылок на Rand элементы.
- Алгоритмическая сложность решения должна быть меньше квадратичной.
- Нельзя добавлять новые поля в исходные классы ListNode, ListRand.
- Для выполнения задания можно использовать любой общеиспользуемый язык.
- Тест нужно выполнить без использования библиотек/стандартных средств сериализации.

# Задание 2 ([Результат](https://github.com/ValeryPopov1995/Examination-SaberInteractive/blob/master/BaheviourTree%20-%20AI/BT_AI.jpg))

Напишите ИИ  для противника используя BhvTree (достаточно нарисовать схему, реализация в каком-либо из движков не требуется).
- Солдат - сущность, которая может стрелять, перезаряжаться, отправиться в указанную точку и ждать.
- Солдат проводит патруль по зацикленному маршруту по точкам А и Б.
- По прибытии на точку солдат останавливается на 10 минут в ожидании врага. Если за 10 минут враг не появился, солдат идет на следующую точку.
- Если враг обнаружен (на любой дистанции), солдат производит 10 выстрелов с паузой 5 секунд между каждым.
