#AbtinFar Calendar Component
#کامپوننت تقویم آبتین فار
Free of Charge Gift For Developers Published On Eid al-Ghadeer</br>
هدیه ای به مناسبت عید غدیر خم به برنامه نویسان  </br>
</br>
Abtin Graphical Farsi jalali,hijri,gregorian Caneldar , free of charge for .net win forms developrs</br>
 تقویم گرافیکی شمسی ، قمری ، میلادی ، بصورت رایگان برای برنامه نویسی بر پایه دات نت</br>
</br>
## AbtinFar , ComboAbtinFar

### Events :
### رخداد ها :

**DateChanged**
Returns Jalali Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ شمسی بر می گرداند</br>

**DayEvents**
Returns Day Event Of Selected Date On AbtinFar Calendar</br>
واقعه مربوط به تاریخ انتخاب شده در تقویم آبتین فار را بر می گرداند</br>

**EnglishDateChanged**
Returns Georgian Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ میلادی بر می گرداند</br>

**ArabicDateChanged**
Returns Hijri Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ قمری بر می گرداند</br>


### Properties :
### پراپرتی ها :

**HijriAdjustment(Integer)**
Hijri Date Small Change To Recieve Correct Date</br>
مقدار صحیح مثبت یا منفی ، جهت محاسبه تاریخ صحیح قمری</br>

**CalendarStyle(string)**
Blue : Blue Style</br> 
استایل آبی ,</br> 
Red : Ret Style</br> 
استایل قرمز ,</br> 
Green : Green Style</br>
استایل سبز</br>

**HijriQamariDate(string)**
Keeps Hijri Date (Cant Be Set)</br>
تاریخ قمری را در خود نگهمیدارد (نمی تواند مقداری بپذیرد)</br>

**EnglishDate(Date)**
Keeps Georgian Date and Can Be Set to Change Date of AbtinFar Calendar</br>
تاریخ میلادی را در خود نگهمیدارد ، با مقدار دهی آن تاریخ تقویم تغییر خواهد کرد</br>

**CalendarDate(string)**
Keeps Jalali Date and Can Be Set to Change Date of AbtinFar Calendar</br>
تاریخ شمسی را در خود نگهمیدارد ، با مقدار دهی آم تاریخ تقویم تغییر خواهد کرد</br>

**PreviousCalendarDate(string)**
Keeps Last Jalali Date</br>
تاریخ شمسی قبلی را در خود نگهمیدارد</br>


### Procedures :
### روال ها :

**SetCalendarStyle**
Set Calendar Style By Accepting string Parameter</br>
با قبول یک پارامتر متنی ، استایل تقویم را تغییر می دهد</br>

"Blue" : Blue Style</br> 
استایل آبی ,</br> 
"Red" : Ret Style </br>
استایل قرمز ,</br> 
"Green" : Green Style</br>
استایل سبز</br>

Example :</br>
مثال :</br>

```
SetCalendarStyle("Blue")
```

##AbtinClock

### Properties :
### پراپرتی ها :

**ClockBackColor(Color)**
Color Of Clock Face</br>
رنگ صفحه زمینه ساعت</br>

**ClockFont(Font)**
Font Of Clock Numbers</br>
فونت شماره های ساعت</br>

**ClockFontColor(Color)**
Font Color Of Clock Numbers
رنگ اعداد ساعت

**ClockFontRTL(Boolean)**
Right to left / Left to right : for Clock Numbers
راست به چپ / چپ به راست : برای شماره های ساعت

**ClockForeColor(Color)**
Color of Clock Markers</br>
رنگ مارکر های ساعت</br>

**ClockHourColor(Color)**
Color of Hour Hand</br>
رنگ عقربه نشاندهنده ساعت</br>

**ClockMinuteColor(Color)**
Color of Minute Hand</br>
رنگ عقربه نشاندهنده دقیقه</br>

**ClockSecondColor(Color)**
Color of Second Hand</br>
رنگ عقربه نشاندهنده ثانیه</br>


