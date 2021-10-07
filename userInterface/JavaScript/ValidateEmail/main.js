function validateEmail(email) {
    const emailChecker = /^([\w\.\-_]+)?\w+@[\w-_]+(\.\w+){1,}$/igm
    if(emailChecker.test(email)){
        return "Valid email address!";
    }
    else{
        return "Invalid email address!";
    }
 }
 
 