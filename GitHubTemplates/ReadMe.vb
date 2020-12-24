
Gamble responsibly. Think of the people you are responsible for.

I am sorry but the spreadsheet is almost 20 years old so it has a bit of legacy and redundancy. 
I am in the process of improving it in Jupyter Notebook using python and machine Learning using appropriate libraries.
This will illiminate bias.

The spreadsheet basically takes data and churns it in the "Racing template".
Its spits out a summary in "Total Daily run_Card.xlsm"
You can then decide whether to bet or not.
The result is as a best % chance with a bundled portfolio.
It may sometimes or often reject the race if there is low % chance to gain.
The spreadsheet is designed around the www.punters.com.au/form-guide.

Gamble responsibly. Think of the people you are responsible for.

To get the necessary csv data sheet for a race go to:
https://www.punters.com.au/form-guide/ 
 
Select a meeting and or race. Each race has its own ID or ShortCode
 So you need to get this ID for the csv  file thats relevant to your race.

For example I select

Ipswich Race 2 1100m CARPET COURT IPSWICH Maiden Handicap

the URL overview for this race is:
https://www.punters.com.au/form-guide/ipswich_188780/carpet-court-ipswich-maiden-handicap_1091441/#Overview

ID or PuntersShortCode is 1091411
For scraping the URL path for the csv spreadsheet therefore :

https://www.punters.com.au/form-guide/spreadsheet-1091441/

I use PowerShell to scrape the Punters website and save the csv file(s) locally (see the summary file).

This summary file compiles an instance of the Race template and you can save it as the name of the race ie " Ipswich Race 2"," Ipswich Race 3"

The the code is found in the "RACING TEMPLATE..." in the developer tab

Please review and F8 debug to follow what the steps are. You will need to create file paths to save and keep each spreadsheet.
I rename each csv from Punters and rename the spreadsheet with the same name and date ie  24122020_Ipswich_R2.csv & 24122020_Ipswich_R2.xlsm

Basic process is.
Get csv file from website and save as name of the race. 
Save in "dump" folder. ie  "./yourcomputer/dump/24122020_Ipswich_R2.csv"
I use powershell to do this. See summary.xlsm file.
Create a copy of racing template and save as name of the race.
The racing template is found here "./yourcomputer/macro/RACING TEMPLATE A1_CopyContentsFromFile.xlsm"
Save as 24122020_Ipswich_R2.xlsm in "summarydump" folder. ie  "./yourcomputer/summarydump/24122020_Ipswich_R2.xlsm"

To run macro
Open file  ie  24122020_Ipswich_R2.xlsm found in "./yourcomputer/summarydump/"
Go to "SPORTSBET FIXED ODDS FOR PARLAY"
Click RUN or got to developer TAB and F8 the process.
It will save the file in the "summarydump" folder ie "./yourcomputer/summarydump/24122020_Ipswich_R2.xlsm"


A copy of result will be found in the "./yourcomputer/summary/Total Daily run_Card.xlsm" or the file itself.
"Total Daily run_Card.xlsm" is a summary of each race you have processed. It allows you find an optimal bet and to balance your books.

Punters publish the results an hour after the each race.
So you can simply grap a new copy and replace the former csv ie  "./yourcomputer/dump/24122020_Ipswich_R2.csv"
with an updated csv file.
Process this by Go to TAB "SPORTSBET FIXED ODDS FOR PARLAY"
Click RESULT
"Total Daily run_Card.xlsm" will have this result of each race you have processed.
A race database will also be updated "Race DataBase.csv"


Gamble responsibly. Think of the people you are responsible for.






