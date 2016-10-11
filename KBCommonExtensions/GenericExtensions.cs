﻿//MIT License

//Copyright(c) 2016 Dheeraj Kumar G

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.Collections.Generic;

namespace KBCommonExtensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Gets the countries. (Country Name and Capital City)
        /// </summary>
        /// <returns>Dictionary Country Name and Capital City</returns>
        public static Dictionary<string, string> GetCountries()
        {
            return new Dictionary<string, string>{
                { "Afghanistan",   "Kabul"},
                { "Albania",     "Tirana"},
                { "Algeria",     "Algiers"},
                { "American Samoa",  "Pago Pago"},
                { "Andorra",     "Andorra la Vella"},
                { "Angola",  "Luanda"},
                { "Anguilla",    "The Valley"},
                { "Antigua and Barbuda",     "Saint John's"},
                { "Argentina",   "Buenos Aires"},
                { "Armenia",     "Yerevan"},
                { "Aruba",   "Oranjestad"},
                { "Australia",   "Canberra"},
                { "Austria",     "Vienna"},
                { "Azerbaijan",  "Baku"},
                { "The Bahamas",     "Nassau"},
                { "Bahrain",     "Manama"},
                { "Bangladesh",  "Dhaka"},
                { "Barbados",    "Bridgetown"},
                { "Belarus",     "Minsk"},
                { "Belgium",     "Brussels"},
                { "Belize",  "Belmopan"},
                { "Benin",   "Porto-Novo"},
                { "Bermuda",     "Hamilton"},
                { "Bhutan",  "Thimphu"},
                { "Bolivia",     "La Paz"},
                { "Bosnia and Herzegovina",  "Sarajevo"},
                { "Botswana",    "Gaborone"},
                { "Brazil",  "Brasília"},
                { "British Virgin Islands",  "Road Town"},
                { "Brunei",  "Bandar Seri Begawan"},
                { "Bulgaria",    "Sofia"},
                { "Burkina Faso",    "Ouagadougou"},
                { "Burundi",     "Bujumbura"},
                { "Cambodia",    "Phnom Penh"},
                { "Cameroon",    "Yaoundé"},
                { "Canada",  "Ottawa"},
                { "Cape Verde",  "Praia"},
                { "Cayman Islands",  "George Town"},
                { "Central African Republic",    "Bangui"},
                { "Chad",    "N'Djamena"},
                { "Chile",   "Santiago"},
                { "China(People's Republic of)",	 "Beijing"},
                { "Christmas Island",    "Flying Fish Cove"},
                { "Cocos Islands",   "West Island"},
                { "Colombia",    "Bogotá"},
                { "Comoros",     "Moroni"},
                { "Cook Islands",    "Avarua"},
                { "Costa Rica",  "San José"},
                { "Côte d'Ivoire",	 "Yamoussoukro"},
                { "Croatia",     "Zagreb"},
                { "Cuba",    "Havana"},
                { "Curaçao",     "Willemstad"},
                { "Cyprus",	 "Nicosia"},
                { "Czech Republic",	 "Prague"},
                { "Democratic Republic of the Congo",	 "Kinshasa"},
                { "Denmark",	 "Copenhagen"},
                { "Djibouti",	 "Djibouti"},
                { "Dominica",	 "Roseau"},
                { "Dominican Republic",	 "Santo Domingo"},
                { "East Timor",	 "Díli"},
                { "Ecuador",	 "Quito"},
                { "Egypt",	 "Cairo"},
                { "El Salvador",	 "San Salvador"},
                { "Equatorial Guinea",	 "Malabo"},
                { "Eritrea",	 "Asmara"},
                { "Estonia",	 "Tallinn"},
                { "Ethiopia",	 "Addis Ababa"},
                { "Falkland Islands",	 "Stanley"},
                { "Faroe Islands",	 "Tórshavn"},
                { "Fiji",	 "Suva"},
                { "Finland",	 "Helsinki"},
                { "France",	 "Paris"},
                { "French Guiana",	 "Cayenne"},
                { "French Polynesia",	 "Papeete"},
                { "Gabon",	 "Libreville"},
                { "The Gambia",	 "Banjul"},
                { "Georgia",	 "Tbilisi"},
                { "Germany",	 "Berlin"},
                { "Ghana",	 "Accra"},
                { "Gibraltar",	 "Gibraltar"},
                { "Greece",	 "Athens"},
                { "Greenland",	 "Nuuk"},
                { "Grenada",	 "St. George's"},
                { "Guadeloupe",	 "Basse-Terre"},
                { "Guam",	 "Hagåtña"},
                { "Guatemala",	 "Guatemala City"},
                { "Guernsey",	 "Saint Peter Port"},
                { "Guinea",	 "Conakry"},
                { "Guinea-Bissau",	 "Bissau"},
                { "Guyana",	 "Georgetown"},
                { "Haiti",	 "Port-au-Prince"},
                { "Honduras",	 "Tegucigalpa"},
                { "Hong Kong",	 "Hong Kong"},
                { "Hungary",	 "Budapest"},
                { "Iceland",	 "Reykjavík"},
                { "India",	 "New Delhi"},
                { "Indonesia",	 "Jakarta"},
                { "Iran",	 "Tehran"},
                { "Iraq",	 "Baghdad"},
                { "Ireland",	 "Dublin"},
                { "Isle of Man",	 "Douglas"},
                { "Israel",	 "Jerusalem"},
                { "Italy",	 "Rome"},
                { "Jamaica",	 "Kingston"},
                { "Japan",	 "Tokyo"},
                { "Jersey",	 "St. Helier"},
                { "Jordan",	 "Amman"},
                { "Kazakhstan",	 "Astana"},
                { "Kenya",	 "Nairobi"},
                { "Kiribati",	 "Tarawa[11]"},
                { "Kosovo",	 "Prishtinë"},
                { "Kuwait",	 "Kuwait City"},
                { "Kyrgyzstan",	 "Bishkek"},
                { "Laos",	 "Vientiane"},
                { "Latvia",	 "Riga"},
                { "Lebanon",	 "Beirut"},
                { "Lesotho",	 "Maseru"},
                { "Liberia",	 "Monrovia"},
                { "Libya",	 "Tripoli"},
                { "Liechtenstein",	 "Vaduz"},
                { "Lithuania",	 "Vilnius"},
                { "Luxembourg",	 "Luxembourg"},
                { "Macedonia",	 "Skopje"},
                { "Madagascar",	 "Antananarivo"},
                { "Malawi",	 "Lilongwe"},
                { "Malaysia",	 "Kuala Lumpur"},
                { "Maldives",	 "Malé"},
                { "Mali",	 "Bamako"},
                { "Malta",	 "Valletta"},
                { "Marshall Islands",	 "Majuro"},
                { "Martinique",	 "Fort-de-France"},
                { "Mauritania",	 "Nouakchott"},
                { "Mauritius",	 "Port Louis"},
                { "Mayotte",	 "Mamoudzou"},
                { "Mexico",	 "Mexico City"},
                { "Federated States of Micronesia",	 "Palikir"},
                { "Moldova",	 "Chișinău"},
                { "Mongolia",	 "Ulaanbaatar"},
                { "Montenegro",	 "Podgorica"},
                { "Montserrat",	 "Brades Estate[13]"},
                { "Morocco",	 "Rabat"},
                { "Mozambique",	 "Maputo"},
                { "Myanmar",	 "Naypyidaw"},
                { "Nagorno-Karabakh",	 "Stepanakert"},
                { "Namibia",	 "Windhoek"},
                { "Nauru",	 "Yaren (de facto)[14]"},
                { "Nepal",	 "Kathmandu"},
                { "Netherlands",	 "Amsterdam"},
                { "New Caledonia",	 "Nouméa"},
                { "New Zealand",	 "Wellington"},
                { "Nicaragua",	 "Managua"},
                { "Niger",	 "Niamey"},
                { "Nigeria",	 "Abuja"},
                { "Niue",	 "Alofi"},
                { "Norfolk Island",	 "Kingston"},
                { "North Korea",	 "P'yŏngyang"},
                { "Northern Cyprus",	 "North Nicosia"},
                { "Northern Mariana Islands",	 "Saipan"},
                { "Norway",	 "Oslo"},
                { "Oman",	 "Muscat"},
                { "Pakistan",	 "Islamabad"},
                { "Palau",	 "Ngerulmud"},
                { "Panama",	 "Panama City"},
                { "Papua New Guinea",	 "Port Moresby"},
                { "Paraguay",	 "Asunción"},
                { "Peru",	 "Lima"},
                { "Philippines",	 "Manila"},
                { "Pitcairn Islands",	 "Adamstown"},
                { "Poland",	 "Warsaw"},
                { "Portugal",	 "Lisbon"},
                { "Puerto Rico",	 "San Juan"},
                { "Qatar",	 "Doha"},
                { "Republic of the Congo",	 "Brazzaville"},
                { "Réunion",	 "Saint-Denis"},
                { "Romania",	 "Bucharest"},
                { "Russia",	 "Moscow"},
                { "Rwanda",	 "Kigali"},
                { "Sahrawi Arab Democratic Republic",	 "El Aaiún"},
                { "Saint Barthélemy",	 "Gustavia"},
                { "Saint Helena, Ascension and Tristan da Cunha",	 "Jamestown"},
                { "Saint Kitts and Nevis",	 "Basseterre"},
                { "Saint Martin",	 "Marigot"},
                { "Saint Lucia",	 "Castries"},
                { "Saint Pierre and Miquelon",	 "Saint-Pierre"},
                { "Saint Vincent and the Grenadines",	 "Kingstown"},
                { "Samoa",	 "Apia"},
                { "San Marino",	 "San Marino"},
                { "São Tomé and Príncipe",	 "São Tomé"},
                { "Saudi Arabia",	 "Riyadh"},
                { "Senegal",	 "Dakar"},
                { "Serbia",	 "Belgrade"},
                { "Seychelles",	 "Victoria"},
                { "Sierra Leone",	 "Freetown"},
                { "Singapore",	 "Singapore City"},
                { "Sint Maarten",	 "Philipsburg"},
                { "Slovakia",	 "Bratislava"},
                { "Slovenia",	 "Ljubljana"},
                { "Solomon Islands",	 "Honiara"},
                { "Somalia",	 "Mogadishu"},
                { "South Africa",	 "Cape Town "},
                { "South Korea",	 "Seoul"},
                { "South Sudan",	 "Juba"},
                { "Spain",	 "Madrid"},
                { "Sri Lanka",	 "Sri Jayawardenapura Kotte"},
                { "Sudan",	 "Khartoum"},
                { "Suriname",	 "Paramaribo"},
                { "Svalbard",	 "Longyearbyen"},
                { "Swaziland",	 "Mbabane"},
                { "Sweden",	 "Stockholm"},
                { "Switzerland",	 "Bern"},
                { "Syria",	 "Damascus"},
                { "Taiwan (Republic of China)",	 "Taipei"},
                { "Tajikistan",	 "Dushanbe"},
                { "Tanzania",	 "Dodoma"},
                { "Thailand",	 "Bangkok"},
                { "Togo",	 "Lomé"},
                { "Tonga",	 "Nukuʻalofa"},
                { "Transnistria",	 "Tiraspol"},
                { "Trinidad and Tobago",	 "Port of Spain"},
                { "Tunisia",	 "Tunis"},
                { "Turkey",	 "Ankara"},
                { "Turkmenistan",	 "Ashgabat"},
                { "Turks and Caicos Islands",	 "Cockburn Town"},
                { "Tuvalu",	 "Fongafale"},
                { "Uganda",	 "Kampala"},
                { "Ukraine",	 "Kiev"},
                { "United Arab Emirates",	 "Abu Dhabi"},
                { "United Kingdom",	 "London"},
                { "United States",	 "Washington, D.C."},
                { "United States Virgin Islands",	 "Charlotte Amalie"},
                { "Uruguay",	 "Montevideo"},
                { "Uzbekistan",	 "Tashkent"},
                { "Vanuatu",	 "Port Vila"},
                { "Venezuela",	 "Caracas"},
                { "Vietnam",	 "Hanoi"},
                { "Wallis and Futuna",	 "Matâ'Utu"},
                { "Yemen",	 "Sana'a"},
                { "Zambia",	 "Lusaka"},
                { "Zimbabwe",	 "Harare"}
           };
        }
    }
}