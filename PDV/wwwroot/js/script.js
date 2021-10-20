function openModal(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'Block';
    document.body.style.overflow = 'hidden';
}

function closeModal(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'none';
    document.body.style.overflow = 'auto';
}

function valorTotal(){
    var qtd = parseFloat(document.getElementById("qtd").value);
    var valor = parseFloat(document.getElementById("valorUni").value);
    var total = qtd * valor;
    document.getElementById("valorTot").value = parseFloat(total).toFixed(2);
}

function ItemList(){
    var item = document.getElementById("listaProd").value + " " + "Código do produto: "+document.getElementById("codProd").value + " " 
    + "Quantidade: " + document.getElementById("qtd").value + " " + "Valor Unitário: "+document.getElementById("valorUni").value + " " 
    + "Valor Total: "+document.getElementById("valorTot").value + "\n";

    document.getElementById("listaProd").value = item+"\n";
    item=" ";
    document.getElementById("codProd").value=item;
    document.getElementById("qtd").value=item;
    document.getElementById("valorUni").value=item;
    document.getElementById("valorTot").value=item;  
}

function CalcTroco(){
    var troco = document.getElementById("recebido").value - document.getElementById("total").value;
    document.getElementById("troco").value = parseFloat(troco).toFixed(2);;
}