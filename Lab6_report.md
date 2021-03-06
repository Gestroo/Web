<p align = center>МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>РОССИЙСКОЙ ФЕДЕРАЦИИ

<p align = center>ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>«ВЯТСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ»

<p align = center>Институт математики и информационных систем

<p align = center>Факультет автоматики и вычислительной техники

<p align = center>Кафедра систем автоматизации управления
<br>
<br>
<br>
<br>

<p align = right>Дата сдачи на проверку:

<p align = right>«___» __________ 2022 г.

<p align = right>Проверено:

<p align = right>«___» __________ 2022 г.
<br>
<br>
<br>
<br>
<br>


<p align = center>Отчет по лабораторной работе № 6

<p align = center>по дисциплине

<p align = center>«Web-программирование»

<br>
<br>
<br>
<br>


<p align = center>Разработал студент гр. ИТб-2301-01-00 ________________ /Широков Д.Р./

<p align = center>Проверил ст. преподаватель _________________ /Земцов М.А./

<p align = center>Работа защищена с оценкой «___________» «___» __________ 2022 г.

<br>
<br>
<br>
<br>

<p align = center>Киров 2022

<hr>
Цель: Сравнить менеджеры состояний (компонентов) для React на примере приложения ToDo List.

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Менеджер состояний Hooks(MobX)
1. Менеджер состояний Redux
1. Менеджер состояний Recoil
1. Сравнение менеджеров состояний


Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Gestroo/Web)* на сайте github.com были созданы три новые ветки с названиями lab6.1, lab6.2 и lab6.3 от ветки main.

2. Менеджер состояний Hooks(MobX)

Hooks - это встроенный в React аналог менеджера состояний компонтов. MobX - библиотека расширяющая возможности Hooks. Hooks React позволяют, при работе с функциональными компонентами, пользоваться аналогом состояния компонентов, основанных на классах, и аналогами методов их жизненного цикла. Hooks появились в React 16.8.

Среди основных сильных сторон хуков можно отметить следующие:

- Возможность использования состояния и обработки событий жизненного цикла компонентов без применения компонентов, основанных на классах.
- Совместное хранение связанной логики в одном и том же месте компонента вместо разбиения подобной логики между несколькими методами жизненного цикла.
- Совместное использование механизмов, независимых от реализации компонента (это похоже на шаблон render prop).

В ходе лабораторной работы был разобран пример реализации приложения todolist с использованием Hooks(MobX). Приложение добавленно в репозиторий git *[ссылка на ветку](https://github.com/Gestroo/Web/tree/lab6.3)*.
Результат работы приложения представлен на рисунке 1.


<p align=center><img src="./Image/lab6-hooks.png" alt="hooks"></p>
<p align = center>Рисунок 1 – ToDo List с использованием Hooks


3. Менеджер состояний Redux

Redux — это библиотека, реализующая предсказуемое хранилище состояния приложений. Это, кроме того, архитектура, которая легко интегрируется с React.

Основные сильные стороны Redux:

- Детерминированное представление состояния (в комбинации с чистыми компонентами это даёт возможность формирования детерминированных визуальных элементов).
- Поддержка транзакционных изменений состояния.
- Изоляция управления состоянием от механизмов ввода-вывода данных и побочных эффектов.
- Наличие единого источника достоверных данных для состояния.
- Лёгкая организация совместной работы с состоянием в различных компонентах.
- Средства анализа транзакций (автоматическое логирование объектов действий).
- Отладка с возможностью записи и воспроизведения процесса выполнения программы (Time Travel Debugging, TTD).


В ходе лабораторной работы был разобран пример реализации приложения todolist с использованием Redux. Приложение добавленно в репозиторий git *[ссылка на ветку](https://github.com/Gestroo/Web/tree/lab6.1)*.
Результат работы приложения представлен на рисунке 2.


<p align=center><img src="./Image/lab6-redux.png" alt="redux"></p>

<p align = center>Рисунок 2 – ToDo List с использованием Redux


4. Менеджер состояний Recoil

Recoil располагает себя как библиотека, имеющая относительно малый размер, исключительно для React, что поможет решать проблемы в диапазоне данного фреймворка.

Сильные стороны Recoil:

- Высокая произовдительность.
- Относительно малый размер библиотеки.
- Удобство для пользователя.

В ходе лабораторной работы был разобран пример реализации приложения todolist с использованием Hooks(MobX). Приложение добавленно в репозиторий git *[ссылка на ветку](https://github.com/Gestroo/Web/tree/lab6.2)*.
Результат работы приложения представлен на рисунке 3.

<p align=center><img src="./Image/lab6-recoil.png" alt="recoil"></p>

<p align = center>Рисунок 3 – ToDo List с использованием Recoil

5. Сравнение менеджеров состояний

Каждый менеджер состояния может заменить другой. При выборе того или другого стоит обратить внимание на объем проекта, удобства использования менеджера и скорость его работы.

Если проект состоит из одного визуального компонента, он не сохраняет данные в состояние и в нём не выполняются асинхронные операции ввода-вывода, то для такого проекта отлично подойдет Hooks. Если в проекте используются стандартные модели состояния компонентов React, то Hooks будет более удобен.

Применение возможностей Redux в компонентах может оказаться оправданным в том случае, если компоненты отличаются следующими особенностями:

- Они пользуются средствами ввода-вывода. Например — работают с сетью или с некими устройствами.
- Они сохраняют данные в состояние или загружают их из него.
- Они работают со своим состоянием совместно с компонентами, не являющимися их потомками.
- Они имеют дело с любой бизнес-логикой, с которой имеют дело и другие части приложения, либо — выполняют обработку данных, которые используются в других частях приложения.

Молодая библиотека Recoil может иметь смысл для огромных приложений, которые должны отображать большое количество компонентов на странице.


Вывод: в ходе выполнения лабораторной работы рассмотрены три менеджера состояний и их особенности на примере реализации приложения ToDo list. В результате иследования было выявлено, что наиболее оптимальным решением является использование менеджера состояний Redux.