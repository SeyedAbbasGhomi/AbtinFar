#AbtinFar Calendar Component 
#کامپوننت تقویم آبتین فار
##**for .net winform developers**


Free of Charge Gift For Developers Published On Eid al-Ghadeer</br>
هدیه ای به مناسبت عید غدیر خم به برنامه نویسان  </br>
</br>
Abtin Graphical Farsi jalali,hijri,gregorian Caneldar , free of charge for .net win forms developrs</br>
 تقویم گرافیکی شمسی ، قمری ، میلادی ، بصورت رایگان برای برنامه نویسی بر پایه دات نت</br>
</br>
## AbtinFar , ComboAbtinFar

### Events :
### رخداد ها :

**DateChanged**</br>
Returns Jalali Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ شمسی بر می گرداند</br>

**DayEvents**</br>
Returns Day Event Of Selected Date On AbtinFar Calendar</br>
واقعه مربوط به تاریخ انتخاب شده در تقویم آبتین فار را بر می گرداند</br>

**EnglishDateChanged**</br>
Returns Georgian Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ میلادی بر می گرداند</br>

**ArabicDateChanged**</br>
Returns Hijri Date Of Selected Date On AbtinFar Calendar</br>
بر اساس تاریخ انتخاب شده در تقویم آبتین فار ، تاریخ قمری بر می گرداند</br>


### Properties :
### پراپرتی ها :

**CalendarDate(string)**</br>
Keeps Jalali Date and Can Be Set to Change Date of AbtinFar Calendar</br>
تاریخ شمسی را در خود نگهمیدارد ، با مقدار دهی آم تاریخ تقویم تغییر خواهد کرد</br>

**CalendarStyle(string)**</br>
Blue : Blue Style</br> 
استایل آبی ,</br> 
Red : Ret Style</br> 
استایل قرمز ,</br> 
Green : Green Style</br>
استایل سبز</br>

**EnglishDate(Date)**</br>
Keeps Georgian Date and Can Be Set to Change Date of AbtinFar Calendar</br>
تاریخ میلادی را در خود نگهمیدارد ، با مقدار دهی آن تاریخ تقویم تغییر خواهد کرد</br>

**HijriAdjustment(Integer)**</br>
Hijri Date Small Change To Recieve Correct Date</br>
مقدار صحیح مثبت یا منفی ، جهت محاسبه تاریخ صحیح قمری</br>

**HijriQamariDate(string)**</br>
Keeps Hijri Date (Cant Be Set)</br>
تاریخ قمری را در خود نگهمیدارد (نمی تواند مقداری بپذیرد)</br>

**TodayDate()**
Set Calendar Date to Today Date</br>
تاریخ تقویم را با تاریخ روز تنظیم می کند</br>

**PreviousCalendarDate(string)**</br>
Keeps Last Jalali Date</br>
تاریخ شمسی قبلی را در خود نگهمیدارد</br>


### Procedures :
### روال ها :

**SetCalendarStyle**</br>
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

**ClockBackColor(Color)**</br>
Color Of Clock Face</br>
رنگ صفحه زمینه ساعت</br>

**ClockFont(Font)**</br>
Font Of Clock Numbers</br>
فونت شماره های ساعت</br>

**ClockFontColor(Color)**</br>
Font Color Of Clock Numbers</br>
رنگ اعداد ساعت</br>

**ClockFontRTL(Boolean)**</br>
Right to left / Left to right : for Clock Numbers</br>
راست به چپ / چپ به راست : برای شماره های ساعت</br>

**ClockForeColor(Color)**</br>
Color of Clock Markers</br>
رنگ مارکر های ساعت</br>

**ClockHourColor(Color)**</br>
Color of Hour Hand</br>
رنگ عقربه نشاندهنده ساعت</br>

**ClockMinuteColor(Color)**</br>
Color of Minute Hand</br>
رنگ عقربه نشاندهنده دقیقه</br>

**ClockSecondColor(Color)**</br>
Color of Second Hand</br>
رنگ عقربه نشاندهنده ثانیه</br>


##AbtinFarConvertor

### Functions :
### فانکشن ها:

**AddDays(Integer, String)**</br>
Return value : String</br>

add X dayes to the given date and return the result</br> 
تعداد روز مشخص شده را به تاریخ ورودی اضافه و نتیجه را بر میگرداند</br>

