<?php
/*
echo "<h1>Hello World</h1>";

$valami = "<h3>teszt</h3>";

echo $valami;


$a = 50;
$b = 50;

echo $a + $b;

echo "<br>";

if ($a > $b) {
    echo " Az A nagyobb, mint a B";
}else if($b > $a){
    echo "A B nagyobb, mint az A";
}else{
    echo "A két szám egyenlő";
}

echo "<br>";

for ($i=0; $i < 10; $i++) { 
    echo $i;
}

$j = 0;
while ($j < 10) {
    echo $j;
    $j++;
}

// 1-tőé 100-ig jelenlenek meg
// 3-mal osztható számok

for ($j = 1; $j < 101; $j++) {
    if ($j % 3 == 0){
        echo "<bra>";
        echo $j;
    }
}

echo "<br>";
//1-től 100 -ig legyenek kiírva és
//az 5 többszörösei legyenek félkövérek
echo "<table>";
$szam = 1;
for ($i=0; $i < 10; $i++) {
    echo "<tr>";
    for ($j=0; $j < 10; $j++) {
        if ($szam % 5 == 0) {
            echo "<td><b>".$szam."</b></td>";
        }else{
            echo "<td>".$szam."</td>";
        }
        $szam++;
    }
    echo "</tr>";
}
echo "</table>";
*/

$szamok = [2, 5, 10, 12, 64, 23, 73, 4, 19, 47];
/*
foreach ( $szamok as $szam) {
    if ($szam % 2 == 0) {
        echo $szam." ";
    }
*/

echo "<h1>Programozási tételek</h1>";

echo "<b> Tömb elemei: ";
foreach ($szamok as $szam) {
    echo $szam." ";
}

echo "<h2>1. Maximum Kiválasztás</h2>";

$max = $szamok[0];
foreach ($szamok as $maxkeres) {
    if ($maxkeres > $max) {
        $max = $maxkeres;
    }
}

echo "A legnagyobb szám: ".$max;

echo "<h2>2. Lineáris keresés</h2>";




?>