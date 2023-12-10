# 💻 DiffusionWinFormsApp

💻 ✨ Программа «Диффузия», моделирующая реальный процесс взаимного проникновения молекул одного вещества между молекулами другого и написанная в процессе изучения технологии **Windows Forms** и **ООП**.

<div align="center"><img src="https://github.com/snikitin-de/DiffusionWinFormsApp/assets/25394427/7d1d1ef1-cb57-48ef-9088-0a90244836d6"></div>

## 📄 Описание

Экран разделен на две половинки. В каждой части экрана по умолчанию появляется одинаковое количество шариков, но разного цвета. Количество шариков на каждой части экрана можно задать с помощью соответствующих ползунков.

По щелчку мыши в произвольном месте шарики начинают случайное движение. Для каждой границы экрана считается количество соударений со стенкой каждого цвета шариков.

По щелчку мыши шарики останавливаются и можно посмотреть "давление газа на стенки сосуда для различных газов".

Когда произойдет "полное перемешивание газов" процесс останавливается. Диффузия является завершенной, когда количество ударов на единицу длины на всех стенках примерно одинаковое. Величину погрешности сравнения можно задать с помощью соответствующих ползунков.

<div align="center"><img src="https://github.com/snikitin-de/DiffusionWinFormsApp/assets/25394427/0b3d74f1-d5f4-4e8c-84a5-6689dfc48302"></div>

### 💻 Работа программы

Пример работы программы:

![Пример работы программы](https://github.com/snikitin-de/DiffusionWinFormsApp/assets/25394427/c2585aa9-bd11-498d-abd8-a01435e26031)

## 🔧 Техническая часть

* Проект реализован на платформе **Windows Forms**.
* Выполнен с соблюдением принципов **ООП**.

### 🧩 Архитектура

Структура каталога решения:

![Структура каталога решения](https://github.com/snikitin-de/DiffusionWinFormsApp/assets/25394427/059452c7-fe74-4264-b138-18804379f42b)

Проект "Common" является общей библиотекой классов для следующих проектов:

* [BallGamesWinFormsApp](https://github.com/snikitin-de/BallGamesWinFormsApp)
* [DiffusionWinFormsApp](https://github.com/snikitin-de/DiffusionWinFormsApp)
* [FruitNinjaWinFormsApp](https://github.com/snikitin-de/FruitNinjaWinFormsApp)
* [FireworkWinFormsApp](https://github.com/snikitin-de/FireworkWinFormsApp)

Библиотека содержит общий класс "Ball" от которого наследуются другие шарики со своими особенностями.

### 📝 Определение момента завершения диффузии

Часть кода с определением момента завершения процесса диффузии:

```csharp
private double CalculateEvennessFactor(int wallCountHitted, int wallLength)
{
   return Math.Round(wallCountHitted / (double)wallLength, 4);
}

private bool EqualTo(double value1, double value2, double epsilon)
{
   return Math.Abs(value1 - value2) < epsilon;
}

public List<EvennessFactor> CalculateEvennessFactor()
{
   var evennessFactors = new List<EvennessFactor>();
   var topEvenessFactor = CalculateEvennessFactor(topCountHitted, width);
   var bottomEvenessFactor = CalculateEvennessFactor(bottomCountHitted, width);
   var leftEvenessFactor = CalculateEvennessFactor(leftCountHitted, height);
   var rightEvenessFactor = CalculateEvennessFactor(rightCountHitted, height);

   evennessFactors.Add(new EvennessFactor(Side.Top, topEvenessFactor));
   evennessFactors.Add(new EvennessFactor(Side.Bottom, bottomEvenessFactor));
   evennessFactors.Add(new EvennessFactor(Side.Left, leftEvenessFactor));
   evennessFactors.Add(new EvennessFactor(Side.Right, rightEvenessFactor));

   return evennessFactors;
}

public bool IsEnd()
{
   var evennessFactors = CalculateEvennessFactor();
   var isEnd = false;

   if(evennessFactors.Max(x => x.EvennessFactorValue) > epsilon)
   {
       var evennessFactorsMin = evennessFactors.Min(x => x.EvennessFactorValue);
       var evennessFactorsMax = evennessFactors.Max(x => x.EvennessFactorValue);

       isEnd = EqualTo(evennessFactorsMin, evennessFactorsMax, epsilon);
   }

   return isEnd;
}
```
