<?php
/**
 * Created by PhpStorm.
 * User: blaze
 * Date: 3/1/2016
 * Time: 4:10 AM
 */

//get the data from php
$product_description = filter_input(INPUT_POST,'product_description');
$list_price = filter_input(INPUT_POST,'list_price');
$discount_percent = filter_input(INPUT_POST,'discount_percent');

//calculate the discount and discounted price
$discount = $list_price * $discount_percent * .01;
$discount_price = $list_price - $discount;

//apply currency formatting to the dollar and percent amounts
$list_price_f = "$".number_format($list_price,2);
$discount_percent_f =$discount_percent."%";
$discount_f = "$".number_format($discount,2);
$discount_price_f = "$".number_format($discount_price,2);
?>

<!DOCTYPE html>
    <html>
    <head>
<title>Product Discount Calculator</title>
        <link rel="stylesheet" type="text/css" href="main.css">

    </head>

<body>
<main>
    <h1>Product Discount Calculator</h1>
    <label>Product Description:</label>
    <span><?php echo htmlspecialchars($product_description);?>

    </span>

    <br>
    <lable>List Price:</lable>
    <span style="text-align: center"><?php echo htmlspecialchars($list_price_f);?></span>
    <br>

    <label>Standard Discount:</label>
    <span><?php echo htmlspecialchars($discount_percent_f);?></span>
    <br>

    <label>Discount Amount:</label>
        <span style="text-align: center"    ><?php echo htmlspecialchars($discount_f);?></span>
        <br>

    <lable>Discount Price:</lable>
    <span style="text-align: center"><?php echo $discount_price_f;?></span>
    <br>
</main>
</body>
    </html>
