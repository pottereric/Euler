var upperLimit = 1000;

function IsMultipleOf3or5(x) {
	return x % 3 == 0 || x % 5 == 0;
}

function Solve() {
	var total = 0;
	for(i = 0; i < upperLimit; i++) {
		if(IsMultipleOf3or5(i)){
			total += i;
		}
	}

	return total;
}

console.log(Solve());
