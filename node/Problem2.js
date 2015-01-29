var upperLimit = 4000000;

var currentFibA = 1;
var currentFibB = 2;

var total = 2;

function IsEven(x) {
	return x % 2 ==0;
}

function GetNextFib() {
	var next = currentFibA + currentFibB;
	currentFibA = currentFibB;
	currentFibB = next;

	return next;
}

function Solve() {
	do{
		var x = GetNextFib();
		if(IsEven(x) && x < upperLimit){
			total += x;
		}
	}while (currentFibB < upperLimit);	

}

Solve();
console.log(total);
