
(function iife() {

    var D = d;


A();

function C() {
	console.log("OOPS!");
}

function C() {
    console.log("C");
    D();
};


function E(f) {
	console.log("E");
	var f = F;
	f();

}

function A() {
	console.log("A");
	B();
};

var C;
var J = function () {
    J = function () {
        console.log("J");
        K();
    };
};

function G() {
	console.log("G");
	
	var H = function() {
		console.log("H");
		I();
	};
	H();
}



function d() {
	console.log("D");
	E(F);
}


function I() {
	console.log("I");
	console.log(J);
	J();
	console.log(J);
    J();
}


function B() {
	console.log("B");
	C();
};

function F() {
	console.log("F");
	G();
};

var rest = "KLMNOPQRSTUVWXYZ".split("");
for (var i=0; i<rest.length; i++) {
	(function(i){
		// define the current function
	    window[rest[i]] = function () {
			console.log(rest[i]);
			if (i < (rest.length-1)) {
			    window[rest[i + 1]]();
			    // TODO: call the next function
			}
		};
	})(i);
}






})();