```
'VB

dim a as string
a=AddDays(5, "1394/07/10")

'Result
'a =  "1394/07/15"
```

```
//C#

string a;
a=AddDays(5, "1394/07/10");

//Result
//a =  "1394/07/15"

```

**AddMonth(Integer, String)**</br>
Return value : String</br>

add X Monthes to the given date and return the result</br> 
تعداد ماه مشخص شده را به تاریخ ورودی اضافه و نتیجه را بر می گرداند</br>

```
'VB

dim a as string
a=AddMonth(5, "1394/07/10")

'Result
'a =  "1394/12/10"
```

```
//C#

string a;
a=AddMonth(5, "1394/07/10");

//Result
//a =  "1394/12/10"

```

**AddYear(Integer, String)**</br>
Return value : String</br>

add X Years to the given date and return the result</br> 
تعداد سال مشخص شده را به تاریخ ورودی اضافه و نتیجه را بر می گرداند</br>

```
'VB

dim a as string
a=AddYear(5, "1394/07/10")

'Result
'a =  "1399/07/10"
```

```
//C#

string a;
a=AddYear(5, "1394/07/10");

//Result
//a =  "1399/07/10"

```

**ConvertDigits(Double)**</br>
Return value : String</br>

Convert Input Double Number to Text</br>
تبدیل عدد اعشاری ورودی به حروف</br>

```
'VB

dim a as string
a=ConvertDigits(14.37)

'Result
'a =  "چهارده ممیز سی و هفت صدم"
```

```
//C#

string a;
a=ConvertDigits(14.37);

//Result
//a =  "چهارده ممیز سی و هفت صدم"

```

**DEvents(String)**</br>
Return value : String</br>

Take Jalali Date As Input And Returns the Day Event Of It</br>
به عنوان پارامتر ورودی تاریخ شمسی دریافت و واقعه آن روز را بر می گرداند</br>

```
'VB

dim a as string
a=DEvents("1394/07/10")

'Result
'a =  "عید سعید غدیر خم"
```

```
//C#

string a;
a=DEvents("1394/07/10");

//Result
//a =  "عید سعید غدیر خم"

```

**English2Persian(Date)**</br>
Return value : String</br>

Convert Georgian Date to Jalali Date</br>
تاریخ میلادی را به شمسی تبدیل می کند</br>

```
'VB

dim a as string
a=English2Persian("2015/10/02")
'Input Date : YYYY/MM/DD

'Result : YYYY/MM/DD
'a = "1394/07/10"
```

```
//C#

string a;
a=English2Persian(DateTime.Parse("2015/10/02"));
//Input Date : YYYY/MM/DD

//Result : YYYY/MM/DD
//a = "1394/07/10"

```

**Persian2English(String)**</br>
Return value : Date</br>

Convert Jalali Date to Georgian Date</br>
تاریخ شمسی را به میلادی تبدیل می کند</br>

```
'VB

dim a as string
a=Persian2English("1394/07/10")
'Input Date : YYYY/MM/DD

'Result : MM/DD/YYYY
'a = "10/2/2015 12:00:00 AM"
```

```
//C#

string a;
a=Persian2English("1394/07/10");
//Input Date : YYYY/MM/DD

//Result : MM/DD/YYYY
//a = "10/2/2015 12:00:00 AM"

```

**Persian2Qamari(String)**</br>
Return value : String</br>

Convert Jalali Date to Hijri Date</br>
تاریخ شمسی را به قمری تبدیل می کند</br>

```
'VB

dim a as string
a=Persian2English("1394/07/10")
'Input Date : YYYY/MM/DD

'Result : YYYY/MM/DD
'a = "1436/12/19"
```

```
//C#

string a;
a=Persian2English("1394/07/10");
//Input Date : YYYY/MM/DD

//Result : YYYY/MM/DD
//a = "1436/12/19"

```


Please Give Me Feed Back To Add More Useful Features</br>
Good luck And Feel Free To Share IT With Other Developers</br>
Seyed abbas Ghomi</br>

لطفا نظرات خودتون رو ارسال کنید تا امکانات مفید بیشتری به تقویم اضافه کنم</br>
موفق باشید و این کامپاننت را با دیگر برنامه نویسان نیز به اشتراک بگذارید</br> 
سید عباس قمی</br> 
