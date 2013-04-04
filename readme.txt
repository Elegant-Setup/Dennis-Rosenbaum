Hoe werkt de Boogie Woogie van JensDennisBv?
In eerste instantie zijn alle coördinaten via een afbeelding bewerking programma bij elkaar gezocht (zie BoogieWoogieCoords.png). 
Vervolgens is een programma geschreven die alle blokjes één voor één op een veld tekent. Per keer dat een blokje wordt getekend, wordt ook de zwarte rand getekend.
Om het mezelf gemakkelijker te maken heb ik twee technieken gebruikt:
Techniek 1: via code
- De enige manier om een blokje op het scherm te plaatsen is via exacte coordinaten. Maar om toch een soort van algoritme te maken (die ook minder code zou kosten) is besloten om functies te maken als 'AddRight()' en 'AddBottom()', deze functies voegen respectievelijk een blokje aan de rechterkant of onderkant. Zo kan je heel mooi snel een rij blokjes plaatsen. Ook de functie 'AddInner()' was (vooral voor techniek 2) belangrijk, om een blokje in een ander blokje te plaatsen.
Techniek 2: via algoritmes
- De algoritmische manier houd niet meer in dan het plaatsen van blokjes in blokjes, waarbij eerst gekeken werd voor een vlak welke kleur het meest voor kwam. Van dit vlak werd een blokje gemaakt, en vervolgens werden de rest van de blokjes geplaatst. Zo hoeven er minder blokjes getekend te worden, maar krijg je wel het volledige resultaat.

Hoe het resultaat wordt gemaakt is op een niet nader te noemen videosite te bekijken: http://www.youtube.com/watch?v=uRpgRgQrK3U