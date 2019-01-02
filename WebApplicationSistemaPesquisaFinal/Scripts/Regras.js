$(document).ready(function () {
    var counter = 2;
            $("#addButton").click(function () {

            if (TipoResposta = 1)
            {
                alert(TipoResposta);
                var newTextBoxDiv = $(document.createElement('div'))
             .attr("id", 'TextBoxDiv' + counter);

                newTextBoxDiv.after().html('<label>Textbox #' + counter + ' : </label>' + '<input type="textbox" name="textbox' + counter +
                      '" id="idCampo' + counter + '" value="" >');

                newTextBoxDiv.appendTo("#TextBoxesGroup");

                counter++;
            }
            
            if (TipoResposta = 2)
            {
                alert(TipoResposta);
                var newCheckBoxDiv = $(document.createElement('div'))
             .attr("id", 'CheckboxBoxDiv' + counter);

                newCheckBoxDiv.after().html('<label>Checkbox #' + counter + ' : </label>' + '<input type="checkbox" name="checkbox' + counter +
                      '" id="idCampo' + counter + '" value="" >');

                newCheckBoxDiv.appendTo("#CheckboxesGroup");

                counter++;  
            }
    
            if (TipoResposta = 3)
            {
                alert(TipoResposta);
                var newRadioBoxDiv = $(document.createElement('div'))
             .attr("id", 'RadioBoxDiv' + counter);

                newRadioBoxDiv.after().html('<label>Radiobox #' + counter + ' : </label>' + '<input type="radio" name="radio' + counter +
                      '" id="idCampo' + counter + '" value="" >');

                newRadioBoxDiv.appendTo("#RadiosGroup");

                counter++;
            }

            if (TipoResposta = 4)
            {
                alert(TipoResposta);
                var newRangeDiv = $(document.createElement('div'))
             .attr("id", 'RangeDiv' + counter);

                newRangeDiv.after().html('<label>Range #' + counter + ' : </label>' + '<input type="range" name="range' + counter +
                      '" id="idCampo' + counter + '" value="" >');

                newRangeDiv.appendTo("#RangeGroup");

                counter++;
            }
    });
});

