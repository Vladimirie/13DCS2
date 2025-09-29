<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
<style>
    body {
        background-image: url("mili.jpg");
        color: red;
        font-weight: bold;
    }

</style>
</head>
<body>
   
<form action="" method="post">
    <div class="container">

        <div class="col-sm-12 text-center" id="1">
                <h3> 1. Kérdés</h3>
                <label for="">Melyik állat nyerte a futóversenyt?</label>
                <br>
                <input type="radio" name="futni" id ="nyul" value="nyul">
                <label for="nyul">Nyúl</label>
                <input type="radio" name="futni" id ="teknos" value="teknos">
                <label for="teknos">Teknős</label>
                <br>
                <input type="radio" name="futni" id ="none" value="none">
                <label for="none">Egyik se</label>
                <input type="radio" name="futni" id ="both" value="both">
                <label for="both">Mindkettő</label>          
        </div>

        <div class="col-sm-12 text-center" id="2" style="display: none;">
                <h3> 2. Kérdés</h3>
                <label for="">Meyik állat NEM jár 4 lábon?</label>
                <br>
                <input type="radio" name="lab" id ="roka" value="roka">
                <label for="roka">Róka</label>
                <input type="radio" name="lab" id ="far" value="far">
                <label for="far">Farkas</label>
                <br>
                <input type="radio" name="lab" id ="zebr" value="zebr">
                <label for="zebr">Zebra</label>
                <input type="radio" name="lab" id ="foka" value="foka">
                <label for="foka">Fóka</label>          
        </div>  


        <div class="col-sm-12 text-center" id="gomb">
                <input type="submit" name="submit" class="btn btn-success mt-3"></input>
        </div>

        <div class="col-sm-12 text-center" style="display: block;">
                <h1 id="nyeremeny">Nyeremény: 0 forint</h1>
        </div>

        <div class="col-sm-12 text-center" id="lose" style="display: none;">
                <h1>VESZTETTÉL!</h1>
        </div>

    </div>

</form>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>

</body>
</html>

<?php

    $kerdes = 1;

    if (isset($_POST["submit"])) 
    { 
        if ($kerdes == 1) {
            if (isset($_POST["futni"])) {
            $elso = "teknos";
            $elsoValasz = $_POST["futni"];
    
            if ($elsoValasz == $elso) {
                $kerdes += 1;
                echo "<p>$kerdes<p>";
                echo "<script>document.getElementById('nyeremeny').textContent = 'Nyeremény: ' + '2000' + ' forint';</script>";
                echo "<script>document.getElementById('1').style.display = 'none';</script>";  
                echo "<script>document.getElementById('2').style.display = 'block';</script>";
            }
            else {
                echo "<script>document.getElementById('1').style.display = 'none';</script>";
                echo "<script>document.getElementById('gomb').style.display = 'none';</script>";
                echo "<script>document.getElementById('lose').style.display = 'block';</script>";
            }
            }    
        }
        else if ($kerdes == 2) {
            if (isset($_POST["lab"])) {
                $ketto = "foka";
                $kettoValasz = $_POST["lab"];
    
                if ($kettoValasz == $ketto) {
                    $kerdes += 1;
                    echo "<script>nyeremenyupdate();</script>";
                    echo "<script>document.getElementById('2').style.display = 'none';</script>";  
                    echo "<script>document.getElementById('3').style.display = 'block';</script>";
                }
                else {
                    echo "<script>document.getElementById('2').style.display = 'none';</script>";
                    echo "<script>document.getElementById('gomb').style.display = 'none';</script>";
                    echo "<script>document.getElementById('lose').style.display = 'block';</script>";
                }
            }
        }
       

    }


?>