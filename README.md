# KBCommonExtensions

>Generic and Common Extensions which make development faster. 

KBCommon Extensions is a Portable Class Library Which can be used in any platform.

- Returns numeric value as a Thousand seperator string
- Generates Random Password
- Generates Random Paragraph Text
- Lists all the countries and capital cities

```
using KBCommonExtensions
```
Returns a Dictionary<string,string> - Country Name and Capital City
```
var result = GenericExtensions.GetCountries();
```
Returns string with Thousand seperator
```
decimal d = 12345566;
var result = NumericExtensions.ThousandSeparator<decimal>(d);
```
Returns a Random Password based on length
```
var result = StringExtensions.RandomPassword(10);
```
Returns a Random Paragraph text based on number of lines. Default is 1.
```
var result = StringExtensions.RandomParagraphText();
```
