// test number 1
//function Foo(who) {

function Foo(who) {
    this.me = who;
    this.greeting = "hello, may name is " + this.me;
}

Foo.x1 = "x1";
Foo.prototype.x2 = "x2";

var a1 = new Foo("Alex");
console.log('a1.greeting =', a1.greeting);

var b1 = new Foo("Bob");
console.log('b1.greeting =', b1.greeting);

console.log('a1.x1 =', a1.x1);
console.log('a1.x2 =', a1.x2);

console.log('b1.x2 =', b1.x2);

console.log('a1.__proto__ = ', a1.__proto__);

