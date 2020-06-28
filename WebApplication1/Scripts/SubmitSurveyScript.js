/// <reference path="jquery-3.4.1.min.js" />

<script>
    $(document).ready(function () {
        $("#btnSave").click(function () {
            $.ajax(
                {
                    type: "POST",   
                    url: "Home/SaveSurvey",    
                    data: {   
                        Name: $("nameid").val(),    
                        Age: $("#ageid").val(),
                        Gender: $("input[name=Gender]:checked").val(),
                        Email: $("#emailid").val(),
                        city: $("city:selected").text(),
                        Education: $("input[id=checkedu]:checked").val()
                    }

                });

        });  
    });
</script>
