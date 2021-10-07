function OrderCake(str) {
    let weight = parseInt(str.substring(0,4));
    let weightInKG = (weight / 1000);
    const cakePricePerKG = 450;
    let totalCost = Math.ceil(weightInKG * cakePricePerKG);
    let cakeName = str.substring(4, str.length - 3);
    let orderNum = str.substring(str.length - 3);

    let outputString = `Your order for ${Math.ceil(weightInKG)} kg ${cakeName} cake has been taken. You are requested to pay Rs. ${totalCost} on the order no ${orderNum}`; 
    return outputString;
}


let str = "5848ButterBlast485";
console.log(OrderCake(str));
