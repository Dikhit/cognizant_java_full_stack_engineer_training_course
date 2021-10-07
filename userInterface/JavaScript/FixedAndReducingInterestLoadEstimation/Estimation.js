function EstimateReducingInterestLoan(){
	  calculateEMI();
      totalPayment();
      totalInterest();
      EstimateFixedInterestLoan();


    
}

function EstimateFixedInterestLoan()
{
    let P = document.getElementById("principalAmount").value;
    let r = document.getElementById("interestRate").value;
    let R = (r/100) / 12;
    let N = document.getElementById("tenure").value;

    let TIF = parseFloat(P) * (parseFloat(r)/10) * (parseFloat(N)/12);
    let TPF = parseFloat(P) + TIF;
    let EMIF = TPF/((N/12)*12);

    console.log(TIF, TPF, EMIF);

    /* Fill with required javascript code here  */
    document.getElementById("tInterestFixed").innerHTML = TIF.toFixed(2); /*Assign total Interest value here*/
    
     /* Fill with required javascript code here  */
    document.getElementById("tPaymentFixed").innerHTML = TPF.toFixed(2); /*Assign total payment value here*/
    
     /* Fill with required javascript code here  */
    document.getElementById("EMIFixed").innerHTML = EMIF.toFixed(2); /*Assign emi  value here*/
    
    
}

function calculateEMI(){
	
    /* Fill with required javascript code here  */
    let P = document.getElementById("principalAmount").value;
    let r = document.getElementById("interestRate").value;
    let R = (r/100) / 12;
    let N = document.getElementById("tenure").value;
    let EMI = P * R * ( Math.pow((1 + R),N) / ( Math.pow((1 + R),N) - 1) )
    document.getElementById("EMI").innerHTML = EMI.toFixed(2);
}

function totalPayment(){
	
	/* Fill with required javascript code here  */
	
	let P = document.getElementById("principalAmount").value;
    let r = document.getElementById("interestRate").value;
    let R = (r/100) / 12;
    let N = document.getElementById("tenure").value;
    let EMI = P * R * ( Math.pow((1 + R),N) / ( Math.pow((1 + R),N) - 1) );
    let TP = EMI * N;
    document.getElementById("tPayment").innerHTML = TP.toFixed(2); /*Assign total payment value here*/
}

function totalInterest(){
	
/* Fill with required javascript code here  */
    let P = document.getElementById("principalAmount").value;
    let r = document.getElementById("interestRate").value;
    let R = (r/100) / 12;
    let N = document.getElementById("tenure").value;
    let EMI = P * R * ( Math.pow((1 + R),N) / ( Math.pow((1 + R),N) - 1) );
    let TP = EMI * N;
    let TI = TP - P;
    document.getElementById("tInterest").innerHTML = TI.toFixed(2); /*Assign total Interest value here*/
}


