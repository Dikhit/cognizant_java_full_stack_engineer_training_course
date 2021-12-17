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

    let totalInterest = parseFloat(P) * (parseFloat(r)/100) * (parseFloat(N)/12);
    let totalPayment = parseFloat(P) + totalInterest;
    let EMI = totalPayment/((N/12)*12);

    /* Fill with required javascript code here  */
    document.getElementById("tInterestFixed").innerHTML = totalInterest.toFixed(2); /*Assign total Interest value here*/
    
     /* Fill with required javascript code here  */
    document.getElementById("tPaymentFixed").innerHTML = totalPayment.toFixed(2); /*Assign total payment value here*/
    
     /* Fill with required javascript code here  */
    document.getElementById("EMIFixed").innerHTML = EMI.toFixed(2); /*Assign emi  value here*/
    
    
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


