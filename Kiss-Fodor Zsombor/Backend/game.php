<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
</head>
<body>

<?php

$file_path = 'game.json';

$json = file_get_contents( $file_path);

$data = json_decode($json, true);

?>

<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
      <img src="testi.webp" alt="Logo" width="30" height="30" class="d-inline-block align-text-top">
      Bootstrap
    </a>
  </div>
</nav>

<div class="row row-cols-1 row-cols-md-2 g-4">

<?php

$items = $data['targyak'];

echo"

<div class='col'>
<div class='card'>
  <img src='...' class='card-img-top'>
  <div class='card-body'>
    <h5 class='card-title'>Card title</h5>
    <p class='card-text'>This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
  </div>
</div>
</div>

";

?>

</div>

</body>
</html>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>