# Создание своей игры на Unity в стиле Tower Defence

[#1 - Создание карты и врагов](https://www.youtube.com/watch?v=UoEzU8rHYTM)

- [OnCollisionEnter](https://docs.unity3d.com/ru/530/ScriptReference/MonoBehaviour.OnCollisionEnter.html)
- [OnTriggerEnter](https://docs.unity3d.com/ru/530/ScriptReference/MonoBehaviour.OnTriggerEnter.html)

+ Dev Environment:
  - **Unity Engine**: [2022.3 (LTS)](https://docs.unity3d.com/2022.3/Documentation/Manual)
  - **Microsoft Visual Studio**: 2022 (_Community_)

---
- `gameObject` - это как `this`
+ Все классы, которые унаследованы от `MonoBehaviour` - являются контроллерами
  - Контроллер - это елемент, который слушает все команды адресуемые этому элементу и меняет свое поведение
+ Чтобы привязать C#-скрипт к полю этого типа-класса из Unity, для этого нужно:
  - Создать пустой обьект (`Create Empty`), привязать к этому обьекту C#-скрипт
  - Тогда можно привязать C#-скрипт к полю, передав этот пустой обьект с C#-скриптом
- Другой способ создание обьекта этого типа-класса с помощю функции `GetComponent` (`_classOne = GetComponent<ClassOne>();`) || это альтернатива оператора `new`
- `Collision` - это компонент, который делает обьект твердым
- `isTrigger` - это метод, который только реагирует на коллизию НО Не делает обьект твердым
+ Используйте `OnCollisionEnter` - когда требуется, чтобы объекты сталкивались по законам физики
  - Для работы `OnCollisionEnter` оба объекта должны быть твердыми телами с выключенным `Is Trigger`
  - Для срабатывания функций `OnCollisionEnter` как минимум один из объектов в сцене обязан иметь компонент `Rigidbody`
+ Используйте `OnTriggerEnter` - когда объект должен проходить сквозь другой без физического отскока
  - Для работы `OnTriggerEnter` хотя бы на одном из объектов должен быть включен параметр `Is Trigger` (работает только с теми объектами, которые имеют галочку `Is Trigger`)
  - Для срабатывания функций `OnTriggerEnter` как минимум один из объектов в сцене обязан иметь компонент `Rigidbody`
  - [OnTriggerEnter в Unity C#](https://itproger.com/ua/spravka/unity/ontriggerenter)
  - [Что такое Trigger и Collision в Unity](https://www.youtube.com/watch?v=b9XcnmPZjB8)
---
Например: есть Игрок и предмет-инвертарь (монета, стена) И пускай будем использовать `OnTriggerEnter`
- И для Игрока и для Инвертаря должен быть установлен компонент-Collider
- Только для Инвертаря компонент-Collider должен стоять флажек `Is Trigger`
- Только для Инвертаря нужно добавить и включить уникальный тег
- Только для Игрока должен быть установлен компонент-Rigidbody
- Только для Игрока нужно добавить и включить C#-скрипт где реализованна функция `OnTriggerEnter` (с проверкой колайдера на Инвертарь)
---

[#3 - Враг преследующий игрока](https://www.youtube.com/watch?v=jxp4cuB1rgk)

[Как добавить игрока в Unity](https://www.youtube.com/watch?v=SOROBCmN16Y)


![Screenshot-0](Images/screenshot_00.png)

![Screenshot-1](Images/screenshot_01.png)

![Screenshot-2](Images/screenshot_02.png)

![Screenshot-3](Images/screenshot_03.png)
