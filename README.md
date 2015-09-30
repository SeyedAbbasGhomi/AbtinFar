#AbtinFar Calendar Component
#کامپوننت تقویم آبتین فار
Free of Charge Gift For Developers Published On Eid al-Ghadeer--
هدیه ای به مناسبت عید غدیر خم به برنامه نویسان  

Abtin Graphical Farsi jalali,hijri,gregorian Caneldar , free of charge for .net win forms developrs
 تقویم گرافیکی شمسی ، قمری ، میلادی ، بصورت رایگان برای برنامه نویسی بر پایه دات نت

## AbtinFar

### Events :
### رخداد ها :

* DateChanged
Returns Jalali Date Of Selected Date On AbtinFar Calendar
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ شمسی بر می گرداند

**bold**DayEvents**bold**
Returns Day Event Of Selected Date On AbtinFar Calendar
واقعه مربوط به تاریخ انتخاب شده در تقویم آبتین فار را بر می گرداند

**bold**EnglishDateChanged**bold**
Returns Georgian Date Of Selected Date On AbtinFar Calendar
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ میلادی بر می گرداند

**bold**ArabicDateChanged**bold**
Returns Hijri Date Of Selected Date On AbtinFar Calendar
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ قمری بر می گرداند


### Properties :
### پراپرتی ها :

**bold**HijriAdjustment(Integer)**bold**
Hijri Date Small Change To Recieve Correct Date
مقدار صحیح مثبت یا منفی ، جهت محاسبه تاریخ صحیح قمری

**bold**CalendarStyle(string)**bold**
Blue : Blue Style 
استایل آبی , 
Red : Ret Style 
استایل قرمز , 
Green : Green Style
استایل سبز

**bold**HijriQamariDate(string)**bold**
Keeps Hijri Date (Cant Be Set)
تاریخ قمری را در خود نگهمیدارد (نمی تواند مقداری بپذیرد)

**bold**EnglishDate(Date)**bold**
Keeps Georgian Date and Can Be Set to Change Date of AbtinFar Calendar
تاریخ میلادی را در خود نگهمیدارد ، با مقدار دهی آن تاریخ تقویم تغییر خواهد کرد

**bold**CalendarDate(string)**bold**
Keeps Jalali Date and Can Be Set to Change Date of AbtinFar Calendar
تاریخ شمسی را در خود نگهمیدارد ، با مقدار دهی آم تاریخ تقویم تغییر خواهد کرد

**bold**PreviousCalendarDate(string)**bold**
Keeps Last Jalali Date
تاریخ شمسی قبلی را در خود نگهمیدارد


### Procedures :
### روال ها :

**bold**SetCalendarStyle**bold**
Set Calendar Style By Accepting string  Parameter:
با قبول یک پارامتر متنی ، استایل تقویم را تغییر می دهد

"Blue" : Blue Style 
استایل آبی , 
"Red" : Ret Style 
استایل قرمز , 
"Green" : Green Style
استایل سبز

Example :
مثال :

```
SetCalendarStyle("Blue")
```
