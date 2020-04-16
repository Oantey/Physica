﻿using System;
using System.Text;

namespace physica
{
    class Program
    {
        static void Chapter1()
        {
            int page = 1; int ans = 0;
            do
            {
                switch (page)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Зайомимося з механічним рухом.                                              |");
                        Console.WriteLine("|Усе у світі перебуває в русі: мільярди років, що існує Всесвіт,             |");
                        Console.WriteLine("|розлітаються одна від одної галактики; Земля обертається навколо Сонця,     |");
                        Console.WriteLine("|здійснюючи один оберт за рік; за декілька годин літак перелітає з           |");
                        Console.WriteLine("|Києва до Парижа; у краплині води безліч мікробів щосекунди пересувається з  |");
                        Console.WriteLine("|місця на місце; увесь час рухаються молекули.                               |");
                        Console.WriteLine("|Незважаючи на розмаїття прикладів руху, для них можна визначити спільні     |");
                        Console.WriteLine("|риси: по-перше, всі тіла, що рухаються, змінюють своє положення в просторі  |");
                        Console.WriteLine("|відносно інших тіл; по-друге зміна положення  тіл відбувається з плином     |");
                        Console.WriteLine("|часу.                                                                       |");
                        Console.WriteLine("|Найпростішим різновидом руху є механічний рух.                              |");
                        Console.WriteLine("|Механічний рух - це зміна з часом положення тіла або частин тіла в          |");
                        Console.WriteLine("|просторі відносно інших тіл.                                                |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|Даємо означення системи відліку.                                            |");
                        Console.WriteLine("|Коли тіло рухається, його положення в просторі змінюється. Для визначення   |");
                        Console.WriteLine("|положення тіла в просторі використовують систему координат, яку пов'язують  |");
                        Console.WriteLine("|                                                                Сторінка 1  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|із тілом відліку.                                                           |");
                        Console.WriteLine("|Тіло, відносно якого розглядається положення рухомого тіла, називають       |");
                        Console.WriteLine("|тілом відліку.                                                              |");
                        Console.WriteLine("|Вибір тіла відліку є довільним. За тіло відліку можна взяти будь-яке тіло   |");
                        Console.WriteLine("|з міркувань зручності. Це може бути як вагон потяга, так і перон вокзалу,   |");
                        Console.WriteLine("|як дерево на узбіччі, так і автомобіль, що мчить дорогою. Тілом відліку     |");
                        Console.WriteLine("|можуть бути і планета Земля, і Сонце, і далекі галактики.                   |");
                        Console.WriteLine("|Після того як тіло відліку вибрано, з ним пов'язують систему координат.     |");
                        Console.WriteLine("|Система координат задається за допомогою однієї, двох або трьох             |");
                        Console.WriteLine("|координатних осей; уздовж осей відкладають відстані в обраному масштабі,    |");
                        Console.WriteLine("|наприклад у кілометрах або метрах.                                          |");
                        Console.WriteLine("|Зміна положення тіла відбувається миттєво, а протягом певного проміжку      |");
                        Console.WriteLine("|часу, тому для дослідження  механічого руху є ткож необхідним прилад для    |");
                        Console.WriteLine("|відліку часу - годинник.                                                    |");
                        Console.WriteLine("|Тіло відліку, пов'язана з ним система координат і годинник утворюють        |");
                        Console.WriteLine("|систему відліку.                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                Сторінка 2  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Визначимо, коли тіло можна вважати за матеріальну точку.                    |");
                        Console.WriteLine("|Зазвичай під час руху тіла кожна його точка рухається по-різному. На        |");
                        Console.WriteLine("|практиці дослідити рух усіх точок тіла досить складно, та часто в цьому й   |");
                        Console.WriteLine("|немає потреби. Описуючи рух тіла, розміри якого наьагато меші, ніж          |");
                        Console.WriteLine("|відстані, які воно долає, тіло замінюють на фізичну модель - матеріальну    |");
                        Console.WriteLine("|точку. Матеріальна точка не має розмірів, а її маса дорівнює масі даного    |");
                        Console.WriteLine("|тіла.                                                                       |");
                        Console.WriteLine("|Матеріальна точка - це фізична модель тіла, розмірами якого в умовах даної  |");
                        Console.WriteLine("|задачі можна знехтувати.                                                    |");
                        Console.WriteLine("|Те саме тіло в умовах однієї задачі можна вважати матеріальною точкою, а в  |");
                        Console.WriteLine("|умовах іншої - не можна.                                                    |");
                        Console.WriteLine("|Уявіть собі автомобіль, який прямує трасою з Одеси до Києва, і цей же       |");
                        Console.WriteLine("|автомобіль, коли він паркується на автосоянці. У першому випадку,           |");
                        Console.WriteLine("|досліджуючи рух автомобіля, його розмірами можна знехтувати. Тобто можна    |");
                        Console.WriteLine("|не враховувати, що під час руху автомобіля його окремі точки рухалися по-   |");
                        Console.WriteLine("|різному, аже відстань, яку подолав автомобіль, біла набагато більшою, ніж   |");
                        Console.WriteLine("|його скажімо довжина. У другому випадку нехтувати розмірами автомобіля не   |");
                        Console.WriteLine("|                                                                Сторінка 3  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|можна.                                                                      |");
                        Console.WriteLine("|Зверніть увагу! Коли ми визначаємо координати тіла, то вважаємо це тіло за  |");
                        Console.WriteLine("|матеріальну точку. Далі, коли говоритимемо про рух тіла, будемо вважати,    |");
                        Console.WriteLine("|що йдется про рух матеріальної точки.                                       |");
                        Console.WriteLine("|Дізнаємося про відностність руху та спокою.                                 |");
                        Console.WriteLine("|Те, що тіло відліку обирається довільно, означає, що стан руху і стан       |");
                        Console.WriteLine("|спокою є відносним.                                                         |");
                        Console.WriteLine("|Уявіть пасажира, який їде, сидячи на кріслі вагона потяга. Відносно крісла  |");
                        Console.WriteLine("|та вагона пасажир не змінює свого положення з часом, тобто перебуває  у     |");
                        Console.WriteLine("|стані спокою, а відносно дерев за вікном пасажир рухається.                 |");
                        Console.WriteLine("|Відностінсть руху дає можливість (зупинити) автомобіль, що мчить дорогою.   |");
                        Console.WriteLine("|Для цього потібний ще один автомобіль, який рухається поряд із першим, не   |");
                        Console.WriteLine("|відстаючи і не обганяючи його. У такому випадку автомобілі один відносно    |");
                        Console.WriteLine("|одного перебуватимуть у стані спокою. Згадайте, як каскадери пересідають з  |");
                        Console.WriteLine("|одного автомобіля, що мчить, на інший, що рухається поряд! Той самий        |");
                        Console.WriteLine("|принцип використовують і для запралення літака пальним під час польоту.     |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                Сторінка 4  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                }
                Console.Write("=>");
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                    page--;
                if (ans == 2)
                    page++;
                if (page == 0)
                {
                    Console.WriteLine("Це перша сторінка, перегорнути в цей бік неможливо!");
                    page++;
                    Console.ReadKey();
                }
            } while (page <= 4);
        }
        static void Chapter2()
        {
            int page = 1; int ans = 0;
            do
            {
                switch (page)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Дізнаємося про траєкторію руху.                                             |");
                        Console.WriteLine("|Траєкторія руху - це уявна лінія, яку описує в просторі точка, що           |");
                        Console.WriteLine("|рухається.                                                                  |");
                        Console.WriteLine("|азвичай ми не бачимо траєкторії руху тіл, проте інколи бувають вийнятки.    |");
                        Console.WriteLine("|Так, у безхмарну погоду високо в небі можна побачити білий слід, який       |");
                        Console.WriteLine("|залишає літак під час свого руху. За цим слідом можна дізнатися про         |");
                        Console.WriteLine("|траєкторію руху літака.                                                     |");
                        Console.WriteLine("|Форма траєкторії може бути різною: пряма, коло, дуга, ламана тощо. За       |");
                        Console.WriteLine("|формаою траєкторї рух тіл поділяють на прямолінійний і криволінійни.        |");
                        Console.WriteLine("|Форма траєкторії руху тіла залежить від того, відносно якої системи         |");
                        Console.WriteLine("|відліку розглядають рух.                                                    |");
                        Console.WriteLine("|Навдемо приклад. У хлопчика, який їде в автобусі, впало з рук яблуко. Для   |");
                        Console.WriteLine("|дівчинки, яка сидить навпроти, трєкторія руху яблука - короткий відрізок    |");
                        Console.WriteLine("|прямої. У цьому випадку система відліку, відносно якої розглядають рух      |");
                        Console.WriteLine("|яблука, пов'язана із салоном автобуса. Але весь час, поки яблуко палало,    |");
                        Console.WriteLine("|воно їхало разом з автобусом, тому для людини, що стоїть на узбіччі         |");
                        Console.WriteLine("|дороги, траєкторія руху яблука зовсім інша. Система відліку в такому разі   |");
                        Console.WriteLine("|                                                                Сторінка 1  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|пов'язана з дорогою.                                                        |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|З'ясовуємо, чим шлях відрізняється від переміщення                          |");
                        Console.WriteLine("|Повернемося на початок парграфа, щоб знайти шлях, який подолав кінець       |");
                        Console.WriteLine("|олівця, рисуючи криву лінію, необхідно виміряти довжину цієї лінії, тобто   |");
                        Console.WriteLine("|знайти довжину траєкторії.                                                  |");
                        Console.WriteLine("|Шлях - це фізична величина, яка дорівнює довжині траєкторії.                |");
                        Console.WriteLine("|Шлях позначають символом l. Одиниця шляху в СІ - метр: [l] = [м].           |");
                        Console.WriteLine("|Використовують також частинні та кратні одиниці шляху, наприклад міліметр   |");
                        Console.WriteLine("|(мм), сантиметр (см), кілометр (км):                                        |");
                        Console.WriteLine("|1 мм = 0,001 м                                                              |");
                        Console.WriteLine("|1 см = 0,01 м                                                               |");
                        Console.WriteLine("|1 км = 1000 м                                                               |");
                        Console.WriteLine("|Шлях, який подолало тіло, буде різним відносно різних систем відліку.       |");
                        Console.WriteLine("|Згааємо яблуко в автобусі, для пасажирів яблуко палало шлях близько         |");
                        Console.WriteLine("|півметра, а для людини на узбіччі дороги - декілька метрів.                 |");
                        Console.WriteLine("|Звернемося знову олівця і з'єднаємо напряму точку початку та завершення     |");
                        Console.WriteLine("|                                                                Сторінка 2  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|руху олівця. Отримаємо напрямлений відрізок, який покаже, в якому напрямку  |");
                        Console.WriteLine("|та на яку відстань перемістився кінець олівця.                              |");
                        Console.WriteLine("|Напрямлений відрізок прямої, який з'єднує початкове  та кінцеве положення   |");
                        Console.WriteLine("|тіла, називають  переміщенням.                                              |"); 
                        Console.WriteLine("|Переміщення позначають s. (стріка над літерою).                             |");
                        Console.WriteLine("|Стрілка над символом фізичної велечини показує, що переміщення - це         |");
                        Console.WriteLine("|векторна фізична величина. Щоб правильно задати переміщення, необхідно      |");
                        Console.WriteLine("|зазаначити не тільки його значення (модуль), але й напрямок.                |");
                        Console.WriteLine("|Модуль переміщення, тобто відстань, на яку перемістилося тіло в певному     |");
                        Console.WriteLine("|напрямку, також позначають символом s, але без стрілки.                     |");
                        Console.WriteLine("|Одиниця переміщення в СІ така сама як і одиниця шляху, - метр:              |");
                        Console.WriteLine("|[s] = [м]                                                                   |");
                        Console.WriteLine("|У загальному випадку переміщення не збігається з траєутрією руху тіла,      |");
                        Console.WriteLine("|тому шлях, подоланий тілом, зазвичай більший за модуль переміщення. Шлях і  |");
                        Console.WriteLine("|модуль переміщення виявляються рівними лише в тому випадку, коли тіло       |");
                        Console.WriteLine("|рухається вздовж прямої в незмінному напрямку.                              |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                Сторінка 3  |");
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("           <-  на сторінку назад (1)   на сторінку вперед (2) ->");
                        break;
                    
                }
                Console.Write("=>");
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                    page--;
                if (ans == 2)
                    page++;
                if (page == 0)
                {
                    Console.WriteLine("Це перша сторінка, перегорнути в цей бік неможливо!");
                    page++;
                    Console.ReadKey();
                }
            } while (page <= 3);
        }
        static void Chapter3()
        {
            int page = 1; int ans = 0;
            do
            {
                switch (page)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Рівномірний рух. Швидкість руху.                                            |");
                        Console.WriteLine("|Знайомство з рівномірним рухом.                                             |");
                        Console.WriteLine("|Слово швидкість ви знаєте змалку. Тому, коли чуєте, що швидкість  руху      |");
                        Console.WriteLine("|автомобіля становить 20 метрів за секунду, то розумієте: автомобіль,        |");
                        Console.WriteLine("|рухаючись з такою швидкістю, кожну секунду долає відстань 20 м. Скоріш за   |");
                        Console.WriteLine("|все, більшість із вас відповідали так: за 10 с автомобіль подолає 200 м,    |");
                        Console.WriteLine("|за півсекунди - 10 м, за 0,1 с - 2 м. І ці відповіді є правильними, якщо    |");
                        Console.WriteLine("|вважати, якщо вважати, що за будь-які (малі або великі) рівні інтервали     |");
                        Console.WriteLine("|часу автомобіль долає однаковий шлях. Тобто якщо рух автомобіля є рівним.   |");
                        Console.WriteLine("|Рівномірний рух - це маханічний рух, у ході якого за будь-які рівні         |");
                        Console.WriteLine("|інтервали часу тіло долає однаковий шлях.                                   |");
                        Console.WriteLine("|Зверніть увагу на слова (будь які рівні інтервали часу). Інколи,            |");
                        Console.WriteLine("|розглядаючи навіть нерівномірний рух тіла, теж можна дібрати такі рівні     |");
                        Console.WriteLine("|інтервали часу, за які тіло долає однакову відстань. Наприклад за кожні 30  |");
                        Console.WriteLine("|с плавець пропливає доріжку в басейні (25 м), проте, не можна               |");
                        Console.WriteLine("|стверджувати, що він ріхається рівномірно, бо під час розвороту він         |");
                        Console.WriteLine("|сповільнує рух.                                                             |");
                        Console.WriteLine("|                                                                Сторінка 1  |");
                        Console.WriteLine("==============================================================================");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Вивчаємо рівномірний прямолінійний рух.                                     |");
                        Console.WriteLine("|Якщо автомобіль рівномірно рухається прямолінійною ділянкоб дороги, то за   |");
                        Console.WriteLine("|рівні інтервали часу він здійснює однакові переміщення, тобто долає         |");
                        Console.WriteLine("|однаковий шлях і не змінює напрямку свого руху. Такий рух називають         |");
                        Console.WriteLine("|рівномірним прямолінійним.                                                  |");
                        Console.WriteLine("|Рівномірний прямолінійний рух - це механічний рух, у ході якого за будь-    |");
                        Console.WriteLine("|які рівні інтервали часу тіло здійснює однакові переміщення.                |");
                        Console.WriteLine("|Рівномірний прямолінійний рух - найпростіший вид руху, який у реальному     |");
                        Console.WriteLine("|житті зустрічається дуже рідко. Прикладами такого руху можуть бути рух      |");
                        Console.WriteLine("|автомобіля на прямолінійній ділянці дороги (без розгону та гальмування),    |");
                        Console.WriteLine("|стабільне падіння кульки в рідині, політ парашутиста через деякий час       |");
                        Console.WriteLine("|після розкритя паршута.                                                     |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|Даємо означення швидкості рівномірного руху                                 |");
                        Console.WriteLine("|Сподіваємося, вам неважко визначити швидкість рівномірного руху, наприклад  |");
                        Console.WriteLine("|, пішохода, який пройшов 30 м за 20 с. Із курсу математики вам буде         |");
                        Console.WriteLine("|відомо, що для цього слід шлях, який подолав пішоход (l=30 м), поділити на  |");
                        Console.WriteLine("|                                                                Сторінка 2  |");
                        Console.WriteLine("==============================================================================");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|час його руху (t=20с).                                                      |");
                        Console.WriteLine("|     l                                                                      |");
                        Console.WriteLine("|U = ---                                                                     |");
                        Console.WriteLine("|     t                                                                      |");
                        Console.WriteLine("|Зверніть увагу! Уході рівномірного прямолінійного руху модуль переміщення   |");
                        Console.WriteLine("|дорівнює шляху (s = l), тому значення швидкості руху можна визначити за     |");
                        Console.WriteLine("|будь-якою з формул:                                                         |");
                        Console.WriteLine("|   s            l                                                           |");
                        Console.WriteLine("|U=---   або  U=---                                                          |");
                        Console.WriteLine("|   t            t                                                           |");
                        Console.WriteLine("|У міжнародній системі одиниць шлях вимірюють у метрах, час - у секундах,    |");
                        Console.WriteLine("|тому одиниця швидості руху в CІ - метр за секунду:                          |");
                        Console.WriteLine("|[U] = [м/с]                                                                 |");
                        Console.WriteLine("|1 м/с дорівнює швидкосіт такогоро рівномірного руху, в ході якого тіло за   |");
                        Console.WriteLine("|1 с долає шлях 1 м.                                                         |");
                        Console.WriteLine("|Приладом для вимірювання швидкості слугує спідометр.                        |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                Сторінка 3  |");
                        Console.WriteLine("==============================================================================");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|Характеризуємо швидкість руху.                                              |");
                        Console.WriteLine("|Швидкість руху - векторна величина: вона має не лише значення, а й          |");
                        Console.WriteLine("|напрямок. На рисунках напрямок швидкості тіла позначають стрілкою. Якщо     |");
                        Console.WriteLine("|тіло рухається рівномірно прямолінійно, то значення і напрямок швидкості    |");
                        Console.WriteLine("|руху залишаються незмінними. Якщо тіло рухається рівномірно криволінійною   |");
                        Console.WriteLine("|траєеторією, значення швидкості руху залишається незмінним, а напрямок      |");
                        Console.WriteLine("|увесь час змінюється.                                                       |");
                        Console.WriteLine("|Напрямок і значення швидкості руху залежить від того, відносно якого тіла   |");
                        Console.WriteLine("|розглядають рух. Уявіть, що ви сидите у вагоні потяга, який прямує на       |");
                        Console.WriteLine("|схід. Потяг прїзджає повз станцію зі швидкістю Uпот =  5 м/с. У цей час     |");
                        Console.WriteLine("|інший пасажир іде вагоном зі швидкістю Uпас = 0,5 м/с, рухаючись проти      |");
                        Console.WriteLine("|руху потяга.                                                                |");
                        Console.WriteLine("|Як ви вважаєте, чи однаковою буде швидкість руху пасажира для вас і людей,  |");
                        Console.WriteLine("|що стоять на пероні? Звісно, ні! Для вас пасажир рухається на захід зі      |");
                        Console.WriteLine("|швидкістю 0,5 м/с, а для людей на пероні він разом із пртягом рухається на  |");
                        Console.WriteLine("|сіхд зі швидкістю 4,5 м/с.                                                  |");
                        Console.WriteLine("|Значення швидкості руху може бути подано не тільки в метрах ха секунду,     |");
                        Console.WriteLine("|                                                                Сторінка 4  |");
                        Console.WriteLine("==============================================================================");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|але й в інших одиниях. Наприклад, автомобоіль рухається зі швидкістю 36     |");
                        Console.WriteLine("|кілометрів за годину ( Uавт = 36 км/год ), ракета мчить зі швидкістю 8      |");
                        Console.WriteLine("|кілометрів за секунду (  Uр = 8 км/с ), равлик повзе зі швидкістю 18        |");
                        Console.WriteLine("|сантиметрів на хвилину ( Uравл = 18 см/хв ) тощо.                           |");
                        Console.WriteLine("|Для розв'язування задач слід навчитися подавати швидкість руху, виражену в  |");
                        Console.WriteLine("|одних одниницях, в інших однинцях. Як це зробити? Наведемо проиклад.        |");
                        Console.WriteLine("|Швидкість руху автомобіля - 36 км/год. Щоб подати її в метрах за секунду,   |");
                        Console.WriteLine("|згадаємо, що 1 год = 3600 с, а 1 км = 1000 м. Тоді:                         |");
                        Console.WriteLine("|   км     36 км     36 * 1000 м        м                                    |");
                        Console.WriteLine("|36 --- = ------- = ------------- = 10 ---                                   |");
                        Console.WriteLine("|   год    1 год        3600 с          с                                    |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|Для того, щоб здійснити обернене перетворення достатньо величину подану в   |");
                        Console.WriteLine("| метрах за секунду помножити на коефіцієнт 3,6.                             |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("| Визначаємо шлях і час руху тіла.                                           |");
                        Console.WriteLine("|З курсу математики ви занєте: якщо відомі швидкість і час руху тіла, то     |");
                        Console.WriteLine("|                                                                Сторінка 5  |");
                        Console.WriteLine("==============================================================================");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("|можна знайти його шлях, який подолало тіло. Для цього слід швидкість руху   |");
                        Console.WriteLine("|помножити на час:  l=Ut                                                     |");
                        Console.WriteLine("|де l - шлях; U - швидкість руху; t - час руху із зазначеою швидкістю.       |");
                        Console.WriteLine("|Якщо відомі шлях і швидкість руху тіла, можна знайти час руху тіла. Для     |");
                        Console.WriteLine("|цього необхідно шлях поділити на швидкість руху:                            |");
                        Console.WriteLine("|t = l/U;                                                                    |");
                        Console.WriteLine("|Інколи для знаходження шляху, швидкості або часу руху тіла зручно           |");
                        Console.WriteLine("|скористатися (чарівним) трикутником.                                       |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                            |");
                        Console.WriteLine("|                                                                Сторінка 6  |");
                        Console.WriteLine("==============================================================================");
                        break;
                }
                Console.Write("=>");
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                    page--;
                if (ans == 2)
                    page++;
                if (page == 0)
                {
                    Console.WriteLine("Це перша сторінка, перегорнути в цей бік неможливо!");
                    page++;
                    Console.ReadKey();
                }
            } while (page <= 6);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int ansver = 0;
            do
            {
                Console.Clear();
                Console.WriteLine ("==============================================================================");
                Console.WriteLine ("|              Консольний проект репетитора з фізика 7 клас                  |");
                Console.WriteLine ("|----------------------------------------------------------------------------|");
                Console.WriteLine ("|                                Розробка Антонченко О.М. Інформатика в школі|");
                Console.WriteLine ("==============================================================================");
                Console.WriteLine ("                             Можливості програми                              ");
                Console.WriteLine ("==============================================================================");
                Console.WriteLine ("|1 - Теоретичний матеріал (Маханічний рух).                                  |");
                Console.WriteLine ("|2 - Тест по першому розділу                                                 |");
                Console.WriteLine ("|3 - Теоретичний матеріал (Траекторія руху. Шлях. Переміщення)               |");
                Console.WriteLine ("|4 - Тест по другому розділу                                                 |");
                Console.WriteLine ("|5 - Теоретичний матеріал (Рівномірний рух. Швидкість)                       |");
                Console.WriteLine ("|6 - Тест по третьому розділу                                                |");
                Console.WriteLine ("|7 - Розв'язування задач (приклади розв'язування задач)                      |");
                Console.WriteLine ("|8 - Тест по четвертому розділу                                              |");
                Console.WriteLine ("|9 - Теоретичний матеріал (Нерівномірний рух)                                |");
                Console.WriteLine ("|10 - Тест по п'ятому розділу                                                |");
                Console.WriteLine ("|0 - Вийти з програми                                                        |");
                Console.WriteLine ("==============================================================================");
                Console.Write ("Ваш вибір (0-10) =>");ansver = Convert.ToInt32(Console.ReadLine());
                switch (ansver)
                {
                    case 1:
                        Chapter1();
                        break;
                    case 3:
                        Chapter2();
                        break;
                    case 5:
                        Chapter3();
                        break;
                }
            }
            while (ansver != 0);
        }
    }
}
