var upperLimit = 1000000;

function T (n) {
	return (n * (n + 1)) / 2;
}

function P(n) {
	return (n * ((3 * n) - 1))/2;
}

function H(n) {
	return n * (2 * n - 1);
}

//console.log(T(285));
//console.log(P(165));
//console.log(H(143));

var TList = [];
var PList = [];
var HList = [];

function Solve() {
	for (i = 100; i < upperLimit; i++) {
		//TList.push(T(i));
		PList.push(P(i));
		HList.push(H(i));
	}

	for(n = 283; n < upperLimit; n++) {
		//var t = TList[i];
		var t = T(n);
		if(PList.indexOf(t) != -1){
			if(HList.indexOf(t) != -1){
				return n;
			}
		}
	}
	return -1;
}

//console.log(Solve());
console.log(T(55385));
