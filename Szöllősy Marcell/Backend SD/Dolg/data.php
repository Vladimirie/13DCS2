<?php
$file = 'sports_data.json';

if (!file_exists($file)) {
    die("Hiba: A fájl nem található!");
}

$jsondata = file_get_contents($file);

$data = json_decode($jsondata, true);

if ($data === null) {
    die ("Hiba: Az adatokat nem sikerült beolvasni!");
}

$teams = $data['teams'];
$players = $data['players'];
$matches = $data['matches'];
?>

 