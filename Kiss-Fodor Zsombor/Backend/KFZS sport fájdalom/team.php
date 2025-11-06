<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Csapat</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
    <link href="sportStyle.css" rel="stylesheet">
</head>
<body>
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid fideszmod">
    <a class="navbar-brand" href="index.php">FUTBOOL!</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link" href="teams.php">Csapatok</a>
        <a class="nav-link" href="#">Játékosok</a>
        <a class="nav-link" href="matches.php">Mérkőzések</a>
        <a class="nav-link" href="stats.php">Statisztikák</a>
      </div>
    </div>
  </div>
</nav>

<div class="fideszmod" style="text-align: center; margin-top: 3ch;">
<?php
    $id = $_GET['id'];
    
    $jsonFile = file_get_contents('sports_data.json');
    $jsonData = json_decode($jsonFile, associative: true);

    $teams = $jsonData['teams'];
    $players = $jsonData['players'];
    $matches = $jsonData['matches'];

    $checkedTeam = '';

    foreach ($teams as $team) {
        if($team['id'] == $id) {
            echo '<h1 class="title">'.$team['name'].'</h1>';
            $checkedTeam = $team['name'];
            echo '<h2> Város: '.$team['city']. '</h2>';
            echo '<h2> Alapítva: '.$team['founded']. '</h2>';
            echo '<h2> Stadionjuk: '.$team['stadium']. '</h2>';
        }
    }
    echo '<h1 class="title">Játékosok</h1>';
    echo '<table><tr><th>Játékos Neve</th><th>Játékos Poziciója</th><th>Gólok Száma</th></tr>';

    foreach ($players as $player) {
        if($player['team_id'] == $id) {
            echo '<tr><td>'.$player['name'].'</td>';
            echo '<td>'.$player['position'].'</td>';
            echo '<td>'.$player['goals'].'</td></tr>';
        }
    }

    echo '</table>';
    echo '<h1 class="title">Meccsek</h1>';
    foreach ($matches as $match) {

        if($match['home_team'] == $id) {
            echo '<div class="match">';
            echo '<h2> Meccs Ideje: '.$match['date']. '</h2>';
            foreach ($teams as $opponent) {
                if ($opponent['id'] == $match['away_team']) {
                    echo '<h2>Ellenfél: '.$opponent['name'].'</h2>';
                }
            }
            echo '<h2> Eredmény: ';
            if ($match['home_score'] > $match['away_score']) {
                echo 'a(z) '. $checkedTeam . ' nyert. ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra.';
            }
            else if ($match['home_score'] < $match['away_score']){
                echo 'a(z) '.$checkedTeam . ' vesztett. ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra.';
            }
            else {
                echo 'döntettlen lett ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra.';
            }
            echo '</h2></div>';
        }
        else if ($match['away_team'] == $id) {
            echo '<div class="match">';
            echo '<h2> Meccs Ideje: '.$match['date']. '</h2>';
            foreach ($teams as $opponent) {
                if ($opponent['id'] == $match['home_team']) {
                    echo '<h2>Ellenfél: '.$opponent['name'].'</h2>';
                }
            }

            echo '<h2> Eredmény: ';
            if ($match['away_score'] > $match['home_score']) {
                echo 'a(z) '.$checkedTeam . ' nyert. ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra.';
            }
            else if ($match['away_score'] < $match['home_score']){
                echo 'a(z) '.$checkedTeam . ' vesztett. ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra.';
            }
            else {
                echo 'döntettlen lett ' . $match['home_score'] .' - '. $match['away_score'] . ' állásra';
            }
            echo '</h2></div>';
        }  
    }
?>
</div>
</body>
</html>