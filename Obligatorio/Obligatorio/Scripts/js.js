function validarVacio(sender, args) {
    if (args.Value != "") args.IsValid = true; else args.IsValid = false;
}

function validarNumero(sender, args) {
    var val = parseInt(args.Value, 10);
    if (!isNaN(val)) args.IsValid = true; else args.IsValid = false;
}

