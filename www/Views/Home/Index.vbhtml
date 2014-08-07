@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Contact Us</h2>
<form action="Home/SendEmail" method="post" id="SendEmail">
    <p><label for="email">Email:</label><br /><input type="email" name="email" placeholder="your email address"/></p>
    <p><label for="subject">Subject:</label><br /><input type="text" name="subject" placeholder="subject of your inquiry"/></p>
    <p><label for="body">Subject:</label><br /><textarea name="body" placeholder="please enter your request here"></textarea></p>
    <button type="submit">Submit</button>
</form>
<div id="rc"></div>
<script>
    jQuery(document).ready(function () {
        jQuery("#SendEmail").submit(function () {
            jQuery.ajax({ url: "Home/SendEmail", type: "post", data: jQuery(this).serialize(), dataType: "json" })
                .done(function (oResponse) {
                    jQuery("#rc").html("Thank you for your inquiry: " + oResponse.Result);
                });
            return false;
        });
    });
</script>