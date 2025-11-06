<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Meccsek</title>
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
        <a class="nav-link active" aria-current="page" href="matches.php">Mérkőzések</a>
        <a class="nav-link" href="stats.php">Statisztikák</a>
      </div>
    </div>
  </div>
</nav>

<div class="fideszmod" style="text-align: center; margin-top: 3ch;">
<table>
    <tr>
        <th>
            Dátum
        </th>
        <th>
            Hazai Csapat
        </th>
        <th>
            Vendég Csapat
        </th>
        <th>
            Eredmény
        </th>
    </tr>

<?php
    
    $jsonFile = file_get_contents('sports_data.json');
    $jsonData = json_decode($jsonFile, associative: true);

    $teams = $jsonData['teams'];
    $players = $jsonData['players'];
    $matches = $jsonData['matches'];


    foreach ($matches as $match) {
        echo '<tr>';
        echo '<td>'.$match['date'].'</td>';

        foreach ($teams as $team) {
            if ($team['id'] == $match['home_team']) {
                echo '<td><a href="team.php?id='. $team['id'].'" class="nav-link teamName">'.$team['name'].'</a></td>';
            }
        }
        foreach ($teams as $away) {
            if ($away['id'] == $match['away_team']) {
                echo '<td><a href="team.php?id='. $away['id'].'" class="nav-link teamName">'.$away['name'].'</a></td>';
            }
        }
        
        echo '<td>'.$match['home_score'].' - '. $match['away_score'].'</td>';
        echo '</tr>';
    }
?>
</table>
</div>
</body>
</html>