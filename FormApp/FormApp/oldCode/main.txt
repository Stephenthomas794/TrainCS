
(function() {
'use strict';

function F2(fun)
{
  function wrapper(a) { return function(b) { return fun(a,b); }; }
  wrapper.arity = 2;
  wrapper.func = fun;
  return wrapper;
}

function F3(fun)
{
  function wrapper(a) {
    return function(b) { return function(c) { return fun(a, b, c); }; };
  }
  wrapper.arity = 3;
  wrapper.func = fun;
  return wrapper;
}

function F4(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return fun(a, b, c, d); }; }; };
  }
  wrapper.arity = 4;
  wrapper.func = fun;
  return wrapper;
}

function F5(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return function(e) { return fun(a, b, c, d, e); }; }; }; };
  }
  wrapper.arity = 5;
  wrapper.func = fun;
  return wrapper;
}

function F6(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return function(e) { return function(f) {
    return fun(a, b, c, d, e, f); }; }; }; }; };
  }
  wrapper.arity = 6;
  wrapper.func = fun;
  return wrapper;
}

function F7(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return function(e) { return function(f) {
    return function(g) { return fun(a, b, c, d, e, f, g); }; }; }; }; }; };
  }
  wrapper.arity = 7;
  wrapper.func = fun;
  return wrapper;
}

function F8(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return function(e) { return function(f) {
    return function(g) { return function(h) {
    return fun(a, b, c, d, e, f, g, h); }; }; }; }; }; }; };
  }
  wrapper.arity = 8;
  wrapper.func = fun;
  return wrapper;
}

function F9(fun)
{
  function wrapper(a) { return function(b) { return function(c) {
    return function(d) { return function(e) { return function(f) {
    return function(g) { return function(h) { return function(i) {
    return fun(a, b, c, d, e, f, g, h, i); }; }; }; }; }; }; }; };
  }
  wrapper.arity = 9;
  wrapper.func = fun;
  return wrapper;
}

function A2(fun, a, b)
{
  return fun.arity === 2
    ? fun.func(a, b)
    : fun(a)(b);
}
function A3(fun, a, b, c)
{
  return fun.arity === 3
    ? fun.func(a, b, c)
    : fun(a)(b)(c);
}
function A4(fun, a, b, c, d)
{
  return fun.arity === 4
    ? fun.func(a, b, c, d)
    : fun(a)(b)(c)(d);
}
function A5(fun, a, b, c, d, e)
{
  return fun.arity === 5
    ? fun.func(a, b, c, d, e)
    : fun(a)(b)(c)(d)(e);
}
function A6(fun, a, b, c, d, e, f)
{
  return fun.arity === 6
    ? fun.func(a, b, c, d, e, f)
    : fun(a)(b)(c)(d)(e)(f);
}
function A7(fun, a, b, c, d, e, f, g)
{
  return fun.arity === 7
    ? fun.func(a, b, c, d, e, f, g)
    : fun(a)(b)(c)(d)(e)(f)(g);
}
function A8(fun, a, b, c, d, e, f, g, h)
{
  return fun.arity === 8
    ? fun.func(a, b, c, d, e, f, g, h)
    : fun(a)(b)(c)(d)(e)(f)(g)(h);
}
function A9(fun, a, b, c, d, e, f, g, h, i)
{
  return fun.arity === 9
    ? fun.func(a, b, c, d, e, f, g, h, i)
    : fun(a)(b)(c)(d)(e)(f)(g)(h)(i);
}

var _elm_lang$core$Native_Bitwise = function() {

return {
	and: F2(function and(a, b) { return a & b; }),
	or: F2(function or(a, b) { return a | b; }),
	xor: F2(function xor(a, b) { return a ^ b; }),
	complement: function complement(a) { return ~a; },
	shiftLeftBy: F2(function(offset, a) { return a << offset; }),
	shiftRightBy: F2(function(offset, a) { return a >> offset; }),
	shiftRightZfBy: F2(function(offset, a) { return a >>> offset; })
};

}();

var _elm_lang$core$Bitwise$shiftRightZfBy = _elm_lang$core$Native_Bitwise.shiftRightZfBy;
var _elm_lang$core$Bitwise$shiftRightBy = _elm_lang$core$Native_Bitwise.shiftRightBy;
var _elm_lang$core$Bitwise$shiftLeftBy = _elm_lang$core$Native_Bitwise.shiftLeftBy;
var _elm_lang$core$Bitwise$complement = _elm_lang$core$Native_Bitwise.complement;
var _elm_lang$core$Bitwise$xor = _elm_lang$core$Native_Bitwise.xor;
var _elm_lang$core$Bitwise$or = _elm_lang$core$Native_Bitwise.or;
var _elm_lang$core$Bitwise$and = _elm_lang$core$Native_Bitwise.and;

var _Skinney$elm_array_exploration$Native_JsArray = function() {

var empty = [];

function singleton(val) {
    return [val];
}

function length(arr) {
    return arr.length;
}

function initialize(size, offset, f) {
    var result = new Array(size);

    for (var i = 0; i < size; i++) {
        result[i] = f(offset + i);
    }

    return result;
}

function initializeFromList(max, ls) {
    var result = new Array(max);

    for (var i = 0; i < max && ls.ctor !== '[]'; i++) {
        result[i] = ls._0;
        ls = ls._1;
    }

    result.length = i;

    return {
        ctor: '_Tuple2',
        _0: result,
        _1: ls
    };
}

function unsafeGet(idx, arr) {
    return arr[idx];
}

function unsafeSet(idx, val, arr) {
    var length = arr.length;
    var result = new Array(length);

    for (var i = 0; i < length; i++) {
        result[i] = arr[i];
    }

    result[idx] = val;
    return result;
}

function push(val, arr) {
    var length = arr.length;
    var result = new Array(length + 1);

    for (var i = 0; i < length; i++) {
        result[i] = arr[i];
    }

    result[length] = val;
    return result;
}

function foldl(f, acc, arr) {
    var length = arr.length;

    for (var i = 0; i < length; i++) {
        acc = A2(f, arr[i], acc);
    }

    return acc;
}

function foldr(f, acc, arr) {
    for (var i = arr.length - 1; i >= 0; i--) {
        acc = A2(f, arr[i], acc);
    }

    return acc;
}

function map(f, arr) {
    var length = arr.length;
    var result = new Array(length);

    for (var i = 0; i < length; i++) {
        result[i] = f(arr[i]);
    }

    return result;
}

function indexedMap(f, offset, arr) {
    var length = arr.length;
    var result = new Array(length);

    for (var i = 0; i < length; i++) {
        result[i] = A2(f, offset + i, arr[i]);
    }

    return result;
}

function slice(from, to, arr) {
    return arr.slice(from, to);
}

function appendN(n, dest, source) {
    var destLen = dest.length;
    var itemsToCopy = n - destLen;

    if (itemsToCopy > source.length) {
        itemsToCopy = source.length;
    }

    var size = destLen + itemsToCopy;
    var result = new Array(size);

    for (var i = 0; i < destLen; i++) {
        result[i] = dest[i];
    }

    for (var i = 0; i < itemsToCopy; i++) {
        result[i + destLen] = source[i];
    }

    return result;
}

return {
    empty: empty,
    singleton: singleton,
    length: length,
    initialize: F3(initialize),
    initializeFromList: F2(initializeFromList),
    unsafeGet: F2(unsafeGet),
    unsafeSet: F3(unsafeSet),
    push: F2(push),
    foldl: F3(foldl),
    foldr: F3(foldr),
    map: F2(map),
    indexedMap: F3(indexedMap),
    slice: F3(slice),
    appendN: F3(appendN)
};

}();

//import Native.Utils //

var _elm_lang$core$Native_Basics = function() {

function div(a, b)
{
	return (a / b) | 0;
}
function rem(a, b)
{
	return a % b;
}
function mod(a, b)
{
	if (b === 0)
	{
		throw new Error('Cannot perform mod 0. Division by zero error.');
	}
	var r = a % b;
	var m = a === 0 ? 0 : (b > 0 ? (a >= 0 ? r : r + b) : -mod(-a, -b));

	return m === b ? 0 : m;
}
function logBase(base, n)
{
	return Math.log(n) / Math.log(base);
}
function negate(n)
{
	return -n;
}
function abs(n)
{
	return n < 0 ? -n : n;
}

function min(a, b)
{
	return _elm_lang$core$Native_Utils.cmp(a, b) < 0 ? a : b;
}
function max(a, b)
{
	return _elm_lang$core$Native_Utils.cmp(a, b) > 0 ? a : b;
}
function clamp(lo, hi, n)
{
	return _elm_lang$core$Native_Utils.cmp(n, lo) < 0
		? lo
		: _elm_lang$core$Native_Utils.cmp(n, hi) > 0
			? hi
			: n;
}

var ord = ['LT', 'EQ', 'GT'];

function compare(x, y)
{
	return { ctor: ord[_elm_lang$core$Native_Utils.cmp(x, y) + 1] };
}

function xor(a, b)
{
	return a !== b;
}
function not(b)
{
	return !b;
}
function isInfinite(n)
{
	return n === Infinity || n === -Infinity;
}

function truncate(n)
{
	return n | 0;
}

function degrees(d)
{
	return d * Math.PI / 180;
}
function turns(t)
{
	return 2 * Math.PI * t;
}
function fromPolar(point)
{
	var r = point._0;
	var t = point._1;
	return _elm_lang$core$Native_Utils.Tuple2(r * Math.cos(t), r * Math.sin(t));
}
function toPolar(point)
{
	var x = point._0;
	var y = point._1;
	return _elm_lang$core$Native_Utils.Tuple2(Math.sqrt(x * x + y * y), Math.atan2(y, x));
}

return {
	div: F2(div),
	rem: F2(rem),
	mod: F2(mod),

	pi: Math.PI,
	e: Math.E,
	cos: Math.cos,
	sin: Math.sin,
	tan: Math.tan,
	acos: Math.acos,
	asin: Math.asin,
	atan: Math.atan,
	atan2: F2(Math.atan2),

	degrees: degrees,
	turns: turns,
	fromPolar: fromPolar,
	toPolar: toPolar,

	sqrt: Math.sqrt,
	logBase: F2(logBase),
	negate: negate,
	abs: abs,
	min: F2(min),
	max: F2(max),
	clamp: F3(clamp),
	compare: F2(compare),

	xor: F2(xor),
	not: not,

	truncate: truncate,
	ceiling: Math.ceil,
	floor: Math.floor,
	round: Math.round,
	toFloat: function(x) { return x; },
	isNaN: isNaN,
	isInfinite: isInfinite
};

}();
//import //

var _elm_lang$core$Native_Utils = function() {

// COMPARISONS

function eq(x, y)
{
	var stack = [];
	var isEqual = eqHelp(x, y, 0, stack);
	var pair;
	while (isEqual && (pair = stack.pop()))
	{
		isEqual = eqHelp(pair.x, pair.y, 0, stack);
	}
	return isEqual;
}


function eqHelp(x, y, depth, stack)
{
	if (depth > 100)
	{
		stack.push({ x: x, y: y });
		return true;
	}

	if (x === y)
	{
		return true;
	}

	if (typeof x !== 'object')
	{
		if (typeof x === 'function')
		{
			throw new Error(
				'Trying to use `(==)` on functions. There is no way to know if functions are "the same" in the Elm sense.'
				+ ' Read more about this at http://package.elm-lang.org/packages/elm-lang/core/latest/Basics#=='
				+ ' which describes why it is this way and what the better version will look like.'
			);
		}
		return false;
	}

	if (x === null || y === null)
	{
		return false
	}

	if (x instanceof Date)
	{
		return x.getTime() === y.getTime();
	}

	if (!('ctor' in x))
	{
		for (var key in x)
		{
			if (!eqHelp(x[key], y[key], depth + 1, stack))
			{
				return false;
			}
		}
		return true;
	}

	// convert Dicts and Sets to lists
	if (x.ctor === 'RBNode_elm_builtin' || x.ctor === 'RBEmpty_elm_builtin')
	{
		x = _elm_lang$core$Dict$toList(x);
		y = _elm_lang$core$Dict$toList(y);
	}
	if (x.ctor === 'Set_elm_builtin')
	{
		x = _elm_lang$core$Set$toList(x);
		y = _elm_lang$core$Set$toList(y);
	}

	// check if lists are equal without recursion
	if (x.ctor === '::')
	{
		var a = x;
		var b = y;
		while (a.ctor === '::' && b.ctor === '::')
		{
			if (!eqHelp(a._0, b._0, depth + 1, stack))
			{
				return false;
			}
			a = a._1;
			b = b._1;
		}
		return a.ctor === b.ctor;
	}

	// check if Arrays are equal
	if (x.ctor === '_Array')
	{
		var xs = _elm_lang$core$Native_Array.toJSArray(x);
		var ys = _elm_lang$core$Native_Array.toJSArray(y);
		if (xs.length !== ys.length)
		{
			return false;
		}
		for (var i = 0; i < xs.length; i++)
		{
			if (!eqHelp(xs[i], ys[i], depth + 1, stack))
			{
				return false;
			}
		}
		return true;
	}

	if (!eqHelp(x.ctor, y.ctor, depth + 1, stack))
	{
		return false;
	}

	for (var key in x)
	{
		if (!eqHelp(x[key], y[key], depth + 1, stack))
		{
			return false;
		}
	}
	return true;
}

// Code in Generate/JavaScript.hs, Basics.js, and List.js depends on
// the particular integer values assigned to LT, EQ, and GT.

var LT = -1, EQ = 0, GT = 1;

function cmp(x, y)
{
	if (typeof x !== 'object')
	{
		return x === y ? EQ : x < y ? LT : GT;
	}

	if (x instanceof String)
	{
		var a = x.valueOf();
		var b = y.valueOf();
		return a === b ? EQ : a < b ? LT : GT;
	}

	if (x.ctor === '::' || x.ctor === '[]')
	{
		while (x.ctor === '::' && y.ctor === '::')
		{
			var ord = cmp(x._0, y._0);
			if (ord !== EQ)
			{
				return ord;
			}
			x = x._1;
			y = y._1;
		}
		return x.ctor === y.ctor ? EQ : x.ctor === '[]' ? LT : GT;
	}

	if (x.ctor.slice(0, 6) === '_Tuple')
	{
		var ord;
		var n = x.ctor.slice(6) - 0;
		var err = 'cannot compare tuples with more than 6 elements.';
		if (n === 0) return EQ;
		if (n >= 1) { ord = cmp(x._0, y._0); if (ord !== EQ) return ord;
		if (n >= 2) { ord = cmp(x._1, y._1); if (ord !== EQ) return ord;
		if (n >= 3) { ord = cmp(x._2, y._2); if (ord !== EQ) return ord;
		if (n >= 4) { ord = cmp(x._3, y._3); if (ord !== EQ) return ord;
		if (n >= 5) { ord = cmp(x._4, y._4); if (ord !== EQ) return ord;
		if (n >= 6) { ord = cmp(x._5, y._5); if (ord !== EQ) return ord;
		if (n >= 7) throw new Error('Comparison error: ' + err); } } } } } }
		return EQ;
	}

	throw new Error(
		'Comparison error: comparison is only defined on ints, '
		+ 'floats, times, chars, strings, lists of comparable values, '
		+ 'and tuples of comparable values.'
	);
}


// COMMON VALUES

var Tuple0 = {
	ctor: '_Tuple0'
};

function Tuple2(x, y)
{
	return {
		ctor: '_Tuple2',
		_0: x,
		_1: y
	};
}

function chr(c)
{
	return new String(c);
}


// GUID

var count = 0;
function guid(_)
{
	return count++;
}


// RECORDS

function update(oldRecord, updatedFields)
{
	var newRecord = {};

	for (var key in oldRecord)
	{
		newRecord[key] = oldRecord[key];
	}

	for (var key in updatedFields)
	{
		newRecord[key] = updatedFields[key];
	}

	return newRecord;
}


//// LIST STUFF ////

var Nil = { ctor: '[]' };

function Cons(hd, tl)
{
	return {
		ctor: '::',
		_0: hd,
		_1: tl
	};
}

function append(xs, ys)
{
	// append Strings
	if (typeof xs === 'string')
	{
		return xs + ys;
	}

	// append Lists
	if (xs.ctor === '[]')
	{
		return ys;
	}
	var root = Cons(xs._0, Nil);
	var curr = root;
	xs = xs._1;
	while (xs.ctor !== '[]')
	{
		curr._1 = Cons(xs._0, Nil);
		xs = xs._1;
		curr = curr._1;
	}
	curr._1 = ys;
	return root;
}


// CRASHES

function crash(moduleName, region)
{
	return function(message) {
		throw new Error(
			'Ran into a `Debug.crash` in module `' + moduleName + '` ' + regionToString(region) + '\n'
			+ 'The message provided by the code author is:\n\n    '
			+ message
		);
	};
}

function crashCase(moduleName, region, value)
{
	return function(message) {
		throw new Error(
			'Ran into a `Debug.crash` in module `' + moduleName + '`\n\n'
			+ 'This was caused by the `case` expression ' + regionToString(region) + '.\n'
			+ 'One of the branches ended with a crash and the following value got through:\n\n    ' + toString(value) + '\n\n'
			+ 'The message provided by the code author is:\n\n    '
			+ message
		);
	};
}

function regionToString(region)
{
	if (region.start.line == region.end.line)
	{
		return 'on line ' + region.start.line;
	}
	return 'between lines ' + region.start.line + ' and ' + region.end.line;
}


// TO STRING

function toString(v)
{
	var type = typeof v;
	if (type === 'function')
	{
		return '<function>';
	}

	if (type === 'boolean')
	{
		return v ? 'True' : 'False';
	}

	if (type === 'number')
	{
		return v + '';
	}

	if (v instanceof String)
	{
		return '\'' + addSlashes(v, true) + '\'';
	}

	if (type === 'string')
	{
		return '"' + addSlashes(v, false) + '"';
	}

	if (v === null)
	{
		return 'null';
	}

	if (type === 'object' && 'ctor' in v)
	{
		var ctorStarter = v.ctor.substring(0, 5);

		if (ctorStarter === '_Tupl')
		{
			var output = [];
			for (var k in v)
			{
				if (k === 'ctor') continue;
				output.push(toString(v[k]));
			}
			return '(' + output.join(',') + ')';
		}

		if (ctorStarter === '_Task')
		{
			return '<task>'
		}

		if (v.ctor === '_Array')
		{
			var list = _elm_lang$core$Array$toList(v);
			return 'Array.fromList ' + toString(list);
		}

		if (v.ctor === '<decoder>')
		{
			return '<decoder>';
		}

		if (v.ctor === '_Process')
		{
			return '<process:' + v.id + '>';
		}

		if (v.ctor === '::')
		{
			var output = '[' + toString(v._0);
			v = v._1;
			while (v.ctor === '::')
			{
				output += ',' + toString(v._0);
				v = v._1;
			}
			return output + ']';
		}

		if (v.ctor === '[]')
		{
			return '[]';
		}

		if (v.ctor === 'Set_elm_builtin')
		{
			return 'Set.fromList ' + toString(_elm_lang$core$Set$toList(v));
		}

		if (v.ctor === 'RBNode_elm_builtin' || v.ctor === 'RBEmpty_elm_builtin')
		{
			return 'Dict.fromList ' + toString(_elm_lang$core$Dict$toList(v));
		}

		var output = '';
		for (var i in v)
		{
			if (i === 'ctor') continue;
			var str = toString(v[i]);
			var c0 = str[0];
			var parenless = c0 === '{' || c0 === '(' || c0 === '<' || c0 === '"' || str.indexOf(' ') < 0;
			output += ' ' + (parenless ? str : '(' + str + ')');
		}
		return v.ctor + output;
	}

	if (type === 'object')
	{
		if (v instanceof Date)
		{
			return '<' + v.toString() + '>';
		}

		if (v.elm_web_socket)
		{
			return '<websocket>';
		}

		var output = [];
		for (var k in v)
		{
			output.push(k + ' = ' + toString(v[k]));
		}
		if (output.length === 0)
		{
			return '{}';
		}
		return '{ ' + output.join(', ') + ' }';
	}

	return '<internal structure>';
}

function addSlashes(str, isChar)
{
	var s = str.replace(/\\/g, '\\\\')
			  .replace(/\n/g, '\\n')
			  .replace(/\t/g, '\\t')
			  .replace(/\r/g, '\\r')
			  .replace(/\v/g, '\\v')
			  .replace(/\0/g, '\\0');
	if (isChar)
	{
		return s.replace(/\'/g, '\\\'');
	}
	else
	{
		return s.replace(/\"/g, '\\"');
	}
}


return {
	eq: eq,
	cmp: cmp,
	Tuple0: Tuple0,
	Tuple2: Tuple2,
	chr: chr,
	update: update,
	guid: guid,

	append: F2(append),

	crash: crash,
	crashCase: crashCase,

	toString: toString
};

}();
var _elm_lang$core$Basics$never = function (_p0) {
	never:
	while (true) {
		var _p1 = _p0;
		var _v1 = _p1._0;
		_p0 = _v1;
		continue never;
	}
};
var _elm_lang$core$Basics$uncurry = F2(
	function (f, _p2) {
		var _p3 = _p2;
		return A2(f, _p3._0, _p3._1);
	});
var _elm_lang$core$Basics$curry = F3(
	function (f, a, b) {
		return f(
			{ctor: '_Tuple2', _0: a, _1: b});
	});
var _elm_lang$core$Basics$flip = F3(
	function (f, b, a) {
		return A2(f, a, b);
	});
var _elm_lang$core$Basics$always = F2(
	function (a, _p4) {
		return a;
	});
var _elm_lang$core$Basics$identity = function (x) {
	return x;
};
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['<|'] = F2(
	function (f, x) {
		return f(x);
	});
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['|>'] = F2(
	function (x, f) {
		return f(x);
	});
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['>>'] = F3(
	function (f, g, x) {
		return g(
			f(x));
	});
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['<<'] = F3(
	function (g, f, x) {
		return g(
			f(x));
	});
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['++'] = _elm_lang$core$Native_Utils.append;
var _elm_lang$core$Basics$toString = _elm_lang$core$Native_Utils.toString;
var _elm_lang$core$Basics$isInfinite = _elm_lang$core$Native_Basics.isInfinite;
var _elm_lang$core$Basics$isNaN = _elm_lang$core$Native_Basics.isNaN;
var _elm_lang$core$Basics$toFloat = _elm_lang$core$Native_Basics.toFloat;
var _elm_lang$core$Basics$ceiling = _elm_lang$core$Native_Basics.ceiling;
var _elm_lang$core$Basics$floor = _elm_lang$core$Native_Basics.floor;
var _elm_lang$core$Basics$truncate = _elm_lang$core$Native_Basics.truncate;
var _elm_lang$core$Basics$round = _elm_lang$core$Native_Basics.round;
var _elm_lang$core$Basics$not = _elm_lang$core$Native_Basics.not;
var _elm_lang$core$Basics$xor = _elm_lang$core$Native_Basics.xor;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['||'] = _elm_lang$core$Native_Basics.or;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['&&'] = _elm_lang$core$Native_Basics.and;
var _elm_lang$core$Basics$max = _elm_lang$core$Native_Basics.max;
var _elm_lang$core$Basics$min = _elm_lang$core$Native_Basics.min;
var _elm_lang$core$Basics$compare = _elm_lang$core$Native_Basics.compare;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['>='] = _elm_lang$core$Native_Basics.ge;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['<='] = _elm_lang$core$Native_Basics.le;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['>'] = _elm_lang$core$Native_Basics.gt;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['<'] = _elm_lang$core$Native_Basics.lt;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['/='] = _elm_lang$core$Native_Basics.neq;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['=='] = _elm_lang$core$Native_Basics.eq;
var _elm_lang$core$Basics$e = _elm_lang$core$Native_Basics.e;
var _elm_lang$core$Basics$pi = _elm_lang$core$Native_Basics.pi;
var _elm_lang$core$Basics$clamp = _elm_lang$core$Native_Basics.clamp;
var _elm_lang$core$Basics$logBase = _elm_lang$core$Native_Basics.logBase;
var _elm_lang$core$Basics$abs = _elm_lang$core$Native_Basics.abs;
var _elm_lang$core$Basics$negate = _elm_lang$core$Native_Basics.negate;
var _elm_lang$core$Basics$sqrt = _elm_lang$core$Native_Basics.sqrt;
var _elm_lang$core$Basics$atan2 = _elm_lang$core$Native_Basics.atan2;
var _elm_lang$core$Basics$atan = _elm_lang$core$Native_Basics.atan;
var _elm_lang$core$Basics$asin = _elm_lang$core$Native_Basics.asin;
var _elm_lang$core$Basics$acos = _elm_lang$core$Native_Basics.acos;
var _elm_lang$core$Basics$tan = _elm_lang$core$Native_Basics.tan;
var _elm_lang$core$Basics$sin = _elm_lang$core$Native_Basics.sin;
var _elm_lang$core$Basics$cos = _elm_lang$core$Native_Basics.cos;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['^'] = _elm_lang$core$Native_Basics.exp;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['%'] = _elm_lang$core$Native_Basics.mod;
var _elm_lang$core$Basics$rem = _elm_lang$core$Native_Basics.rem;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['//'] = _elm_lang$core$Native_Basics.div;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['/'] = _elm_lang$core$Native_Basics.floatDiv;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['*'] = _elm_lang$core$Native_Basics.mul;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['-'] = _elm_lang$core$Native_Basics.sub;
var _elm_lang$core$Basics_ops = _elm_lang$core$Basics_ops || {};
_elm_lang$core$Basics_ops['+'] = _elm_lang$core$Native_Basics.add;
var _elm_lang$core$Basics$toPolar = _elm_lang$core$Native_Basics.toPolar;
var _elm_lang$core$Basics$fromPolar = _elm_lang$core$Native_Basics.fromPolar;
var _elm_lang$core$Basics$turns = _elm_lang$core$Native_Basics.turns;
var _elm_lang$core$Basics$degrees = _elm_lang$core$Native_Basics.degrees;
var _elm_lang$core$Basics$radians = function (t) {
	return t;
};
var _elm_lang$core$Basics$GT = {ctor: 'GT'};
var _elm_lang$core$Basics$EQ = {ctor: 'EQ'};
var _elm_lang$core$Basics$LT = {ctor: 'LT'};
var _elm_lang$core$Basics$JustOneMore = function (a) {
	return {ctor: 'JustOneMore', _0: a};
};

//import Native.Utils //

var _elm_lang$core$Native_Debug = function() {

function log(tag, value)
{
	var msg = tag + ': ' + _elm_lang$core$Native_Utils.toString(value);
	var process = process || {};
	if (process.stdout)
	{
		process.stdout.write(msg);
	}
	else
	{
		console.log(msg);
	}
	return value;
}

function crash(message)
{
	throw new Error(message);
}

return {
	crash: crash,
	log: F2(log)
};

}();
var _elm_lang$core$Debug$crash = _elm_lang$core$Native_Debug.crash;
var _elm_lang$core$Debug$log = _elm_lang$core$Native_Debug.log;

var _elm_lang$core$Maybe$withDefault = F2(
	function ($default, maybe) {
		var _p0 = maybe;
		if (_p0.ctor === 'Just') {
			return _p0._0;
		} else {
			return $default;
		}
	});
var _elm_lang$core$Maybe$Nothing = {ctor: 'Nothing'};
var _elm_lang$core$Maybe$andThen = F2(
	function (callback, maybeValue) {
		var _p1 = maybeValue;
		if (_p1.ctor === 'Just') {
			return callback(_p1._0);
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_lang$core$Maybe$Just = function (a) {
	return {ctor: 'Just', _0: a};
};
var _elm_lang$core$Maybe$map = F2(
	function (f, maybe) {
		var _p2 = maybe;
		if (_p2.ctor === 'Just') {
			return _elm_lang$core$Maybe$Just(
				f(_p2._0));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_lang$core$Maybe$map2 = F3(
	function (func, ma, mb) {
		var _p3 = {ctor: '_Tuple2', _0: ma, _1: mb};
		if (((_p3.ctor === '_Tuple2') && (_p3._0.ctor === 'Just')) && (_p3._1.ctor === 'Just')) {
			return _elm_lang$core$Maybe$Just(
				A2(func, _p3._0._0, _p3._1._0));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_lang$core$Maybe$map3 = F4(
	function (func, ma, mb, mc) {
		var _p4 = {ctor: '_Tuple3', _0: ma, _1: mb, _2: mc};
		if ((((_p4.ctor === '_Tuple3') && (_p4._0.ctor === 'Just')) && (_p4._1.ctor === 'Just')) && (_p4._2.ctor === 'Just')) {
			return _elm_lang$core$Maybe$Just(
				A3(func, _p4._0._0, _p4._1._0, _p4._2._0));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_lang$core$Maybe$map4 = F5(
	function (func, ma, mb, mc, md) {
		var _p5 = {ctor: '_Tuple4', _0: ma, _1: mb, _2: mc, _3: md};
		if (((((_p5.ctor === '_Tuple4') && (_p5._0.ctor === 'Just')) && (_p5._1.ctor === 'Just')) && (_p5._2.ctor === 'Just')) && (_p5._3.ctor === 'Just')) {
			return _elm_lang$core$Maybe$Just(
				A4(func, _p5._0._0, _p5._1._0, _p5._2._0, _p5._3._0));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_lang$core$Maybe$map5 = F6(
	function (func, ma, mb, mc, md, me) {
		var _p6 = {ctor: '_Tuple5', _0: ma, _1: mb, _2: mc, _3: md, _4: me};
		if ((((((_p6.ctor === '_Tuple5') && (_p6._0.ctor === 'Just')) && (_p6._1.ctor === 'Just')) && (_p6._2.ctor === 'Just')) && (_p6._3.ctor === 'Just')) && (_p6._4.ctor === 'Just')) {
			return _elm_lang$core$Maybe$Just(
				A5(func, _p6._0._0, _p6._1._0, _p6._2._0, _p6._3._0, _p6._4._0));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});

//import Native.Utils //

var _elm_lang$core$Native_List = function() {

var Nil = { ctor: '[]' };

function Cons(hd, tl)
{
	return { ctor: '::', _0: hd, _1: tl };
}

function fromArray(arr)
{
	var out = Nil;
	for (var i = arr.length; i--; )
	{
		out = Cons(arr[i], out);
	}
	return out;
}

function toArray(xs)
{
	var out = [];
	while (xs.ctor !== '[]')
	{
		out.push(xs._0);
		xs = xs._1;
	}
	return out;
}

function foldr(f, b, xs)
{
	var arr = toArray(xs);
	var acc = b;
	for (var i = arr.length; i--; )
	{
		acc = A2(f, arr[i], acc);
	}
	return acc;
}

function map2(f, xs, ys)
{
	var arr = [];
	while (xs.ctor !== '[]' && ys.ctor !== '[]')
	{
		arr.push(A2(f, xs._0, ys._0));
		xs = xs._1;
		ys = ys._1;
	}
	return fromArray(arr);
}

function map3(f, xs, ys, zs)
{
	var arr = [];
	while (xs.ctor !== '[]' && ys.ctor !== '[]' && zs.ctor !== '[]')
	{
		arr.push(A3(f, xs._0, ys._0, zs._0));
		xs = xs._1;
		ys = ys._1;
		zs = zs._1;
	}
	return fromArray(arr);
}

function map4(f, ws, xs, ys, zs)
{
	var arr = [];
	while (   ws.ctor !== '[]'
		   && xs.ctor !== '[]'
		   && ys.ctor !== '[]'
		   && zs.ctor !== '[]')
	{
		arr.push(A4(f, ws._0, xs._0, ys._0, zs._0));
		ws = ws._1;
		xs = xs._1;
		ys = ys._1;
		zs = zs._1;
	}
	return fromArray(arr);
}

function map5(f, vs, ws, xs, ys, zs)
{
	var arr = [];
	while (   vs.ctor !== '[]'
		   && ws.ctor !== '[]'
		   && xs.ctor !== '[]'
		   && ys.ctor !== '[]'
		   && zs.ctor !== '[]')
	{
		arr.push(A5(f, vs._0, ws._0, xs._0, ys._0, zs._0));
		vs = vs._1;
		ws = ws._1;
		xs = xs._1;
		ys = ys._1;
		zs = zs._1;
	}
	return fromArray(arr);
}

function sortBy(f, xs)
{
	return fromArray(toArray(xs).sort(function(a, b) {
		return _elm_lang$core$Native_Utils.cmp(f(a), f(b));
	}));
}

function sortWith(f, xs)
{
	return fromArray(toArray(xs).sort(function(a, b) {
		var ord = f(a)(b).ctor;
		return ord === 'EQ' ? 0 : ord === 'LT' ? -1 : 1;
	}));
}

return {
	Nil: Nil,
	Cons: Cons,
	cons: F2(Cons),
	toArray: toArray,
	fromArray: fromArray,

	foldr: F3(foldr),

	map2: F3(map2),
	map3: F4(map3),
	map4: F5(map4),
	map5: F6(map5),
	sortBy: F2(sortBy),
	sortWith: F2(sortWith)
};

}();
var _elm_lang$core$List$sortWith = _elm_lang$core$Native_List.sortWith;
var _elm_lang$core$List$sortBy = _elm_lang$core$Native_List.sortBy;
var _elm_lang$core$List$sort = function (xs) {
	return A2(_elm_lang$core$List$sortBy, _elm_lang$core$Basics$identity, xs);
};
var _elm_lang$core$List$singleton = function (value) {
	return {
		ctor: '::',
		_0: value,
		_1: {ctor: '[]'}
	};
};
var _elm_lang$core$List$drop = F2(
	function (n, list) {
		drop:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(n, 0) < 1) {
				return list;
			} else {
				var _p0 = list;
				if (_p0.ctor === '[]') {
					return list;
				} else {
					var _v1 = n - 1,
						_v2 = _p0._1;
					n = _v1;
					list = _v2;
					continue drop;
				}
			}
		}
	});
var _elm_lang$core$List$map5 = _elm_lang$core$Native_List.map5;
var _elm_lang$core$List$map4 = _elm_lang$core$Native_List.map4;
var _elm_lang$core$List$map3 = _elm_lang$core$Native_List.map3;
var _elm_lang$core$List$map2 = _elm_lang$core$Native_List.map2;
var _elm_lang$core$List$any = F2(
	function (isOkay, list) {
		any:
		while (true) {
			var _p1 = list;
			if (_p1.ctor === '[]') {
				return false;
			} else {
				if (isOkay(_p1._0)) {
					return true;
				} else {
					var _v4 = isOkay,
						_v5 = _p1._1;
					isOkay = _v4;
					list = _v5;
					continue any;
				}
			}
		}
	});
var _elm_lang$core$List$all = F2(
	function (isOkay, list) {
		return !A2(
			_elm_lang$core$List$any,
			function (_p2) {
				return !isOkay(_p2);
			},
			list);
	});
var _elm_lang$core$List$foldr = _elm_lang$core$Native_List.foldr;
var _elm_lang$core$List$foldl = F3(
	function (func, acc, list) {
		foldl:
		while (true) {
			var _p3 = list;
			if (_p3.ctor === '[]') {
				return acc;
			} else {
				var _v7 = func,
					_v8 = A2(func, _p3._0, acc),
					_v9 = _p3._1;
				func = _v7;
				acc = _v8;
				list = _v9;
				continue foldl;
			}
		}
	});
var _elm_lang$core$List$length = function (xs) {
	return A3(
		_elm_lang$core$List$foldl,
		F2(
			function (_p4, i) {
				return i + 1;
			}),
		0,
		xs);
};
var _elm_lang$core$List$sum = function (numbers) {
	return A3(
		_elm_lang$core$List$foldl,
		F2(
			function (x, y) {
				return x + y;
			}),
		0,
		numbers);
};
var _elm_lang$core$List$product = function (numbers) {
	return A3(
		_elm_lang$core$List$foldl,
		F2(
			function (x, y) {
				return x * y;
			}),
		1,
		numbers);
};
var _elm_lang$core$List$maximum = function (list) {
	var _p5 = list;
	if (_p5.ctor === '::') {
		return _elm_lang$core$Maybe$Just(
			A3(_elm_lang$core$List$foldl, _elm_lang$core$Basics$max, _p5._0, _p5._1));
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_lang$core$List$minimum = function (list) {
	var _p6 = list;
	if (_p6.ctor === '::') {
		return _elm_lang$core$Maybe$Just(
			A3(_elm_lang$core$List$foldl, _elm_lang$core$Basics$min, _p6._0, _p6._1));
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_lang$core$List$member = F2(
	function (x, xs) {
		return A2(
			_elm_lang$core$List$any,
			function (a) {
				return _elm_lang$core$Native_Utils.eq(a, x);
			},
			xs);
	});
var _elm_lang$core$List$isEmpty = function (xs) {
	var _p7 = xs;
	if (_p7.ctor === '[]') {
		return true;
	} else {
		return false;
	}
};
var _elm_lang$core$List$tail = function (list) {
	var _p8 = list;
	if (_p8.ctor === '::') {
		return _elm_lang$core$Maybe$Just(_p8._1);
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_lang$core$List$head = function (list) {
	var _p9 = list;
	if (_p9.ctor === '::') {
		return _elm_lang$core$Maybe$Just(_p9._0);
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_lang$core$List_ops = _elm_lang$core$List_ops || {};
_elm_lang$core$List_ops['::'] = _elm_lang$core$Native_List.cons;
var _elm_lang$core$List$map = F2(
	function (f, xs) {
		return A3(
			_elm_lang$core$List$foldr,
			F2(
				function (x, acc) {
					return {
						ctor: '::',
						_0: f(x),
						_1: acc
					};
				}),
			{ctor: '[]'},
			xs);
	});
var _elm_lang$core$List$filter = F2(
	function (pred, xs) {
		var conditionalCons = F2(
			function (front, back) {
				return pred(front) ? {ctor: '::', _0: front, _1: back} : back;
			});
		return A3(
			_elm_lang$core$List$foldr,
			conditionalCons,
			{ctor: '[]'},
			xs);
	});
var _elm_lang$core$List$maybeCons = F3(
	function (f, mx, xs) {
		var _p10 = f(mx);
		if (_p10.ctor === 'Just') {
			return {ctor: '::', _0: _p10._0, _1: xs};
		} else {
			return xs;
		}
	});
var _elm_lang$core$List$filterMap = F2(
	function (f, xs) {
		return A3(
			_elm_lang$core$List$foldr,
			_elm_lang$core$List$maybeCons(f),
			{ctor: '[]'},
			xs);
	});
var _elm_lang$core$List$reverse = function (list) {
	return A3(
		_elm_lang$core$List$foldl,
		F2(
			function (x, y) {
				return {ctor: '::', _0: x, _1: y};
			}),
		{ctor: '[]'},
		list);
};
var _elm_lang$core$List$scanl = F3(
	function (f, b, xs) {
		var scan1 = F2(
			function (x, accAcc) {
				var _p11 = accAcc;
				if (_p11.ctor === '::') {
					return {
						ctor: '::',
						_0: A2(f, x, _p11._0),
						_1: accAcc
					};
				} else {
					return {ctor: '[]'};
				}
			});
		return _elm_lang$core$List$reverse(
			A3(
				_elm_lang$core$List$foldl,
				scan1,
				{
					ctor: '::',
					_0: b,
					_1: {ctor: '[]'}
				},
				xs));
	});
var _elm_lang$core$List$append = F2(
	function (xs, ys) {
		var _p12 = ys;
		if (_p12.ctor === '[]') {
			return xs;
		} else {
			return A3(
				_elm_lang$core$List$foldr,
				F2(
					function (x, y) {
						return {ctor: '::', _0: x, _1: y};
					}),
				ys,
				xs);
		}
	});
var _elm_lang$core$List$concat = function (lists) {
	return A3(
		_elm_lang$core$List$foldr,
		_elm_lang$core$List$append,
		{ctor: '[]'},
		lists);
};
var _elm_lang$core$List$concatMap = F2(
	function (f, list) {
		return _elm_lang$core$List$concat(
			A2(_elm_lang$core$List$map, f, list));
	});
var _elm_lang$core$List$partition = F2(
	function (pred, list) {
		var step = F2(
			function (x, _p13) {
				var _p14 = _p13;
				var _p16 = _p14._0;
				var _p15 = _p14._1;
				return pred(x) ? {
					ctor: '_Tuple2',
					_0: {ctor: '::', _0: x, _1: _p16},
					_1: _p15
				} : {
					ctor: '_Tuple2',
					_0: _p16,
					_1: {ctor: '::', _0: x, _1: _p15}
				};
			});
		return A3(
			_elm_lang$core$List$foldr,
			step,
			{
				ctor: '_Tuple2',
				_0: {ctor: '[]'},
				_1: {ctor: '[]'}
			},
			list);
	});
var _elm_lang$core$List$unzip = function (pairs) {
	var step = F2(
		function (_p18, _p17) {
			var _p19 = _p18;
			var _p20 = _p17;
			return {
				ctor: '_Tuple2',
				_0: {ctor: '::', _0: _p19._0, _1: _p20._0},
				_1: {ctor: '::', _0: _p19._1, _1: _p20._1}
			};
		});
	return A3(
		_elm_lang$core$List$foldr,
		step,
		{
			ctor: '_Tuple2',
			_0: {ctor: '[]'},
			_1: {ctor: '[]'}
		},
		pairs);
};
var _elm_lang$core$List$intersperse = F2(
	function (sep, xs) {
		var _p21 = xs;
		if (_p21.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			var step = F2(
				function (x, rest) {
					return {
						ctor: '::',
						_0: sep,
						_1: {ctor: '::', _0: x, _1: rest}
					};
				});
			var spersed = A3(
				_elm_lang$core$List$foldr,
				step,
				{ctor: '[]'},
				_p21._1);
			return {ctor: '::', _0: _p21._0, _1: spersed};
		}
	});
var _elm_lang$core$List$takeReverse = F3(
	function (n, list, taken) {
		takeReverse:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(n, 0) < 1) {
				return taken;
			} else {
				var _p22 = list;
				if (_p22.ctor === '[]') {
					return taken;
				} else {
					var _v23 = n - 1,
						_v24 = _p22._1,
						_v25 = {ctor: '::', _0: _p22._0, _1: taken};
					n = _v23;
					list = _v24;
					taken = _v25;
					continue takeReverse;
				}
			}
		}
	});
var _elm_lang$core$List$takeTailRec = F2(
	function (n, list) {
		return _elm_lang$core$List$reverse(
			A3(
				_elm_lang$core$List$takeReverse,
				n,
				list,
				{ctor: '[]'}));
	});
var _elm_lang$core$List$takeFast = F3(
	function (ctr, n, list) {
		if (_elm_lang$core$Native_Utils.cmp(n, 0) < 1) {
			return {ctor: '[]'};
		} else {
			var _p23 = {ctor: '_Tuple2', _0: n, _1: list};
			_v26_5:
			do {
				_v26_1:
				do {
					if (_p23.ctor === '_Tuple2') {
						if (_p23._1.ctor === '[]') {
							return list;
						} else {
							if (_p23._1._1.ctor === '::') {
								switch (_p23._0) {
									case 1:
										break _v26_1;
									case 2:
										return {
											ctor: '::',
											_0: _p23._1._0,
											_1: {
												ctor: '::',
												_0: _p23._1._1._0,
												_1: {ctor: '[]'}
											}
										};
									case 3:
										if (_p23._1._1._1.ctor === '::') {
											return {
												ctor: '::',
												_0: _p23._1._0,
												_1: {
													ctor: '::',
													_0: _p23._1._1._0,
													_1: {
														ctor: '::',
														_0: _p23._1._1._1._0,
														_1: {ctor: '[]'}
													}
												}
											};
										} else {
											break _v26_5;
										}
									default:
										if ((_p23._1._1._1.ctor === '::') && (_p23._1._1._1._1.ctor === '::')) {
											var _p28 = _p23._1._1._1._0;
											var _p27 = _p23._1._1._0;
											var _p26 = _p23._1._0;
											var _p25 = _p23._1._1._1._1._0;
											var _p24 = _p23._1._1._1._1._1;
											return (_elm_lang$core$Native_Utils.cmp(ctr, 1000) > 0) ? {
												ctor: '::',
												_0: _p26,
												_1: {
													ctor: '::',
													_0: _p27,
													_1: {
														ctor: '::',
														_0: _p28,
														_1: {
															ctor: '::',
															_0: _p25,
															_1: A2(_elm_lang$core$List$takeTailRec, n - 4, _p24)
														}
													}
												}
											} : {
												ctor: '::',
												_0: _p26,
												_1: {
													ctor: '::',
													_0: _p27,
													_1: {
														ctor: '::',
														_0: _p28,
														_1: {
															ctor: '::',
															_0: _p25,
															_1: A3(_elm_lang$core$List$takeFast, ctr + 1, n - 4, _p24)
														}
													}
												}
											};
										} else {
											break _v26_5;
										}
								}
							} else {
								if (_p23._0 === 1) {
									break _v26_1;
								} else {
									break _v26_5;
								}
							}
						}
					} else {
						break _v26_5;
					}
				} while(false);
				return {
					ctor: '::',
					_0: _p23._1._0,
					_1: {ctor: '[]'}
				};
			} while(false);
			return list;
		}
	});
var _elm_lang$core$List$take = F2(
	function (n, list) {
		return A3(_elm_lang$core$List$takeFast, 0, n, list);
	});
var _elm_lang$core$List$repeatHelp = F3(
	function (result, n, value) {
		repeatHelp:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(n, 0) < 1) {
				return result;
			} else {
				var _v27 = {ctor: '::', _0: value, _1: result},
					_v28 = n - 1,
					_v29 = value;
				result = _v27;
				n = _v28;
				value = _v29;
				continue repeatHelp;
			}
		}
	});
var _elm_lang$core$List$repeat = F2(
	function (n, value) {
		return A3(
			_elm_lang$core$List$repeatHelp,
			{ctor: '[]'},
			n,
			value);
	});
var _elm_lang$core$List$rangeHelp = F3(
	function (lo, hi, list) {
		rangeHelp:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(lo, hi) < 1) {
				var _v30 = lo,
					_v31 = hi - 1,
					_v32 = {ctor: '::', _0: hi, _1: list};
				lo = _v30;
				hi = _v31;
				list = _v32;
				continue rangeHelp;
			} else {
				return list;
			}
		}
	});
var _elm_lang$core$List$range = F2(
	function (lo, hi) {
		return A3(
			_elm_lang$core$List$rangeHelp,
			lo,
			hi,
			{ctor: '[]'});
	});
var _elm_lang$core$List$indexedMap = F2(
	function (f, xs) {
		return A3(
			_elm_lang$core$List$map2,
			f,
			A2(
				_elm_lang$core$List$range,
				0,
				_elm_lang$core$List$length(xs) - 1),
			xs);
	});

var _elm_lang$core$Result$toMaybe = function (result) {
	var _p0 = result;
	if (_p0.ctor === 'Ok') {
		return _elm_lang$core$Maybe$Just(_p0._0);
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_lang$core$Result$withDefault = F2(
	function (def, result) {
		var _p1 = result;
		if (_p1.ctor === 'Ok') {
			return _p1._0;
		} else {
			return def;
		}
	});
var _elm_lang$core$Result$Err = function (a) {
	return {ctor: 'Err', _0: a};
};
var _elm_lang$core$Result$andThen = F2(
	function (callback, result) {
		var _p2 = result;
		if (_p2.ctor === 'Ok') {
			return callback(_p2._0);
		} else {
			return _elm_lang$core$Result$Err(_p2._0);
		}
	});
var _elm_lang$core$Result$Ok = function (a) {
	return {ctor: 'Ok', _0: a};
};
var _elm_lang$core$Result$map = F2(
	function (func, ra) {
		var _p3 = ra;
		if (_p3.ctor === 'Ok') {
			return _elm_lang$core$Result$Ok(
				func(_p3._0));
		} else {
			return _elm_lang$core$Result$Err(_p3._0);
		}
	});
var _elm_lang$core$Result$map2 = F3(
	function (func, ra, rb) {
		var _p4 = {ctor: '_Tuple2', _0: ra, _1: rb};
		if (_p4._0.ctor === 'Ok') {
			if (_p4._1.ctor === 'Ok') {
				return _elm_lang$core$Result$Ok(
					A2(func, _p4._0._0, _p4._1._0));
			} else {
				return _elm_lang$core$Result$Err(_p4._1._0);
			}
		} else {
			return _elm_lang$core$Result$Err(_p4._0._0);
		}
	});
var _elm_lang$core$Result$map3 = F4(
	function (func, ra, rb, rc) {
		var _p5 = {ctor: '_Tuple3', _0: ra, _1: rb, _2: rc};
		if (_p5._0.ctor === 'Ok') {
			if (_p5._1.ctor === 'Ok') {
				if (_p5._2.ctor === 'Ok') {
					return _elm_lang$core$Result$Ok(
						A3(func, _p5._0._0, _p5._1._0, _p5._2._0));
				} else {
					return _elm_lang$core$Result$Err(_p5._2._0);
				}
			} else {
				return _elm_lang$core$Result$Err(_p5._1._0);
			}
		} else {
			return _elm_lang$core$Result$Err(_p5._0._0);
		}
	});
var _elm_lang$core$Result$map4 = F5(
	function (func, ra, rb, rc, rd) {
		var _p6 = {ctor: '_Tuple4', _0: ra, _1: rb, _2: rc, _3: rd};
		if (_p6._0.ctor === 'Ok') {
			if (_p6._1.ctor === 'Ok') {
				if (_p6._2.ctor === 'Ok') {
					if (_p6._3.ctor === 'Ok') {
						return _elm_lang$core$Result$Ok(
							A4(func, _p6._0._0, _p6._1._0, _p6._2._0, _p6._3._0));
					} else {
						return _elm_lang$core$Result$Err(_p6._3._0);
					}
				} else {
					return _elm_lang$core$Result$Err(_p6._2._0);
				}
			} else {
				return _elm_lang$core$Result$Err(_p6._1._0);
			}
		} else {
			return _elm_lang$core$Result$Err(_p6._0._0);
		}
	});
var _elm_lang$core$Result$map5 = F6(
	function (func, ra, rb, rc, rd, re) {
		var _p7 = {ctor: '_Tuple5', _0: ra, _1: rb, _2: rc, _3: rd, _4: re};
		if (_p7._0.ctor === 'Ok') {
			if (_p7._1.ctor === 'Ok') {
				if (_p7._2.ctor === 'Ok') {
					if (_p7._3.ctor === 'Ok') {
						if (_p7._4.ctor === 'Ok') {
							return _elm_lang$core$Result$Ok(
								A5(func, _p7._0._0, _p7._1._0, _p7._2._0, _p7._3._0, _p7._4._0));
						} else {
							return _elm_lang$core$Result$Err(_p7._4._0);
						}
					} else {
						return _elm_lang$core$Result$Err(_p7._3._0);
					}
				} else {
					return _elm_lang$core$Result$Err(_p7._2._0);
				}
			} else {
				return _elm_lang$core$Result$Err(_p7._1._0);
			}
		} else {
			return _elm_lang$core$Result$Err(_p7._0._0);
		}
	});
var _elm_lang$core$Result$mapError = F2(
	function (f, result) {
		var _p8 = result;
		if (_p8.ctor === 'Ok') {
			return _elm_lang$core$Result$Ok(_p8._0);
		} else {
			return _elm_lang$core$Result$Err(
				f(_p8._0));
		}
	});
var _elm_lang$core$Result$fromMaybe = F2(
	function (err, maybe) {
		var _p9 = maybe;
		if (_p9.ctor === 'Just') {
			return _elm_lang$core$Result$Ok(_p9._0);
		} else {
			return _elm_lang$core$Result$Err(err);
		}
	});

//import Maybe, Native.List, Native.Utils, Result //

var _elm_lang$core$Native_String = function() {

function isEmpty(str)
{
	return str.length === 0;
}
function cons(chr, str)
{
	return chr + str;
}
function uncons(str)
{
	var hd = str[0];
	if (hd)
	{
		return _elm_lang$core$Maybe$Just(_elm_lang$core$Native_Utils.Tuple2(_elm_lang$core$Native_Utils.chr(hd), str.slice(1)));
	}
	return _elm_lang$core$Maybe$Nothing;
}
function append(a, b)
{
	return a + b;
}
function concat(strs)
{
	return _elm_lang$core$Native_List.toArray(strs).join('');
}
function length(str)
{
	return str.length;
}
function map(f, str)
{
	var out = str.split('');
	for (var i = out.length; i--; )
	{
		out[i] = f(_elm_lang$core$Native_Utils.chr(out[i]));
	}
	return out.join('');
}
function filter(pred, str)
{
	return str.split('').map(_elm_lang$core$Native_Utils.chr).filter(pred).join('');
}
function reverse(str)
{
	return str.split('').reverse().join('');
}
function foldl(f, b, str)
{
	var len = str.length;
	for (var i = 0; i < len; ++i)
	{
		b = A2(f, _elm_lang$core$Native_Utils.chr(str[i]), b);
	}
	return b;
}
function foldr(f, b, str)
{
	for (var i = str.length; i--; )
	{
		b = A2(f, _elm_lang$core$Native_Utils.chr(str[i]), b);
	}
	return b;
}
function split(sep, str)
{
	return _elm_lang$core$Native_List.fromArray(str.split(sep));
}
function join(sep, strs)
{
	return _elm_lang$core$Native_List.toArray(strs).join(sep);
}
function repeat(n, str)
{
	var result = '';
	while (n > 0)
	{
		if (n & 1)
		{
			result += str;
		}
		n >>= 1, str += str;
	}
	return result;
}
function slice(start, end, str)
{
	return str.slice(start, end);
}
function left(n, str)
{
	return n < 1 ? '' : str.slice(0, n);
}
function right(n, str)
{
	return n < 1 ? '' : str.slice(-n);
}
function dropLeft(n, str)
{
	return n < 1 ? str : str.slice(n);
}
function dropRight(n, str)
{
	return n < 1 ? str : str.slice(0, -n);
}
function pad(n, chr, str)
{
	var half = (n - str.length) / 2;
	return repeat(Math.ceil(half), chr) + str + repeat(half | 0, chr);
}
function padRight(n, chr, str)
{
	return str + repeat(n - str.length, chr);
}
function padLeft(n, chr, str)
{
	return repeat(n - str.length, chr) + str;
}

function trim(str)
{
	return str.trim();
}
function trimLeft(str)
{
	return str.replace(/^\s+/, '');
}
function trimRight(str)
{
	return str.replace(/\s+$/, '');
}

function words(str)
{
	return _elm_lang$core$Native_List.fromArray(str.trim().split(/\s+/g));
}
function lines(str)
{
	return _elm_lang$core$Native_List.fromArray(str.split(/\r\n|\r|\n/g));
}

function toUpper(str)
{
	return str.toUpperCase();
}
function toLower(str)
{
	return str.toLowerCase();
}

function any(pred, str)
{
	for (var i = str.length; i--; )
	{
		if (pred(_elm_lang$core$Native_Utils.chr(str[i])))
		{
			return true;
		}
	}
	return false;
}
function all(pred, str)
{
	for (var i = str.length; i--; )
	{
		if (!pred(_elm_lang$core$Native_Utils.chr(str[i])))
		{
			return false;
		}
	}
	return true;
}

function contains(sub, str)
{
	return str.indexOf(sub) > -1;
}
function startsWith(sub, str)
{
	return str.indexOf(sub) === 0;
}
function endsWith(sub, str)
{
	return str.length >= sub.length &&
		str.lastIndexOf(sub) === str.length - sub.length;
}
function indexes(sub, str)
{
	var subLen = sub.length;

	if (subLen < 1)
	{
		return _elm_lang$core$Native_List.Nil;
	}

	var i = 0;
	var is = [];

	while ((i = str.indexOf(sub, i)) > -1)
	{
		is.push(i);
		i = i + subLen;
	}

	return _elm_lang$core$Native_List.fromArray(is);
}


function toInt(s)
{
	var len = s.length;

	// if empty
	if (len === 0)
	{
		return intErr(s);
	}

	// if hex
	var c = s[0];
	if (c === '0' && s[1] === 'x')
	{
		for (var i = 2; i < len; ++i)
		{
			var c = s[i];
			if (('0' <= c && c <= '9') || ('A' <= c && c <= 'F') || ('a' <= c && c <= 'f'))
			{
				continue;
			}
			return intErr(s);
		}
		return _elm_lang$core$Result$Ok(parseInt(s, 16));
	}

	// is decimal
	if (c > '9' || (c < '0' && c !== '-' && c !== '+'))
	{
		return intErr(s);
	}
	for (var i = 1; i < len; ++i)
	{
		var c = s[i];
		if (c < '0' || '9' < c)
		{
			return intErr(s);
		}
	}

	return _elm_lang$core$Result$Ok(parseInt(s, 10));
}

function intErr(s)
{
	return _elm_lang$core$Result$Err("could not convert string '" + s + "' to an Int");
}


function toFloat(s)
{
	// check if it is a hex, octal, or binary number
	if (s.length === 0 || /[\sxbo]/.test(s))
	{
		return floatErr(s);
	}
	var n = +s;
	// faster isNaN check
	return n === n ? _elm_lang$core$Result$Ok(n) : floatErr(s);
}

function floatErr(s)
{
	return _elm_lang$core$Result$Err("could not convert string '" + s + "' to a Float");
}


function toList(str)
{
	return _elm_lang$core$Native_List.fromArray(str.split('').map(_elm_lang$core$Native_Utils.chr));
}
function fromList(chars)
{
	return _elm_lang$core$Native_List.toArray(chars).join('');
}

return {
	isEmpty: isEmpty,
	cons: F2(cons),
	uncons: uncons,
	append: F2(append),
	concat: concat,
	length: length,
	map: F2(map),
	filter: F2(filter),
	reverse: reverse,
	foldl: F3(foldl),
	foldr: F3(foldr),

	split: F2(split),
	join: F2(join),
	repeat: F2(repeat),

	slice: F3(slice),
	left: F2(left),
	right: F2(right),
	dropLeft: F2(dropLeft),
	dropRight: F2(dropRight),

	pad: F3(pad),
	padLeft: F3(padLeft),
	padRight: F3(padRight),

	trim: trim,
	trimLeft: trimLeft,
	trimRight: trimRight,

	words: words,
	lines: lines,

	toUpper: toUpper,
	toLower: toLower,

	any: F2(any),
	all: F2(all),

	contains: F2(contains),
	startsWith: F2(startsWith),
	endsWith: F2(endsWith),
	indexes: F2(indexes),

	toInt: toInt,
	toFloat: toFloat,
	toList: toList,
	fromList: fromList
};

}();

//import Native.Utils //

var _elm_lang$core$Native_Char = function() {

return {
	fromCode: function(c) { return _elm_lang$core$Native_Utils.chr(String.fromCharCode(c)); },
	toCode: function(c) { return c.charCodeAt(0); },
	toUpper: function(c) { return _elm_lang$core$Native_Utils.chr(c.toUpperCase()); },
	toLower: function(c) { return _elm_lang$core$Native_Utils.chr(c.toLowerCase()); },
	toLocaleUpper: function(c) { return _elm_lang$core$Native_Utils.chr(c.toLocaleUpperCase()); },
	toLocaleLower: function(c) { return _elm_lang$core$Native_Utils.chr(c.toLocaleLowerCase()); }
};

}();
var _elm_lang$core$Char$fromCode = _elm_lang$core$Native_Char.fromCode;
var _elm_lang$core$Char$toCode = _elm_lang$core$Native_Char.toCode;
var _elm_lang$core$Char$toLocaleLower = _elm_lang$core$Native_Char.toLocaleLower;
var _elm_lang$core$Char$toLocaleUpper = _elm_lang$core$Native_Char.toLocaleUpper;
var _elm_lang$core$Char$toLower = _elm_lang$core$Native_Char.toLower;
var _elm_lang$core$Char$toUpper = _elm_lang$core$Native_Char.toUpper;
var _elm_lang$core$Char$isBetween = F3(
	function (low, high, $char) {
		var code = _elm_lang$core$Char$toCode($char);
		return (_elm_lang$core$Native_Utils.cmp(
			code,
			_elm_lang$core$Char$toCode(low)) > -1) && (_elm_lang$core$Native_Utils.cmp(
			code,
			_elm_lang$core$Char$toCode(high)) < 1);
	});
var _elm_lang$core$Char$isUpper = A2(
	_elm_lang$core$Char$isBetween,
	_elm_lang$core$Native_Utils.chr('A'),
	_elm_lang$core$Native_Utils.chr('Z'));
var _elm_lang$core$Char$isLower = A2(
	_elm_lang$core$Char$isBetween,
	_elm_lang$core$Native_Utils.chr('a'),
	_elm_lang$core$Native_Utils.chr('z'));
var _elm_lang$core$Char$isDigit = A2(
	_elm_lang$core$Char$isBetween,
	_elm_lang$core$Native_Utils.chr('0'),
	_elm_lang$core$Native_Utils.chr('9'));
var _elm_lang$core$Char$isOctDigit = A2(
	_elm_lang$core$Char$isBetween,
	_elm_lang$core$Native_Utils.chr('0'),
	_elm_lang$core$Native_Utils.chr('7'));
var _elm_lang$core$Char$isHexDigit = function ($char) {
	return _elm_lang$core$Char$isDigit($char) || (A3(
		_elm_lang$core$Char$isBetween,
		_elm_lang$core$Native_Utils.chr('a'),
		_elm_lang$core$Native_Utils.chr('f'),
		$char) || A3(
		_elm_lang$core$Char$isBetween,
		_elm_lang$core$Native_Utils.chr('A'),
		_elm_lang$core$Native_Utils.chr('F'),
		$char));
};

var _elm_lang$core$String$fromList = _elm_lang$core$Native_String.fromList;
var _elm_lang$core$String$toList = _elm_lang$core$Native_String.toList;
var _elm_lang$core$String$toFloat = _elm_lang$core$Native_String.toFloat;
var _elm_lang$core$String$toInt = _elm_lang$core$Native_String.toInt;
var _elm_lang$core$String$indices = _elm_lang$core$Native_String.indexes;
var _elm_lang$core$String$indexes = _elm_lang$core$Native_String.indexes;
var _elm_lang$core$String$endsWith = _elm_lang$core$Native_String.endsWith;
var _elm_lang$core$String$startsWith = _elm_lang$core$Native_String.startsWith;
var _elm_lang$core$String$contains = _elm_lang$core$Native_String.contains;
var _elm_lang$core$String$all = _elm_lang$core$Native_String.all;
var _elm_lang$core$String$any = _elm_lang$core$Native_String.any;
var _elm_lang$core$String$toLower = _elm_lang$core$Native_String.toLower;
var _elm_lang$core$String$toUpper = _elm_lang$core$Native_String.toUpper;
var _elm_lang$core$String$lines = _elm_lang$core$Native_String.lines;
var _elm_lang$core$String$words = _elm_lang$core$Native_String.words;
var _elm_lang$core$String$trimRight = _elm_lang$core$Native_String.trimRight;
var _elm_lang$core$String$trimLeft = _elm_lang$core$Native_String.trimLeft;
var _elm_lang$core$String$trim = _elm_lang$core$Native_String.trim;
var _elm_lang$core$String$padRight = _elm_lang$core$Native_String.padRight;
var _elm_lang$core$String$padLeft = _elm_lang$core$Native_String.padLeft;
var _elm_lang$core$String$pad = _elm_lang$core$Native_String.pad;
var _elm_lang$core$String$dropRight = _elm_lang$core$Native_String.dropRight;
var _elm_lang$core$String$dropLeft = _elm_lang$core$Native_String.dropLeft;
var _elm_lang$core$String$right = _elm_lang$core$Native_String.right;
var _elm_lang$core$String$left = _elm_lang$core$Native_String.left;
var _elm_lang$core$String$slice = _elm_lang$core$Native_String.slice;
var _elm_lang$core$String$repeat = _elm_lang$core$Native_String.repeat;
var _elm_lang$core$String$join = _elm_lang$core$Native_String.join;
var _elm_lang$core$String$split = _elm_lang$core$Native_String.split;
var _elm_lang$core$String$foldr = _elm_lang$core$Native_String.foldr;
var _elm_lang$core$String$foldl = _elm_lang$core$Native_String.foldl;
var _elm_lang$core$String$reverse = _elm_lang$core$Native_String.reverse;
var _elm_lang$core$String$filter = _elm_lang$core$Native_String.filter;
var _elm_lang$core$String$map = _elm_lang$core$Native_String.map;
var _elm_lang$core$String$length = _elm_lang$core$Native_String.length;
var _elm_lang$core$String$concat = _elm_lang$core$Native_String.concat;
var _elm_lang$core$String$append = _elm_lang$core$Native_String.append;
var _elm_lang$core$String$uncons = _elm_lang$core$Native_String.uncons;
var _elm_lang$core$String$cons = _elm_lang$core$Native_String.cons;
var _elm_lang$core$String$fromChar = function ($char) {
	return A2(_elm_lang$core$String$cons, $char, '');
};
var _elm_lang$core$String$isEmpty = _elm_lang$core$Native_String.isEmpty;

var _elm_lang$core$Tuple$mapSecond = F2(
	function (func, _p0) {
		var _p1 = _p0;
		return {
			ctor: '_Tuple2',
			_0: _p1._0,
			_1: func(_p1._1)
		};
	});
var _elm_lang$core$Tuple$mapFirst = F2(
	function (func, _p2) {
		var _p3 = _p2;
		return {
			ctor: '_Tuple2',
			_0: func(_p3._0),
			_1: _p3._1
		};
	});
var _elm_lang$core$Tuple$second = function (_p4) {
	var _p5 = _p4;
	return _p5._1;
};
var _elm_lang$core$Tuple$first = function (_p6) {
	var _p7 = _p6;
	return _p7._0;
};

//import //

var _elm_lang$core$Native_Platform = function() {


// PROGRAMS

function program(impl)
{
	return function(flagDecoder)
	{
		return function(object, moduleName)
		{
			object['worker'] = function worker(flags)
			{
				if (typeof flags !== 'undefined')
				{
					throw new Error(
						'The `' + moduleName + '` module does not need flags.\n'
						+ 'Call ' + moduleName + '.worker() with no arguments and you should be all set!'
					);
				}

				return initialize(
					impl.init,
					impl.update,
					impl.subscriptions,
					renderer
				);
			};
		};
	};
}

function programWithFlags(impl)
{
	return function(flagDecoder)
	{
		return function(object, moduleName)
		{
			object['worker'] = function worker(flags)
			{
				if (typeof flagDecoder === 'undefined')
				{
					throw new Error(
						'Are you trying to sneak a Never value into Elm? Trickster!\n'
						+ 'It looks like ' + moduleName + '.main is defined with `programWithFlags` but has type `Program Never`.\n'
						+ 'Use `program` instead if you do not want flags.'
					);
				}

				var result = A2(_elm_lang$core$Native_Json.run, flagDecoder, flags);
				if (result.ctor === 'Err')
				{
					throw new Error(
						moduleName + '.worker(...) was called with an unexpected argument.\n'
						+ 'I tried to convert it to an Elm value, but ran into this problem:\n\n'
						+ result._0
					);
				}

				return initialize(
					impl.init(result._0),
					impl.update,
					impl.subscriptions,
					renderer
				);
			};
		};
	};
}

function renderer(enqueue, _)
{
	return function(_) {};
}


// HTML TO PROGRAM

function htmlToProgram(vnode)
{
	var emptyBag = batch(_elm_lang$core$Native_List.Nil);
	var noChange = _elm_lang$core$Native_Utils.Tuple2(
		_elm_lang$core$Native_Utils.Tuple0,
		emptyBag
	);

	return _elm_lang$virtual_dom$VirtualDom$program({
		init: noChange,
		view: function(model) { return main; },
		update: F2(function(msg, model) { return noChange; }),
		subscriptions: function (model) { return emptyBag; }
	});
}


// INITIALIZE A PROGRAM

function initialize(init, update, subscriptions, renderer)
{
	// ambient state
	var managers = {};
	var updateView;

	// init and update state in main process
	var initApp = _elm_lang$core$Native_Scheduler.nativeBinding(function(callback) {
		var model = init._0;
		updateView = renderer(enqueue, model);
		var cmds = init._1;
		var subs = subscriptions(model);
		dispatchEffects(managers, cmds, subs);
		callback(_elm_lang$core$Native_Scheduler.succeed(model));
	});

	function onMessage(msg, model)
	{
		return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback) {
			var results = A2(update, msg, model);
			model = results._0;
			updateView(model);
			var cmds = results._1;
			var subs = subscriptions(model);
			dispatchEffects(managers, cmds, subs);
			callback(_elm_lang$core$Native_Scheduler.succeed(model));
		});
	}

	var mainProcess = spawnLoop(initApp, onMessage);

	function enqueue(msg)
	{
		_elm_lang$core$Native_Scheduler.rawSend(mainProcess, msg);
	}

	var ports = setupEffects(managers, enqueue);

	return ports ? { ports: ports } : {};
}


// EFFECT MANAGERS

var effectManagers = {};

function setupEffects(managers, callback)
{
	var ports;

	// setup all necessary effect managers
	for (var key in effectManagers)
	{
		var manager = effectManagers[key];

		if (manager.isForeign)
		{
			ports = ports || {};
			ports[key] = manager.tag === 'cmd'
				? setupOutgoingPort(key)
				: setupIncomingPort(key, callback);
		}

		managers[key] = makeManager(manager, callback);
	}

	return ports;
}

function makeManager(info, callback)
{
	var router = {
		main: callback,
		self: undefined
	};

	var tag = info.tag;
	var onEffects = info.onEffects;
	var onSelfMsg = info.onSelfMsg;

	function onMessage(msg, state)
	{
		if (msg.ctor === 'self')
		{
			return A3(onSelfMsg, router, msg._0, state);
		}

		var fx = msg._0;
		switch (tag)
		{
			case 'cmd':
				return A3(onEffects, router, fx.cmds, state);

			case 'sub':
				return A3(onEffects, router, fx.subs, state);

			case 'fx':
				return A4(onEffects, router, fx.cmds, fx.subs, state);
		}
	}

	var process = spawnLoop(info.init, onMessage);
	router.self = process;
	return process;
}

function sendToApp(router, msg)
{
	return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback)
	{
		router.main(msg);
		callback(_elm_lang$core$Native_Scheduler.succeed(_elm_lang$core$Native_Utils.Tuple0));
	});
}

function sendToSelf(router, msg)
{
	return A2(_elm_lang$core$Native_Scheduler.send, router.self, {
		ctor: 'self',
		_0: msg
	});
}


// HELPER for STATEFUL LOOPS

function spawnLoop(init, onMessage)
{
	var andThen = _elm_lang$core$Native_Scheduler.andThen;

	function loop(state)
	{
		var handleMsg = _elm_lang$core$Native_Scheduler.receive(function(msg) {
			return onMessage(msg, state);
		});
		return A2(andThen, loop, handleMsg);
	}

	var task = A2(andThen, loop, init);

	return _elm_lang$core$Native_Scheduler.rawSpawn(task);
}


// BAGS

function leaf(home)
{
	return function(value)
	{
		return {
			type: 'leaf',
			home: home,
			value: value
		};
	};
}

function batch(list)
{
	return {
		type: 'node',
		branches: list
	};
}

function map(tagger, bag)
{
	return {
		type: 'map',
		tagger: tagger,
		tree: bag
	}
}


// PIPE BAGS INTO EFFECT MANAGERS

function dispatchEffects(managers, cmdBag, subBag)
{
	var effectsDict = {};
	gatherEffects(true, cmdBag, effectsDict, null);
	gatherEffects(false, subBag, effectsDict, null);

	for (var home in managers)
	{
		var fx = home in effectsDict
			? effectsDict[home]
			: {
				cmds: _elm_lang$core$Native_List.Nil,
				subs: _elm_lang$core$Native_List.Nil
			};

		_elm_lang$core$Native_Scheduler.rawSend(managers[home], { ctor: 'fx', _0: fx });
	}
}

function gatherEffects(isCmd, bag, effectsDict, taggers)
{
	switch (bag.type)
	{
		case 'leaf':
			var home = bag.home;
			var effect = toEffect(isCmd, home, taggers, bag.value);
			effectsDict[home] = insert(isCmd, effect, effectsDict[home]);
			return;

		case 'node':
			var list = bag.branches;
			while (list.ctor !== '[]')
			{
				gatherEffects(isCmd, list._0, effectsDict, taggers);
				list = list._1;
			}
			return;

		case 'map':
			gatherEffects(isCmd, bag.tree, effectsDict, {
				tagger: bag.tagger,
				rest: taggers
			});
			return;
	}
}

function toEffect(isCmd, home, taggers, value)
{
	function applyTaggers(x)
	{
		var temp = taggers;
		while (temp)
		{
			x = temp.tagger(x);
			temp = temp.rest;
		}
		return x;
	}

	var map = isCmd
		? effectManagers[home].cmdMap
		: effectManagers[home].subMap;

	return A2(map, applyTaggers, value)
}

function insert(isCmd, newEffect, effects)
{
	effects = effects || {
		cmds: _elm_lang$core$Native_List.Nil,
		subs: _elm_lang$core$Native_List.Nil
	};
	if (isCmd)
	{
		effects.cmds = _elm_lang$core$Native_List.Cons(newEffect, effects.cmds);
		return effects;
	}
	effects.subs = _elm_lang$core$Native_List.Cons(newEffect, effects.subs);
	return effects;
}


// PORTS

function checkPortName(name)
{
	if (name in effectManagers)
	{
		throw new Error('There can only be one port named `' + name + '`, but your program has multiple.');
	}
}


// OUTGOING PORTS

function outgoingPort(name, converter)
{
	checkPortName(name);
	effectManagers[name] = {
		tag: 'cmd',
		cmdMap: outgoingPortMap,
		converter: converter,
		isForeign: true
	};
	return leaf(name);
}

var outgoingPortMap = F2(function cmdMap(tagger, value) {
	return value;
});

function setupOutgoingPort(name)
{
	var subs = [];
	var converter = effectManagers[name].converter;

	// CREATE MANAGER

	var init = _elm_lang$core$Native_Scheduler.succeed(null);

	function onEffects(router, cmdList, state)
	{
		while (cmdList.ctor !== '[]')
		{
			// grab a separate reference to subs in case unsubscribe is called
			var currentSubs = subs;
			var value = converter(cmdList._0);
			for (var i = 0; i < currentSubs.length; i++)
			{
				currentSubs[i](value);
			}
			cmdList = cmdList._1;
		}
		return init;
	}

	effectManagers[name].init = init;
	effectManagers[name].onEffects = F3(onEffects);

	// PUBLIC API

	function subscribe(callback)
	{
		subs.push(callback);
	}

	function unsubscribe(callback)
	{
		// copy subs into a new array in case unsubscribe is called within a
		// subscribed callback
		subs = subs.slice();
		var index = subs.indexOf(callback);
		if (index >= 0)
		{
			subs.splice(index, 1);
		}
	}

	return {
		subscribe: subscribe,
		unsubscribe: unsubscribe
	};
}


// INCOMING PORTS

function incomingPort(name, converter)
{
	checkPortName(name);
	effectManagers[name] = {
		tag: 'sub',
		subMap: incomingPortMap,
		converter: converter,
		isForeign: true
	};
	return leaf(name);
}

var incomingPortMap = F2(function subMap(tagger, finalTagger)
{
	return function(value)
	{
		return tagger(finalTagger(value));
	};
});

function setupIncomingPort(name, callback)
{
	var sentBeforeInit = [];
	var subs = _elm_lang$core$Native_List.Nil;
	var converter = effectManagers[name].converter;
	var currentOnEffects = preInitOnEffects;
	var currentSend = preInitSend;

	// CREATE MANAGER

	var init = _elm_lang$core$Native_Scheduler.succeed(null);

	function preInitOnEffects(router, subList, state)
	{
		var postInitResult = postInitOnEffects(router, subList, state);

		for(var i = 0; i < sentBeforeInit.length; i++)
		{
			postInitSend(sentBeforeInit[i]);
		}

		sentBeforeInit = null; // to release objects held in queue
		currentSend = postInitSend;
		currentOnEffects = postInitOnEffects;
		return postInitResult;
	}

	function postInitOnEffects(router, subList, state)
	{
		subs = subList;
		return init;
	}

	function onEffects(router, subList, state)
	{
		return currentOnEffects(router, subList, state);
	}

	effectManagers[name].init = init;
	effectManagers[name].onEffects = F3(onEffects);

	// PUBLIC API

	function preInitSend(value)
	{
		sentBeforeInit.push(value);
	}

	function postInitSend(value)
	{
		var temp = subs;
		while (temp.ctor !== '[]')
		{
			callback(temp._0(value));
			temp = temp._1;
		}
	}

	function send(incomingValue)
	{
		var result = A2(_elm_lang$core$Json_Decode$decodeValue, converter, incomingValue);
		if (result.ctor === 'Err')
		{
			throw new Error('Trying to send an unexpected type of value through port `' + name + '`:\n' + result._0);
		}

		currentSend(result._0);
	}

	return { send: send };
}

return {
	// routers
	sendToApp: F2(sendToApp),
	sendToSelf: F2(sendToSelf),

	// global setup
	effectManagers: effectManagers,
	outgoingPort: outgoingPort,
	incomingPort: incomingPort,

	htmlToProgram: htmlToProgram,
	program: program,
	programWithFlags: programWithFlags,
	initialize: initialize,

	// effect bags
	leaf: leaf,
	batch: batch,
	map: F2(map)
};

}();

//import Native.Utils //

var _elm_lang$core$Native_Scheduler = function() {

var MAX_STEPS = 10000;


// TASKS

function succeed(value)
{
	return {
		ctor: '_Task_succeed',
		value: value
	};
}

function fail(error)
{
	return {
		ctor: '_Task_fail',
		value: error
	};
}

function nativeBinding(callback)
{
	return {
		ctor: '_Task_nativeBinding',
		callback: callback,
		cancel: null
	};
}

function andThen(callback, task)
{
	return {
		ctor: '_Task_andThen',
		callback: callback,
		task: task
	};
}

function onError(callback, task)
{
	return {
		ctor: '_Task_onError',
		callback: callback,
		task: task
	};
}

function receive(callback)
{
	return {
		ctor: '_Task_receive',
		callback: callback
	};
}


// PROCESSES

function rawSpawn(task)
{
	var process = {
		ctor: '_Process',
		id: _elm_lang$core$Native_Utils.guid(),
		root: task,
		stack: null,
		mailbox: []
	};

	enqueue(process);

	return process;
}

function spawn(task)
{
	return nativeBinding(function(callback) {
		var process = rawSpawn(task);
		callback(succeed(process));
	});
}

function rawSend(process, msg)
{
	process.mailbox.push(msg);
	enqueue(process);
}

function send(process, msg)
{
	return nativeBinding(function(callback) {
		rawSend(process, msg);
		callback(succeed(_elm_lang$core$Native_Utils.Tuple0));
	});
}

function kill(process)
{
	return nativeBinding(function(callback) {
		var root = process.root;
		if (root.ctor === '_Task_nativeBinding' && root.cancel)
		{
			root.cancel();
		}

		process.root = null;

		callback(succeed(_elm_lang$core$Native_Utils.Tuple0));
	});
}

function sleep(time)
{
	return nativeBinding(function(callback) {
		var id = setTimeout(function() {
			callback(succeed(_elm_lang$core$Native_Utils.Tuple0));
		}, time);

		return function() { clearTimeout(id); };
	});
}


// STEP PROCESSES

function step(numSteps, process)
{
	while (numSteps < MAX_STEPS)
	{
		var ctor = process.root.ctor;

		if (ctor === '_Task_succeed')
		{
			while (process.stack && process.stack.ctor === '_Task_onError')
			{
				process.stack = process.stack.rest;
			}
			if (process.stack === null)
			{
				break;
			}
			process.root = process.stack.callback(process.root.value);
			process.stack = process.stack.rest;
			++numSteps;
			continue;
		}

		if (ctor === '_Task_fail')
		{
			while (process.stack && process.stack.ctor === '_Task_andThen')
			{
				process.stack = process.stack.rest;
			}
			if (process.stack === null)
			{
				break;
			}
			process.root = process.stack.callback(process.root.value);
			process.stack = process.stack.rest;
			++numSteps;
			continue;
		}

		if (ctor === '_Task_andThen')
		{
			process.stack = {
				ctor: '_Task_andThen',
				callback: process.root.callback,
				rest: process.stack
			};
			process.root = process.root.task;
			++numSteps;
			continue;
		}

		if (ctor === '_Task_onError')
		{
			process.stack = {
				ctor: '_Task_onError',
				callback: process.root.callback,
				rest: process.stack
			};
			process.root = process.root.task;
			++numSteps;
			continue;
		}

		if (ctor === '_Task_nativeBinding')
		{
			process.root.cancel = process.root.callback(function(newRoot) {
				process.root = newRoot;
				enqueue(process);
			});

			break;
		}

		if (ctor === '_Task_receive')
		{
			var mailbox = process.mailbox;
			if (mailbox.length === 0)
			{
				break;
			}

			process.root = process.root.callback(mailbox.shift());
			++numSteps;
			continue;
		}

		throw new Error(ctor);
	}

	if (numSteps < MAX_STEPS)
	{
		return numSteps + 1;
	}
	enqueue(process);

	return numSteps;
}


// WORK QUEUE

var working = false;
var workQueue = [];

function enqueue(process)
{
	workQueue.push(process);

	if (!working)
	{
		setTimeout(work, 0);
		working = true;
	}
}

function work()
{
	var numSteps = 0;
	var process;
	while (numSteps < MAX_STEPS && (process = workQueue.shift()))
	{
		if (process.root)
		{
			numSteps = step(numSteps, process);
		}
	}
	if (!process)
	{
		working = false;
		return;
	}
	setTimeout(work, 0);
}


return {
	succeed: succeed,
	fail: fail,
	nativeBinding: nativeBinding,
	andThen: F2(andThen),
	onError: F2(onError),
	receive: receive,

	spawn: spawn,
	kill: kill,
	sleep: sleep,
	send: F2(send),

	rawSpawn: rawSpawn,
	rawSend: rawSend
};

}();
var _elm_lang$core$Platform_Cmd$batch = _elm_lang$core$Native_Platform.batch;
var _elm_lang$core$Platform_Cmd$none = _elm_lang$core$Platform_Cmd$batch(
	{ctor: '[]'});
var _elm_lang$core$Platform_Cmd_ops = _elm_lang$core$Platform_Cmd_ops || {};
_elm_lang$core$Platform_Cmd_ops['!'] = F2(
	function (model, commands) {
		return {
			ctor: '_Tuple2',
			_0: model,
			_1: _elm_lang$core$Platform_Cmd$batch(commands)
		};
	});
var _elm_lang$core$Platform_Cmd$map = _elm_lang$core$Native_Platform.map;
var _elm_lang$core$Platform_Cmd$Cmd = {ctor: 'Cmd'};

var _elm_lang$core$Platform_Sub$batch = _elm_lang$core$Native_Platform.batch;
var _elm_lang$core$Platform_Sub$none = _elm_lang$core$Platform_Sub$batch(
	{ctor: '[]'});
var _elm_lang$core$Platform_Sub$map = _elm_lang$core$Native_Platform.map;
var _elm_lang$core$Platform_Sub$Sub = {ctor: 'Sub'};

var _elm_lang$core$Platform$hack = _elm_lang$core$Native_Scheduler.succeed;
var _elm_lang$core$Platform$sendToSelf = _elm_lang$core$Native_Platform.sendToSelf;
var _elm_lang$core$Platform$sendToApp = _elm_lang$core$Native_Platform.sendToApp;
var _elm_lang$core$Platform$programWithFlags = _elm_lang$core$Native_Platform.programWithFlags;
var _elm_lang$core$Platform$program = _elm_lang$core$Native_Platform.program;
var _elm_lang$core$Platform$Program = {ctor: 'Program'};
var _elm_lang$core$Platform$Task = {ctor: 'Task'};
var _elm_lang$core$Platform$ProcessId = {ctor: 'ProcessId'};
var _elm_lang$core$Platform$Router = {ctor: 'Router'};

var _Skinney$elm_array_exploration$Array_JsArray$appendN = _Skinney$elm_array_exploration$Native_JsArray.appendN;
var _Skinney$elm_array_exploration$Array_JsArray$slice = _Skinney$elm_array_exploration$Native_JsArray.slice;
var _Skinney$elm_array_exploration$Array_JsArray$indexedMap = _Skinney$elm_array_exploration$Native_JsArray.indexedMap;
var _Skinney$elm_array_exploration$Array_JsArray$map = _Skinney$elm_array_exploration$Native_JsArray.map;
var _Skinney$elm_array_exploration$Array_JsArray$foldr = _Skinney$elm_array_exploration$Native_JsArray.foldr;
var _Skinney$elm_array_exploration$Array_JsArray$foldl = _Skinney$elm_array_exploration$Native_JsArray.foldl;
var _Skinney$elm_array_exploration$Array_JsArray$push = _Skinney$elm_array_exploration$Native_JsArray.push;
var _Skinney$elm_array_exploration$Array_JsArray$unsafeSet = _Skinney$elm_array_exploration$Native_JsArray.unsafeSet;
var _Skinney$elm_array_exploration$Array_JsArray$unsafeGet = _Skinney$elm_array_exploration$Native_JsArray.unsafeGet;
var _Skinney$elm_array_exploration$Array_JsArray$initializeFromList = _Skinney$elm_array_exploration$Native_JsArray.initializeFromList;
var _Skinney$elm_array_exploration$Array_JsArray$initialize = _Skinney$elm_array_exploration$Native_JsArray.initialize;
var _Skinney$elm_array_exploration$Array_JsArray$length = _Skinney$elm_array_exploration$Native_JsArray.length;
var _Skinney$elm_array_exploration$Array_JsArray$singleton = _Skinney$elm_array_exploration$Native_JsArray.singleton;
var _Skinney$elm_array_exploration$Array_JsArray$empty = _Skinney$elm_array_exploration$Native_JsArray.empty;
var _Skinney$elm_array_exploration$Array_JsArray$JsArray = function (a) {
	return {ctor: 'JsArray', _0: a};
};

var _Skinney$elm_array_exploration$Array_Hamt$emptyBuilder = {
	tail: _Skinney$elm_array_exploration$Array_JsArray$empty,
	nodeList: {ctor: '[]'},
	nodeListSize: 0
};
var _Skinney$elm_array_exploration$Array_Hamt$translateIndex = F2(
	function (idx, _p0) {
		var _p1 = _p0;
		var _p2 = _p1._0;
		var posIndex = (_elm_lang$core$Native_Utils.cmp(idx, 0) < 0) ? (_p2 + idx) : idx;
		return (_elm_lang$core$Native_Utils.cmp(posIndex, 0) < 0) ? 0 : ((_elm_lang$core$Native_Utils.cmp(posIndex, _p2) > 0) ? _p2 : posIndex);
	});
var _Skinney$elm_array_exploration$Array_Hamt$foldl = F3(
	function (f, init, _p3) {
		var _p4 = _p3;
		var helper = F2(
			function (i, acc) {
				var _p5 = i;
				if (_p5.ctor === 'SubTree') {
					return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, helper, acc, _p5._0);
				} else {
					return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, f, acc, _p5._0);
				}
			});
		var acc = A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, helper, init, _p4._2);
		return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, f, acc, _p4._3);
	});
var _Skinney$elm_array_exploration$Array_Hamt$foldr = F3(
	function (f, init, _p6) {
		var _p7 = _p6;
		var acc = A3(_Skinney$elm_array_exploration$Array_JsArray$foldr, f, init, _p7._3);
		var helper = F2(
			function (i, acc) {
				var _p8 = i;
				if (_p8.ctor === 'SubTree') {
					return A3(_Skinney$elm_array_exploration$Array_JsArray$foldr, helper, acc, _p8._0);
				} else {
					return A3(_Skinney$elm_array_exploration$Array_JsArray$foldr, f, acc, _p8._0);
				}
			});
		return A3(_Skinney$elm_array_exploration$Array_JsArray$foldr, helper, acc, _p7._2);
	});
var _Skinney$elm_array_exploration$Array_Hamt$toIndexedList = function (_p9) {
	var _p10 = _p9;
	var helper = F2(
		function (n, _p11) {
			var _p12 = _p11;
			var _p13 = _p12._0;
			return {
				ctor: '_Tuple2',
				_0: _p13 - 1,
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: _p13, _1: n},
					_1: _p12._1
				}
			};
		});
	return _elm_lang$core$Tuple$second(
		A3(
			_Skinney$elm_array_exploration$Array_Hamt$foldr,
			helper,
			{
				ctor: '_Tuple2',
				_0: _p10._0 - 1,
				_1: {ctor: '[]'}
			},
			_p10));
};
var _Skinney$elm_array_exploration$Array_Hamt$toList = function (arr) {
	return A3(
		_Skinney$elm_array_exploration$Array_Hamt$foldr,
		F2(
			function (x, y) {
				return {ctor: '::', _0: x, _1: y};
			}),
		{ctor: '[]'},
		arr);
};
var _Skinney$elm_array_exploration$Array_Hamt$tailIndex = function (len) {
	return (len >>> 5) << 5;
};
var _Skinney$elm_array_exploration$Array_Hamt$length = function (_p14) {
	var _p15 = _p14;
	return _p15._0;
};
var _Skinney$elm_array_exploration$Array_Hamt$isEmpty = function (_p16) {
	var _p17 = _p16;
	return _elm_lang$core$Native_Utils.eq(_p17._0, 0);
};
var _Skinney$elm_array_exploration$Array_Hamt$branchFactor = 32;
var _Skinney$elm_array_exploration$Array_Hamt$shiftStep = _elm_lang$core$Basics$ceiling(
	A2(
		_elm_lang$core$Basics$logBase,
		2,
		_elm_lang$core$Basics$toFloat(_Skinney$elm_array_exploration$Array_Hamt$branchFactor)));
var _Skinney$elm_array_exploration$Array_Hamt$bitMask = -1 >>> (32 - _Skinney$elm_array_exploration$Array_Hamt$shiftStep);
var _Skinney$elm_array_exploration$Array_Hamt$getHelp = F3(
	function (shift, idx, tree) {
		getHelp:
		while (true) {
			var pos = _Skinney$elm_array_exploration$Array_Hamt$bitMask & (idx >>> shift);
			var _p18 = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, pos, tree);
			if (_p18.ctor === 'SubTree') {
				var _v10 = shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep,
					_v11 = idx,
					_v12 = _p18._0;
				shift = _v10;
				idx = _v11;
				tree = _v12;
				continue getHelp;
			} else {
				return A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, _Skinney$elm_array_exploration$Array_Hamt$bitMask & idx, _p18._0);
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$get = F2(
	function (idx, _p19) {
		var _p20 = _p19;
		var _p21 = _p20._0;
		return ((_elm_lang$core$Native_Utils.cmp(idx, 0) < 0) || (_elm_lang$core$Native_Utils.cmp(idx, _p21) > -1)) ? _elm_lang$core$Maybe$Nothing : ((_elm_lang$core$Native_Utils.cmp(
			idx,
			_Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p21)) > -1) ? _elm_lang$core$Maybe$Just(
			A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, _Skinney$elm_array_exploration$Array_Hamt$bitMask & idx, _p20._3)) : _elm_lang$core$Maybe$Just(
			A3(_Skinney$elm_array_exploration$Array_Hamt$getHelp, _p20._1, idx, _p20._2)));
	});
var _Skinney$elm_array_exploration$Array_Hamt$fetchNewTail = F4(
	function (shift, end, treeEnd, tree) {
		fetchNewTail:
		while (true) {
			var pos = _Skinney$elm_array_exploration$Array_Hamt$bitMask & (treeEnd >>> shift);
			var _p22 = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, pos, tree);
			if (_p22.ctor === 'SubTree') {
				var _v15 = shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep,
					_v16 = end,
					_v17 = treeEnd,
					_v18 = _p22._0;
				shift = _v15;
				end = _v16;
				treeEnd = _v17;
				tree = _v18;
				continue fetchNewTail;
			} else {
				return A3(_Skinney$elm_array_exploration$Array_JsArray$slice, 0, _Skinney$elm_array_exploration$Array_Hamt$bitMask & end, _p22._0);
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$hoistTree = F3(
	function (oldShift, newShift, tree) {
		hoistTree:
		while (true) {
			if ((_elm_lang$core$Native_Utils.cmp(oldShift, newShift) < 1) || _elm_lang$core$Native_Utils.eq(
				_Skinney$elm_array_exploration$Array_JsArray$length(tree),
				0)) {
				return tree;
			} else {
				var _p23 = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, 0, tree);
				if (_p23.ctor === 'SubTree') {
					var _v20 = oldShift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep,
						_v21 = newShift,
						_v22 = _p23._0;
					oldShift = _v20;
					newShift = _v21;
					tree = _v22;
					continue hoistTree;
				} else {
					return tree;
				}
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$builderFromArray = function (_p24) {
	var _p25 = _p24;
	var helper = F2(
		function (node, acc) {
			var _p26 = node;
			if (_p26.ctor === 'SubTree') {
				return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, helper, acc, _p26._0);
			} else {
				return {ctor: '::', _0: node, _1: acc};
			}
		});
	return {
		tail: _p25._3,
		nodeList: A3(
			_Skinney$elm_array_exploration$Array_JsArray$foldl,
			helper,
			{ctor: '[]'},
			_p25._2),
		nodeListSize: (_p25._0 / _Skinney$elm_array_exploration$Array_Hamt$branchFactor) | 0
	};
};
var _Skinney$elm_array_exploration$Array_Hamt$Builder = F3(
	function (a, b, c) {
		return {tail: a, nodeList: b, nodeListSize: c};
	});
var _Skinney$elm_array_exploration$Array_Hamt$Array = F4(
	function (a, b, c, d) {
		return {ctor: 'Array', _0: a, _1: b, _2: c, _3: d};
	});
var _Skinney$elm_array_exploration$Array_Hamt$empty = A4(_Skinney$elm_array_exploration$Array_Hamt$Array, 0, _Skinney$elm_array_exploration$Array_Hamt$shiftStep, _Skinney$elm_array_exploration$Array_JsArray$empty, _Skinney$elm_array_exploration$Array_JsArray$empty);
var _Skinney$elm_array_exploration$Array_Hamt$Leaf = function (a) {
	return {ctor: 'Leaf', _0: a};
};
var _Skinney$elm_array_exploration$Array_Hamt$appendHelpBuilder = F2(
	function (tail, builder) {
		var tailLen = _Skinney$elm_array_exploration$Array_JsArray$length(tail);
		var notAppended = (_Skinney$elm_array_exploration$Array_Hamt$branchFactor - _Skinney$elm_array_exploration$Array_JsArray$length(builder.tail)) - tailLen;
		var appended = A3(_Skinney$elm_array_exploration$Array_JsArray$appendN, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, builder.tail, tail);
		return (_elm_lang$core$Native_Utils.cmp(notAppended, 0) < 0) ? {
			tail: A3(_Skinney$elm_array_exploration$Array_JsArray$slice, notAppended, tailLen, tail),
			nodeList: {
				ctor: '::',
				_0: _Skinney$elm_array_exploration$Array_Hamt$Leaf(appended),
				_1: builder.nodeList
			},
			nodeListSize: builder.nodeListSize + 1
		} : (_elm_lang$core$Native_Utils.eq(notAppended, 0) ? {
			tail: _Skinney$elm_array_exploration$Array_JsArray$empty,
			nodeList: {
				ctor: '::',
				_0: _Skinney$elm_array_exploration$Array_Hamt$Leaf(appended),
				_1: builder.nodeList
			},
			nodeListSize: builder.nodeListSize + 1
		} : {tail: appended, nodeList: builder.nodeList, nodeListSize: builder.nodeListSize});
	});
var _Skinney$elm_array_exploration$Array_Hamt$SubTree = function (a) {
	return {ctor: 'SubTree', _0: a};
};
var _Skinney$elm_array_exploration$Array_Hamt$setHelp = F4(
	function (shift, idx, val, tree) {
		var pos = _Skinney$elm_array_exploration$Array_Hamt$bitMask & (idx >>> shift);
		var _p27 = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, pos, tree);
		if (_p27.ctor === 'SubTree') {
			var newSub = A4(_Skinney$elm_array_exploration$Array_Hamt$setHelp, shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep, idx, val, _p27._0);
			return A3(
				_Skinney$elm_array_exploration$Array_JsArray$unsafeSet,
				pos,
				_Skinney$elm_array_exploration$Array_Hamt$SubTree(newSub),
				tree);
		} else {
			var newLeaf = A3(_Skinney$elm_array_exploration$Array_JsArray$unsafeSet, _Skinney$elm_array_exploration$Array_Hamt$bitMask & idx, val, _p27._0);
			return A3(
				_Skinney$elm_array_exploration$Array_JsArray$unsafeSet,
				pos,
				_Skinney$elm_array_exploration$Array_Hamt$Leaf(newLeaf),
				tree);
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$set = F3(
	function (idx, val, _p28) {
		var _p29 = _p28;
		var _p33 = _p29._2;
		var _p32 = _p29._3;
		var _p31 = _p29._1;
		var _p30 = _p29._0;
		return ((_elm_lang$core$Native_Utils.cmp(idx, 0) < 0) || (_elm_lang$core$Native_Utils.cmp(idx, _p30) > -1)) ? _p29 : ((_elm_lang$core$Native_Utils.cmp(
			idx,
			_Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p30)) > -1) ? A4(
			_Skinney$elm_array_exploration$Array_Hamt$Array,
			_p30,
			_p31,
			_p33,
			A3(_Skinney$elm_array_exploration$Array_JsArray$unsafeSet, _Skinney$elm_array_exploration$Array_Hamt$bitMask & idx, val, _p32)) : A4(
			_Skinney$elm_array_exploration$Array_Hamt$Array,
			_p30,
			_p31,
			A4(_Skinney$elm_array_exploration$Array_Hamt$setHelp, _p31, idx, val, _p33),
			_p32));
	});
var _Skinney$elm_array_exploration$Array_Hamt$insertTailInTree = F4(
	function (shift, idx, tail, tree) {
		var pos = _Skinney$elm_array_exploration$Array_Hamt$bitMask & (idx >>> shift);
		if (_elm_lang$core$Native_Utils.cmp(
			pos,
			_Skinney$elm_array_exploration$Array_JsArray$length(tree)) > -1) {
			if (_elm_lang$core$Native_Utils.eq(shift, 5)) {
				return A2(
					_Skinney$elm_array_exploration$Array_JsArray$push,
					_Skinney$elm_array_exploration$Array_Hamt$Leaf(tail),
					tree);
			} else {
				var newSub = _Skinney$elm_array_exploration$Array_Hamt$SubTree(
					A4(_Skinney$elm_array_exploration$Array_Hamt$insertTailInTree, shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep, idx, tail, _Skinney$elm_array_exploration$Array_JsArray$empty));
				return A2(_Skinney$elm_array_exploration$Array_JsArray$push, newSub, tree);
			}
		} else {
			var val = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, pos, tree);
			var _p34 = val;
			if (_p34.ctor === 'SubTree') {
				var newSub = _Skinney$elm_array_exploration$Array_Hamt$SubTree(
					A4(_Skinney$elm_array_exploration$Array_Hamt$insertTailInTree, shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep, idx, tail, _p34._0));
				return A3(_Skinney$elm_array_exploration$Array_JsArray$unsafeSet, pos, newSub, tree);
			} else {
				var newSub = _Skinney$elm_array_exploration$Array_Hamt$SubTree(
					A4(
						_Skinney$elm_array_exploration$Array_Hamt$insertTailInTree,
						shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep,
						idx,
						tail,
						_Skinney$elm_array_exploration$Array_JsArray$singleton(val)));
				return A3(_Skinney$elm_array_exploration$Array_JsArray$unsafeSet, pos, newSub, tree);
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$unsafeReplaceTail = F2(
	function (newTail, _p35) {
		var _p36 = _p35;
		var _p39 = _p36._2;
		var _p38 = _p36._1;
		var _p37 = _p36._0;
		var newTailLen = _Skinney$elm_array_exploration$Array_JsArray$length(newTail);
		var originalTailLen = _Skinney$elm_array_exploration$Array_JsArray$length(_p36._3);
		var newArrayLen = _p37 + (newTailLen - originalTailLen);
		if (_elm_lang$core$Native_Utils.eq(newTailLen, _Skinney$elm_array_exploration$Array_Hamt$branchFactor)) {
			var overflow = _elm_lang$core$Native_Utils.cmp(newArrayLen >>> _Skinney$elm_array_exploration$Array_Hamt$shiftStep, 1 << _p38) > 0;
			if (overflow) {
				var newShift = _p38 + _Skinney$elm_array_exploration$Array_Hamt$shiftStep;
				var newTree = A4(
					_Skinney$elm_array_exploration$Array_Hamt$insertTailInTree,
					newShift,
					_p37,
					newTail,
					_Skinney$elm_array_exploration$Array_JsArray$singleton(
						_Skinney$elm_array_exploration$Array_Hamt$SubTree(_p39)));
				return A4(_Skinney$elm_array_exploration$Array_Hamt$Array, newArrayLen, newShift, newTree, _Skinney$elm_array_exploration$Array_JsArray$empty);
			} else {
				return A4(
					_Skinney$elm_array_exploration$Array_Hamt$Array,
					newArrayLen,
					_p38,
					A4(_Skinney$elm_array_exploration$Array_Hamt$insertTailInTree, _p38, _p37, newTail, _p39),
					_Skinney$elm_array_exploration$Array_JsArray$empty);
			}
		} else {
			return A4(_Skinney$elm_array_exploration$Array_Hamt$Array, newArrayLen, _p38, _p39, newTail);
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$push = F2(
	function (a, _p40) {
		var _p41 = _p40;
		return A2(
			_Skinney$elm_array_exploration$Array_Hamt$unsafeReplaceTail,
			A2(_Skinney$elm_array_exploration$Array_JsArray$push, a, _p41._3),
			_p41);
	});
var _Skinney$elm_array_exploration$Array_Hamt$appendHelpTree = F2(
	function (toAppend, _p42) {
		var _p43 = _p42;
		var _p44 = _p43._3;
		var itemsToAppend = _Skinney$elm_array_exploration$Array_JsArray$length(toAppend);
		var notAppended = (_Skinney$elm_array_exploration$Array_Hamt$branchFactor - _Skinney$elm_array_exploration$Array_JsArray$length(_p44)) - itemsToAppend;
		var appended = A3(_Skinney$elm_array_exploration$Array_JsArray$appendN, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, _p44, toAppend);
		var newArray = A2(_Skinney$elm_array_exploration$Array_Hamt$unsafeReplaceTail, appended, _p43);
		if (_elm_lang$core$Native_Utils.cmp(notAppended, 0) < 0) {
			var nextTail = A3(_Skinney$elm_array_exploration$Array_JsArray$slice, notAppended, itemsToAppend, toAppend);
			return A2(_Skinney$elm_array_exploration$Array_Hamt$unsafeReplaceTail, nextTail, newArray);
		} else {
			return newArray;
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$map = F2(
	function (f, _p45) {
		var _p46 = _p45;
		var helper = function (i) {
			var _p47 = i;
			if (_p47.ctor === 'SubTree') {
				return _Skinney$elm_array_exploration$Array_Hamt$SubTree(
					A2(_Skinney$elm_array_exploration$Array_JsArray$map, helper, _p47._0));
			} else {
				return _Skinney$elm_array_exploration$Array_Hamt$Leaf(
					A2(_Skinney$elm_array_exploration$Array_JsArray$map, f, _p47._0));
			}
		};
		return A4(
			_Skinney$elm_array_exploration$Array_Hamt$Array,
			_p46._0,
			_p46._1,
			A2(_Skinney$elm_array_exploration$Array_JsArray$map, helper, _p46._2),
			A2(_Skinney$elm_array_exploration$Array_JsArray$map, f, _p46._3));
	});
var _Skinney$elm_array_exploration$Array_Hamt$toString = function (array) {
	var content = A2(
		_elm_lang$core$String$join,
		',',
		_Skinney$elm_array_exploration$Array_Hamt$toList(
			A2(_Skinney$elm_array_exploration$Array_Hamt$map, _elm_lang$core$Basics$toString, array)));
	return A2(
		_elm_lang$core$Basics_ops['++'],
		'Array [',
		A2(_elm_lang$core$Basics_ops['++'], content, ']'));
};
var _Skinney$elm_array_exploration$Array_Hamt$sliceTree = F3(
	function (shift, endIdx, tree) {
		var lastPos = _Skinney$elm_array_exploration$Array_Hamt$bitMask & (endIdx >>> shift);
		var _p48 = A2(_Skinney$elm_array_exploration$Array_JsArray$unsafeGet, lastPos, tree);
		if (_p48.ctor === 'SubTree') {
			var newSub = A3(_Skinney$elm_array_exploration$Array_Hamt$sliceTree, shift - _Skinney$elm_array_exploration$Array_Hamt$shiftStep, endIdx, _p48._0);
			return _elm_lang$core$Native_Utils.eq(
				_Skinney$elm_array_exploration$Array_JsArray$length(newSub),
				0) ? A3(_Skinney$elm_array_exploration$Array_JsArray$slice, 0, lastPos, tree) : A3(
				_Skinney$elm_array_exploration$Array_JsArray$unsafeSet,
				lastPos,
				_Skinney$elm_array_exploration$Array_Hamt$SubTree(newSub),
				A3(_Skinney$elm_array_exploration$Array_JsArray$slice, 0, lastPos + 1, tree));
		} else {
			return A3(_Skinney$elm_array_exploration$Array_JsArray$slice, 0, lastPos, tree);
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$sliceRight = F2(
	function (end, _p49) {
		var _p50 = _p49;
		var _p53 = _p50._2;
		var _p52 = _p50._1;
		var _p51 = _p50._0;
		if (_elm_lang$core$Native_Utils.eq(end, _p51)) {
			return _p50;
		} else {
			if (_elm_lang$core$Native_Utils.cmp(
				end,
				_Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p51)) > -1) {
				return A4(
					_Skinney$elm_array_exploration$Array_Hamt$Array,
					end,
					_p52,
					_p53,
					A3(_Skinney$elm_array_exploration$Array_JsArray$slice, 0, _Skinney$elm_array_exploration$Array_Hamt$bitMask & end, _p50._3));
			} else {
				var endIdx = _Skinney$elm_array_exploration$Array_Hamt$tailIndex(end);
				var depth = _elm_lang$core$Basics$floor(
					A2(
						_elm_lang$core$Basics$logBase,
						_elm_lang$core$Basics$toFloat(_Skinney$elm_array_exploration$Array_Hamt$branchFactor),
						_elm_lang$core$Basics$toFloat(
							A2(_elm_lang$core$Basics$max, 1, endIdx - 1))));
				var newShift = A2(_elm_lang$core$Basics$max, 5, depth * _Skinney$elm_array_exploration$Array_Hamt$shiftStep);
				return A4(
					_Skinney$elm_array_exploration$Array_Hamt$Array,
					end,
					newShift,
					A3(
						_Skinney$elm_array_exploration$Array_Hamt$hoistTree,
						_p52,
						newShift,
						A3(_Skinney$elm_array_exploration$Array_Hamt$sliceTree, _p52, endIdx, _p53)),
					A4(_Skinney$elm_array_exploration$Array_Hamt$fetchNewTail, _p52, end, endIdx, _p53));
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$compressNodes = F2(
	function (nodes, acc) {
		compressNodes:
		while (true) {
			var _p54 = A2(_Skinney$elm_array_exploration$Array_JsArray$initializeFromList, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, nodes);
			var node = _p54._0;
			var remainingNodes = _p54._1;
			var newAcc = {
				ctor: '::',
				_0: _Skinney$elm_array_exploration$Array_Hamt$SubTree(node),
				_1: acc
			};
			var _p55 = remainingNodes;
			if (_p55.ctor === '[]') {
				return _elm_lang$core$List$reverse(newAcc);
			} else {
				var _v36 = remainingNodes,
					_v37 = newAcc;
				nodes = _v36;
				acc = _v37;
				continue compressNodes;
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$treeFromBuilder = F2(
	function (nodeList, nodeListSize) {
		treeFromBuilder:
		while (true) {
			var newNodeSize = _elm_lang$core$Basics$ceiling(
				_elm_lang$core$Basics$toFloat(nodeListSize) / _elm_lang$core$Basics$toFloat(_Skinney$elm_array_exploration$Array_Hamt$branchFactor));
			if (_elm_lang$core$Native_Utils.eq(newNodeSize, 1)) {
				return _elm_lang$core$Tuple$first(
					A2(_Skinney$elm_array_exploration$Array_JsArray$initializeFromList, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, nodeList));
			} else {
				var _v38 = A2(
					_Skinney$elm_array_exploration$Array_Hamt$compressNodes,
					nodeList,
					{ctor: '[]'}),
					_v39 = newNodeSize;
				nodeList = _v38;
				nodeListSize = _v39;
				continue treeFromBuilder;
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$builderToArray = F2(
	function (reverseNodeList, builder) {
		if (_elm_lang$core$Native_Utils.eq(builder.nodeListSize, 0)) {
			return A4(
				_Skinney$elm_array_exploration$Array_Hamt$Array,
				_Skinney$elm_array_exploration$Array_JsArray$length(builder.tail),
				_Skinney$elm_array_exploration$Array_Hamt$shiftStep,
				_Skinney$elm_array_exploration$Array_JsArray$empty,
				builder.tail);
		} else {
			var correctNodeList = reverseNodeList ? _elm_lang$core$List$reverse(builder.nodeList) : builder.nodeList;
			var tree = A2(_Skinney$elm_array_exploration$Array_Hamt$treeFromBuilder, correctNodeList, builder.nodeListSize);
			var treeLen = builder.nodeListSize * _Skinney$elm_array_exploration$Array_Hamt$branchFactor;
			var depth = _elm_lang$core$Basics$floor(
				A2(
					_elm_lang$core$Basics$logBase,
					_elm_lang$core$Basics$toFloat(_Skinney$elm_array_exploration$Array_Hamt$branchFactor),
					_elm_lang$core$Basics$toFloat(treeLen - 1)));
			return A4(
				_Skinney$elm_array_exploration$Array_Hamt$Array,
				_Skinney$elm_array_exploration$Array_JsArray$length(builder.tail) + treeLen,
				A2(_elm_lang$core$Basics$max, 5, depth * _Skinney$elm_array_exploration$Array_Hamt$shiftStep),
				tree,
				builder.tail);
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$initializeHelp = F5(
	function (fn, fromIndex, length, nodeList, tail) {
		initializeHelp:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(fromIndex, 0) < 0) {
				return A2(
					_Skinney$elm_array_exploration$Array_Hamt$builderToArray,
					false,
					{tail: tail, nodeList: nodeList, nodeListSize: (length / _Skinney$elm_array_exploration$Array_Hamt$branchFactor) | 0});
			} else {
				var leaf = _Skinney$elm_array_exploration$Array_Hamt$Leaf(
					A3(_Skinney$elm_array_exploration$Array_JsArray$initialize, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, fromIndex, fn));
				var _v40 = fn,
					_v41 = fromIndex - _Skinney$elm_array_exploration$Array_Hamt$branchFactor,
					_v42 = length,
					_v43 = {ctor: '::', _0: leaf, _1: nodeList},
					_v44 = tail;
				fn = _v40;
				fromIndex = _v41;
				length = _v42;
				nodeList = _v43;
				tail = _v44;
				continue initializeHelp;
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$initialize = F2(
	function (length, fn) {
		if (_elm_lang$core$Native_Utils.cmp(length, 0) < 1) {
			return _Skinney$elm_array_exploration$Array_Hamt$empty;
		} else {
			var tailLen = A2(_elm_lang$core$Basics$rem, length, _Skinney$elm_array_exploration$Array_Hamt$branchFactor);
			var tail = A3(_Skinney$elm_array_exploration$Array_JsArray$initialize, tailLen, length - tailLen, fn);
			var initialFromIndex = (length - tailLen) - _Skinney$elm_array_exploration$Array_Hamt$branchFactor;
			return A5(
				_Skinney$elm_array_exploration$Array_Hamt$initializeHelp,
				fn,
				initialFromIndex,
				length,
				{ctor: '[]'},
				tail);
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$repeat = F2(
	function (n, e) {
		return A2(
			_Skinney$elm_array_exploration$Array_Hamt$initialize,
			n,
			function (_p56) {
				return e;
			});
	});
var _Skinney$elm_array_exploration$Array_Hamt$fromListHelp = F3(
	function (list, nodeList, nodeListSize) {
		fromListHelp:
		while (true) {
			var _p57 = A2(_Skinney$elm_array_exploration$Array_JsArray$initializeFromList, _Skinney$elm_array_exploration$Array_Hamt$branchFactor, list);
			var jsArray = _p57._0;
			var remainingItems = _p57._1;
			if (_elm_lang$core$Native_Utils.cmp(
				_Skinney$elm_array_exploration$Array_JsArray$length(jsArray),
				_Skinney$elm_array_exploration$Array_Hamt$branchFactor) < 0) {
				return A2(
					_Skinney$elm_array_exploration$Array_Hamt$builderToArray,
					true,
					{tail: jsArray, nodeList: nodeList, nodeListSize: nodeListSize});
			} else {
				var _v45 = remainingItems,
					_v46 = {
					ctor: '::',
					_0: _Skinney$elm_array_exploration$Array_Hamt$Leaf(jsArray),
					_1: nodeList
				},
					_v47 = nodeListSize + 1;
				list = _v45;
				nodeList = _v46;
				nodeListSize = _v47;
				continue fromListHelp;
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$fromList = function (ls) {
	var _p58 = ls;
	if (_p58.ctor === '[]') {
		return _Skinney$elm_array_exploration$Array_Hamt$empty;
	} else {
		return A3(
			_Skinney$elm_array_exploration$Array_Hamt$fromListHelp,
			ls,
			{ctor: '[]'},
			0);
	}
};
var _Skinney$elm_array_exploration$Array_Hamt$filter = F2(
	function (f, arr) {
		var helper = F2(
			function (n, acc) {
				return f(n) ? {ctor: '::', _0: n, _1: acc} : acc;
			});
		return _Skinney$elm_array_exploration$Array_Hamt$fromList(
			A3(
				_Skinney$elm_array_exploration$Array_Hamt$foldr,
				helper,
				{ctor: '[]'},
				arr));
	});
var _Skinney$elm_array_exploration$Array_Hamt$indexedMap = F2(
	function (f, _p59) {
		var _p60 = _p59;
		var initialBuilder = {
			tail: A3(
				_Skinney$elm_array_exploration$Array_JsArray$indexedMap,
				f,
				_Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p60._0),
				_p60._3),
			nodeList: {ctor: '[]'},
			nodeListSize: 0
		};
		var helper = F2(
			function (node, builder) {
				var _p61 = node;
				if (_p61.ctor === 'SubTree') {
					return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, helper, builder, _p61._0);
				} else {
					var offset = builder.nodeListSize * _Skinney$elm_array_exploration$Array_Hamt$branchFactor;
					var mappedLeaf = _Skinney$elm_array_exploration$Array_Hamt$Leaf(
						A3(_Skinney$elm_array_exploration$Array_JsArray$indexedMap, f, offset, _p61._0));
					return {
						tail: builder.tail,
						nodeList: {ctor: '::', _0: mappedLeaf, _1: builder.nodeList},
						nodeListSize: builder.nodeListSize + 1
					};
				}
			});
		return A2(
			_Skinney$elm_array_exploration$Array_Hamt$builderToArray,
			true,
			A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, helper, initialBuilder, _p60._2));
	});
var _Skinney$elm_array_exploration$Array_Hamt$append = F2(
	function (_p63, _p62) {
		var _p64 = _p63;
		var _p70 = _p64;
		var _p65 = _p62;
		var _p69 = _p65._2;
		var _p68 = _p65._3;
		if (_elm_lang$core$Native_Utils.cmp(_p65._0, _Skinney$elm_array_exploration$Array_Hamt$branchFactor * 4) < 1) {
			var foldHelper = F2(
				function (node, arr) {
					var _p66 = node;
					if (_p66.ctor === 'SubTree') {
						return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, foldHelper, arr, _p66._0);
					} else {
						return A2(_Skinney$elm_array_exploration$Array_Hamt$appendHelpTree, _p66._0, arr);
					}
				});
			return A2(
				_Skinney$elm_array_exploration$Array_Hamt$appendHelpTree,
				_p68,
				A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, foldHelper, _p70, _p69));
		} else {
			var foldHelper = F2(
				function (node, builder) {
					var _p67 = node;
					if (_p67.ctor === 'SubTree') {
						return A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, foldHelper, builder, _p67._0);
					} else {
						return A2(_Skinney$elm_array_exploration$Array_Hamt$appendHelpBuilder, _p67._0, builder);
					}
				});
			var builder = _Skinney$elm_array_exploration$Array_Hamt$builderFromArray(_p70);
			return A2(
				_Skinney$elm_array_exploration$Array_Hamt$builderToArray,
				true,
				A2(
					_Skinney$elm_array_exploration$Array_Hamt$appendHelpBuilder,
					_p68,
					A3(_Skinney$elm_array_exploration$Array_JsArray$foldl, foldHelper, builder, _p69)));
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$sliceLeft = F2(
	function (from, _p71) {
		var _p72 = _p71;
		var _p77 = _p72._3;
		var _p76 = _p72._0;
		if (_elm_lang$core$Native_Utils.eq(from, 0)) {
			return _p72;
		} else {
			if (_elm_lang$core$Native_Utils.cmp(
				from,
				_Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p76)) > -1) {
				return A4(
					_Skinney$elm_array_exploration$Array_Hamt$Array,
					_p76 - from,
					_Skinney$elm_array_exploration$Array_Hamt$shiftStep,
					_Skinney$elm_array_exploration$Array_JsArray$empty,
					A3(
						_Skinney$elm_array_exploration$Array_JsArray$slice,
						from - _Skinney$elm_array_exploration$Array_Hamt$tailIndex(_p76),
						_Skinney$elm_array_exploration$Array_JsArray$length(_p77),
						_p77));
			} else {
				var skipNodes = (from / _Skinney$elm_array_exploration$Array_Hamt$branchFactor) | 0;
				var helper = F2(
					function (node, acc) {
						var _p73 = node;
						if (_p73.ctor === 'SubTree') {
							return A3(_Skinney$elm_array_exploration$Array_JsArray$foldr, helper, acc, _p73._0);
						} else {
							return {ctor: '::', _0: _p73._0, _1: acc};
						}
					});
				var leafNodes = A3(
					_Skinney$elm_array_exploration$Array_JsArray$foldr,
					helper,
					{
						ctor: '::',
						_0: _p77,
						_1: {ctor: '[]'}
					},
					_p72._2);
				var nodesToInsert = A2(_elm_lang$core$List$drop, skipNodes, leafNodes);
				var _p74 = nodesToInsert;
				if (_p74.ctor === '[]') {
					return _Skinney$elm_array_exploration$Array_Hamt$empty;
				} else {
					var _p75 = _p74._0;
					var firstSlice = from - (skipNodes * _Skinney$elm_array_exploration$Array_Hamt$branchFactor);
					var initialBuilder = {
						tail: A3(
							_Skinney$elm_array_exploration$Array_JsArray$slice,
							firstSlice,
							_Skinney$elm_array_exploration$Array_JsArray$length(_p75),
							_p75),
						nodeList: {ctor: '[]'},
						nodeListSize: 0
					};
					return A2(
						_Skinney$elm_array_exploration$Array_Hamt$builderToArray,
						true,
						A3(_elm_lang$core$List$foldl, _Skinney$elm_array_exploration$Array_Hamt$appendHelpBuilder, initialBuilder, _p74._1));
				}
			}
		}
	});
var _Skinney$elm_array_exploration$Array_Hamt$slice = F3(
	function (from, to, arr) {
		var correctTo = A2(_Skinney$elm_array_exploration$Array_Hamt$translateIndex, to, arr);
		var correctFrom = A2(_Skinney$elm_array_exploration$Array_Hamt$translateIndex, from, arr);
		return (_elm_lang$core$Native_Utils.cmp(correctFrom, correctTo) > 0) ? _Skinney$elm_array_exploration$Array_Hamt$empty : A2(
			_Skinney$elm_array_exploration$Array_Hamt$sliceLeft,
			correctFrom,
			A2(_Skinney$elm_array_exploration$Array_Hamt$sliceRight, correctTo, arr));
	});

var _elm_community$basics_extra$Basics_Extra$turnsPerRadian = 1 / _elm_lang$core$Basics$turns(1);
var _elm_community$basics_extra$Basics_Extra$inTurns = function (angle) {
	return angle * _elm_community$basics_extra$Basics_Extra$turnsPerRadian;
};
var _elm_community$basics_extra$Basics_Extra$inRadians = _elm_lang$core$Basics$identity;
var _elm_community$basics_extra$Basics_Extra$degreesPerRadian = 1 / _elm_lang$core$Basics$degrees(1);
var _elm_community$basics_extra$Basics_Extra$inDegrees = function (angle) {
	return angle * _elm_community$basics_extra$Basics_Extra$degreesPerRadian;
};
var _elm_community$basics_extra$Basics_Extra$fmod = F2(
	function (x, m) {
		return x - (m * _elm_lang$core$Basics$toFloat(
			_elm_lang$core$Basics$floor(x / m)));
	});
var _elm_community$basics_extra$Basics_Extra$maxSafeInteger = Math.pow(2, 53) - 1;
var _elm_community$basics_extra$Basics_Extra$minSafeInteger = 0 - _elm_community$basics_extra$Basics_Extra$maxSafeInteger;
var _elm_community$basics_extra$Basics_Extra$isSafeInteger = function (number) {
	return (_elm_lang$core$Native_Utils.cmp(_elm_community$basics_extra$Basics_Extra$minSafeInteger, number) < 1) && (_elm_lang$core$Native_Utils.cmp(_elm_community$basics_extra$Basics_Extra$maxSafeInteger, number) > -1);
};
var _elm_community$basics_extra$Basics_Extra$swap = function (_p0) {
	var _p1 = _p0;
	return {ctor: '_Tuple2', _0: _p1._1, _1: _p1._0};
};
var _elm_community$basics_extra$Basics_Extra_ops = _elm_community$basics_extra$Basics_Extra_ops || {};
_elm_community$basics_extra$Basics_Extra_ops['=>'] = F2(
	function (v0, v1) {
		return {ctor: '_Tuple2', _0: v0, _1: v1};
	});

var _elm_lang$core$Dict$foldr = F3(
	function (f, acc, t) {
		foldr:
		while (true) {
			var _p0 = t;
			if (_p0.ctor === 'RBEmpty_elm_builtin') {
				return acc;
			} else {
				var _v1 = f,
					_v2 = A3(
					f,
					_p0._1,
					_p0._2,
					A3(_elm_lang$core$Dict$foldr, f, acc, _p0._4)),
					_v3 = _p0._3;
				f = _v1;
				acc = _v2;
				t = _v3;
				continue foldr;
			}
		}
	});
var _elm_lang$core$Dict$keys = function (dict) {
	return A3(
		_elm_lang$core$Dict$foldr,
		F3(
			function (key, value, keyList) {
				return {ctor: '::', _0: key, _1: keyList};
			}),
		{ctor: '[]'},
		dict);
};
var _elm_lang$core$Dict$values = function (dict) {
	return A3(
		_elm_lang$core$Dict$foldr,
		F3(
			function (key, value, valueList) {
				return {ctor: '::', _0: value, _1: valueList};
			}),
		{ctor: '[]'},
		dict);
};
var _elm_lang$core$Dict$toList = function (dict) {
	return A3(
		_elm_lang$core$Dict$foldr,
		F3(
			function (key, value, list) {
				return {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: key, _1: value},
					_1: list
				};
			}),
		{ctor: '[]'},
		dict);
};
var _elm_lang$core$Dict$foldl = F3(
	function (f, acc, dict) {
		foldl:
		while (true) {
			var _p1 = dict;
			if (_p1.ctor === 'RBEmpty_elm_builtin') {
				return acc;
			} else {
				var _v5 = f,
					_v6 = A3(
					f,
					_p1._1,
					_p1._2,
					A3(_elm_lang$core$Dict$foldl, f, acc, _p1._3)),
					_v7 = _p1._4;
				f = _v5;
				acc = _v6;
				dict = _v7;
				continue foldl;
			}
		}
	});
var _elm_lang$core$Dict$merge = F6(
	function (leftStep, bothStep, rightStep, leftDict, rightDict, initialResult) {
		var stepState = F3(
			function (rKey, rValue, _p2) {
				stepState:
				while (true) {
					var _p3 = _p2;
					var _p9 = _p3._1;
					var _p8 = _p3._0;
					var _p4 = _p8;
					if (_p4.ctor === '[]') {
						return {
							ctor: '_Tuple2',
							_0: _p8,
							_1: A3(rightStep, rKey, rValue, _p9)
						};
					} else {
						var _p7 = _p4._1;
						var _p6 = _p4._0._1;
						var _p5 = _p4._0._0;
						if (_elm_lang$core$Native_Utils.cmp(_p5, rKey) < 0) {
							var _v10 = rKey,
								_v11 = rValue,
								_v12 = {
								ctor: '_Tuple2',
								_0: _p7,
								_1: A3(leftStep, _p5, _p6, _p9)
							};
							rKey = _v10;
							rValue = _v11;
							_p2 = _v12;
							continue stepState;
						} else {
							if (_elm_lang$core$Native_Utils.cmp(_p5, rKey) > 0) {
								return {
									ctor: '_Tuple2',
									_0: _p8,
									_1: A3(rightStep, rKey, rValue, _p9)
								};
							} else {
								return {
									ctor: '_Tuple2',
									_0: _p7,
									_1: A4(bothStep, _p5, _p6, rValue, _p9)
								};
							}
						}
					}
				}
			});
		var _p10 = A3(
			_elm_lang$core$Dict$foldl,
			stepState,
			{
				ctor: '_Tuple2',
				_0: _elm_lang$core$Dict$toList(leftDict),
				_1: initialResult
			},
			rightDict);
		var leftovers = _p10._0;
		var intermediateResult = _p10._1;
		return A3(
			_elm_lang$core$List$foldl,
			F2(
				function (_p11, result) {
					var _p12 = _p11;
					return A3(leftStep, _p12._0, _p12._1, result);
				}),
			intermediateResult,
			leftovers);
	});
var _elm_lang$core$Dict$reportRemBug = F4(
	function (msg, c, lgot, rgot) {
		return _elm_lang$core$Native_Debug.crash(
			_elm_lang$core$String$concat(
				{
					ctor: '::',
					_0: 'Internal red-black tree invariant violated, expected ',
					_1: {
						ctor: '::',
						_0: msg,
						_1: {
							ctor: '::',
							_0: ' and got ',
							_1: {
								ctor: '::',
								_0: _elm_lang$core$Basics$toString(c),
								_1: {
									ctor: '::',
									_0: '/',
									_1: {
										ctor: '::',
										_0: lgot,
										_1: {
											ctor: '::',
											_0: '/',
											_1: {
												ctor: '::',
												_0: rgot,
												_1: {
													ctor: '::',
													_0: '\nPlease report this bug to <https://github.com/elm-lang/core/issues>',
													_1: {ctor: '[]'}
												}
											}
										}
									}
								}
							}
						}
					}
				}));
	});
var _elm_lang$core$Dict$isBBlack = function (dict) {
	var _p13 = dict;
	_v14_2:
	do {
		if (_p13.ctor === 'RBNode_elm_builtin') {
			if (_p13._0.ctor === 'BBlack') {
				return true;
			} else {
				break _v14_2;
			}
		} else {
			if (_p13._0.ctor === 'LBBlack') {
				return true;
			} else {
				break _v14_2;
			}
		}
	} while(false);
	return false;
};
var _elm_lang$core$Dict$sizeHelp = F2(
	function (n, dict) {
		sizeHelp:
		while (true) {
			var _p14 = dict;
			if (_p14.ctor === 'RBEmpty_elm_builtin') {
				return n;
			} else {
				var _v16 = A2(_elm_lang$core$Dict$sizeHelp, n + 1, _p14._4),
					_v17 = _p14._3;
				n = _v16;
				dict = _v17;
				continue sizeHelp;
			}
		}
	});
var _elm_lang$core$Dict$size = function (dict) {
	return A2(_elm_lang$core$Dict$sizeHelp, 0, dict);
};
var _elm_lang$core$Dict$get = F2(
	function (targetKey, dict) {
		get:
		while (true) {
			var _p15 = dict;
			if (_p15.ctor === 'RBEmpty_elm_builtin') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				var _p16 = A2(_elm_lang$core$Basics$compare, targetKey, _p15._1);
				switch (_p16.ctor) {
					case 'LT':
						var _v20 = targetKey,
							_v21 = _p15._3;
						targetKey = _v20;
						dict = _v21;
						continue get;
					case 'EQ':
						return _elm_lang$core$Maybe$Just(_p15._2);
					default:
						var _v22 = targetKey,
							_v23 = _p15._4;
						targetKey = _v22;
						dict = _v23;
						continue get;
				}
			}
		}
	});
var _elm_lang$core$Dict$member = F2(
	function (key, dict) {
		var _p17 = A2(_elm_lang$core$Dict$get, key, dict);
		if (_p17.ctor === 'Just') {
			return true;
		} else {
			return false;
		}
	});
var _elm_lang$core$Dict$maxWithDefault = F3(
	function (k, v, r) {
		maxWithDefault:
		while (true) {
			var _p18 = r;
			if (_p18.ctor === 'RBEmpty_elm_builtin') {
				return {ctor: '_Tuple2', _0: k, _1: v};
			} else {
				var _v26 = _p18._1,
					_v27 = _p18._2,
					_v28 = _p18._4;
				k = _v26;
				v = _v27;
				r = _v28;
				continue maxWithDefault;
			}
		}
	});
var _elm_lang$core$Dict$NBlack = {ctor: 'NBlack'};
var _elm_lang$core$Dict$BBlack = {ctor: 'BBlack'};
var _elm_lang$core$Dict$Black = {ctor: 'Black'};
var _elm_lang$core$Dict$blackish = function (t) {
	var _p19 = t;
	if (_p19.ctor === 'RBNode_elm_builtin') {
		var _p20 = _p19._0;
		return _elm_lang$core$Native_Utils.eq(_p20, _elm_lang$core$Dict$Black) || _elm_lang$core$Native_Utils.eq(_p20, _elm_lang$core$Dict$BBlack);
	} else {
		return true;
	}
};
var _elm_lang$core$Dict$Red = {ctor: 'Red'};
var _elm_lang$core$Dict$moreBlack = function (color) {
	var _p21 = color;
	switch (_p21.ctor) {
		case 'Black':
			return _elm_lang$core$Dict$BBlack;
		case 'Red':
			return _elm_lang$core$Dict$Black;
		case 'NBlack':
			return _elm_lang$core$Dict$Red;
		default:
			return _elm_lang$core$Native_Debug.crash('Can\'t make a double black node more black!');
	}
};
var _elm_lang$core$Dict$lessBlack = function (color) {
	var _p22 = color;
	switch (_p22.ctor) {
		case 'BBlack':
			return _elm_lang$core$Dict$Black;
		case 'Black':
			return _elm_lang$core$Dict$Red;
		case 'Red':
			return _elm_lang$core$Dict$NBlack;
		default:
			return _elm_lang$core$Native_Debug.crash('Can\'t make a negative black node less black!');
	}
};
var _elm_lang$core$Dict$LBBlack = {ctor: 'LBBlack'};
var _elm_lang$core$Dict$LBlack = {ctor: 'LBlack'};
var _elm_lang$core$Dict$RBEmpty_elm_builtin = function (a) {
	return {ctor: 'RBEmpty_elm_builtin', _0: a};
};
var _elm_lang$core$Dict$empty = _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBlack);
var _elm_lang$core$Dict$isEmpty = function (dict) {
	return _elm_lang$core$Native_Utils.eq(dict, _elm_lang$core$Dict$empty);
};
var _elm_lang$core$Dict$RBNode_elm_builtin = F5(
	function (a, b, c, d, e) {
		return {ctor: 'RBNode_elm_builtin', _0: a, _1: b, _2: c, _3: d, _4: e};
	});
var _elm_lang$core$Dict$ensureBlackRoot = function (dict) {
	var _p23 = dict;
	if ((_p23.ctor === 'RBNode_elm_builtin') && (_p23._0.ctor === 'Red')) {
		return A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p23._1, _p23._2, _p23._3, _p23._4);
	} else {
		return dict;
	}
};
var _elm_lang$core$Dict$lessBlackTree = function (dict) {
	var _p24 = dict;
	if (_p24.ctor === 'RBNode_elm_builtin') {
		return A5(
			_elm_lang$core$Dict$RBNode_elm_builtin,
			_elm_lang$core$Dict$lessBlack(_p24._0),
			_p24._1,
			_p24._2,
			_p24._3,
			_p24._4);
	} else {
		return _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBlack);
	}
};
var _elm_lang$core$Dict$balancedTree = function (col) {
	return function (xk) {
		return function (xv) {
			return function (yk) {
				return function (yv) {
					return function (zk) {
						return function (zv) {
							return function (a) {
								return function (b) {
									return function (c) {
										return function (d) {
											return A5(
												_elm_lang$core$Dict$RBNode_elm_builtin,
												_elm_lang$core$Dict$lessBlack(col),
												yk,
												yv,
												A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, xk, xv, a, b),
												A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, zk, zv, c, d));
										};
									};
								};
							};
						};
					};
				};
			};
		};
	};
};
var _elm_lang$core$Dict$blacken = function (t) {
	var _p25 = t;
	if (_p25.ctor === 'RBEmpty_elm_builtin') {
		return _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBlack);
	} else {
		return A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p25._1, _p25._2, _p25._3, _p25._4);
	}
};
var _elm_lang$core$Dict$redden = function (t) {
	var _p26 = t;
	if (_p26.ctor === 'RBEmpty_elm_builtin') {
		return _elm_lang$core$Native_Debug.crash('can\'t make a Leaf red');
	} else {
		return A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Red, _p26._1, _p26._2, _p26._3, _p26._4);
	}
};
var _elm_lang$core$Dict$balanceHelp = function (tree) {
	var _p27 = tree;
	_v36_6:
	do {
		_v36_5:
		do {
			_v36_4:
			do {
				_v36_3:
				do {
					_v36_2:
					do {
						_v36_1:
						do {
							_v36_0:
							do {
								if (_p27.ctor === 'RBNode_elm_builtin') {
									if (_p27._3.ctor === 'RBNode_elm_builtin') {
										if (_p27._4.ctor === 'RBNode_elm_builtin') {
											switch (_p27._3._0.ctor) {
												case 'Red':
													switch (_p27._4._0.ctor) {
														case 'Red':
															if ((_p27._3._3.ctor === 'RBNode_elm_builtin') && (_p27._3._3._0.ctor === 'Red')) {
																break _v36_0;
															} else {
																if ((_p27._3._4.ctor === 'RBNode_elm_builtin') && (_p27._3._4._0.ctor === 'Red')) {
																	break _v36_1;
																} else {
																	if ((_p27._4._3.ctor === 'RBNode_elm_builtin') && (_p27._4._3._0.ctor === 'Red')) {
																		break _v36_2;
																	} else {
																		if ((_p27._4._4.ctor === 'RBNode_elm_builtin') && (_p27._4._4._0.ctor === 'Red')) {
																			break _v36_3;
																		} else {
																			break _v36_6;
																		}
																	}
																}
															}
														case 'NBlack':
															if ((_p27._3._3.ctor === 'RBNode_elm_builtin') && (_p27._3._3._0.ctor === 'Red')) {
																break _v36_0;
															} else {
																if ((_p27._3._4.ctor === 'RBNode_elm_builtin') && (_p27._3._4._0.ctor === 'Red')) {
																	break _v36_1;
																} else {
																	if (((((_p27._0.ctor === 'BBlack') && (_p27._4._3.ctor === 'RBNode_elm_builtin')) && (_p27._4._3._0.ctor === 'Black')) && (_p27._4._4.ctor === 'RBNode_elm_builtin')) && (_p27._4._4._0.ctor === 'Black')) {
																		break _v36_4;
																	} else {
																		break _v36_6;
																	}
																}
															}
														default:
															if ((_p27._3._3.ctor === 'RBNode_elm_builtin') && (_p27._3._3._0.ctor === 'Red')) {
																break _v36_0;
															} else {
																if ((_p27._3._4.ctor === 'RBNode_elm_builtin') && (_p27._3._4._0.ctor === 'Red')) {
																	break _v36_1;
																} else {
																	break _v36_6;
																}
															}
													}
												case 'NBlack':
													switch (_p27._4._0.ctor) {
														case 'Red':
															if ((_p27._4._3.ctor === 'RBNode_elm_builtin') && (_p27._4._3._0.ctor === 'Red')) {
																break _v36_2;
															} else {
																if ((_p27._4._4.ctor === 'RBNode_elm_builtin') && (_p27._4._4._0.ctor === 'Red')) {
																	break _v36_3;
																} else {
																	if (((((_p27._0.ctor === 'BBlack') && (_p27._3._3.ctor === 'RBNode_elm_builtin')) && (_p27._3._3._0.ctor === 'Black')) && (_p27._3._4.ctor === 'RBNode_elm_builtin')) && (_p27._3._4._0.ctor === 'Black')) {
																		break _v36_5;
																	} else {
																		break _v36_6;
																	}
																}
															}
														case 'NBlack':
															if (_p27._0.ctor === 'BBlack') {
																if ((((_p27._4._3.ctor === 'RBNode_elm_builtin') && (_p27._4._3._0.ctor === 'Black')) && (_p27._4._4.ctor === 'RBNode_elm_builtin')) && (_p27._4._4._0.ctor === 'Black')) {
																	break _v36_4;
																} else {
																	if ((((_p27._3._3.ctor === 'RBNode_elm_builtin') && (_p27._3._3._0.ctor === 'Black')) && (_p27._3._4.ctor === 'RBNode_elm_builtin')) && (_p27._3._4._0.ctor === 'Black')) {
																		break _v36_5;
																	} else {
																		break _v36_6;
																	}
																}
															} else {
																break _v36_6;
															}
														default:
															if (((((_p27._0.ctor === 'BBlack') && (_p27._3._3.ctor === 'RBNode_elm_builtin')) && (_p27._3._3._0.ctor === 'Black')) && (_p27._3._4.ctor === 'RBNode_elm_builtin')) && (_p27._3._4._0.ctor === 'Black')) {
																break _v36_5;
															} else {
																break _v36_6;
															}
													}
												default:
													switch (_p27._4._0.ctor) {
														case 'Red':
															if ((_p27._4._3.ctor === 'RBNode_elm_builtin') && (_p27._4._3._0.ctor === 'Red')) {
																break _v36_2;
															} else {
																if ((_p27._4._4.ctor === 'RBNode_elm_builtin') && (_p27._4._4._0.ctor === 'Red')) {
																	break _v36_3;
																} else {
																	break _v36_6;
																}
															}
														case 'NBlack':
															if (((((_p27._0.ctor === 'BBlack') && (_p27._4._3.ctor === 'RBNode_elm_builtin')) && (_p27._4._3._0.ctor === 'Black')) && (_p27._4._4.ctor === 'RBNode_elm_builtin')) && (_p27._4._4._0.ctor === 'Black')) {
																break _v36_4;
															} else {
																break _v36_6;
															}
														default:
															break _v36_6;
													}
											}
										} else {
											switch (_p27._3._0.ctor) {
												case 'Red':
													if ((_p27._3._3.ctor === 'RBNode_elm_builtin') && (_p27._3._3._0.ctor === 'Red')) {
														break _v36_0;
													} else {
														if ((_p27._3._4.ctor === 'RBNode_elm_builtin') && (_p27._3._4._0.ctor === 'Red')) {
															break _v36_1;
														} else {
															break _v36_6;
														}
													}
												case 'NBlack':
													if (((((_p27._0.ctor === 'BBlack') && (_p27._3._3.ctor === 'RBNode_elm_builtin')) && (_p27._3._3._0.ctor === 'Black')) && (_p27._3._4.ctor === 'RBNode_elm_builtin')) && (_p27._3._4._0.ctor === 'Black')) {
														break _v36_5;
													} else {
														break _v36_6;
													}
												default:
													break _v36_6;
											}
										}
									} else {
										if (_p27._4.ctor === 'RBNode_elm_builtin') {
											switch (_p27._4._0.ctor) {
												case 'Red':
													if ((_p27._4._3.ctor === 'RBNode_elm_builtin') && (_p27._4._3._0.ctor === 'Red')) {
														break _v36_2;
													} else {
														if ((_p27._4._4.ctor === 'RBNode_elm_builtin') && (_p27._4._4._0.ctor === 'Red')) {
															break _v36_3;
														} else {
															break _v36_6;
														}
													}
												case 'NBlack':
													if (((((_p27._0.ctor === 'BBlack') && (_p27._4._3.ctor === 'RBNode_elm_builtin')) && (_p27._4._3._0.ctor === 'Black')) && (_p27._4._4.ctor === 'RBNode_elm_builtin')) && (_p27._4._4._0.ctor === 'Black')) {
														break _v36_4;
													} else {
														break _v36_6;
													}
												default:
													break _v36_6;
											}
										} else {
											break _v36_6;
										}
									}
								} else {
									break _v36_6;
								}
							} while(false);
							return _elm_lang$core$Dict$balancedTree(_p27._0)(_p27._3._3._1)(_p27._3._3._2)(_p27._3._1)(_p27._3._2)(_p27._1)(_p27._2)(_p27._3._3._3)(_p27._3._3._4)(_p27._3._4)(_p27._4);
						} while(false);
						return _elm_lang$core$Dict$balancedTree(_p27._0)(_p27._3._1)(_p27._3._2)(_p27._3._4._1)(_p27._3._4._2)(_p27._1)(_p27._2)(_p27._3._3)(_p27._3._4._3)(_p27._3._4._4)(_p27._4);
					} while(false);
					return _elm_lang$core$Dict$balancedTree(_p27._0)(_p27._1)(_p27._2)(_p27._4._3._1)(_p27._4._3._2)(_p27._4._1)(_p27._4._2)(_p27._3)(_p27._4._3._3)(_p27._4._3._4)(_p27._4._4);
				} while(false);
				return _elm_lang$core$Dict$balancedTree(_p27._0)(_p27._1)(_p27._2)(_p27._4._1)(_p27._4._2)(_p27._4._4._1)(_p27._4._4._2)(_p27._3)(_p27._4._3)(_p27._4._4._3)(_p27._4._4._4);
			} while(false);
			return A5(
				_elm_lang$core$Dict$RBNode_elm_builtin,
				_elm_lang$core$Dict$Black,
				_p27._4._3._1,
				_p27._4._3._2,
				A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p27._1, _p27._2, _p27._3, _p27._4._3._3),
				A5(
					_elm_lang$core$Dict$balance,
					_elm_lang$core$Dict$Black,
					_p27._4._1,
					_p27._4._2,
					_p27._4._3._4,
					_elm_lang$core$Dict$redden(_p27._4._4)));
		} while(false);
		return A5(
			_elm_lang$core$Dict$RBNode_elm_builtin,
			_elm_lang$core$Dict$Black,
			_p27._3._4._1,
			_p27._3._4._2,
			A5(
				_elm_lang$core$Dict$balance,
				_elm_lang$core$Dict$Black,
				_p27._3._1,
				_p27._3._2,
				_elm_lang$core$Dict$redden(_p27._3._3),
				_p27._3._4._3),
			A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p27._1, _p27._2, _p27._3._4._4, _p27._4));
	} while(false);
	return tree;
};
var _elm_lang$core$Dict$balance = F5(
	function (c, k, v, l, r) {
		var tree = A5(_elm_lang$core$Dict$RBNode_elm_builtin, c, k, v, l, r);
		return _elm_lang$core$Dict$blackish(tree) ? _elm_lang$core$Dict$balanceHelp(tree) : tree;
	});
var _elm_lang$core$Dict$bubble = F5(
	function (c, k, v, l, r) {
		return (_elm_lang$core$Dict$isBBlack(l) || _elm_lang$core$Dict$isBBlack(r)) ? A5(
			_elm_lang$core$Dict$balance,
			_elm_lang$core$Dict$moreBlack(c),
			k,
			v,
			_elm_lang$core$Dict$lessBlackTree(l),
			_elm_lang$core$Dict$lessBlackTree(r)) : A5(_elm_lang$core$Dict$RBNode_elm_builtin, c, k, v, l, r);
	});
var _elm_lang$core$Dict$removeMax = F5(
	function (c, k, v, l, r) {
		var _p28 = r;
		if (_p28.ctor === 'RBEmpty_elm_builtin') {
			return A3(_elm_lang$core$Dict$rem, c, l, r);
		} else {
			return A5(
				_elm_lang$core$Dict$bubble,
				c,
				k,
				v,
				l,
				A5(_elm_lang$core$Dict$removeMax, _p28._0, _p28._1, _p28._2, _p28._3, _p28._4));
		}
	});
var _elm_lang$core$Dict$rem = F3(
	function (color, left, right) {
		var _p29 = {ctor: '_Tuple2', _0: left, _1: right};
		if (_p29._0.ctor === 'RBEmpty_elm_builtin') {
			if (_p29._1.ctor === 'RBEmpty_elm_builtin') {
				var _p30 = color;
				switch (_p30.ctor) {
					case 'Red':
						return _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBlack);
					case 'Black':
						return _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBBlack);
					default:
						return _elm_lang$core$Native_Debug.crash('cannot have bblack or nblack nodes at this point');
				}
			} else {
				var _p33 = _p29._1._0;
				var _p32 = _p29._0._0;
				var _p31 = {ctor: '_Tuple3', _0: color, _1: _p32, _2: _p33};
				if ((((_p31.ctor === '_Tuple3') && (_p31._0.ctor === 'Black')) && (_p31._1.ctor === 'LBlack')) && (_p31._2.ctor === 'Red')) {
					return A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p29._1._1, _p29._1._2, _p29._1._3, _p29._1._4);
				} else {
					return A4(
						_elm_lang$core$Dict$reportRemBug,
						'Black/LBlack/Red',
						color,
						_elm_lang$core$Basics$toString(_p32),
						_elm_lang$core$Basics$toString(_p33));
				}
			}
		} else {
			if (_p29._1.ctor === 'RBEmpty_elm_builtin') {
				var _p36 = _p29._1._0;
				var _p35 = _p29._0._0;
				var _p34 = {ctor: '_Tuple3', _0: color, _1: _p35, _2: _p36};
				if ((((_p34.ctor === '_Tuple3') && (_p34._0.ctor === 'Black')) && (_p34._1.ctor === 'Red')) && (_p34._2.ctor === 'LBlack')) {
					return A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Black, _p29._0._1, _p29._0._2, _p29._0._3, _p29._0._4);
				} else {
					return A4(
						_elm_lang$core$Dict$reportRemBug,
						'Black/Red/LBlack',
						color,
						_elm_lang$core$Basics$toString(_p35),
						_elm_lang$core$Basics$toString(_p36));
				}
			} else {
				var _p40 = _p29._0._2;
				var _p39 = _p29._0._4;
				var _p38 = _p29._0._1;
				var newLeft = A5(_elm_lang$core$Dict$removeMax, _p29._0._0, _p38, _p40, _p29._0._3, _p39);
				var _p37 = A3(_elm_lang$core$Dict$maxWithDefault, _p38, _p40, _p39);
				var k = _p37._0;
				var v = _p37._1;
				return A5(_elm_lang$core$Dict$bubble, color, k, v, newLeft, right);
			}
		}
	});
var _elm_lang$core$Dict$map = F2(
	function (f, dict) {
		var _p41 = dict;
		if (_p41.ctor === 'RBEmpty_elm_builtin') {
			return _elm_lang$core$Dict$RBEmpty_elm_builtin(_elm_lang$core$Dict$LBlack);
		} else {
			var _p42 = _p41._1;
			return A5(
				_elm_lang$core$Dict$RBNode_elm_builtin,
				_p41._0,
				_p42,
				A2(f, _p42, _p41._2),
				A2(_elm_lang$core$Dict$map, f, _p41._3),
				A2(_elm_lang$core$Dict$map, f, _p41._4));
		}
	});
var _elm_lang$core$Dict$Same = {ctor: 'Same'};
var _elm_lang$core$Dict$Remove = {ctor: 'Remove'};
var _elm_lang$core$Dict$Insert = {ctor: 'Insert'};
var _elm_lang$core$Dict$update = F3(
	function (k, alter, dict) {
		var up = function (dict) {
			var _p43 = dict;
			if (_p43.ctor === 'RBEmpty_elm_builtin') {
				var _p44 = alter(_elm_lang$core$Maybe$Nothing);
				if (_p44.ctor === 'Nothing') {
					return {ctor: '_Tuple2', _0: _elm_lang$core$Dict$Same, _1: _elm_lang$core$Dict$empty};
				} else {
					return {
						ctor: '_Tuple2',
						_0: _elm_lang$core$Dict$Insert,
						_1: A5(_elm_lang$core$Dict$RBNode_elm_builtin, _elm_lang$core$Dict$Red, k, _p44._0, _elm_lang$core$Dict$empty, _elm_lang$core$Dict$empty)
					};
				}
			} else {
				var _p55 = _p43._2;
				var _p54 = _p43._4;
				var _p53 = _p43._3;
				var _p52 = _p43._1;
				var _p51 = _p43._0;
				var _p45 = A2(_elm_lang$core$Basics$compare, k, _p52);
				switch (_p45.ctor) {
					case 'EQ':
						var _p46 = alter(
							_elm_lang$core$Maybe$Just(_p55));
						if (_p46.ctor === 'Nothing') {
							return {
								ctor: '_Tuple2',
								_0: _elm_lang$core$Dict$Remove,
								_1: A3(_elm_lang$core$Dict$rem, _p51, _p53, _p54)
							};
						} else {
							return {
								ctor: '_Tuple2',
								_0: _elm_lang$core$Dict$Same,
								_1: A5(_elm_lang$core$Dict$RBNode_elm_builtin, _p51, _p52, _p46._0, _p53, _p54)
							};
						}
					case 'LT':
						var _p47 = up(_p53);
						var flag = _p47._0;
						var newLeft = _p47._1;
						var _p48 = flag;
						switch (_p48.ctor) {
							case 'Same':
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Same,
									_1: A5(_elm_lang$core$Dict$RBNode_elm_builtin, _p51, _p52, _p55, newLeft, _p54)
								};
							case 'Insert':
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Insert,
									_1: A5(_elm_lang$core$Dict$balance, _p51, _p52, _p55, newLeft, _p54)
								};
							default:
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Remove,
									_1: A5(_elm_lang$core$Dict$bubble, _p51, _p52, _p55, newLeft, _p54)
								};
						}
					default:
						var _p49 = up(_p54);
						var flag = _p49._0;
						var newRight = _p49._1;
						var _p50 = flag;
						switch (_p50.ctor) {
							case 'Same':
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Same,
									_1: A5(_elm_lang$core$Dict$RBNode_elm_builtin, _p51, _p52, _p55, _p53, newRight)
								};
							case 'Insert':
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Insert,
									_1: A5(_elm_lang$core$Dict$balance, _p51, _p52, _p55, _p53, newRight)
								};
							default:
								return {
									ctor: '_Tuple2',
									_0: _elm_lang$core$Dict$Remove,
									_1: A5(_elm_lang$core$Dict$bubble, _p51, _p52, _p55, _p53, newRight)
								};
						}
				}
			}
		};
		var _p56 = up(dict);
		var flag = _p56._0;
		var updatedDict = _p56._1;
		var _p57 = flag;
		switch (_p57.ctor) {
			case 'Same':
				return updatedDict;
			case 'Insert':
				return _elm_lang$core$Dict$ensureBlackRoot(updatedDict);
			default:
				return _elm_lang$core$Dict$blacken(updatedDict);
		}
	});
var _elm_lang$core$Dict$insert = F3(
	function (key, value, dict) {
		return A3(
			_elm_lang$core$Dict$update,
			key,
			_elm_lang$core$Basics$always(
				_elm_lang$core$Maybe$Just(value)),
			dict);
	});
var _elm_lang$core$Dict$singleton = F2(
	function (key, value) {
		return A3(_elm_lang$core$Dict$insert, key, value, _elm_lang$core$Dict$empty);
	});
var _elm_lang$core$Dict$union = F2(
	function (t1, t2) {
		return A3(_elm_lang$core$Dict$foldl, _elm_lang$core$Dict$insert, t2, t1);
	});
var _elm_lang$core$Dict$filter = F2(
	function (predicate, dictionary) {
		var add = F3(
			function (key, value, dict) {
				return A2(predicate, key, value) ? A3(_elm_lang$core$Dict$insert, key, value, dict) : dict;
			});
		return A3(_elm_lang$core$Dict$foldl, add, _elm_lang$core$Dict$empty, dictionary);
	});
var _elm_lang$core$Dict$intersect = F2(
	function (t1, t2) {
		return A2(
			_elm_lang$core$Dict$filter,
			F2(
				function (k, _p58) {
					return A2(_elm_lang$core$Dict$member, k, t2);
				}),
			t1);
	});
var _elm_lang$core$Dict$partition = F2(
	function (predicate, dict) {
		var add = F3(
			function (key, value, _p59) {
				var _p60 = _p59;
				var _p62 = _p60._1;
				var _p61 = _p60._0;
				return A2(predicate, key, value) ? {
					ctor: '_Tuple2',
					_0: A3(_elm_lang$core$Dict$insert, key, value, _p61),
					_1: _p62
				} : {
					ctor: '_Tuple2',
					_0: _p61,
					_1: A3(_elm_lang$core$Dict$insert, key, value, _p62)
				};
			});
		return A3(
			_elm_lang$core$Dict$foldl,
			add,
			{ctor: '_Tuple2', _0: _elm_lang$core$Dict$empty, _1: _elm_lang$core$Dict$empty},
			dict);
	});
var _elm_lang$core$Dict$fromList = function (assocs) {
	return A3(
		_elm_lang$core$List$foldl,
		F2(
			function (_p63, dict) {
				var _p64 = _p63;
				return A3(_elm_lang$core$Dict$insert, _p64._0, _p64._1, dict);
			}),
		_elm_lang$core$Dict$empty,
		assocs);
};
var _elm_lang$core$Dict$remove = F2(
	function (key, dict) {
		return A3(
			_elm_lang$core$Dict$update,
			key,
			_elm_lang$core$Basics$always(_elm_lang$core$Maybe$Nothing),
			dict);
	});
var _elm_lang$core$Dict$diff = F2(
	function (t1, t2) {
		return A3(
			_elm_lang$core$Dict$foldl,
			F3(
				function (k, v, t) {
					return A2(_elm_lang$core$Dict$remove, k, t);
				}),
			t1,
			t2);
	});

var _elm_lang$core$Set$foldr = F3(
	function (f, b, _p0) {
		var _p1 = _p0;
		return A3(
			_elm_lang$core$Dict$foldr,
			F3(
				function (k, _p2, b) {
					return A2(f, k, b);
				}),
			b,
			_p1._0);
	});
var _elm_lang$core$Set$foldl = F3(
	function (f, b, _p3) {
		var _p4 = _p3;
		return A3(
			_elm_lang$core$Dict$foldl,
			F3(
				function (k, _p5, b) {
					return A2(f, k, b);
				}),
			b,
			_p4._0);
	});
var _elm_lang$core$Set$toList = function (_p6) {
	var _p7 = _p6;
	return _elm_lang$core$Dict$keys(_p7._0);
};
var _elm_lang$core$Set$size = function (_p8) {
	var _p9 = _p8;
	return _elm_lang$core$Dict$size(_p9._0);
};
var _elm_lang$core$Set$member = F2(
	function (k, _p10) {
		var _p11 = _p10;
		return A2(_elm_lang$core$Dict$member, k, _p11._0);
	});
var _elm_lang$core$Set$isEmpty = function (_p12) {
	var _p13 = _p12;
	return _elm_lang$core$Dict$isEmpty(_p13._0);
};
var _elm_lang$core$Set$Set_elm_builtin = function (a) {
	return {ctor: 'Set_elm_builtin', _0: a};
};
var _elm_lang$core$Set$empty = _elm_lang$core$Set$Set_elm_builtin(_elm_lang$core$Dict$empty);
var _elm_lang$core$Set$singleton = function (k) {
	return _elm_lang$core$Set$Set_elm_builtin(
		A2(
			_elm_lang$core$Dict$singleton,
			k,
			{ctor: '_Tuple0'}));
};
var _elm_lang$core$Set$insert = F2(
	function (k, _p14) {
		var _p15 = _p14;
		return _elm_lang$core$Set$Set_elm_builtin(
			A3(
				_elm_lang$core$Dict$insert,
				k,
				{ctor: '_Tuple0'},
				_p15._0));
	});
var _elm_lang$core$Set$fromList = function (xs) {
	return A3(_elm_lang$core$List$foldl, _elm_lang$core$Set$insert, _elm_lang$core$Set$empty, xs);
};
var _elm_lang$core$Set$map = F2(
	function (f, s) {
		return _elm_lang$core$Set$fromList(
			A2(
				_elm_lang$core$List$map,
				f,
				_elm_lang$core$Set$toList(s)));
	});
var _elm_lang$core$Set$remove = F2(
	function (k, _p16) {
		var _p17 = _p16;
		return _elm_lang$core$Set$Set_elm_builtin(
			A2(_elm_lang$core$Dict$remove, k, _p17._0));
	});
var _elm_lang$core$Set$union = F2(
	function (_p19, _p18) {
		var _p20 = _p19;
		var _p21 = _p18;
		return _elm_lang$core$Set$Set_elm_builtin(
			A2(_elm_lang$core$Dict$union, _p20._0, _p21._0));
	});
var _elm_lang$core$Set$intersect = F2(
	function (_p23, _p22) {
		var _p24 = _p23;
		var _p25 = _p22;
		return _elm_lang$core$Set$Set_elm_builtin(
			A2(_elm_lang$core$Dict$intersect, _p24._0, _p25._0));
	});
var _elm_lang$core$Set$diff = F2(
	function (_p27, _p26) {
		var _p28 = _p27;
		var _p29 = _p26;
		return _elm_lang$core$Set$Set_elm_builtin(
			A2(_elm_lang$core$Dict$diff, _p28._0, _p29._0));
	});
var _elm_lang$core$Set$filter = F2(
	function (p, _p30) {
		var _p31 = _p30;
		return _elm_lang$core$Set$Set_elm_builtin(
			A2(
				_elm_lang$core$Dict$filter,
				F2(
					function (k, _p32) {
						return p(k);
					}),
				_p31._0));
	});
var _elm_lang$core$Set$partition = F2(
	function (p, _p33) {
		var _p34 = _p33;
		var _p35 = A2(
			_elm_lang$core$Dict$partition,
			F2(
				function (k, _p36) {
					return p(k);
				}),
			_p34._0);
		var p1 = _p35._0;
		var p2 = _p35._1;
		return {
			ctor: '_Tuple2',
			_0: _elm_lang$core$Set$Set_elm_builtin(p1),
			_1: _elm_lang$core$Set$Set_elm_builtin(p2)
		};
	});

var _elm_community$list_extra$List_Extra$greedyGroupsOfWithStep = F3(
	function (size, step, xs) {
		var okayXs = _elm_lang$core$Native_Utils.cmp(
			_elm_lang$core$List$length(xs),
			0) > 0;
		var okayArgs = (_elm_lang$core$Native_Utils.cmp(size, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(step, 0) > 0);
		var xs_ = A2(_elm_lang$core$List$drop, step, xs);
		var group = A2(_elm_lang$core$List$take, size, xs);
		return (okayArgs && okayXs) ? {
			ctor: '::',
			_0: group,
			_1: A3(_elm_community$list_extra$List_Extra$greedyGroupsOfWithStep, size, step, xs_)
		} : {ctor: '[]'};
	});
var _elm_community$list_extra$List_Extra$greedyGroupsOf = F2(
	function (size, xs) {
		return A3(_elm_community$list_extra$List_Extra$greedyGroupsOfWithStep, size, size, xs);
	});
var _elm_community$list_extra$List_Extra$groupsOfWithStep = F3(
	function (size, step, xs) {
		var okayArgs = (_elm_lang$core$Native_Utils.cmp(size, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(step, 0) > 0);
		var xs_ = A2(_elm_lang$core$List$drop, step, xs);
		var group = A2(_elm_lang$core$List$take, size, xs);
		var okayLength = _elm_lang$core$Native_Utils.eq(
			size,
			_elm_lang$core$List$length(group));
		return (okayArgs && okayLength) ? {
			ctor: '::',
			_0: group,
			_1: A3(_elm_community$list_extra$List_Extra$groupsOfWithStep, size, step, xs_)
		} : {ctor: '[]'};
	});
var _elm_community$list_extra$List_Extra$groupsOf = F2(
	function (size, xs) {
		return A3(_elm_community$list_extra$List_Extra$groupsOfWithStep, size, size, xs);
	});
var _elm_community$list_extra$List_Extra$zip5 = _elm_lang$core$List$map5(
	F5(
		function (v0, v1, v2, v3, v4) {
			return {ctor: '_Tuple5', _0: v0, _1: v1, _2: v2, _3: v3, _4: v4};
		}));
var _elm_community$list_extra$List_Extra$zip4 = _elm_lang$core$List$map4(
	F4(
		function (v0, v1, v2, v3) {
			return {ctor: '_Tuple4', _0: v0, _1: v1, _2: v2, _3: v3};
		}));
var _elm_community$list_extra$List_Extra$zip3 = _elm_lang$core$List$map3(
	F3(
		function (v0, v1, v2) {
			return {ctor: '_Tuple3', _0: v0, _1: v1, _2: v2};
		}));
var _elm_community$list_extra$List_Extra$zip = _elm_lang$core$List$map2(
	F2(
		function (v0, v1) {
			return {ctor: '_Tuple2', _0: v0, _1: v1};
		}));
var _elm_community$list_extra$List_Extra$isSubsequenceOf = F2(
	function (subseq, list) {
		isSubsequenceOf:
		while (true) {
			var _p0 = {ctor: '_Tuple2', _0: subseq, _1: list};
			if (_p0._0.ctor === '[]') {
				return true;
			} else {
				if (_p0._1.ctor === '[]') {
					return false;
				} else {
					var _p1 = _p0._1._1;
					if (_elm_lang$core$Native_Utils.eq(_p0._0._0, _p0._1._0)) {
						var _v1 = _p0._0._1,
							_v2 = _p1;
						subseq = _v1;
						list = _v2;
						continue isSubsequenceOf;
					} else {
						var _v3 = subseq,
							_v4 = _p1;
						subseq = _v3;
						list = _v4;
						continue isSubsequenceOf;
					}
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$isPrefixOf = F2(
	function (prefix, xs) {
		var _p2 = {ctor: '_Tuple2', _0: prefix, _1: xs};
		if (_p2._0.ctor === '[]') {
			return true;
		} else {
			if (_p2._1.ctor === '[]') {
				return false;
			} else {
				return _elm_lang$core$Native_Utils.eq(_p2._0._0, _p2._1._0) && A2(_elm_community$list_extra$List_Extra$isPrefixOf, _p2._0._1, _p2._1._1);
			}
		}
	});
var _elm_community$list_extra$List_Extra$isSuffixOf = F2(
	function (suffix, xs) {
		return A2(
			_elm_community$list_extra$List_Extra$isPrefixOf,
			_elm_lang$core$List$reverse(suffix),
			_elm_lang$core$List$reverse(xs));
	});
var _elm_community$list_extra$List_Extra$isInfixOfHelp = F3(
	function (infixHead, infixTail, list) {
		isInfixOfHelp:
		while (true) {
			var _p3 = list;
			if (_p3.ctor === '[]') {
				return false;
			} else {
				var _p4 = _p3._1;
				if (_elm_lang$core$Native_Utils.eq(_p3._0, infixHead)) {
					return A2(_elm_community$list_extra$List_Extra$isPrefixOf, infixTail, _p4);
				} else {
					var _v7 = infixHead,
						_v8 = infixTail,
						_v9 = _p4;
					infixHead = _v7;
					infixTail = _v8;
					list = _v9;
					continue isInfixOfHelp;
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$isInfixOf = F2(
	function (infixList, list) {
		var _p5 = infixList;
		if (_p5.ctor === '[]') {
			return true;
		} else {
			return A3(_elm_community$list_extra$List_Extra$isInfixOfHelp, _p5._0, _p5._1, list);
		}
	});
var _elm_community$list_extra$List_Extra$selectSplit = function (xs) {
	var _p6 = xs;
	if (_p6.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		var _p10 = _p6._1;
		var _p9 = _p6._0;
		return {
			ctor: '::',
			_0: {
				ctor: '_Tuple3',
				_0: {ctor: '[]'},
				_1: _p9,
				_2: _p10
			},
			_1: A2(
				_elm_lang$core$List$map,
				function (_p7) {
					var _p8 = _p7;
					return {
						ctor: '_Tuple3',
						_0: {ctor: '::', _0: _p9, _1: _p8._0},
						_1: _p8._1,
						_2: _p8._2
					};
				},
				_elm_community$list_extra$List_Extra$selectSplit(_p10))
		};
	}
};
var _elm_community$list_extra$List_Extra$select = function (xs) {
	var _p11 = xs;
	if (_p11.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		var _p15 = _p11._1;
		var _p14 = _p11._0;
		return {
			ctor: '::',
			_0: {ctor: '_Tuple2', _0: _p14, _1: _p15},
			_1: A2(
				_elm_lang$core$List$map,
				function (_p12) {
					var _p13 = _p12;
					return {
						ctor: '_Tuple2',
						_0: _p13._0,
						_1: {ctor: '::', _0: _p14, _1: _p13._1}
					};
				},
				_elm_community$list_extra$List_Extra$select(_p15))
		};
	}
};
var _elm_community$list_extra$List_Extra$tailsHelp = F2(
	function (e, list) {
		var _p16 = list;
		if (_p16.ctor === '::') {
			var _p17 = _p16._0;
			return {
				ctor: '::',
				_0: {ctor: '::', _0: e, _1: _p17},
				_1: {ctor: '::', _0: _p17, _1: _p16._1}
			};
		} else {
			return {ctor: '[]'};
		}
	});
var _elm_community$list_extra$List_Extra$tails = A2(
	_elm_lang$core$List$foldr,
	_elm_community$list_extra$List_Extra$tailsHelp,
	{
		ctor: '::',
		_0: {ctor: '[]'},
		_1: {ctor: '[]'}
	});
var _elm_community$list_extra$List_Extra$inits = A2(
	_elm_lang$core$List$foldr,
	F2(
		function (e, acc) {
			return {
				ctor: '::',
				_0: {ctor: '[]'},
				_1: A2(
					_elm_lang$core$List$map,
					F2(
						function (x, y) {
							return {ctor: '::', _0: x, _1: y};
						})(e),
					acc)
			};
		}),
	{
		ctor: '::',
		_0: {ctor: '[]'},
		_1: {ctor: '[]'}
	});
var _elm_community$list_extra$List_Extra$groupWhileTransitivelyHelp = F4(
	function (result, currentGroup, compare, list) {
		groupWhileTransitivelyHelp:
		while (true) {
			var _p18 = list;
			if (_p18.ctor === '[]') {
				return _elm_lang$core$List$reverse(
					_elm_lang$core$List$isEmpty(currentGroup) ? result : _elm_lang$core$List$reverse(
						{ctor: '::', _0: currentGroup, _1: result}));
			} else {
				if (_p18._1.ctor === '[]') {
					return _elm_lang$core$List$reverse(
						{
							ctor: '::',
							_0: _elm_lang$core$List$reverse(
								{ctor: '::', _0: _p18._0, _1: currentGroup}),
							_1: result
						});
				} else {
					var _p20 = _p18._1;
					var _p19 = _p18._0;
					if (A2(compare, _p19, _p18._1._0)) {
						var _v17 = result,
							_v18 = {ctor: '::', _0: _p19, _1: currentGroup},
							_v19 = compare,
							_v20 = _p20;
						result = _v17;
						currentGroup = _v18;
						compare = _v19;
						list = _v20;
						continue groupWhileTransitivelyHelp;
					} else {
						var _v21 = {
							ctor: '::',
							_0: _elm_lang$core$List$reverse(
								{ctor: '::', _0: _p19, _1: currentGroup}),
							_1: result
						},
							_v22 = {ctor: '[]'},
							_v23 = compare,
							_v24 = _p20;
						result = _v21;
						currentGroup = _v22;
						compare = _v23;
						list = _v24;
						continue groupWhileTransitivelyHelp;
					}
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$groupWhileTransitively = F2(
	function (compare, list) {
		return A4(
			_elm_community$list_extra$List_Extra$groupWhileTransitivelyHelp,
			{ctor: '[]'},
			{ctor: '[]'},
			compare,
			list);
	});
var _elm_community$list_extra$List_Extra$stripPrefix = F2(
	function (prefix, xs) {
		var step = F2(
			function (e, m) {
				var _p21 = m;
				if (_p21.ctor === 'Nothing') {
					return _elm_lang$core$Maybe$Nothing;
				} else {
					if (_p21._0.ctor === '[]') {
						return _elm_lang$core$Maybe$Nothing;
					} else {
						return _elm_lang$core$Native_Utils.eq(e, _p21._0._0) ? _elm_lang$core$Maybe$Just(_p21._0._1) : _elm_lang$core$Maybe$Nothing;
					}
				}
			});
		return A3(
			_elm_lang$core$List$foldl,
			step,
			_elm_lang$core$Maybe$Just(xs),
			prefix);
	});
var _elm_community$list_extra$List_Extra$dropWhileRight = function (p) {
	return A2(
		_elm_lang$core$List$foldr,
		F2(
			function (x, xs) {
				return (p(x) && _elm_lang$core$List$isEmpty(xs)) ? {ctor: '[]'} : {ctor: '::', _0: x, _1: xs};
			}),
		{ctor: '[]'});
};
var _elm_community$list_extra$List_Extra$takeWhileRight = function (p) {
	var step = F2(
		function (x, _p22) {
			var _p23 = _p22;
			var _p24 = _p23._0;
			return (p(x) && _p23._1) ? {
				ctor: '_Tuple2',
				_0: {ctor: '::', _0: x, _1: _p24},
				_1: true
			} : {ctor: '_Tuple2', _0: _p24, _1: false};
		});
	return function (_p25) {
		return _elm_lang$core$Tuple$first(
			A3(
				_elm_lang$core$List$foldr,
				step,
				{
					ctor: '_Tuple2',
					_0: {ctor: '[]'},
					_1: true
				},
				_p25));
	};
};
var _elm_community$list_extra$List_Extra$splitAt = F2(
	function (n, xs) {
		return {
			ctor: '_Tuple2',
			_0: A2(_elm_lang$core$List$take, n, xs),
			_1: A2(_elm_lang$core$List$drop, n, xs)
		};
	});
var _elm_community$list_extra$List_Extra$groupsOfVarying_ = F3(
	function (listOflengths, list, accu) {
		groupsOfVarying_:
		while (true) {
			var _p26 = {ctor: '_Tuple2', _0: listOflengths, _1: list};
			if (((_p26.ctor === '_Tuple2') && (_p26._0.ctor === '::')) && (_p26._1.ctor === '::')) {
				var _p27 = A2(_elm_community$list_extra$List_Extra$splitAt, _p26._0._0, list);
				var head = _p27._0;
				var tail = _p27._1;
				var _v28 = _p26._0._1,
					_v29 = tail,
					_v30 = {ctor: '::', _0: head, _1: accu};
				listOflengths = _v28;
				list = _v29;
				accu = _v30;
				continue groupsOfVarying_;
			} else {
				return _elm_lang$core$List$reverse(accu);
			}
		}
	});
var _elm_community$list_extra$List_Extra$groupsOfVarying = F2(
	function (listOflengths, list) {
		return A3(
			_elm_community$list_extra$List_Extra$groupsOfVarying_,
			listOflengths,
			list,
			{ctor: '[]'});
	});
var _elm_community$list_extra$List_Extra$unfoldr = F2(
	function (f, seed) {
		var _p28 = f(seed);
		if (_p28.ctor === 'Nothing') {
			return {ctor: '[]'};
		} else {
			return {
				ctor: '::',
				_0: _p28._0._0,
				_1: A2(_elm_community$list_extra$List_Extra$unfoldr, f, _p28._0._1)
			};
		}
	});
var _elm_community$list_extra$List_Extra$mapAccumr = F3(
	function (f, acc0, list) {
		return A3(
			_elm_lang$core$List$foldr,
			F2(
				function (x, _p29) {
					var _p30 = _p29;
					var _p31 = A2(f, _p30._0, x);
					var acc2 = _p31._0;
					var y = _p31._1;
					return {
						ctor: '_Tuple2',
						_0: acc2,
						_1: {ctor: '::', _0: y, _1: _p30._1}
					};
				}),
			{
				ctor: '_Tuple2',
				_0: acc0,
				_1: {ctor: '[]'}
			},
			list);
	});
var _elm_community$list_extra$List_Extra$mapAccuml = F3(
	function (f, acc0, list) {
		var _p32 = A3(
			_elm_lang$core$List$foldl,
			F2(
				function (x, _p33) {
					var _p34 = _p33;
					var _p35 = A2(f, _p34._0, x);
					var acc2 = _p35._0;
					var y = _p35._1;
					return {
						ctor: '_Tuple2',
						_0: acc2,
						_1: {ctor: '::', _0: y, _1: _p34._1}
					};
				}),
			{
				ctor: '_Tuple2',
				_0: acc0,
				_1: {ctor: '[]'}
			},
			list);
		var accFinal = _p32._0;
		var generatedList = _p32._1;
		return {
			ctor: '_Tuple2',
			_0: accFinal,
			_1: _elm_lang$core$List$reverse(generatedList)
		};
	});
var _elm_community$list_extra$List_Extra$scanr1 = F2(
	function (f, xs_) {
		var _p36 = xs_;
		if (_p36.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			if (_p36._1.ctor === '[]') {
				return {
					ctor: '::',
					_0: _p36._0,
					_1: {ctor: '[]'}
				};
			} else {
				var _p37 = A2(_elm_community$list_extra$List_Extra$scanr1, f, _p36._1);
				if (_p37.ctor === '::') {
					return {
						ctor: '::',
						_0: A2(f, _p36._0, _p37._0),
						_1: _p37
					};
				} else {
					return {ctor: '[]'};
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$scanr = F3(
	function (f, acc, xs_) {
		var _p38 = xs_;
		if (_p38.ctor === '[]') {
			return {
				ctor: '::',
				_0: acc,
				_1: {ctor: '[]'}
			};
		} else {
			var _p39 = A3(_elm_community$list_extra$List_Extra$scanr, f, acc, _p38._1);
			if (_p39.ctor === '::') {
				return {
					ctor: '::',
					_0: A2(f, _p38._0, _p39._0),
					_1: _p39
				};
			} else {
				return {ctor: '[]'};
			}
		}
	});
var _elm_community$list_extra$List_Extra$scanl1 = F2(
	function (f, xs_) {
		var _p40 = xs_;
		if (_p40.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			return A3(_elm_lang$core$List$scanl, f, _p40._0, _p40._1);
		}
	});
var _elm_community$list_extra$List_Extra$indexedFoldr = F3(
	function (func, acc, list) {
		var step = F2(
			function (x, _p41) {
				var _p42 = _p41;
				var _p43 = _p42._0;
				return {
					ctor: '_Tuple2',
					_0: _p43 - 1,
					_1: A3(func, _p43, x, _p42._1)
				};
			});
		return _elm_lang$core$Tuple$second(
			A3(
				_elm_lang$core$List$foldr,
				step,
				{
					ctor: '_Tuple2',
					_0: _elm_lang$core$List$length(list) - 1,
					_1: acc
				},
				list));
	});
var _elm_community$list_extra$List_Extra$indexedFoldl = F3(
	function (func, acc, list) {
		var step = F2(
			function (x, _p44) {
				var _p45 = _p44;
				var _p46 = _p45._0;
				return {
					ctor: '_Tuple2',
					_0: _p46 + 1,
					_1: A3(func, _p46, x, _p45._1)
				};
			});
		return _elm_lang$core$Tuple$second(
			A3(
				_elm_lang$core$List$foldl,
				step,
				{ctor: '_Tuple2', _0: 0, _1: acc},
				list));
	});
var _elm_community$list_extra$List_Extra$foldr1 = F2(
	function (f, xs) {
		var mf = F2(
			function (x, m) {
				return _elm_lang$core$Maybe$Just(
					function () {
						var _p47 = m;
						if (_p47.ctor === 'Nothing') {
							return x;
						} else {
							return A2(f, x, _p47._0);
						}
					}());
			});
		return A3(_elm_lang$core$List$foldr, mf, _elm_lang$core$Maybe$Nothing, xs);
	});
var _elm_community$list_extra$List_Extra$foldl1 = F2(
	function (f, xs) {
		var mf = F2(
			function (x, m) {
				return _elm_lang$core$Maybe$Just(
					function () {
						var _p48 = m;
						if (_p48.ctor === 'Nothing') {
							return x;
						} else {
							return A2(f, _p48._0, x);
						}
					}());
			});
		return A3(_elm_lang$core$List$foldl, mf, _elm_lang$core$Maybe$Nothing, xs);
	});
var _elm_community$list_extra$List_Extra$reverseAppend = F2(
	function (list1, list2) {
		return A3(
			_elm_lang$core$List$foldl,
			F2(
				function (x, y) {
					return {ctor: '::', _0: x, _1: y};
				}),
			list2,
			list1);
	});
var _elm_community$list_extra$List_Extra$interweaveHelp = F3(
	function (acc, list1, list2) {
		interweaveHelp:
		while (true) {
			var _p49 = {ctor: '_Tuple2', _0: list1, _1: list2};
			if (_p49._0.ctor === '::') {
				if (_p49._1.ctor === '::') {
					var _v44 = {
						ctor: '::',
						_0: _p49._1._0,
						_1: {ctor: '::', _0: _p49._0._0, _1: acc}
					},
						_v45 = _p49._0._1,
						_v46 = _p49._1._1;
					acc = _v44;
					list1 = _v45;
					list2 = _v46;
					continue interweaveHelp;
				} else {
					return A2(_elm_community$list_extra$List_Extra$reverseAppend, acc, list1);
				}
			} else {
				return A2(_elm_community$list_extra$List_Extra$reverseAppend, acc, list2);
			}
		}
	});
var _elm_community$list_extra$List_Extra$interweave = _elm_community$list_extra$List_Extra$interweaveHelp(
	{ctor: '[]'});
var _elm_community$list_extra$List_Extra$permutations = function (xs_) {
	var _p50 = xs_;
	if (_p50.ctor === '[]') {
		return {
			ctor: '::',
			_0: {ctor: '[]'},
			_1: {ctor: '[]'}
		};
	} else {
		var f = function (_p51) {
			var _p52 = _p51;
			return A2(
				_elm_lang$core$List$map,
				F2(
					function (x, y) {
						return {ctor: '::', _0: x, _1: y};
					})(_p52._0),
				_elm_community$list_extra$List_Extra$permutations(_p52._1));
		};
		return A2(
			_elm_lang$core$List$concatMap,
			f,
			_elm_community$list_extra$List_Extra$select(_p50));
	}
};
var _elm_community$list_extra$List_Extra$isPermutationOf = F2(
	function (permut, xs) {
		return A2(
			_elm_lang$core$List$member,
			permut,
			_elm_community$list_extra$List_Extra$permutations(xs));
	});
var _elm_community$list_extra$List_Extra$subsequencesNonEmpty = function (xs) {
	var _p53 = xs;
	if (_p53.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		var _p54 = _p53._0;
		var f = F2(
			function (ys, r) {
				return {
					ctor: '::',
					_0: ys,
					_1: {
						ctor: '::',
						_0: {ctor: '::', _0: _p54, _1: ys},
						_1: r
					}
				};
			});
		return {
			ctor: '::',
			_0: {
				ctor: '::',
				_0: _p54,
				_1: {ctor: '[]'}
			},
			_1: A3(
				_elm_lang$core$List$foldr,
				f,
				{ctor: '[]'},
				_elm_community$list_extra$List_Extra$subsequencesNonEmpty(_p53._1))
		};
	}
};
var _elm_community$list_extra$List_Extra$subsequences = function (xs) {
	return {
		ctor: '::',
		_0: {ctor: '[]'},
		_1: _elm_community$list_extra$List_Extra$subsequencesNonEmpty(xs)
	};
};
var _elm_community$list_extra$List_Extra$rowsLength = function (listOfLists) {
	var _p55 = listOfLists;
	if (_p55.ctor === '[]') {
		return 0;
	} else {
		return _elm_lang$core$List$length(_p55._0);
	}
};
var _elm_community$list_extra$List_Extra$transpose = function (listOfLists) {
	return A3(
		_elm_lang$core$List$foldr,
		_elm_lang$core$List$map2(
			F2(
				function (x, y) {
					return {ctor: '::', _0: x, _1: y};
				})),
		A2(
			_elm_lang$core$List$repeat,
			_elm_community$list_extra$List_Extra$rowsLength(listOfLists),
			{ctor: '[]'}),
		listOfLists);
};
var _elm_community$list_extra$List_Extra$intercalate = function (xs) {
	return function (_p56) {
		return _elm_lang$core$List$concat(
			A2(_elm_lang$core$List$intersperse, xs, _p56));
	};
};
var _elm_community$list_extra$List_Extra$filterNot = F2(
	function (pred, list) {
		return A2(
			_elm_lang$core$List$filter,
			function (_p57) {
				return !pred(_p57);
			},
			list);
	});
var _elm_community$list_extra$List_Extra$removeIfIndex = function (predicate) {
	return A2(
		_elm_community$list_extra$List_Extra$indexedFoldr,
		F3(
			function (index, item, acc) {
				return predicate(index) ? acc : {ctor: '::', _0: item, _1: acc};
			}),
		{ctor: '[]'});
};
var _elm_community$list_extra$List_Extra$removeAt = F2(
	function (index, l) {
		if (_elm_lang$core$Native_Utils.cmp(index, 0) < 0) {
			return l;
		} else {
			var tail = _elm_lang$core$List$tail(
				A2(_elm_lang$core$List$drop, index, l));
			var head = A2(_elm_lang$core$List$take, index, l);
			var _p58 = tail;
			if (_p58.ctor === 'Nothing') {
				return l;
			} else {
				return A2(_elm_lang$core$List$append, head, _p58._0);
			}
		}
	});
var _elm_community$list_extra$List_Extra$stableSortWith = F2(
	function (pred, list) {
		var predWithIndex = F2(
			function (_p60, _p59) {
				var _p61 = _p60;
				var _p62 = _p59;
				var result = A2(pred, _p61._0, _p62._0);
				var _p63 = result;
				if (_p63.ctor === 'EQ') {
					return A2(_elm_lang$core$Basics$compare, _p61._1, _p62._1);
				} else {
					return result;
				}
			});
		var listWithIndex = A2(
			_elm_lang$core$List$indexedMap,
			F2(
				function (i, a) {
					return {ctor: '_Tuple2', _0: a, _1: i};
				}),
			list);
		return A2(
			_elm_lang$core$List$map,
			_elm_lang$core$Tuple$first,
			A2(_elm_lang$core$List$sortWith, predWithIndex, listWithIndex));
	});
var _elm_community$list_extra$List_Extra$remove = F2(
	function (x, xs) {
		var _p64 = xs;
		if (_p64.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			var _p66 = _p64._1;
			var _p65 = _p64._0;
			return _elm_lang$core$Native_Utils.eq(x, _p65) ? _p66 : {
				ctor: '::',
				_0: _p65,
				_1: A2(_elm_community$list_extra$List_Extra$remove, x, _p66)
			};
		}
	});
var _elm_community$list_extra$List_Extra$updateIfIndex = F3(
	function (predicate, update, list) {
		return A2(
			_elm_lang$core$List$indexedMap,
			F2(
				function (i, x) {
					return predicate(i) ? update(x) : x;
				}),
			list);
	});
var _elm_community$list_extra$List_Extra$updateAt = F3(
	function (index, fn, list) {
		if (_elm_lang$core$Native_Utils.cmp(index, 0) < 0) {
			return list;
		} else {
			var tail = A2(_elm_lang$core$List$drop, index, list);
			var head = A2(_elm_lang$core$List$take, index, list);
			var _p67 = tail;
			if (_p67.ctor === '::') {
				return A2(
					_elm_lang$core$Basics_ops['++'],
					head,
					{
						ctor: '::',
						_0: fn(_p67._0),
						_1: _p67._1
					});
			} else {
				return list;
			}
		}
	});
var _elm_community$list_extra$List_Extra$setAt = F2(
	function (index, value) {
		return A2(
			_elm_community$list_extra$List_Extra$updateAt,
			index,
			_elm_lang$core$Basics$always(value));
	});
var _elm_community$list_extra$List_Extra$updateIf = F3(
	function (predicate, update, list) {
		return A2(
			_elm_lang$core$List$map,
			function (item) {
				return predicate(item) ? update(item) : item;
			},
			list);
	});
var _elm_community$list_extra$List_Extra$replaceIf = F3(
	function (predicate, replacement, list) {
		return A3(
			_elm_community$list_extra$List_Extra$updateIf,
			predicate,
			_elm_lang$core$Basics$always(replacement),
			list);
	});
var _elm_community$list_extra$List_Extra$count = function (predicate) {
	return A2(
		_elm_lang$core$List$foldl,
		F2(
			function (x, acc) {
				return predicate(x) ? (acc + 1) : acc;
			}),
		0);
};
var _elm_community$list_extra$List_Extra$findIndices = function (predicate) {
	var consIndexIf = F3(
		function (index, x, acc) {
			return predicate(x) ? {ctor: '::', _0: index, _1: acc} : acc;
		});
	return A2(
		_elm_community$list_extra$List_Extra$indexedFoldr,
		consIndexIf,
		{ctor: '[]'});
};
var _elm_community$list_extra$List_Extra$findIndexHelp = F3(
	function (index, predicate, list) {
		findIndexHelp:
		while (true) {
			var _p68 = list;
			if (_p68.ctor === '[]') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				if (predicate(_p68._0)) {
					return _elm_lang$core$Maybe$Just(index);
				} else {
					var _v58 = index + 1,
						_v59 = predicate,
						_v60 = _p68._1;
					index = _v58;
					predicate = _v59;
					list = _v60;
					continue findIndexHelp;
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$findIndex = _elm_community$list_extra$List_Extra$findIndexHelp(0);
var _elm_community$list_extra$List_Extra$splitWhen = F2(
	function (predicate, list) {
		return A2(
			_elm_lang$core$Maybe$map,
			function (i) {
				return A2(_elm_community$list_extra$List_Extra$splitAt, i, list);
			},
			A2(_elm_community$list_extra$List_Extra$findIndex, predicate, list));
	});
var _elm_community$list_extra$List_Extra$elemIndices = function (x) {
	return _elm_community$list_extra$List_Extra$findIndices(
		F2(
			function (x, y) {
				return _elm_lang$core$Native_Utils.eq(x, y);
			})(x));
};
var _elm_community$list_extra$List_Extra$elemIndex = function (x) {
	return _elm_community$list_extra$List_Extra$findIndex(
		F2(
			function (x, y) {
				return _elm_lang$core$Native_Utils.eq(x, y);
			})(x));
};
var _elm_community$list_extra$List_Extra$find = F2(
	function (predicate, list) {
		find:
		while (true) {
			var _p69 = list;
			if (_p69.ctor === '[]') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				var _p70 = _p69._0;
				if (predicate(_p70)) {
					return _elm_lang$core$Maybe$Just(_p70);
				} else {
					var _v62 = predicate,
						_v63 = _p69._1;
					predicate = _v62;
					list = _v63;
					continue find;
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$notMember = function (x) {
	return function (_p71) {
		return !A2(_elm_lang$core$List$member, x, _p71);
	};
};
var _elm_community$list_extra$List_Extra$reverseMap = F2(
	function (f, xs) {
		return A3(
			_elm_lang$core$List$foldl,
			F2(
				function (x, acc) {
					return {
						ctor: '::',
						_0: f(x),
						_1: acc
					};
				}),
			{ctor: '[]'},
			xs);
	});
var _elm_community$list_extra$List_Extra$andThen = _elm_lang$core$List$concatMap;
var _elm_community$list_extra$List_Extra$lift2 = F3(
	function (f, la, lb) {
		return A2(
			_elm_community$list_extra$List_Extra$andThen,
			function (a) {
				return A2(
					_elm_community$list_extra$List_Extra$andThen,
					function (b) {
						return {
							ctor: '::',
							_0: A2(f, a, b),
							_1: {ctor: '[]'}
						};
					},
					lb);
			},
			la);
	});
var _elm_community$list_extra$List_Extra$cartesianProduct = function (ll) {
	var _p72 = ll;
	if (_p72.ctor === '[]') {
		return {
			ctor: '::',
			_0: {ctor: '[]'},
			_1: {ctor: '[]'}
		};
	} else {
		return A3(
			_elm_community$list_extra$List_Extra$lift2,
			F2(
				function (x, y) {
					return {ctor: '::', _0: x, _1: y};
				}),
			_p72._0,
			_elm_community$list_extra$List_Extra$cartesianProduct(_p72._1));
	}
};
var _elm_community$list_extra$List_Extra$lift3 = F4(
	function (f, la, lb, lc) {
		return A2(
			_elm_community$list_extra$List_Extra$andThen,
			function (a) {
				return A2(
					_elm_community$list_extra$List_Extra$andThen,
					function (b) {
						return A2(
							_elm_community$list_extra$List_Extra$andThen,
							function (c) {
								return {
									ctor: '::',
									_0: A3(f, a, b, c),
									_1: {ctor: '[]'}
								};
							},
							lc);
					},
					lb);
			},
			la);
	});
var _elm_community$list_extra$List_Extra$lift4 = F5(
	function (f, la, lb, lc, ld) {
		return A2(
			_elm_community$list_extra$List_Extra$andThen,
			function (a) {
				return A2(
					_elm_community$list_extra$List_Extra$andThen,
					function (b) {
						return A2(
							_elm_community$list_extra$List_Extra$andThen,
							function (c) {
								return A2(
									_elm_community$list_extra$List_Extra$andThen,
									function (d) {
										return {
											ctor: '::',
											_0: A4(f, a, b, c, d),
											_1: {ctor: '[]'}
										};
									},
									ld);
							},
							lc);
					},
					lb);
			},
			la);
	});
var _elm_community$list_extra$List_Extra$andMap = F2(
	function (l, fl) {
		return A3(
			_elm_lang$core$List$map2,
			F2(
				function (x, y) {
					return x(y);
				}),
			fl,
			l);
	});
var _elm_community$list_extra$List_Extra$uniqueHelp = F4(
	function (f, existing, remaining, accumulator) {
		uniqueHelp:
		while (true) {
			var _p73 = remaining;
			if (_p73.ctor === '[]') {
				return _elm_lang$core$List$reverse(accumulator);
			} else {
				var _p75 = _p73._1;
				var _p74 = _p73._0;
				var computedFirst = f(_p74);
				if (A2(_elm_lang$core$Set$member, computedFirst, existing)) {
					var _v66 = f,
						_v67 = existing,
						_v68 = _p75,
						_v69 = accumulator;
					f = _v66;
					existing = _v67;
					remaining = _v68;
					accumulator = _v69;
					continue uniqueHelp;
				} else {
					var _v70 = f,
						_v71 = A2(_elm_lang$core$Set$insert, computedFirst, existing),
						_v72 = _p75,
						_v73 = {ctor: '::', _0: _p74, _1: accumulator};
					f = _v70;
					existing = _v71;
					remaining = _v72;
					accumulator = _v73;
					continue uniqueHelp;
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$uniqueBy = F2(
	function (f, list) {
		return A4(
			_elm_community$list_extra$List_Extra$uniqueHelp,
			f,
			_elm_lang$core$Set$empty,
			list,
			{ctor: '[]'});
	});
var _elm_community$list_extra$List_Extra$allDifferentBy = F2(
	function (f, list) {
		return _elm_lang$core$Native_Utils.eq(
			_elm_lang$core$List$length(list),
			_elm_lang$core$List$length(
				A2(_elm_community$list_extra$List_Extra$uniqueBy, f, list)));
	});
var _elm_community$list_extra$List_Extra$allDifferent = function (list) {
	return A2(_elm_community$list_extra$List_Extra$allDifferentBy, _elm_lang$core$Basics$identity, list);
};
var _elm_community$list_extra$List_Extra$unique = function (list) {
	return A4(
		_elm_community$list_extra$List_Extra$uniqueHelp,
		_elm_lang$core$Basics$identity,
		_elm_lang$core$Set$empty,
		list,
		{ctor: '[]'});
};
var _elm_community$list_extra$List_Extra$dropWhile = F2(
	function (predicate, list) {
		dropWhile:
		while (true) {
			var _p76 = list;
			if (_p76.ctor === '[]') {
				return {ctor: '[]'};
			} else {
				if (predicate(_p76._0)) {
					var _v75 = predicate,
						_v76 = _p76._1;
					predicate = _v75;
					list = _v76;
					continue dropWhile;
				} else {
					return list;
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$takeWhile = function (predicate) {
	var takeWhileMemo = F2(
		function (memo, list) {
			takeWhileMemo:
			while (true) {
				var _p77 = list;
				if (_p77.ctor === '[]') {
					return _elm_lang$core$List$reverse(memo);
				} else {
					var _p78 = _p77._0;
					if (predicate(_p78)) {
						var _v78 = {ctor: '::', _0: _p78, _1: memo},
							_v79 = _p77._1;
						memo = _v78;
						list = _v79;
						continue takeWhileMemo;
					} else {
						return _elm_lang$core$List$reverse(memo);
					}
				}
			}
		});
	return takeWhileMemo(
		{ctor: '[]'});
};
var _elm_community$list_extra$List_Extra$span = F2(
	function (p, xs) {
		return {
			ctor: '_Tuple2',
			_0: A2(_elm_community$list_extra$List_Extra$takeWhile, p, xs),
			_1: A2(_elm_community$list_extra$List_Extra$dropWhile, p, xs)
		};
	});
var _elm_community$list_extra$List_Extra$break = function (p) {
	return _elm_community$list_extra$List_Extra$span(
		function (_p79) {
			return !p(_p79);
		});
};
var _elm_community$list_extra$List_Extra$groupWhile = F2(
	function (eq, xs_) {
		var _p80 = xs_;
		if (_p80.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			var _p82 = _p80._0;
			var _p81 = A2(
				_elm_community$list_extra$List_Extra$span,
				eq(_p82),
				_p80._1);
			var ys = _p81._0;
			var zs = _p81._1;
			return {
				ctor: '::',
				_0: {ctor: '::', _0: _p82, _1: ys},
				_1: A2(_elm_community$list_extra$List_Extra$groupWhile, eq, zs)
			};
		}
	});
var _elm_community$list_extra$List_Extra$group = _elm_community$list_extra$List_Extra$groupWhile(
	F2(
		function (x, y) {
			return _elm_lang$core$Native_Utils.eq(x, y);
		}));
var _elm_community$list_extra$List_Extra$minimumBy = F2(
	function (f, ls) {
		var minBy = F2(
			function (x, _p83) {
				var _p84 = _p83;
				var _p85 = _p84._1;
				var fx = f(x);
				return (_elm_lang$core$Native_Utils.cmp(fx, _p85) < 0) ? {ctor: '_Tuple2', _0: x, _1: fx} : {ctor: '_Tuple2', _0: _p84._0, _1: _p85};
			});
		var _p86 = ls;
		if (_p86.ctor === '::') {
			if (_p86._1.ctor === '[]') {
				return _elm_lang$core$Maybe$Just(_p86._0);
			} else {
				var _p87 = _p86._0;
				return _elm_lang$core$Maybe$Just(
					_elm_lang$core$Tuple$first(
						A3(
							_elm_lang$core$List$foldl,
							minBy,
							{
								ctor: '_Tuple2',
								_0: _p87,
								_1: f(_p87)
							},
							_p86._1)));
			}
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_community$list_extra$List_Extra$maximumBy = F2(
	function (f, ls) {
		var maxBy = F2(
			function (x, _p88) {
				var _p89 = _p88;
				var _p90 = _p89._1;
				var fx = f(x);
				return (_elm_lang$core$Native_Utils.cmp(fx, _p90) > 0) ? {ctor: '_Tuple2', _0: x, _1: fx} : {ctor: '_Tuple2', _0: _p89._0, _1: _p90};
			});
		var _p91 = ls;
		if (_p91.ctor === '::') {
			if (_p91._1.ctor === '[]') {
				return _elm_lang$core$Maybe$Just(_p91._0);
			} else {
				var _p92 = _p91._0;
				return _elm_lang$core$Maybe$Just(
					_elm_lang$core$Tuple$first(
						A3(
							_elm_lang$core$List$foldl,
							maxBy,
							{
								ctor: '_Tuple2',
								_0: _p92,
								_1: f(_p92)
							},
							_p91._1)));
			}
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_community$list_extra$List_Extra$uncons = function (xs) {
	var _p93 = xs;
	if (_p93.ctor === '[]') {
		return _elm_lang$core$Maybe$Nothing;
	} else {
		return _elm_lang$core$Maybe$Just(
			{ctor: '_Tuple2', _0: _p93._0, _1: _p93._1});
	}
};
var _elm_community$list_extra$List_Extra$swapAt = F3(
	function (index1, index2, l) {
		swapAt:
		while (true) {
			if (_elm_lang$core$Native_Utils.eq(index1, index2) || (_elm_lang$core$Native_Utils.cmp(index1, 0) < 0)) {
				return l;
			} else {
				if (_elm_lang$core$Native_Utils.cmp(index1, index2) > 0) {
					var _v86 = index2,
						_v87 = index1,
						_v88 = l;
					index1 = _v86;
					index2 = _v87;
					l = _v88;
					continue swapAt;
				} else {
					var _p94 = A2(_elm_community$list_extra$List_Extra$splitAt, index1, l);
					var part1 = _p94._0;
					var tail1 = _p94._1;
					var _p95 = A2(_elm_community$list_extra$List_Extra$splitAt, index2 - index1, tail1);
					var head2 = _p95._0;
					var tail2 = _p95._1;
					var _p96 = {
						ctor: '_Tuple2',
						_0: _elm_community$list_extra$List_Extra$uncons(head2),
						_1: _elm_community$list_extra$List_Extra$uncons(tail2)
					};
					if (((((_p96.ctor === '_Tuple2') && (_p96._0.ctor === 'Just')) && (_p96._0._0.ctor === '_Tuple2')) && (_p96._1.ctor === 'Just')) && (_p96._1._0.ctor === '_Tuple2')) {
						return _elm_lang$core$List$concat(
							{
								ctor: '::',
								_0: part1,
								_1: {
									ctor: '::',
									_0: {ctor: '::', _0: _p96._1._0._0, _1: _p96._0._0._1},
									_1: {
										ctor: '::',
										_0: {ctor: '::', _0: _p96._0._0._0, _1: _p96._1._0._1},
										_1: {ctor: '[]'}
									}
								}
							});
					} else {
						return l;
					}
				}
			}
		}
	});
var _elm_community$list_extra$List_Extra$cycleHelp = F3(
	function (acc, n, list) {
		cycleHelp:
		while (true) {
			if (_elm_lang$core$Native_Utils.cmp(n, 0) > 0) {
				var _v90 = A2(_elm_community$list_extra$List_Extra$reverseAppend, list, acc),
					_v91 = n - 1,
					_v92 = list;
				acc = _v90;
				n = _v91;
				list = _v92;
				continue cycleHelp;
			} else {
				return acc;
			}
		}
	});
var _elm_community$list_extra$List_Extra$cycle = F2(
	function (len, list) {
		var cycleLength = _elm_lang$core$List$length(list);
		return (_elm_lang$core$Native_Utils.eq(cycleLength, 0) || _elm_lang$core$Native_Utils.eq(cycleLength, len)) ? list : ((_elm_lang$core$Native_Utils.cmp(cycleLength, len) < 0) ? _elm_lang$core$List$reverse(
			A2(
				_elm_community$list_extra$List_Extra$reverseAppend,
				A2(
					_elm_lang$core$List$take,
					A2(_elm_lang$core$Basics$rem, len, cycleLength),
					list),
				A3(
					_elm_community$list_extra$List_Extra$cycleHelp,
					{ctor: '[]'},
					(len / cycleLength) | 0,
					list))) : A2(_elm_lang$core$List$take, len, list));
	});
var _elm_community$list_extra$List_Extra$initialize = F2(
	function (n, f) {
		var step = F2(
			function (i, acc) {
				step:
				while (true) {
					if (_elm_lang$core$Native_Utils.cmp(i, 0) < 0) {
						return acc;
					} else {
						var _v93 = i - 1,
							_v94 = {
							ctor: '::',
							_0: f(i),
							_1: acc
						};
						i = _v93;
						acc = _v94;
						continue step;
					}
				}
			});
		return A2(
			step,
			n - 1,
			{ctor: '[]'});
	});
var _elm_community$list_extra$List_Extra$iterate = F2(
	function (f, x) {
		var _p97 = f(x);
		if (_p97.ctor === 'Just') {
			return {
				ctor: '::',
				_0: x,
				_1: A2(_elm_community$list_extra$List_Extra$iterate, f, _p97._0)
			};
		} else {
			return {
				ctor: '::',
				_0: x,
				_1: {ctor: '[]'}
			};
		}
	});
var _elm_community$list_extra$List_Extra$getAt = F2(
	function (idx, xs) {
		return (_elm_lang$core$Native_Utils.cmp(idx, 0) < 0) ? _elm_lang$core$Maybe$Nothing : _elm_lang$core$List$head(
			A2(_elm_lang$core$List$drop, idx, xs));
	});
var _elm_community$list_extra$List_Extra_ops = _elm_community$list_extra$List_Extra_ops || {};
_elm_community$list_extra$List_Extra_ops['!!'] = _elm_lang$core$Basics$flip(_elm_community$list_extra$List_Extra$getAt);
var _elm_community$list_extra$List_Extra$init = function (items) {
	var _p98 = items;
	if (_p98.ctor === '[]') {
		return _elm_lang$core$Maybe$Nothing;
	} else {
		return A2(
			_elm_lang$core$Maybe$map,
			_elm_lang$core$List$reverse,
			_elm_lang$core$List$tail(
				_elm_lang$core$List$reverse(_p98)));
	}
};
var _elm_community$list_extra$List_Extra$last = function (items) {
	last:
	while (true) {
		var _p99 = items;
		if (_p99.ctor === '[]') {
			return _elm_lang$core$Maybe$Nothing;
		} else {
			if (_p99._1.ctor === '[]') {
				return _elm_lang$core$Maybe$Just(_p99._0);
			} else {
				var _v98 = _p99._1;
				items = _v98;
				continue last;
			}
		}
	}
};

//import Native.List //

var _elm_lang$core$Native_Array = function() {

// A RRB-Tree has two distinct data types.
// Leaf -> "height"  is always 0
//         "table"   is an array of elements
// Node -> "height"  is always greater than 0
//         "table"   is an array of child nodes
//         "lengths" is an array of accumulated lengths of the child nodes

// M is the maximal table size. 32 seems fast. E is the allowed increase
// of search steps when concatting to find an index. Lower values will
// decrease balancing, but will increase search steps.
var M = 32;
var E = 2;

// An empty array.
var empty = {
	ctor: '_Array',
	height: 0,
	table: []
};


function get(i, array)
{
	if (i < 0 || i >= length(array))
	{
		throw new Error(
			'Index ' + i + ' is out of range. Check the length of ' +
			'your array first or use getMaybe or getWithDefault.');
	}
	return unsafeGet(i, array);
}


function unsafeGet(i, array)
{
	for (var x = array.height; x > 0; x--)
	{
		var slot = i >> (x * 5);
		while (array.lengths[slot] <= i)
		{
			slot++;
		}
		if (slot > 0)
		{
			i -= array.lengths[slot - 1];
		}
		array = array.table[slot];
	}
	return array.table[i];
}


// Sets the value at the index i. Only the nodes leading to i will get
// copied and updated.
function set(i, item, array)
{
	if (i < 0 || length(array) <= i)
	{
		return array;
	}
	return unsafeSet(i, item, array);
}


function unsafeSet(i, item, array)
{
	array = nodeCopy(array);

	if (array.height === 0)
	{
		array.table[i] = item;
	}
	else
	{
		var slot = getSlot(i, array);
		if (slot > 0)
		{
			i -= array.lengths[slot - 1];
		}
		array.table[slot] = unsafeSet(i, item, array.table[slot]);
	}
	return array;
}


function initialize(len, f)
{
	if (len <= 0)
	{
		return empty;
	}
	var h = Math.floor( Math.log(len) / Math.log(M) );
	return initialize_(f, h, 0, len);
}

function initialize_(f, h, from, to)
{
	if (h === 0)
	{
		var table = new Array((to - from) % (M + 1));
		for (var i = 0; i < table.length; i++)
		{
		  table[i] = f(from + i);
		}
		return {
			ctor: '_Array',
			height: 0,
			table: table
		};
	}

	var step = Math.pow(M, h);
	var table = new Array(Math.ceil((to - from) / step));
	var lengths = new Array(table.length);
	for (var i = 0; i < table.length; i++)
	{
		table[i] = initialize_(f, h - 1, from + (i * step), Math.min(from + ((i + 1) * step), to));
		lengths[i] = length(table[i]) + (i > 0 ? lengths[i-1] : 0);
	}
	return {
		ctor: '_Array',
		height: h,
		table: table,
		lengths: lengths
	};
}

function fromList(list)
{
	if (list.ctor === '[]')
	{
		return empty;
	}

	// Allocate M sized blocks (table) and write list elements to it.
	var table = new Array(M);
	var nodes = [];
	var i = 0;

	while (list.ctor !== '[]')
	{
		table[i] = list._0;
		list = list._1;
		i++;

		// table is full, so we can push a leaf containing it into the
		// next node.
		if (i === M)
		{
			var leaf = {
				ctor: '_Array',
				height: 0,
				table: table
			};
			fromListPush(leaf, nodes);
			table = new Array(M);
			i = 0;
		}
	}

	// Maybe there is something left on the table.
	if (i > 0)
	{
		var leaf = {
			ctor: '_Array',
			height: 0,
			table: table.splice(0, i)
		};
		fromListPush(leaf, nodes);
	}

	// Go through all of the nodes and eventually push them into higher nodes.
	for (var h = 0; h < nodes.length - 1; h++)
	{
		if (nodes[h].table.length > 0)
		{
			fromListPush(nodes[h], nodes);
		}
	}

	var head = nodes[nodes.length - 1];
	if (head.height > 0 && head.table.length === 1)
	{
		return head.table[0];
	}
	else
	{
		return head;
	}
}

// Push a node into a higher node as a child.
function fromListPush(toPush, nodes)
{
	var h = toPush.height;

	// Maybe the node on this height does not exist.
	if (nodes.length === h)
	{
		var node = {
			ctor: '_Array',
			height: h + 1,
			table: [],
			lengths: []
		};
		nodes.push(node);
	}

	nodes[h].table.push(toPush);
	var len = length(toPush);
	if (nodes[h].lengths.length > 0)
	{
		len += nodes[h].lengths[nodes[h].lengths.length - 1];
	}
	nodes[h].lengths.push(len);

	if (nodes[h].table.length === M)
	{
		fromListPush(nodes[h], nodes);
		nodes[h] = {
			ctor: '_Array',
			height: h + 1,
			table: [],
			lengths: []
		};
	}
}

// Pushes an item via push_ to the bottom right of a tree.
function push(item, a)
{
	var pushed = push_(item, a);
	if (pushed !== null)
	{
		return pushed;
	}

	var newTree = create(item, a.height);
	return siblise(a, newTree);
}

// Recursively tries to push an item to the bottom-right most
// tree possible. If there is no space left for the item,
// null will be returned.
function push_(item, a)
{
	// Handle resursion stop at leaf level.
	if (a.height === 0)
	{
		if (a.table.length < M)
		{
			var newA = {
				ctor: '_Array',
				height: 0,
				table: a.table.slice()
			};
			newA.table.push(item);
			return newA;
		}
		else
		{
		  return null;
		}
	}

	// Recursively push
	var pushed = push_(item, botRight(a));

	// There was space in the bottom right tree, so the slot will
	// be updated.
	if (pushed !== null)
	{
		var newA = nodeCopy(a);
		newA.table[newA.table.length - 1] = pushed;
		newA.lengths[newA.lengths.length - 1]++;
		return newA;
	}

	// When there was no space left, check if there is space left
	// for a new slot with a tree which contains only the item
	// at the bottom.
	if (a.table.length < M)
	{
		var newSlot = create(item, a.height - 1);
		var newA = nodeCopy(a);
		newA.table.push(newSlot);
		newA.lengths.push(newA.lengths[newA.lengths.length - 1] + length(newSlot));
		return newA;
	}
	else
	{
		return null;
	}
}

// Converts an array into a list of elements.
function toList(a)
{
	return toList_(_elm_lang$core$Native_List.Nil, a);
}

function toList_(list, a)
{
	for (var i = a.table.length - 1; i >= 0; i--)
	{
		list =
			a.height === 0
				? _elm_lang$core$Native_List.Cons(a.table[i], list)
				: toList_(list, a.table[i]);
	}
	return list;
}

// Maps a function over the elements of an array.
function map(f, a)
{
	var newA = {
		ctor: '_Array',
		height: a.height,
		table: new Array(a.table.length)
	};
	if (a.height > 0)
	{
		newA.lengths = a.lengths;
	}
	for (var i = 0; i < a.table.length; i++)
	{
		newA.table[i] =
			a.height === 0
				? f(a.table[i])
				: map(f, a.table[i]);
	}
	return newA;
}

// Maps a function over the elements with their index as first argument.
function indexedMap(f, a)
{
	return indexedMap_(f, a, 0);
}

function indexedMap_(f, a, from)
{
	var newA = {
		ctor: '_Array',
		height: a.height,
		table: new Array(a.table.length)
	};
	if (a.height > 0)
	{
		newA.lengths = a.lengths;
	}
	for (var i = 0; i < a.table.length; i++)
	{
		newA.table[i] =
			a.height === 0
				? A2(f, from + i, a.table[i])
				: indexedMap_(f, a.table[i], i == 0 ? from : from + a.lengths[i - 1]);
	}
	return newA;
}

function foldl(f, b, a)
{
	if (a.height === 0)
	{
		for (var i = 0; i < a.table.length; i++)
		{
			b = A2(f, a.table[i], b);
		}
	}
	else
	{
		for (var i = 0; i < a.table.length; i++)
		{
			b = foldl(f, b, a.table[i]);
		}
	}
	return b;
}

function foldr(f, b, a)
{
	if (a.height === 0)
	{
		for (var i = a.table.length; i--; )
		{
			b = A2(f, a.table[i], b);
		}
	}
	else
	{
		for (var i = a.table.length; i--; )
		{
			b = foldr(f, b, a.table[i]);
		}
	}
	return b;
}

// TODO: currently, it slices the right, then the left. This can be
// optimized.
function slice(from, to, a)
{
	if (from < 0)
	{
		from += length(a);
	}
	if (to < 0)
	{
		to += length(a);
	}
	return sliceLeft(from, sliceRight(to, a));
}

function sliceRight(to, a)
{
	if (to === length(a))
	{
		return a;
	}

	// Handle leaf level.
	if (a.height === 0)
	{
		var newA = { ctor:'_Array', height:0 };
		newA.table = a.table.slice(0, to);
		return newA;
	}

	// Slice the right recursively.
	var right = getSlot(to, a);
	var sliced = sliceRight(to - (right > 0 ? a.lengths[right - 1] : 0), a.table[right]);

	// Maybe the a node is not even needed, as sliced contains the whole slice.
	if (right === 0)
	{
		return sliced;
	}

	// Create new node.
	var newA = {
		ctor: '_Array',
		height: a.height,
		table: a.table.slice(0, right),
		lengths: a.lengths.slice(0, right)
	};
	if (sliced.table.length > 0)
	{
		newA.table[right] = sliced;
		newA.lengths[right] = length(sliced) + (right > 0 ? newA.lengths[right - 1] : 0);
	}
	return newA;
}

function sliceLeft(from, a)
{
	if (from === 0)
	{
		return a;
	}

	// Handle leaf level.
	if (a.height === 0)
	{
		var newA = { ctor:'_Array', height:0 };
		newA.table = a.table.slice(from, a.table.length + 1);
		return newA;
	}

	// Slice the left recursively.
	var left = getSlot(from, a);
	var sliced = sliceLeft(from - (left > 0 ? a.lengths[left - 1] : 0), a.table[left]);

	// Maybe the a node is not even needed, as sliced contains the whole slice.
	if (left === a.table.length - 1)
	{
		return sliced;
	}

	// Create new node.
	var newA = {
		ctor: '_Array',
		height: a.height,
		table: a.table.slice(left, a.table.length + 1),
		lengths: new Array(a.table.length - left)
	};
	newA.table[0] = sliced;
	var len = 0;
	for (var i = 0; i < newA.table.length; i++)
	{
		len += length(newA.table[i]);
		newA.lengths[i] = len;
	}

	return newA;
}

// Appends two trees.
function append(a,b)
{
	if (a.table.length === 0)
	{
		return b;
	}
	if (b.table.length === 0)
	{
		return a;
	}

	var c = append_(a, b);

	// Check if both nodes can be crunshed together.
	if (c[0].table.length + c[1].table.length <= M)
	{
		if (c[0].table.length === 0)
		{
			return c[1];
		}
		if (c[1].table.length === 0)
		{
			return c[0];
		}

		// Adjust .table and .lengths
		c[0].table = c[0].table.concat(c[1].table);
		if (c[0].height > 0)
		{
			var len = length(c[0]);
			for (var i = 0; i < c[1].lengths.length; i++)
			{
				c[1].lengths[i] += len;
			}
			c[0].lengths = c[0].lengths.concat(c[1].lengths);
		}

		return c[0];
	}

	if (c[0].height > 0)
	{
		var toRemove = calcToRemove(a, b);
		if (toRemove > E)
		{
			c = shuffle(c[0], c[1], toRemove);
		}
	}

	return siblise(c[0], c[1]);
}

// Returns an array of two nodes; right and left. One node _may_ be empty.
function append_(a, b)
{
	if (a.height === 0 && b.height === 0)
	{
		return [a, b];
	}

	if (a.height !== 1 || b.height !== 1)
	{
		if (a.height === b.height)
		{
			a = nodeCopy(a);
			b = nodeCopy(b);
			var appended = append_(botRight(a), botLeft(b));

			insertRight(a, appended[1]);
			insertLeft(b, appended[0]);
		}
		else if (a.height > b.height)
		{
			a = nodeCopy(a);
			var appended = append_(botRight(a), b);

			insertRight(a, appended[0]);
			b = parentise(appended[1], appended[1].height + 1);
		}
		else
		{
			b = nodeCopy(b);
			var appended = append_(a, botLeft(b));

			var left = appended[0].table.length === 0 ? 0 : 1;
			var right = left === 0 ? 1 : 0;
			insertLeft(b, appended[left]);
			a = parentise(appended[right], appended[right].height + 1);
		}
	}

	// Check if balancing is needed and return based on that.
	if (a.table.length === 0 || b.table.length === 0)
	{
		return [a, b];
	}

	var toRemove = calcToRemove(a, b);
	if (toRemove <= E)
	{
		return [a, b];
	}
	return shuffle(a, b, toRemove);
}

// Helperfunctions for append_. Replaces a child node at the side of the parent.
function insertRight(parent, node)
{
	var index = parent.table.length - 1;
	parent.table[index] = node;
	parent.lengths[index] = length(node);
	parent.lengths[index] += index > 0 ? parent.lengths[index - 1] : 0;
}

function insertLeft(parent, node)
{
	if (node.table.length > 0)
	{
		parent.table[0] = node;
		parent.lengths[0] = length(node);

		var len = length(parent.table[0]);
		for (var i = 1; i < parent.lengths.length; i++)
		{
			len += length(parent.table[i]);
			parent.lengths[i] = len;
		}
	}
	else
	{
		parent.table.shift();
		for (var i = 1; i < parent.lengths.length; i++)
		{
			parent.lengths[i] = parent.lengths[i] - parent.lengths[0];
		}
		parent.lengths.shift();
	}
}

// Returns the extra search steps for E. Refer to the paper.
function calcToRemove(a, b)
{
	var subLengths = 0;
	for (var i = 0; i < a.table.length; i++)
	{
		subLengths += a.table[i].table.length;
	}
	for (var i = 0; i < b.table.length; i++)
	{
		subLengths += b.table[i].table.length;
	}

	var toRemove = a.table.length + b.table.length;
	return toRemove - (Math.floor((subLengths - 1) / M) + 1);
}

// get2, set2 and saveSlot are helpers for accessing elements over two arrays.
function get2(a, b, index)
{
	return index < a.length
		? a[index]
		: b[index - a.length];
}

function set2(a, b, index, value)
{
	if (index < a.length)
	{
		a[index] = value;
	}
	else
	{
		b[index - a.length] = value;
	}
}

function saveSlot(a, b, index, slot)
{
	set2(a.table, b.table, index, slot);

	var l = (index === 0 || index === a.lengths.length)
		? 0
		: get2(a.lengths, a.lengths, index - 1);

	set2(a.lengths, b.lengths, index, l + length(slot));
}

// Creates a node or leaf with a given length at their arrays for perfomance.
// Is only used by shuffle.
function createNode(h, length)
{
	if (length < 0)
	{
		length = 0;
	}
	var a = {
		ctor: '_Array',
		height: h,
		table: new Array(length)
	};
	if (h > 0)
	{
		a.lengths = new Array(length);
	}
	return a;
}

// Returns an array of two balanced nodes.
function shuffle(a, b, toRemove)
{
	var newA = createNode(a.height, Math.min(M, a.table.length + b.table.length - toRemove));
	var newB = createNode(a.height, newA.table.length - (a.table.length + b.table.length - toRemove));

	// Skip the slots with size M. More precise: copy the slot references
	// to the new node
	var read = 0;
	while (get2(a.table, b.table, read).table.length % M === 0)
	{
		set2(newA.table, newB.table, read, get2(a.table, b.table, read));
		set2(newA.lengths, newB.lengths, read, get2(a.lengths, b.lengths, read));
		read++;
	}

	// Pulling items from left to right, caching in a slot before writing
	// it into the new nodes.
	var write = read;
	var slot = new createNode(a.height - 1, 0);
	var from = 0;

	// If the current slot is still containing data, then there will be at
	// least one more write, so we do not break this loop yet.
	while (read - write - (slot.table.length > 0 ? 1 : 0) < toRemove)
	{
		// Find out the max possible items for copying.
		var source = get2(a.table, b.table, read);
		var to = Math.min(M - slot.table.length, source.table.length);

		// Copy and adjust size table.
		slot.table = slot.table.concat(source.table.slice(from, to));
		if (slot.height > 0)
		{
			var len = slot.lengths.length;
			for (var i = len; i < len + to - from; i++)
			{
				slot.lengths[i] = length(slot.table[i]);
				slot.lengths[i] += (i > 0 ? slot.lengths[i - 1] : 0);
			}
		}

		from += to;

		// Only proceed to next slots[i] if the current one was
		// fully copied.
		if (source.table.length <= to)
		{
			read++; from = 0;
		}

		// Only create a new slot if the current one is filled up.
		if (slot.table.length === M)
		{
			saveSlot(newA, newB, write, slot);
			slot = createNode(a.height - 1, 0);
			write++;
		}
	}

	// Cleanup after the loop. Copy the last slot into the new nodes.
	if (slot.table.length > 0)
	{
		saveSlot(newA, newB, write, slot);
		write++;
	}

	// Shift the untouched slots to the left
	while (read < a.table.length + b.table.length )
	{
		saveSlot(newA, newB, write, get2(a.table, b.table, read));
		read++;
		write++;
	}

	return [newA, newB];
}

// Navigation functions
function botRight(a)
{
	return a.table[a.table.length - 1];
}
function botLeft(a)
{
	return a.table[0];
}

// Copies a node for updating. Note that you should not use this if
// only updating only one of "table" or "lengths" for performance reasons.
function nodeCopy(a)
{
	var newA = {
		ctor: '_Array',
		height: a.height,
		table: a.table.slice()
	};
	if (a.height > 0)
	{
		newA.lengths = a.lengths.slice();
	}
	return newA;
}

// Returns how many items are in the tree.
function length(array)
{
	if (array.height === 0)
	{
		return array.table.length;
	}
	else
	{
		return array.lengths[array.lengths.length - 1];
	}
}

// Calculates in which slot of "table" the item probably is, then
// find the exact slot via forward searching in  "lengths". Returns the index.
function getSlot(i, a)
{
	var slot = i >> (5 * a.height);
	while (a.lengths[slot] <= i)
	{
		slot++;
	}
	return slot;
}

// Recursively creates a tree with a given height containing
// only the given item.
function create(item, h)
{
	if (h === 0)
	{
		return {
			ctor: '_Array',
			height: 0,
			table: [item]
		};
	}
	return {
		ctor: '_Array',
		height: h,
		table: [create(item, h - 1)],
		lengths: [1]
	};
}

// Recursively creates a tree that contains the given tree.
function parentise(tree, h)
{
	if (h === tree.height)
	{
		return tree;
	}

	return {
		ctor: '_Array',
		height: h,
		table: [parentise(tree, h - 1)],
		lengths: [length(tree)]
	};
}

// Emphasizes blood brotherhood beneath two trees.
function siblise(a, b)
{
	return {
		ctor: '_Array',
		height: a.height + 1,
		table: [a, b],
		lengths: [length(a), length(a) + length(b)]
	};
}

function toJSArray(a)
{
	var jsArray = new Array(length(a));
	toJSArray_(jsArray, 0, a);
	return jsArray;
}

function toJSArray_(jsArray, i, a)
{
	for (var t = 0; t < a.table.length; t++)
	{
		if (a.height === 0)
		{
			jsArray[i + t] = a.table[t];
		}
		else
		{
			var inc = t === 0 ? 0 : a.lengths[t - 1];
			toJSArray_(jsArray, i + inc, a.table[t]);
		}
	}
}

function fromJSArray(jsArray)
{
	if (jsArray.length === 0)
	{
		return empty;
	}
	var h = Math.floor(Math.log(jsArray.length) / Math.log(M));
	return fromJSArray_(jsArray, h, 0, jsArray.length);
}

function fromJSArray_(jsArray, h, from, to)
{
	if (h === 0)
	{
		return {
			ctor: '_Array',
			height: 0,
			table: jsArray.slice(from, to)
		};
	}

	var step = Math.pow(M, h);
	var table = new Array(Math.ceil((to - from) / step));
	var lengths = new Array(table.length);
	for (var i = 0; i < table.length; i++)
	{
		table[i] = fromJSArray_(jsArray, h - 1, from + (i * step), Math.min(from + ((i + 1) * step), to));
		lengths[i] = length(table[i]) + (i > 0 ? lengths[i - 1] : 0);
	}
	return {
		ctor: '_Array',
		height: h,
		table: table,
		lengths: lengths
	};
}

return {
	empty: empty,
	fromList: fromList,
	toList: toList,
	initialize: F2(initialize),
	append: F2(append),
	push: F2(push),
	slice: F3(slice),
	get: F2(get),
	set: F3(set),
	map: F2(map),
	indexedMap: F2(indexedMap),
	foldl: F3(foldl),
	foldr: F3(foldr),
	length: length,

	toJSArray: toJSArray,
	fromJSArray: fromJSArray
};

}();
var _elm_lang$core$Array$append = _elm_lang$core$Native_Array.append;
var _elm_lang$core$Array$length = _elm_lang$core$Native_Array.length;
var _elm_lang$core$Array$isEmpty = function (array) {
	return _elm_lang$core$Native_Utils.eq(
		_elm_lang$core$Array$length(array),
		0);
};
var _elm_lang$core$Array$slice = _elm_lang$core$Native_Array.slice;
var _elm_lang$core$Array$set = _elm_lang$core$Native_Array.set;
var _elm_lang$core$Array$get = F2(
	function (i, array) {
		return ((_elm_lang$core$Native_Utils.cmp(0, i) < 1) && (_elm_lang$core$Native_Utils.cmp(
			i,
			_elm_lang$core$Native_Array.length(array)) < 0)) ? _elm_lang$core$Maybe$Just(
			A2(_elm_lang$core$Native_Array.get, i, array)) : _elm_lang$core$Maybe$Nothing;
	});
var _elm_lang$core$Array$push = _elm_lang$core$Native_Array.push;
var _elm_lang$core$Array$empty = _elm_lang$core$Native_Array.empty;
var _elm_lang$core$Array$filter = F2(
	function (isOkay, arr) {
		var update = F2(
			function (x, xs) {
				return isOkay(x) ? A2(_elm_lang$core$Native_Array.push, x, xs) : xs;
			});
		return A3(_elm_lang$core$Native_Array.foldl, update, _elm_lang$core$Native_Array.empty, arr);
	});
var _elm_lang$core$Array$foldr = _elm_lang$core$Native_Array.foldr;
var _elm_lang$core$Array$foldl = _elm_lang$core$Native_Array.foldl;
var _elm_lang$core$Array$indexedMap = _elm_lang$core$Native_Array.indexedMap;
var _elm_lang$core$Array$map = _elm_lang$core$Native_Array.map;
var _elm_lang$core$Array$toIndexedList = function (array) {
	return A3(
		_elm_lang$core$List$map2,
		F2(
			function (v0, v1) {
				return {ctor: '_Tuple2', _0: v0, _1: v1};
			}),
		A2(
			_elm_lang$core$List$range,
			0,
			_elm_lang$core$Native_Array.length(array) - 1),
		_elm_lang$core$Native_Array.toList(array));
};
var _elm_lang$core$Array$toList = _elm_lang$core$Native_Array.toList;
var _elm_lang$core$Array$fromList = _elm_lang$core$Native_Array.fromList;
var _elm_lang$core$Array$initialize = _elm_lang$core$Native_Array.initialize;
var _elm_lang$core$Array$repeat = F2(
	function (n, e) {
		return A2(
			_elm_lang$core$Array$initialize,
			n,
			_elm_lang$core$Basics$always(e));
	});
var _elm_lang$core$Array$Array = {ctor: 'Array'};

var _elm_community$maybe_extra$Maybe_Extra$foldrValues = F2(
	function (item, list) {
		var _p0 = item;
		if (_p0.ctor === 'Nothing') {
			return list;
		} else {
			return {ctor: '::', _0: _p0._0, _1: list};
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$values = A2(
	_elm_lang$core$List$foldr,
	_elm_community$maybe_extra$Maybe_Extra$foldrValues,
	{ctor: '[]'});
var _elm_community$maybe_extra$Maybe_Extra$filter = F2(
	function (f, m) {
		var _p1 = A2(_elm_lang$core$Maybe$map, f, m);
		if ((_p1.ctor === 'Just') && (_p1._0 === true)) {
			return m;
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$traverseArray = function (f) {
	var step = F2(
		function (e, acc) {
			var _p2 = f(e);
			if (_p2.ctor === 'Nothing') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				return A2(
					_elm_lang$core$Maybe$map,
					_elm_lang$core$Array$push(_p2._0),
					acc);
			}
		});
	return A2(
		_elm_lang$core$Array$foldl,
		step,
		_elm_lang$core$Maybe$Just(_elm_lang$core$Array$empty));
};
var _elm_community$maybe_extra$Maybe_Extra$combineArray = _elm_community$maybe_extra$Maybe_Extra$traverseArray(_elm_lang$core$Basics$identity);
var _elm_community$maybe_extra$Maybe_Extra$traverse = function (f) {
	var step = F2(
		function (e, acc) {
			var _p3 = f(e);
			if (_p3.ctor === 'Nothing') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				return A2(
					_elm_lang$core$Maybe$map,
					F2(
						function (x, y) {
							return {ctor: '::', _0: x, _1: y};
						})(_p3._0),
					acc);
			}
		});
	return A2(
		_elm_lang$core$List$foldr,
		step,
		_elm_lang$core$Maybe$Just(
			{ctor: '[]'}));
};
var _elm_community$maybe_extra$Maybe_Extra$combine = _elm_community$maybe_extra$Maybe_Extra$traverse(_elm_lang$core$Basics$identity);
var _elm_community$maybe_extra$Maybe_Extra$toArray = function (m) {
	var _p4 = m;
	if (_p4.ctor === 'Nothing') {
		return _elm_lang$core$Array$empty;
	} else {
		return A2(_elm_lang$core$Array$repeat, 1, _p4._0);
	}
};
var _elm_community$maybe_extra$Maybe_Extra$toList = function (m) {
	var _p5 = m;
	if (_p5.ctor === 'Nothing') {
		return {ctor: '[]'};
	} else {
		return {
			ctor: '::',
			_0: _p5._0,
			_1: {ctor: '[]'}
		};
	}
};
var _elm_community$maybe_extra$Maybe_Extra$orElse = F2(
	function (ma, mb) {
		var _p6 = mb;
		if (_p6.ctor === 'Nothing') {
			return ma;
		} else {
			return mb;
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$orElseLazy = F2(
	function (fma, mb) {
		var _p7 = mb;
		if (_p7.ctor === 'Nothing') {
			return fma(
				{ctor: '_Tuple0'});
		} else {
			return mb;
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$orLazy = F2(
	function (ma, fmb) {
		var _p8 = ma;
		if (_p8.ctor === 'Nothing') {
			return fmb(
				{ctor: '_Tuple0'});
		} else {
			return ma;
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$or = F2(
	function (ma, mb) {
		var _p9 = ma;
		if (_p9.ctor === 'Nothing') {
			return mb;
		} else {
			return ma;
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$prev = _elm_lang$core$Maybe$map2(_elm_lang$core$Basics$always);
var _elm_community$maybe_extra$Maybe_Extra$next = _elm_lang$core$Maybe$map2(
	_elm_lang$core$Basics$flip(_elm_lang$core$Basics$always));
var _elm_community$maybe_extra$Maybe_Extra$andMap = _elm_lang$core$Maybe$map2(
	F2(
		function (x, y) {
			return y(x);
		}));
var _elm_community$maybe_extra$Maybe_Extra$unpack = F3(
	function (d, f, m) {
		var _p10 = m;
		if (_p10.ctor === 'Nothing') {
			return d(
				{ctor: '_Tuple0'});
		} else {
			return f(_p10._0);
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$unwrap = F3(
	function (d, f, m) {
		var _p11 = m;
		if (_p11.ctor === 'Nothing') {
			return d;
		} else {
			return f(_p11._0);
		}
	});
var _elm_community$maybe_extra$Maybe_Extra$isJust = function (m) {
	var _p12 = m;
	if (_p12.ctor === 'Nothing') {
		return false;
	} else {
		return true;
	}
};
var _elm_community$maybe_extra$Maybe_Extra$isNothing = function (m) {
	var _p13 = m;
	if (_p13.ctor === 'Nothing') {
		return true;
	} else {
		return false;
	}
};
var _elm_community$maybe_extra$Maybe_Extra$join = function (mx) {
	var _p14 = mx;
	if (_p14.ctor === 'Just') {
		return _p14._0;
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _elm_community$maybe_extra$Maybe_Extra_ops = _elm_community$maybe_extra$Maybe_Extra_ops || {};
_elm_community$maybe_extra$Maybe_Extra_ops['?'] = F2(
	function (mx, x) {
		return A2(_elm_lang$core$Maybe$withDefault, x, mx);
	});

var _elm_lang$core$Task$onError = _elm_lang$core$Native_Scheduler.onError;
var _elm_lang$core$Task$andThen = _elm_lang$core$Native_Scheduler.andThen;
var _elm_lang$core$Task$spawnCmd = F2(
	function (router, _p0) {
		var _p1 = _p0;
		return _elm_lang$core$Native_Scheduler.spawn(
			A2(
				_elm_lang$core$Task$andThen,
				_elm_lang$core$Platform$sendToApp(router),
				_p1._0));
	});
var _elm_lang$core$Task$fail = _elm_lang$core$Native_Scheduler.fail;
var _elm_lang$core$Task$mapError = F2(
	function (convert, task) {
		return A2(
			_elm_lang$core$Task$onError,
			function (_p2) {
				return _elm_lang$core$Task$fail(
					convert(_p2));
			},
			task);
	});
var _elm_lang$core$Task$succeed = _elm_lang$core$Native_Scheduler.succeed;
var _elm_lang$core$Task$map = F2(
	function (func, taskA) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (a) {
				return _elm_lang$core$Task$succeed(
					func(a));
			},
			taskA);
	});
var _elm_lang$core$Task$map2 = F3(
	function (func, taskA, taskB) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (a) {
				return A2(
					_elm_lang$core$Task$andThen,
					function (b) {
						return _elm_lang$core$Task$succeed(
							A2(func, a, b));
					},
					taskB);
			},
			taskA);
	});
var _elm_lang$core$Task$map3 = F4(
	function (func, taskA, taskB, taskC) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (a) {
				return A2(
					_elm_lang$core$Task$andThen,
					function (b) {
						return A2(
							_elm_lang$core$Task$andThen,
							function (c) {
								return _elm_lang$core$Task$succeed(
									A3(func, a, b, c));
							},
							taskC);
					},
					taskB);
			},
			taskA);
	});
var _elm_lang$core$Task$map4 = F5(
	function (func, taskA, taskB, taskC, taskD) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (a) {
				return A2(
					_elm_lang$core$Task$andThen,
					function (b) {
						return A2(
							_elm_lang$core$Task$andThen,
							function (c) {
								return A2(
									_elm_lang$core$Task$andThen,
									function (d) {
										return _elm_lang$core$Task$succeed(
											A4(func, a, b, c, d));
									},
									taskD);
							},
							taskC);
					},
					taskB);
			},
			taskA);
	});
var _elm_lang$core$Task$map5 = F6(
	function (func, taskA, taskB, taskC, taskD, taskE) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (a) {
				return A2(
					_elm_lang$core$Task$andThen,
					function (b) {
						return A2(
							_elm_lang$core$Task$andThen,
							function (c) {
								return A2(
									_elm_lang$core$Task$andThen,
									function (d) {
										return A2(
											_elm_lang$core$Task$andThen,
											function (e) {
												return _elm_lang$core$Task$succeed(
													A5(func, a, b, c, d, e));
											},
											taskE);
									},
									taskD);
							},
							taskC);
					},
					taskB);
			},
			taskA);
	});
var _elm_lang$core$Task$sequence = function (tasks) {
	var _p3 = tasks;
	if (_p3.ctor === '[]') {
		return _elm_lang$core$Task$succeed(
			{ctor: '[]'});
	} else {
		return A3(
			_elm_lang$core$Task$map2,
			F2(
				function (x, y) {
					return {ctor: '::', _0: x, _1: y};
				}),
			_p3._0,
			_elm_lang$core$Task$sequence(_p3._1));
	}
};
var _elm_lang$core$Task$onEffects = F3(
	function (router, commands, state) {
		return A2(
			_elm_lang$core$Task$map,
			function (_p4) {
				return {ctor: '_Tuple0'};
			},
			_elm_lang$core$Task$sequence(
				A2(
					_elm_lang$core$List$map,
					_elm_lang$core$Task$spawnCmd(router),
					commands)));
	});
var _elm_lang$core$Task$init = _elm_lang$core$Task$succeed(
	{ctor: '_Tuple0'});
var _elm_lang$core$Task$onSelfMsg = F3(
	function (_p7, _p6, _p5) {
		return _elm_lang$core$Task$succeed(
			{ctor: '_Tuple0'});
	});
var _elm_lang$core$Task$command = _elm_lang$core$Native_Platform.leaf('Task');
var _elm_lang$core$Task$Perform = function (a) {
	return {ctor: 'Perform', _0: a};
};
var _elm_lang$core$Task$perform = F2(
	function (toMessage, task) {
		return _elm_lang$core$Task$command(
			_elm_lang$core$Task$Perform(
				A2(_elm_lang$core$Task$map, toMessage, task)));
	});
var _elm_lang$core$Task$attempt = F2(
	function (resultToMessage, task) {
		return _elm_lang$core$Task$command(
			_elm_lang$core$Task$Perform(
				A2(
					_elm_lang$core$Task$onError,
					function (_p8) {
						return _elm_lang$core$Task$succeed(
							resultToMessage(
								_elm_lang$core$Result$Err(_p8)));
					},
					A2(
						_elm_lang$core$Task$andThen,
						function (_p9) {
							return _elm_lang$core$Task$succeed(
								resultToMessage(
									_elm_lang$core$Result$Ok(_p9)));
						},
						task))));
	});
var _elm_lang$core$Task$cmdMap = F2(
	function (tagger, _p10) {
		var _p11 = _p10;
		return _elm_lang$core$Task$Perform(
			A2(_elm_lang$core$Task$map, tagger, _p11._0));
	});
_elm_lang$core$Native_Platform.effectManagers['Task'] = {pkg: 'elm-lang/core', init: _elm_lang$core$Task$init, onEffects: _elm_lang$core$Task$onEffects, onSelfMsg: _elm_lang$core$Task$onSelfMsg, tag: 'cmd', cmdMap: _elm_lang$core$Task$cmdMap};

//import Native.Scheduler //

var _elm_lang$core$Native_Time = function() {

var now = _elm_lang$core$Native_Scheduler.nativeBinding(function(callback)
{
	callback(_elm_lang$core$Native_Scheduler.succeed(Date.now()));
});

function setInterval_(interval, task)
{
	return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback)
	{
		var id = setInterval(function() {
			_elm_lang$core$Native_Scheduler.rawSpawn(task);
		}, interval);

		return function() { clearInterval(id); };
	});
}

return {
	now: now,
	setInterval_: F2(setInterval_)
};

}();
var _elm_lang$core$Time$setInterval = _elm_lang$core$Native_Time.setInterval_;
var _elm_lang$core$Time$spawnHelp = F3(
	function (router, intervals, processes) {
		var _p0 = intervals;
		if (_p0.ctor === '[]') {
			return _elm_lang$core$Task$succeed(processes);
		} else {
			var _p1 = _p0._0;
			var spawnRest = function (id) {
				return A3(
					_elm_lang$core$Time$spawnHelp,
					router,
					_p0._1,
					A3(_elm_lang$core$Dict$insert, _p1, id, processes));
			};
			var spawnTimer = _elm_lang$core$Native_Scheduler.spawn(
				A2(
					_elm_lang$core$Time$setInterval,
					_p1,
					A2(_elm_lang$core$Platform$sendToSelf, router, _p1)));
			return A2(_elm_lang$core$Task$andThen, spawnRest, spawnTimer);
		}
	});
var _elm_lang$core$Time$addMySub = F2(
	function (_p2, state) {
		var _p3 = _p2;
		var _p6 = _p3._1;
		var _p5 = _p3._0;
		var _p4 = A2(_elm_lang$core$Dict$get, _p5, state);
		if (_p4.ctor === 'Nothing') {
			return A3(
				_elm_lang$core$Dict$insert,
				_p5,
				{
					ctor: '::',
					_0: _p6,
					_1: {ctor: '[]'}
				},
				state);
		} else {
			return A3(
				_elm_lang$core$Dict$insert,
				_p5,
				{ctor: '::', _0: _p6, _1: _p4._0},
				state);
		}
	});
var _elm_lang$core$Time$inMilliseconds = function (t) {
	return t;
};
var _elm_lang$core$Time$millisecond = 1;
var _elm_lang$core$Time$second = 1000 * _elm_lang$core$Time$millisecond;
var _elm_lang$core$Time$minute = 60 * _elm_lang$core$Time$second;
var _elm_lang$core$Time$hour = 60 * _elm_lang$core$Time$minute;
var _elm_lang$core$Time$inHours = function (t) {
	return t / _elm_lang$core$Time$hour;
};
var _elm_lang$core$Time$inMinutes = function (t) {
	return t / _elm_lang$core$Time$minute;
};
var _elm_lang$core$Time$inSeconds = function (t) {
	return t / _elm_lang$core$Time$second;
};
var _elm_lang$core$Time$now = _elm_lang$core$Native_Time.now;
var _elm_lang$core$Time$onSelfMsg = F3(
	function (router, interval, state) {
		var _p7 = A2(_elm_lang$core$Dict$get, interval, state.taggers);
		if (_p7.ctor === 'Nothing') {
			return _elm_lang$core$Task$succeed(state);
		} else {
			var tellTaggers = function (time) {
				return _elm_lang$core$Task$sequence(
					A2(
						_elm_lang$core$List$map,
						function (tagger) {
							return A2(
								_elm_lang$core$Platform$sendToApp,
								router,
								tagger(time));
						},
						_p7._0));
			};
			return A2(
				_elm_lang$core$Task$andThen,
				function (_p8) {
					return _elm_lang$core$Task$succeed(state);
				},
				A2(_elm_lang$core$Task$andThen, tellTaggers, _elm_lang$core$Time$now));
		}
	});
var _elm_lang$core$Time$subscription = _elm_lang$core$Native_Platform.leaf('Time');
var _elm_lang$core$Time$State = F2(
	function (a, b) {
		return {taggers: a, processes: b};
	});
var _elm_lang$core$Time$init = _elm_lang$core$Task$succeed(
	A2(_elm_lang$core$Time$State, _elm_lang$core$Dict$empty, _elm_lang$core$Dict$empty));
var _elm_lang$core$Time$onEffects = F3(
	function (router, subs, _p9) {
		var _p10 = _p9;
		var rightStep = F3(
			function (_p12, id, _p11) {
				var _p13 = _p11;
				return {
					ctor: '_Tuple3',
					_0: _p13._0,
					_1: _p13._1,
					_2: A2(
						_elm_lang$core$Task$andThen,
						function (_p14) {
							return _p13._2;
						},
						_elm_lang$core$Native_Scheduler.kill(id))
				};
			});
		var bothStep = F4(
			function (interval, taggers, id, _p15) {
				var _p16 = _p15;
				return {
					ctor: '_Tuple3',
					_0: _p16._0,
					_1: A3(_elm_lang$core$Dict$insert, interval, id, _p16._1),
					_2: _p16._2
				};
			});
		var leftStep = F3(
			function (interval, taggers, _p17) {
				var _p18 = _p17;
				return {
					ctor: '_Tuple3',
					_0: {ctor: '::', _0: interval, _1: _p18._0},
					_1: _p18._1,
					_2: _p18._2
				};
			});
		var newTaggers = A3(_elm_lang$core$List$foldl, _elm_lang$core$Time$addMySub, _elm_lang$core$Dict$empty, subs);
		var _p19 = A6(
			_elm_lang$core$Dict$merge,
			leftStep,
			bothStep,
			rightStep,
			newTaggers,
			_p10.processes,
			{
				ctor: '_Tuple3',
				_0: {ctor: '[]'},
				_1: _elm_lang$core$Dict$empty,
				_2: _elm_lang$core$Task$succeed(
					{ctor: '_Tuple0'})
			});
		var spawnList = _p19._0;
		var existingDict = _p19._1;
		var killTask = _p19._2;
		return A2(
			_elm_lang$core$Task$andThen,
			function (newProcesses) {
				return _elm_lang$core$Task$succeed(
					A2(_elm_lang$core$Time$State, newTaggers, newProcesses));
			},
			A2(
				_elm_lang$core$Task$andThen,
				function (_p20) {
					return A3(_elm_lang$core$Time$spawnHelp, router, spawnList, existingDict);
				},
				killTask));
	});
var _elm_lang$core$Time$Every = F2(
	function (a, b) {
		return {ctor: 'Every', _0: a, _1: b};
	});
var _elm_lang$core$Time$every = F2(
	function (interval, tagger) {
		return _elm_lang$core$Time$subscription(
			A2(_elm_lang$core$Time$Every, interval, tagger));
	});
var _elm_lang$core$Time$subMap = F2(
	function (f, _p21) {
		var _p22 = _p21;
		return A2(
			_elm_lang$core$Time$Every,
			_p22._0,
			function (_p23) {
				return f(
					_p22._1(_p23));
			});
	});
_elm_lang$core$Native_Platform.effectManagers['Time'] = {pkg: 'elm-lang/core', init: _elm_lang$core$Time$init, onEffects: _elm_lang$core$Time$onEffects, onSelfMsg: _elm_lang$core$Time$onSelfMsg, tag: 'sub', subMap: _elm_lang$core$Time$subMap};

var _elm_lang$core$Process$kill = _elm_lang$core$Native_Scheduler.kill;
var _elm_lang$core$Process$sleep = _elm_lang$core$Native_Scheduler.sleep;
var _elm_lang$core$Process$spawn = _elm_lang$core$Native_Scheduler.spawn;

var _elm_lang$core$Color$fmod = F2(
	function (f, n) {
		var integer = _elm_lang$core$Basics$floor(f);
		return (_elm_lang$core$Basics$toFloat(
			A2(_elm_lang$core$Basics_ops['%'], integer, n)) + f) - _elm_lang$core$Basics$toFloat(integer);
	});
var _elm_lang$core$Color$rgbToHsl = F3(
	function (red, green, blue) {
		var b = _elm_lang$core$Basics$toFloat(blue) / 255;
		var g = _elm_lang$core$Basics$toFloat(green) / 255;
		var r = _elm_lang$core$Basics$toFloat(red) / 255;
		var cMax = A2(
			_elm_lang$core$Basics$max,
			A2(_elm_lang$core$Basics$max, r, g),
			b);
		var cMin = A2(
			_elm_lang$core$Basics$min,
			A2(_elm_lang$core$Basics$min, r, g),
			b);
		var c = cMax - cMin;
		var lightness = (cMax + cMin) / 2;
		var saturation = _elm_lang$core$Native_Utils.eq(lightness, 0) ? 0 : (c / (1 - _elm_lang$core$Basics$abs((2 * lightness) - 1)));
		var hue = _elm_lang$core$Basics$degrees(60) * (_elm_lang$core$Native_Utils.eq(cMax, r) ? A2(_elm_lang$core$Color$fmod, (g - b) / c, 6) : (_elm_lang$core$Native_Utils.eq(cMax, g) ? (((b - r) / c) + 2) : (((r - g) / c) + 4)));
		return {ctor: '_Tuple3', _0: hue, _1: saturation, _2: lightness};
	});
var _elm_lang$core$Color$hslToRgb = F3(
	function (hue, saturation, lightness) {
		var normHue = hue / _elm_lang$core$Basics$degrees(60);
		var chroma = (1 - _elm_lang$core$Basics$abs((2 * lightness) - 1)) * saturation;
		var x = chroma * (1 - _elm_lang$core$Basics$abs(
			A2(_elm_lang$core$Color$fmod, normHue, 2) - 1));
		var _p0 = (_elm_lang$core$Native_Utils.cmp(normHue, 0) < 0) ? {ctor: '_Tuple3', _0: 0, _1: 0, _2: 0} : ((_elm_lang$core$Native_Utils.cmp(normHue, 1) < 0) ? {ctor: '_Tuple3', _0: chroma, _1: x, _2: 0} : ((_elm_lang$core$Native_Utils.cmp(normHue, 2) < 0) ? {ctor: '_Tuple3', _0: x, _1: chroma, _2: 0} : ((_elm_lang$core$Native_Utils.cmp(normHue, 3) < 0) ? {ctor: '_Tuple3', _0: 0, _1: chroma, _2: x} : ((_elm_lang$core$Native_Utils.cmp(normHue, 4) < 0) ? {ctor: '_Tuple3', _0: 0, _1: x, _2: chroma} : ((_elm_lang$core$Native_Utils.cmp(normHue, 5) < 0) ? {ctor: '_Tuple3', _0: x, _1: 0, _2: chroma} : ((_elm_lang$core$Native_Utils.cmp(normHue, 6) < 0) ? {ctor: '_Tuple3', _0: chroma, _1: 0, _2: x} : {ctor: '_Tuple3', _0: 0, _1: 0, _2: 0}))))));
		var r = _p0._0;
		var g = _p0._1;
		var b = _p0._2;
		var m = lightness - (chroma / 2);
		return {ctor: '_Tuple3', _0: r + m, _1: g + m, _2: b + m};
	});
var _elm_lang$core$Color$toRgb = function (color) {
	var _p1 = color;
	if (_p1.ctor === 'RGBA') {
		return {red: _p1._0, green: _p1._1, blue: _p1._2, alpha: _p1._3};
	} else {
		var _p2 = A3(_elm_lang$core$Color$hslToRgb, _p1._0, _p1._1, _p1._2);
		var r = _p2._0;
		var g = _p2._1;
		var b = _p2._2;
		return {
			red: _elm_lang$core$Basics$round(255 * r),
			green: _elm_lang$core$Basics$round(255 * g),
			blue: _elm_lang$core$Basics$round(255 * b),
			alpha: _p1._3
		};
	}
};
var _elm_lang$core$Color$toHsl = function (color) {
	var _p3 = color;
	if (_p3.ctor === 'HSLA') {
		return {hue: _p3._0, saturation: _p3._1, lightness: _p3._2, alpha: _p3._3};
	} else {
		var _p4 = A3(_elm_lang$core$Color$rgbToHsl, _p3._0, _p3._1, _p3._2);
		var h = _p4._0;
		var s = _p4._1;
		var l = _p4._2;
		return {hue: h, saturation: s, lightness: l, alpha: _p3._3};
	}
};
var _elm_lang$core$Color$HSLA = F4(
	function (a, b, c, d) {
		return {ctor: 'HSLA', _0: a, _1: b, _2: c, _3: d};
	});
var _elm_lang$core$Color$hsla = F4(
	function (hue, saturation, lightness, alpha) {
		return A4(
			_elm_lang$core$Color$HSLA,
			hue - _elm_lang$core$Basics$turns(
				_elm_lang$core$Basics$toFloat(
					_elm_lang$core$Basics$floor(hue / (2 * _elm_lang$core$Basics$pi)))),
			saturation,
			lightness,
			alpha);
	});
var _elm_lang$core$Color$hsl = F3(
	function (hue, saturation, lightness) {
		return A4(_elm_lang$core$Color$hsla, hue, saturation, lightness, 1);
	});
var _elm_lang$core$Color$complement = function (color) {
	var _p5 = color;
	if (_p5.ctor === 'HSLA') {
		return A4(
			_elm_lang$core$Color$hsla,
			_p5._0 + _elm_lang$core$Basics$degrees(180),
			_p5._1,
			_p5._2,
			_p5._3);
	} else {
		var _p6 = A3(_elm_lang$core$Color$rgbToHsl, _p5._0, _p5._1, _p5._2);
		var h = _p6._0;
		var s = _p6._1;
		var l = _p6._2;
		return A4(
			_elm_lang$core$Color$hsla,
			h + _elm_lang$core$Basics$degrees(180),
			s,
			l,
			_p5._3);
	}
};
var _elm_lang$core$Color$grayscale = function (p) {
	return A4(_elm_lang$core$Color$HSLA, 0, 0, 1 - p, 1);
};
var _elm_lang$core$Color$greyscale = function (p) {
	return A4(_elm_lang$core$Color$HSLA, 0, 0, 1 - p, 1);
};
var _elm_lang$core$Color$RGBA = F4(
	function (a, b, c, d) {
		return {ctor: 'RGBA', _0: a, _1: b, _2: c, _3: d};
	});
var _elm_lang$core$Color$rgba = _elm_lang$core$Color$RGBA;
var _elm_lang$core$Color$rgb = F3(
	function (r, g, b) {
		return A4(_elm_lang$core$Color$RGBA, r, g, b, 1);
	});
var _elm_lang$core$Color$lightRed = A4(_elm_lang$core$Color$RGBA, 239, 41, 41, 1);
var _elm_lang$core$Color$red = A4(_elm_lang$core$Color$RGBA, 204, 0, 0, 1);
var _elm_lang$core$Color$darkRed = A4(_elm_lang$core$Color$RGBA, 164, 0, 0, 1);
var _elm_lang$core$Color$lightOrange = A4(_elm_lang$core$Color$RGBA, 252, 175, 62, 1);
var _elm_lang$core$Color$orange = A4(_elm_lang$core$Color$RGBA, 245, 121, 0, 1);
var _elm_lang$core$Color$darkOrange = A4(_elm_lang$core$Color$RGBA, 206, 92, 0, 1);
var _elm_lang$core$Color$lightYellow = A4(_elm_lang$core$Color$RGBA, 255, 233, 79, 1);
var _elm_lang$core$Color$yellow = A4(_elm_lang$core$Color$RGBA, 237, 212, 0, 1);
var _elm_lang$core$Color$darkYellow = A4(_elm_lang$core$Color$RGBA, 196, 160, 0, 1);
var _elm_lang$core$Color$lightGreen = A4(_elm_lang$core$Color$RGBA, 138, 226, 52, 1);
var _elm_lang$core$Color$green = A4(_elm_lang$core$Color$RGBA, 115, 210, 22, 1);
var _elm_lang$core$Color$darkGreen = A4(_elm_lang$core$Color$RGBA, 78, 154, 6, 1);
var _elm_lang$core$Color$lightBlue = A4(_elm_lang$core$Color$RGBA, 114, 159, 207, 1);
var _elm_lang$core$Color$blue = A4(_elm_lang$core$Color$RGBA, 52, 101, 164, 1);
var _elm_lang$core$Color$darkBlue = A4(_elm_lang$core$Color$RGBA, 32, 74, 135, 1);
var _elm_lang$core$Color$lightPurple = A4(_elm_lang$core$Color$RGBA, 173, 127, 168, 1);
var _elm_lang$core$Color$purple = A4(_elm_lang$core$Color$RGBA, 117, 80, 123, 1);
var _elm_lang$core$Color$darkPurple = A4(_elm_lang$core$Color$RGBA, 92, 53, 102, 1);
var _elm_lang$core$Color$lightBrown = A4(_elm_lang$core$Color$RGBA, 233, 185, 110, 1);
var _elm_lang$core$Color$brown = A4(_elm_lang$core$Color$RGBA, 193, 125, 17, 1);
var _elm_lang$core$Color$darkBrown = A4(_elm_lang$core$Color$RGBA, 143, 89, 2, 1);
var _elm_lang$core$Color$black = A4(_elm_lang$core$Color$RGBA, 0, 0, 0, 1);
var _elm_lang$core$Color$white = A4(_elm_lang$core$Color$RGBA, 255, 255, 255, 1);
var _elm_lang$core$Color$lightGrey = A4(_elm_lang$core$Color$RGBA, 238, 238, 236, 1);
var _elm_lang$core$Color$grey = A4(_elm_lang$core$Color$RGBA, 211, 215, 207, 1);
var _elm_lang$core$Color$darkGrey = A4(_elm_lang$core$Color$RGBA, 186, 189, 182, 1);
var _elm_lang$core$Color$lightGray = A4(_elm_lang$core$Color$RGBA, 238, 238, 236, 1);
var _elm_lang$core$Color$gray = A4(_elm_lang$core$Color$RGBA, 211, 215, 207, 1);
var _elm_lang$core$Color$darkGray = A4(_elm_lang$core$Color$RGBA, 186, 189, 182, 1);
var _elm_lang$core$Color$lightCharcoal = A4(_elm_lang$core$Color$RGBA, 136, 138, 133, 1);
var _elm_lang$core$Color$charcoal = A4(_elm_lang$core$Color$RGBA, 85, 87, 83, 1);
var _elm_lang$core$Color$darkCharcoal = A4(_elm_lang$core$Color$RGBA, 46, 52, 54, 1);
var _elm_lang$core$Color$Radial = F5(
	function (a, b, c, d, e) {
		return {ctor: 'Radial', _0: a, _1: b, _2: c, _3: d, _4: e};
	});
var _elm_lang$core$Color$radial = _elm_lang$core$Color$Radial;
var _elm_lang$core$Color$Linear = F3(
	function (a, b, c) {
		return {ctor: 'Linear', _0: a, _1: b, _2: c};
	});
var _elm_lang$core$Color$linear = _elm_lang$core$Color$Linear;

//import Maybe, Native.Array, Native.List, Native.Utils, Result //

var _elm_lang$core$Native_Json = function() {


// CORE DECODERS

function succeed(msg)
{
	return {
		ctor: '<decoder>',
		tag: 'succeed',
		msg: msg
	};
}

function fail(msg)
{
	return {
		ctor: '<decoder>',
		tag: 'fail',
		msg: msg
	};
}

function decodePrimitive(tag)
{
	return {
		ctor: '<decoder>',
		tag: tag
	};
}

function decodeContainer(tag, decoder)
{
	return {
		ctor: '<decoder>',
		tag: tag,
		decoder: decoder
	};
}

function decodeNull(value)
{
	return {
		ctor: '<decoder>',
		tag: 'null',
		value: value
	};
}

function decodeField(field, decoder)
{
	return {
		ctor: '<decoder>',
		tag: 'field',
		field: field,
		decoder: decoder
	};
}

function decodeIndex(index, decoder)
{
	return {
		ctor: '<decoder>',
		tag: 'index',
		index: index,
		decoder: decoder
	};
}

function decodeKeyValuePairs(decoder)
{
	return {
		ctor: '<decoder>',
		tag: 'key-value',
		decoder: decoder
	};
}

function mapMany(f, decoders)
{
	return {
		ctor: '<decoder>',
		tag: 'map-many',
		func: f,
		decoders: decoders
	};
}

function andThen(callback, decoder)
{
	return {
		ctor: '<decoder>',
		tag: 'andThen',
		decoder: decoder,
		callback: callback
	};
}

function oneOf(decoders)
{
	return {
		ctor: '<decoder>',
		tag: 'oneOf',
		decoders: decoders
	};
}


// DECODING OBJECTS

function map1(f, d1)
{
	return mapMany(f, [d1]);
}

function map2(f, d1, d2)
{
	return mapMany(f, [d1, d2]);
}

function map3(f, d1, d2, d3)
{
	return mapMany(f, [d1, d2, d3]);
}

function map4(f, d1, d2, d3, d4)
{
	return mapMany(f, [d1, d2, d3, d4]);
}

function map5(f, d1, d2, d3, d4, d5)
{
	return mapMany(f, [d1, d2, d3, d4, d5]);
}

function map6(f, d1, d2, d3, d4, d5, d6)
{
	return mapMany(f, [d1, d2, d3, d4, d5, d6]);
}

function map7(f, d1, d2, d3, d4, d5, d6, d7)
{
	return mapMany(f, [d1, d2, d3, d4, d5, d6, d7]);
}

function map8(f, d1, d2, d3, d4, d5, d6, d7, d8)
{
	return mapMany(f, [d1, d2, d3, d4, d5, d6, d7, d8]);
}


// DECODE HELPERS

function ok(value)
{
	return { tag: 'ok', value: value };
}

function badPrimitive(type, value)
{
	return { tag: 'primitive', type: type, value: value };
}

function badIndex(index, nestedProblems)
{
	return { tag: 'index', index: index, rest: nestedProblems };
}

function badField(field, nestedProblems)
{
	return { tag: 'field', field: field, rest: nestedProblems };
}

function badIndex(index, nestedProblems)
{
	return { tag: 'index', index: index, rest: nestedProblems };
}

function badOneOf(problems)
{
	return { tag: 'oneOf', problems: problems };
}

function bad(msg)
{
	return { tag: 'fail', msg: msg };
}

function badToString(problem)
{
	var context = '_';
	while (problem)
	{
		switch (problem.tag)
		{
			case 'primitive':
				return 'Expecting ' + problem.type
					+ (context === '_' ? '' : ' at ' + context)
					+ ' but instead got: ' + jsToString(problem.value);

			case 'index':
				context += '[' + problem.index + ']';
				problem = problem.rest;
				break;

			case 'field':
				context += '.' + problem.field;
				problem = problem.rest;
				break;

			case 'oneOf':
				var problems = problem.problems;
				for (var i = 0; i < problems.length; i++)
				{
					problems[i] = badToString(problems[i]);
				}
				return 'I ran into the following problems'
					+ (context === '_' ? '' : ' at ' + context)
					+ ':\n\n' + problems.join('\n');

			case 'fail':
				return 'I ran into a `fail` decoder'
					+ (context === '_' ? '' : ' at ' + context)
					+ ': ' + problem.msg;
		}
	}
}

function jsToString(value)
{
	return value === undefined
		? 'undefined'
		: JSON.stringify(value);
}


// DECODE

function runOnString(decoder, string)
{
	var json;
	try
	{
		json = JSON.parse(string);
	}
	catch (e)
	{
		return _elm_lang$core$Result$Err('Given an invalid JSON: ' + e.message);
	}
	return run(decoder, json);
}

function run(decoder, value)
{
	var result = runHelp(decoder, value);
	return (result.tag === 'ok')
		? _elm_lang$core$Result$Ok(result.value)
		: _elm_lang$core$Result$Err(badToString(result));
}

function runHelp(decoder, value)
{
	switch (decoder.tag)
	{
		case 'bool':
			return (typeof value === 'boolean')
				? ok(value)
				: badPrimitive('a Bool', value);

		case 'int':
			if (typeof value !== 'number') {
				return badPrimitive('an Int', value);
			}

			if (-2147483647 < value && value < 2147483647 && (value | 0) === value) {
				return ok(value);
			}

			if (isFinite(value) && !(value % 1)) {
				return ok(value);
			}

			return badPrimitive('an Int', value);

		case 'float':
			return (typeof value === 'number')
				? ok(value)
				: badPrimitive('a Float', value);

		case 'string':
			return (typeof value === 'string')
				? ok(value)
				: (value instanceof String)
					? ok(value + '')
					: badPrimitive('a String', value);

		case 'null':
			return (value === null)
				? ok(decoder.value)
				: badPrimitive('null', value);

		case 'value':
			return ok(value);

		case 'list':
			if (!(value instanceof Array))
			{
				return badPrimitive('a List', value);
			}

			var list = _elm_lang$core$Native_List.Nil;
			for (var i = value.length; i--; )
			{
				var result = runHelp(decoder.decoder, value[i]);
				if (result.tag !== 'ok')
				{
					return badIndex(i, result)
				}
				list = _elm_lang$core$Native_List.Cons(result.value, list);
			}
			return ok(list);

		case 'array':
			if (!(value instanceof Array))
			{
				return badPrimitive('an Array', value);
			}

			var len = value.length;
			var array = new Array(len);
			for (var i = len; i--; )
			{
				var result = runHelp(decoder.decoder, value[i]);
				if (result.tag !== 'ok')
				{
					return badIndex(i, result);
				}
				array[i] = result.value;
			}
			return ok(_elm_lang$core$Native_Array.fromJSArray(array));

		case 'maybe':
			var result = runHelp(decoder.decoder, value);
			return (result.tag === 'ok')
				? ok(_elm_lang$core$Maybe$Just(result.value))
				: ok(_elm_lang$core$Maybe$Nothing);

		case 'field':
			var field = decoder.field;
			if (typeof value !== 'object' || value === null || !(field in value))
			{
				return badPrimitive('an object with a field named `' + field + '`', value);
			}

			var result = runHelp(decoder.decoder, value[field]);
			return (result.tag === 'ok') ? result : badField(field, result);

		case 'index':
			var index = decoder.index;
			if (!(value instanceof Array))
			{
				return badPrimitive('an array', value);
			}
			if (index >= value.length)
			{
				return badPrimitive('a longer array. Need index ' + index + ' but there are only ' + value.length + ' entries', value);
			}

			var result = runHelp(decoder.decoder, value[index]);
			return (result.tag === 'ok') ? result : badIndex(index, result);

		case 'key-value':
			if (typeof value !== 'object' || value === null || value instanceof Array)
			{
				return badPrimitive('an object', value);
			}

			var keyValuePairs = _elm_lang$core$Native_List.Nil;
			for (var key in value)
			{
				var result = runHelp(decoder.decoder, value[key]);
				if (result.tag !== 'ok')
				{
					return badField(key, result);
				}
				var pair = _elm_lang$core$Native_Utils.Tuple2(key, result.value);
				keyValuePairs = _elm_lang$core$Native_List.Cons(pair, keyValuePairs);
			}
			return ok(keyValuePairs);

		case 'map-many':
			var answer = decoder.func;
			var decoders = decoder.decoders;
			for (var i = 0; i < decoders.length; i++)
			{
				var result = runHelp(decoders[i], value);
				if (result.tag !== 'ok')
				{
					return result;
				}
				answer = answer(result.value);
			}
			return ok(answer);

		case 'andThen':
			var result = runHelp(decoder.decoder, value);
			return (result.tag !== 'ok')
				? result
				: runHelp(decoder.callback(result.value), value);

		case 'oneOf':
			var errors = [];
			var temp = decoder.decoders;
			while (temp.ctor !== '[]')
			{
				var result = runHelp(temp._0, value);

				if (result.tag === 'ok')
				{
					return result;
				}

				errors.push(result);

				temp = temp._1;
			}
			return badOneOf(errors);

		case 'fail':
			return bad(decoder.msg);

		case 'succeed':
			return ok(decoder.msg);
	}
}


// EQUALITY

function equality(a, b)
{
	if (a === b)
	{
		return true;
	}

	if (a.tag !== b.tag)
	{
		return false;
	}

	switch (a.tag)
	{
		case 'succeed':
		case 'fail':
			return a.msg === b.msg;

		case 'bool':
		case 'int':
		case 'float':
		case 'string':
		case 'value':
			return true;

		case 'null':
			return a.value === b.value;

		case 'list':
		case 'array':
		case 'maybe':
		case 'key-value':
			return equality(a.decoder, b.decoder);

		case 'field':
			return a.field === b.field && equality(a.decoder, b.decoder);

		case 'index':
			return a.index === b.index && equality(a.decoder, b.decoder);

		case 'map-many':
			if (a.func !== b.func)
			{
				return false;
			}
			return listEquality(a.decoders, b.decoders);

		case 'andThen':
			return a.callback === b.callback && equality(a.decoder, b.decoder);

		case 'oneOf':
			return listEquality(a.decoders, b.decoders);
	}
}

function listEquality(aDecoders, bDecoders)
{
	var len = aDecoders.length;
	if (len !== bDecoders.length)
	{
		return false;
	}
	for (var i = 0; i < len; i++)
	{
		if (!equality(aDecoders[i], bDecoders[i]))
		{
			return false;
		}
	}
	return true;
}


// ENCODE

function encode(indentLevel, value)
{
	return JSON.stringify(value, null, indentLevel);
}

function identity(value)
{
	return value;
}

function encodeObject(keyValuePairs)
{
	var obj = {};
	while (keyValuePairs.ctor !== '[]')
	{
		var pair = keyValuePairs._0;
		obj[pair._0] = pair._1;
		keyValuePairs = keyValuePairs._1;
	}
	return obj;
}

return {
	encode: F2(encode),
	runOnString: F2(runOnString),
	run: F2(run),

	decodeNull: decodeNull,
	decodePrimitive: decodePrimitive,
	decodeContainer: F2(decodeContainer),

	decodeField: F2(decodeField),
	decodeIndex: F2(decodeIndex),

	map1: F2(map1),
	map2: F3(map2),
	map3: F4(map3),
	map4: F5(map4),
	map5: F6(map5),
	map6: F7(map6),
	map7: F8(map7),
	map8: F9(map8),
	decodeKeyValuePairs: decodeKeyValuePairs,

	andThen: F2(andThen),
	fail: fail,
	succeed: succeed,
	oneOf: oneOf,

	identity: identity,
	encodeNull: null,
	encodeArray: _elm_lang$core$Native_Array.toJSArray,
	encodeList: _elm_lang$core$Native_List.toArray,
	encodeObject: encodeObject,

	equality: equality
};

}();

var _elm_lang$core$Json_Encode$list = _elm_lang$core$Native_Json.encodeList;
var _elm_lang$core$Json_Encode$array = _elm_lang$core$Native_Json.encodeArray;
var _elm_lang$core$Json_Encode$object = _elm_lang$core$Native_Json.encodeObject;
var _elm_lang$core$Json_Encode$null = _elm_lang$core$Native_Json.encodeNull;
var _elm_lang$core$Json_Encode$bool = _elm_lang$core$Native_Json.identity;
var _elm_lang$core$Json_Encode$float = _elm_lang$core$Native_Json.identity;
var _elm_lang$core$Json_Encode$int = _elm_lang$core$Native_Json.identity;
var _elm_lang$core$Json_Encode$string = _elm_lang$core$Native_Json.identity;
var _elm_lang$core$Json_Encode$encode = _elm_lang$core$Native_Json.encode;
var _elm_lang$core$Json_Encode$Value = {ctor: 'Value'};

var _elm_lang$core$Json_Decode$null = _elm_lang$core$Native_Json.decodeNull;
var _elm_lang$core$Json_Decode$value = _elm_lang$core$Native_Json.decodePrimitive('value');
var _elm_lang$core$Json_Decode$andThen = _elm_lang$core$Native_Json.andThen;
var _elm_lang$core$Json_Decode$fail = _elm_lang$core$Native_Json.fail;
var _elm_lang$core$Json_Decode$succeed = _elm_lang$core$Native_Json.succeed;
var _elm_lang$core$Json_Decode$lazy = function (thunk) {
	return A2(
		_elm_lang$core$Json_Decode$andThen,
		thunk,
		_elm_lang$core$Json_Decode$succeed(
			{ctor: '_Tuple0'}));
};
var _elm_lang$core$Json_Decode$decodeValue = _elm_lang$core$Native_Json.run;
var _elm_lang$core$Json_Decode$decodeString = _elm_lang$core$Native_Json.runOnString;
var _elm_lang$core$Json_Decode$map8 = _elm_lang$core$Native_Json.map8;
var _elm_lang$core$Json_Decode$map7 = _elm_lang$core$Native_Json.map7;
var _elm_lang$core$Json_Decode$map6 = _elm_lang$core$Native_Json.map6;
var _elm_lang$core$Json_Decode$map5 = _elm_lang$core$Native_Json.map5;
var _elm_lang$core$Json_Decode$map4 = _elm_lang$core$Native_Json.map4;
var _elm_lang$core$Json_Decode$map3 = _elm_lang$core$Native_Json.map3;
var _elm_lang$core$Json_Decode$map2 = _elm_lang$core$Native_Json.map2;
var _elm_lang$core$Json_Decode$map = _elm_lang$core$Native_Json.map1;
var _elm_lang$core$Json_Decode$oneOf = _elm_lang$core$Native_Json.oneOf;
var _elm_lang$core$Json_Decode$maybe = function (decoder) {
	return A2(_elm_lang$core$Native_Json.decodeContainer, 'maybe', decoder);
};
var _elm_lang$core$Json_Decode$index = _elm_lang$core$Native_Json.decodeIndex;
var _elm_lang$core$Json_Decode$field = _elm_lang$core$Native_Json.decodeField;
var _elm_lang$core$Json_Decode$at = F2(
	function (fields, decoder) {
		return A3(_elm_lang$core$List$foldr, _elm_lang$core$Json_Decode$field, decoder, fields);
	});
var _elm_lang$core$Json_Decode$keyValuePairs = _elm_lang$core$Native_Json.decodeKeyValuePairs;
var _elm_lang$core$Json_Decode$dict = function (decoder) {
	return A2(
		_elm_lang$core$Json_Decode$map,
		_elm_lang$core$Dict$fromList,
		_elm_lang$core$Json_Decode$keyValuePairs(decoder));
};
var _elm_lang$core$Json_Decode$array = function (decoder) {
	return A2(_elm_lang$core$Native_Json.decodeContainer, 'array', decoder);
};
var _elm_lang$core$Json_Decode$list = function (decoder) {
	return A2(_elm_lang$core$Native_Json.decodeContainer, 'list', decoder);
};
var _elm_lang$core$Json_Decode$nullable = function (decoder) {
	return _elm_lang$core$Json_Decode$oneOf(
		{
			ctor: '::',
			_0: _elm_lang$core$Json_Decode$null(_elm_lang$core$Maybe$Nothing),
			_1: {
				ctor: '::',
				_0: A2(_elm_lang$core$Json_Decode$map, _elm_lang$core$Maybe$Just, decoder),
				_1: {ctor: '[]'}
			}
		});
};
var _elm_lang$core$Json_Decode$float = _elm_lang$core$Native_Json.decodePrimitive('float');
var _elm_lang$core$Json_Decode$int = _elm_lang$core$Native_Json.decodePrimitive('int');
var _elm_lang$core$Json_Decode$bool = _elm_lang$core$Native_Json.decodePrimitive('bool');
var _elm_lang$core$Json_Decode$string = _elm_lang$core$Native_Json.decodePrimitive('string');
var _elm_lang$core$Json_Decode$Decoder = {ctor: 'Decoder'};

//import Maybe, Native.List //

var _elm_lang$core$Native_Regex = function() {

function escape(str)
{
	return str.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&');
}
function caseInsensitive(re)
{
	return new RegExp(re.source, 'gi');
}
function regex(raw)
{
	return new RegExp(raw, 'g');
}

function contains(re, string)
{
	return string.match(re) !== null;
}

function find(n, re, str)
{
	n = n.ctor === 'All' ? Infinity : n._0;
	var out = [];
	var number = 0;
	var string = str;
	var lastIndex = re.lastIndex;
	var prevLastIndex = -1;
	var result;
	while (number++ < n && (result = re.exec(string)))
	{
		if (prevLastIndex === re.lastIndex) break;
		var i = result.length - 1;
		var subs = new Array(i);
		while (i > 0)
		{
			var submatch = result[i];
			subs[--i] = submatch === undefined
				? _elm_lang$core$Maybe$Nothing
				: _elm_lang$core$Maybe$Just(submatch);
		}
		out.push({
			match: result[0],
			submatches: _elm_lang$core$Native_List.fromArray(subs),
			index: result.index,
			number: number
		});
		prevLastIndex = re.lastIndex;
	}
	re.lastIndex = lastIndex;
	return _elm_lang$core$Native_List.fromArray(out);
}

function replace(n, re, replacer, string)
{
	n = n.ctor === 'All' ? Infinity : n._0;
	var count = 0;
	function jsReplacer(match)
	{
		if (count++ >= n)
		{
			return match;
		}
		var i = arguments.length - 3;
		var submatches = new Array(i);
		while (i > 0)
		{
			var submatch = arguments[i];
			submatches[--i] = submatch === undefined
				? _elm_lang$core$Maybe$Nothing
				: _elm_lang$core$Maybe$Just(submatch);
		}
		return replacer({
			match: match,
			submatches: _elm_lang$core$Native_List.fromArray(submatches),
			index: arguments[arguments.length - 2],
			number: count
		});
	}
	return string.replace(re, jsReplacer);
}

function split(n, re, str)
{
	n = n.ctor === 'All' ? Infinity : n._0;
	if (n === Infinity)
	{
		return _elm_lang$core$Native_List.fromArray(str.split(re));
	}
	var string = str;
	var result;
	var out = [];
	var start = re.lastIndex;
	var restoreLastIndex = re.lastIndex;
	while (n--)
	{
		if (!(result = re.exec(string))) break;
		out.push(string.slice(start, result.index));
		start = re.lastIndex;
	}
	out.push(string.slice(start));
	re.lastIndex = restoreLastIndex;
	return _elm_lang$core$Native_List.fromArray(out);
}

return {
	regex: regex,
	caseInsensitive: caseInsensitive,
	escape: escape,

	contains: F2(contains),
	find: F3(find),
	replace: F4(replace),
	split: F3(split)
};

}();

var _elm_lang$core$Regex$split = _elm_lang$core$Native_Regex.split;
var _elm_lang$core$Regex$replace = _elm_lang$core$Native_Regex.replace;
var _elm_lang$core$Regex$find = _elm_lang$core$Native_Regex.find;
var _elm_lang$core$Regex$contains = _elm_lang$core$Native_Regex.contains;
var _elm_lang$core$Regex$caseInsensitive = _elm_lang$core$Native_Regex.caseInsensitive;
var _elm_lang$core$Regex$regex = _elm_lang$core$Native_Regex.regex;
var _elm_lang$core$Regex$escape = _elm_lang$core$Native_Regex.escape;
var _elm_lang$core$Regex$Match = F4(
	function (a, b, c, d) {
		return {match: a, submatches: b, index: c, number: d};
	});
var _elm_lang$core$Regex$Regex = {ctor: 'Regex'};
var _elm_lang$core$Regex$AtMost = function (a) {
	return {ctor: 'AtMost', _0: a};
};
var _elm_lang$core$Regex$All = {ctor: 'All'};

var _elm_lang$dom$Native_Dom = function() {

var fakeNode = {
	addEventListener: function() {},
	removeEventListener: function() {}
};

var onDocument = on(typeof document !== 'undefined' ? document : fakeNode);
var onWindow = on(typeof window !== 'undefined' ? window : fakeNode);

function on(node)
{
	return function(eventName, decoder, toTask)
	{
		return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback) {

			function performTask(event)
			{
				var result = A2(_elm_lang$core$Json_Decode$decodeValue, decoder, event);
				if (result.ctor === 'Ok')
				{
					_elm_lang$core$Native_Scheduler.rawSpawn(toTask(result._0));
				}
			}

			node.addEventListener(eventName, performTask);

			return function()
			{
				node.removeEventListener(eventName, performTask);
			};
		});
	};
}

var rAF = typeof requestAnimationFrame !== 'undefined'
	? requestAnimationFrame
	: function(callback) { callback(); };

function withNode(id, doStuff)
{
	return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback)
	{
		rAF(function()
		{
			var node = document.getElementById(id);
			if (node === null)
			{
				callback(_elm_lang$core$Native_Scheduler.fail({ ctor: 'NotFound', _0: id }));
				return;
			}
			callback(_elm_lang$core$Native_Scheduler.succeed(doStuff(node)));
		});
	});
}


// FOCUS

function focus(id)
{
	return withNode(id, function(node) {
		node.focus();
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}

function blur(id)
{
	return withNode(id, function(node) {
		node.blur();
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}


// SCROLLING

function getScrollTop(id)
{
	return withNode(id, function(node) {
		return node.scrollTop;
	});
}

function setScrollTop(id, desiredScrollTop)
{
	return withNode(id, function(node) {
		node.scrollTop = desiredScrollTop;
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}

function toBottom(id)
{
	return withNode(id, function(node) {
		node.scrollTop = node.scrollHeight;
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}

function getScrollLeft(id)
{
	return withNode(id, function(node) {
		return node.scrollLeft;
	});
}

function setScrollLeft(id, desiredScrollLeft)
{
	return withNode(id, function(node) {
		node.scrollLeft = desiredScrollLeft;
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}

function toRight(id)
{
	return withNode(id, function(node) {
		node.scrollLeft = node.scrollWidth;
		return _elm_lang$core$Native_Utils.Tuple0;
	});
}


// SIZE

function width(options, id)
{
	return withNode(id, function(node) {
		switch (options.ctor)
		{
			case 'Content':
				return node.scrollWidth;
			case 'VisibleContent':
				return node.clientWidth;
			case 'VisibleContentWithBorders':
				return node.offsetWidth;
			case 'VisibleContentWithBordersAndMargins':
				var rect = node.getBoundingClientRect();
				return rect.right - rect.left;
		}
	});
}

function height(options, id)
{
	return withNode(id, function(node) {
		switch (options.ctor)
		{
			case 'Content':
				return node.scrollHeight;
			case 'VisibleContent':
				return node.clientHeight;
			case 'VisibleContentWithBorders':
				return node.offsetHeight;
			case 'VisibleContentWithBordersAndMargins':
				var rect = node.getBoundingClientRect();
				return rect.bottom - rect.top;
		}
	});
}

return {
	onDocument: F3(onDocument),
	onWindow: F3(onWindow),

	focus: focus,
	blur: blur,

	getScrollTop: getScrollTop,
	setScrollTop: F2(setScrollTop),
	getScrollLeft: getScrollLeft,
	setScrollLeft: F2(setScrollLeft),
	toBottom: toBottom,
	toRight: toRight,

	height: F2(height),
	width: F2(width)
};

}();

var _elm_lang$dom$Dom_LowLevel$onWindow = _elm_lang$dom$Native_Dom.onWindow;
var _elm_lang$dom$Dom_LowLevel$onDocument = _elm_lang$dom$Native_Dom.onDocument;

var _elm_lang$virtual_dom$VirtualDom_Debug$wrap;
var _elm_lang$virtual_dom$VirtualDom_Debug$wrapWithFlags;

var _elm_lang$virtual_dom$Native_VirtualDom = function() {

var STYLE_KEY = 'STYLE';
var EVENT_KEY = 'EVENT';
var ATTR_KEY = 'ATTR';
var ATTR_NS_KEY = 'ATTR_NS';

var localDoc = typeof document !== 'undefined' ? document : {};


////////////  VIRTUAL DOM NODES  ////////////


function text(string)
{
	return {
		type: 'text',
		text: string
	};
}


function node(tag)
{
	return F2(function(factList, kidList) {
		return nodeHelp(tag, factList, kidList);
	});
}


function nodeHelp(tag, factList, kidList)
{
	var organized = organizeFacts(factList);
	var namespace = organized.namespace;
	var facts = organized.facts;

	var children = [];
	var descendantsCount = 0;
	while (kidList.ctor !== '[]')
	{
		var kid = kidList._0;
		descendantsCount += (kid.descendantsCount || 0);
		children.push(kid);
		kidList = kidList._1;
	}
	descendantsCount += children.length;

	return {
		type: 'node',
		tag: tag,
		facts: facts,
		children: children,
		namespace: namespace,
		descendantsCount: descendantsCount
	};
}


function keyedNode(tag, factList, kidList)
{
	var organized = organizeFacts(factList);
	var namespace = organized.namespace;
	var facts = organized.facts;

	var children = [];
	var descendantsCount = 0;
	while (kidList.ctor !== '[]')
	{
		var kid = kidList._0;
		descendantsCount += (kid._1.descendantsCount || 0);
		children.push(kid);
		kidList = kidList._1;
	}
	descendantsCount += children.length;

	return {
		type: 'keyed-node',
		tag: tag,
		facts: facts,
		children: children,
		namespace: namespace,
		descendantsCount: descendantsCount
	};
}


function custom(factList, model, impl)
{
	var facts = organizeFacts(factList).facts;

	return {
		type: 'custom',
		facts: facts,
		model: model,
		impl: impl
	};
}


function map(tagger, node)
{
	return {
		type: 'tagger',
		tagger: tagger,
		node: node,
		descendantsCount: 1 + (node.descendantsCount || 0)
	};
}


function thunk(func, args, thunk)
{
	return {
		type: 'thunk',
		func: func,
		args: args,
		thunk: thunk,
		node: undefined
	};
}

function lazy(fn, a)
{
	return thunk(fn, [a], function() {
		return fn(a);
	});
}

function lazy2(fn, a, b)
{
	return thunk(fn, [a,b], function() {
		return A2(fn, a, b);
	});
}

function lazy3(fn, a, b, c)
{
	return thunk(fn, [a,b,c], function() {
		return A3(fn, a, b, c);
	});
}



// FACTS


function organizeFacts(factList)
{
	var namespace, facts = {};

	while (factList.ctor !== '[]')
	{
		var entry = factList._0;
		var key = entry.key;

		if (key === ATTR_KEY || key === ATTR_NS_KEY || key === EVENT_KEY)
		{
			var subFacts = facts[key] || {};
			subFacts[entry.realKey] = entry.value;
			facts[key] = subFacts;
		}
		else if (key === STYLE_KEY)
		{
			var styles = facts[key] || {};
			var styleList = entry.value;
			while (styleList.ctor !== '[]')
			{
				var style = styleList._0;
				styles[style._0] = style._1;
				styleList = styleList._1;
			}
			facts[key] = styles;
		}
		else if (key === 'namespace')
		{
			namespace = entry.value;
		}
		else if (key === 'className')
		{
			var classes = facts[key];
			facts[key] = typeof classes === 'undefined'
				? entry.value
				: classes + ' ' + entry.value;
		}
 		else
		{
			facts[key] = entry.value;
		}
		factList = factList._1;
	}

	return {
		facts: facts,
		namespace: namespace
	};
}



////////////  PROPERTIES AND ATTRIBUTES  ////////////


function style(value)
{
	return {
		key: STYLE_KEY,
		value: value
	};
}


function property(key, value)
{
	return {
		key: key,
		value: value
	};
}


function attribute(key, value)
{
	return {
		key: ATTR_KEY,
		realKey: key,
		value: value
	};
}


function attributeNS(namespace, key, value)
{
	return {
		key: ATTR_NS_KEY,
		realKey: key,
		value: {
			value: value,
			namespace: namespace
		}
	};
}


function on(name, options, decoder)
{
	return {
		key: EVENT_KEY,
		realKey: name,
		value: {
			options: options,
			decoder: decoder
		}
	};
}


function equalEvents(a, b)
{
	if (a.options !== b.options)
	{
		if (a.options.stopPropagation !== b.options.stopPropagation || a.options.preventDefault !== b.options.preventDefault)
		{
			return false;
		}
	}
	return _elm_lang$core$Native_Json.equality(a.decoder, b.decoder);
}


function mapProperty(func, property)
{
	if (property.key !== EVENT_KEY)
	{
		return property;
	}
	return on(
		property.realKey,
		property.value.options,
		A2(_elm_lang$core$Json_Decode$map, func, property.value.decoder)
	);
}


////////////  RENDER  ////////////


function render(vNode, eventNode)
{
	switch (vNode.type)
	{
		case 'thunk':
			if (!vNode.node)
			{
				vNode.node = vNode.thunk();
			}
			return render(vNode.node, eventNode);

		case 'tagger':
			var subNode = vNode.node;
			var tagger = vNode.tagger;

			while (subNode.type === 'tagger')
			{
				typeof tagger !== 'object'
					? tagger = [tagger, subNode.tagger]
					: tagger.push(subNode.tagger);

				subNode = subNode.node;
			}

			var subEventRoot = { tagger: tagger, parent: eventNode };
			var domNode = render(subNode, subEventRoot);
			domNode.elm_event_node_ref = subEventRoot;
			return domNode;

		case 'text':
			return localDoc.createTextNode(vNode.text);

		case 'node':
			var domNode = vNode.namespace
				? localDoc.createElementNS(vNode.namespace, vNode.tag)
				: localDoc.createElement(vNode.tag);

			applyFacts(domNode, eventNode, vNode.facts);

			var children = vNode.children;

			for (var i = 0; i < children.length; i++)
			{
				domNode.appendChild(render(children[i], eventNode));
			}

			return domNode;

		case 'keyed-node':
			var domNode = vNode.namespace
				? localDoc.createElementNS(vNode.namespace, vNode.tag)
				: localDoc.createElement(vNode.tag);

			applyFacts(domNode, eventNode, vNode.facts);

			var children = vNode.children;

			for (var i = 0; i < children.length; i++)
			{
				domNode.appendChild(render(children[i]._1, eventNode));
			}

			return domNode;

		case 'custom':
			var domNode = vNode.impl.render(vNode.model);
			applyFacts(domNode, eventNode, vNode.facts);
			return domNode;
	}
}



////////////  APPLY FACTS  ////////////


function applyFacts(domNode, eventNode, facts)
{
	for (var key in facts)
	{
		var value = facts[key];

		switch (key)
		{
			case STYLE_KEY:
				applyStyles(domNode, value);
				break;

			case EVENT_KEY:
				applyEvents(domNode, eventNode, value);
				break;

			case ATTR_KEY:
				applyAttrs(domNode, value);
				break;

			case ATTR_NS_KEY:
				applyAttrsNS(domNode, value);
				break;

			case 'value':
				if (domNode[key] !== value)
				{
					domNode[key] = value;
				}
				break;

			default:
				domNode[key] = value;
				break;
		}
	}
}

function applyStyles(domNode, styles)
{
	var domNodeStyle = domNode.style;

	for (var key in styles)
	{
		domNodeStyle[key] = styles[key];
	}
}

function applyEvents(domNode, eventNode, events)
{
	var allHandlers = domNode.elm_handlers || {};

	for (var key in events)
	{
		var handler = allHandlers[key];
		var value = events[key];

		if (typeof value === 'undefined')
		{
			domNode.removeEventListener(key, handler);
			allHandlers[key] = undefined;
		}
		else if (typeof handler === 'undefined')
		{
			var handler = makeEventHandler(eventNode, value);
			domNode.addEventListener(key, handler);
			allHandlers[key] = handler;
		}
		else
		{
			handler.info = value;
		}
	}

	domNode.elm_handlers = allHandlers;
}

function makeEventHandler(eventNode, info)
{
	function eventHandler(event)
	{
		var info = eventHandler.info;

		var value = A2(_elm_lang$core$Native_Json.run, info.decoder, event);

		if (value.ctor === 'Ok')
		{
			var options = info.options;
			if (options.stopPropagation)
			{
				event.stopPropagation();
			}
			if (options.preventDefault)
			{
				event.preventDefault();
			}

			var message = value._0;

			var currentEventNode = eventNode;
			while (currentEventNode)
			{
				var tagger = currentEventNode.tagger;
				if (typeof tagger === 'function')
				{
					message = tagger(message);
				}
				else
				{
					for (var i = tagger.length; i--; )
					{
						message = tagger[i](message);
					}
				}
				currentEventNode = currentEventNode.parent;
			}
		}
	};

	eventHandler.info = info;

	return eventHandler;
}

function applyAttrs(domNode, attrs)
{
	for (var key in attrs)
	{
		var value = attrs[key];
		if (typeof value === 'undefined')
		{
			domNode.removeAttribute(key);
		}
		else
		{
			domNode.setAttribute(key, value);
		}
	}
}

function applyAttrsNS(domNode, nsAttrs)
{
	for (var key in nsAttrs)
	{
		var pair = nsAttrs[key];
		var namespace = pair.namespace;
		var value = pair.value;

		if (typeof value === 'undefined')
		{
			domNode.removeAttributeNS(namespace, key);
		}
		else
		{
			domNode.setAttributeNS(namespace, key, value);
		}
	}
}



////////////  DIFF  ////////////


function diff(a, b)
{
	var patches = [];
	diffHelp(a, b, patches, 0);
	return patches;
}


function makePatch(type, index, data)
{
	return {
		index: index,
		type: type,
		data: data,
		domNode: undefined,
		eventNode: undefined
	};
}


function diffHelp(a, b, patches, index)
{
	if (a === b)
	{
		return;
	}

	var aType = a.type;
	var bType = b.type;

	// Bail if you run into different types of nodes. Implies that the
	// structure has changed significantly and it's not worth a diff.
	if (aType !== bType)
	{
		patches.push(makePatch('p-redraw', index, b));
		return;
	}

	// Now we know that both nodes are the same type.
	switch (bType)
	{
		case 'thunk':
			var aArgs = a.args;
			var bArgs = b.args;
			var i = aArgs.length;
			var same = a.func === b.func && i === bArgs.length;
			while (same && i--)
			{
				same = aArgs[i] === bArgs[i];
			}
			if (same)
			{
				b.node = a.node;
				return;
			}
			b.node = b.thunk();
			var subPatches = [];
			diffHelp(a.node, b.node, subPatches, 0);
			if (subPatches.length > 0)
			{
				patches.push(makePatch('p-thunk', index, subPatches));
			}
			return;

		case 'tagger':
			// gather nested taggers
			var aTaggers = a.tagger;
			var bTaggers = b.tagger;
			var nesting = false;

			var aSubNode = a.node;
			while (aSubNode.type === 'tagger')
			{
				nesting = true;

				typeof aTaggers !== 'object'
					? aTaggers = [aTaggers, aSubNode.tagger]
					: aTaggers.push(aSubNode.tagger);

				aSubNode = aSubNode.node;
			}

			var bSubNode = b.node;
			while (bSubNode.type === 'tagger')
			{
				nesting = true;

				typeof bTaggers !== 'object'
					? bTaggers = [bTaggers, bSubNode.tagger]
					: bTaggers.push(bSubNode.tagger);

				bSubNode = bSubNode.node;
			}

			// Just bail if different numbers of taggers. This implies the
			// structure of the virtual DOM has changed.
			if (nesting && aTaggers.length !== bTaggers.length)
			{
				patches.push(makePatch('p-redraw', index, b));
				return;
			}

			// check if taggers are "the same"
			if (nesting ? !pairwiseRefEqual(aTaggers, bTaggers) : aTaggers !== bTaggers)
			{
				patches.push(makePatch('p-tagger', index, bTaggers));
			}

			// diff everything below the taggers
			diffHelp(aSubNode, bSubNode, patches, index + 1);
			return;

		case 'text':
			if (a.text !== b.text)
			{
				patches.push(makePatch('p-text', index, b.text));
				return;
			}

			return;

		case 'node':
			// Bail if obvious indicators have changed. Implies more serious
			// structural changes such that it's not worth it to diff.
			if (a.tag !== b.tag || a.namespace !== b.namespace)
			{
				patches.push(makePatch('p-redraw', index, b));
				return;
			}

			var factsDiff = diffFacts(a.facts, b.facts);

			if (typeof factsDiff !== 'undefined')
			{
				patches.push(makePatch('p-facts', index, factsDiff));
			}

			diffChildren(a, b, patches, index);
			return;

		case 'keyed-node':
			// Bail if obvious indicators have changed. Implies more serious
			// structural changes such that it's not worth it to diff.
			if (a.tag !== b.tag || a.namespace !== b.namespace)
			{
				patches.push(makePatch('p-redraw', index, b));
				return;
			}

			var factsDiff = diffFacts(a.facts, b.facts);

			if (typeof factsDiff !== 'undefined')
			{
				patches.push(makePatch('p-facts', index, factsDiff));
			}

			diffKeyedChildren(a, b, patches, index);
			return;

		case 'custom':
			if (a.impl !== b.impl)
			{
				patches.push(makePatch('p-redraw', index, b));
				return;
			}

			var factsDiff = diffFacts(a.facts, b.facts);
			if (typeof factsDiff !== 'undefined')
			{
				patches.push(makePatch('p-facts', index, factsDiff));
			}

			var patch = b.impl.diff(a,b);
			if (patch)
			{
				patches.push(makePatch('p-custom', index, patch));
				return;
			}

			return;
	}
}


// assumes the incoming arrays are the same length
function pairwiseRefEqual(as, bs)
{
	for (var i = 0; i < as.length; i++)
	{
		if (as[i] !== bs[i])
		{
			return false;
		}
	}

	return true;
}


// TODO Instead of creating a new diff object, it's possible to just test if
// there *is* a diff. During the actual patch, do the diff again and make the
// modifications directly. This way, there's no new allocations. Worth it?
function diffFacts(a, b, category)
{
	var diff;

	// look for changes and removals
	for (var aKey in a)
	{
		if (aKey === STYLE_KEY || aKey === EVENT_KEY || aKey === ATTR_KEY || aKey === ATTR_NS_KEY)
		{
			var subDiff = diffFacts(a[aKey], b[aKey] || {}, aKey);
			if (subDiff)
			{
				diff = diff || {};
				diff[aKey] = subDiff;
			}
			continue;
		}

		// remove if not in the new facts
		if (!(aKey in b))
		{
			diff = diff || {};
			diff[aKey] =
				(typeof category === 'undefined')
					? (typeof a[aKey] === 'string' ? '' : null)
					:
				(category === STYLE_KEY)
					? ''
					:
				(category === EVENT_KEY || category === ATTR_KEY)
					? undefined
					:
				{ namespace: a[aKey].namespace, value: undefined };

			continue;
		}

		var aValue = a[aKey];
		var bValue = b[aKey];

		// reference equal, so don't worry about it
		if (aValue === bValue && aKey !== 'value'
			|| category === EVENT_KEY && equalEvents(aValue, bValue))
		{
			continue;
		}

		diff = diff || {};
		diff[aKey] = bValue;
	}

	// add new stuff
	for (var bKey in b)
	{
		if (!(bKey in a))
		{
			diff = diff || {};
			diff[bKey] = b[bKey];
		}
	}

	return diff;
}


function diffChildren(aParent, bParent, patches, rootIndex)
{
	var aChildren = aParent.children;
	var bChildren = bParent.children;

	var aLen = aChildren.length;
	var bLen = bChildren.length;

	// FIGURE OUT IF THERE ARE INSERTS OR REMOVALS

	if (aLen > bLen)
	{
		patches.push(makePatch('p-remove-last', rootIndex, aLen - bLen));
	}
	else if (aLen < bLen)
	{
		patches.push(makePatch('p-append', rootIndex, bChildren.slice(aLen)));
	}

	// PAIRWISE DIFF EVERYTHING ELSE

	var index = rootIndex;
	var minLen = aLen < bLen ? aLen : bLen;
	for (var i = 0; i < minLen; i++)
	{
		index++;
		var aChild = aChildren[i];
		diffHelp(aChild, bChildren[i], patches, index);
		index += aChild.descendantsCount || 0;
	}
}



////////////  KEYED DIFF  ////////////


function diffKeyedChildren(aParent, bParent, patches, rootIndex)
{
	var localPatches = [];

	var changes = {}; // Dict String Entry
	var inserts = []; // Array { index : Int, entry : Entry }
	// type Entry = { tag : String, vnode : VNode, index : Int, data : _ }

	var aChildren = aParent.children;
	var bChildren = bParent.children;
	var aLen = aChildren.length;
	var bLen = bChildren.length;
	var aIndex = 0;
	var bIndex = 0;

	var index = rootIndex;

	while (aIndex < aLen && bIndex < bLen)
	{
		var a = aChildren[aIndex];
		var b = bChildren[bIndex];

		var aKey = a._0;
		var bKey = b._0;
		var aNode = a._1;
		var bNode = b._1;

		// check if keys match

		if (aKey === bKey)
		{
			index++;
			diffHelp(aNode, bNode, localPatches, index);
			index += aNode.descendantsCount || 0;

			aIndex++;
			bIndex++;
			continue;
		}

		// look ahead 1 to detect insertions and removals.

		var aLookAhead = aIndex + 1 < aLen;
		var bLookAhead = bIndex + 1 < bLen;

		if (aLookAhead)
		{
			var aNext = aChildren[aIndex + 1];
			var aNextKey = aNext._0;
			var aNextNode = aNext._1;
			var oldMatch = bKey === aNextKey;
		}

		if (bLookAhead)
		{
			var bNext = bChildren[bIndex + 1];
			var bNextKey = bNext._0;
			var bNextNode = bNext._1;
			var newMatch = aKey === bNextKey;
		}


		// swap a and b
		if (aLookAhead && bLookAhead && newMatch && oldMatch)
		{
			index++;
			diffHelp(aNode, bNextNode, localPatches, index);
			insertNode(changes, localPatches, aKey, bNode, bIndex, inserts);
			index += aNode.descendantsCount || 0;

			index++;
			removeNode(changes, localPatches, aKey, aNextNode, index);
			index += aNextNode.descendantsCount || 0;

			aIndex += 2;
			bIndex += 2;
			continue;
		}

		// insert b
		if (bLookAhead && newMatch)
		{
			index++;
			insertNode(changes, localPatches, bKey, bNode, bIndex, inserts);
			diffHelp(aNode, bNextNode, localPatches, index);
			index += aNode.descendantsCount || 0;

			aIndex += 1;
			bIndex += 2;
			continue;
		}

		// remove a
		if (aLookAhead && oldMatch)
		{
			index++;
			removeNode(changes, localPatches, aKey, aNode, index);
			index += aNode.descendantsCount || 0;

			index++;
			diffHelp(aNextNode, bNode, localPatches, index);
			index += aNextNode.descendantsCount || 0;

			aIndex += 2;
			bIndex += 1;
			continue;
		}

		// remove a, insert b
		if (aLookAhead && bLookAhead && aNextKey === bNextKey)
		{
			index++;
			removeNode(changes, localPatches, aKey, aNode, index);
			insertNode(changes, localPatches, bKey, bNode, bIndex, inserts);
			index += aNode.descendantsCount || 0;

			index++;
			diffHelp(aNextNode, bNextNode, localPatches, index);
			index += aNextNode.descendantsCount || 0;

			aIndex += 2;
			bIndex += 2;
			continue;
		}

		break;
	}

	// eat up any remaining nodes with removeNode and insertNode

	while (aIndex < aLen)
	{
		index++;
		var a = aChildren[aIndex];
		var aNode = a._1;
		removeNode(changes, localPatches, a._0, aNode, index);
		index += aNode.descendantsCount || 0;
		aIndex++;
	}

	var endInserts;
	while (bIndex < bLen)
	{
		endInserts = endInserts || [];
		var b = bChildren[bIndex];
		insertNode(changes, localPatches, b._0, b._1, undefined, endInserts);
		bIndex++;
	}

	if (localPatches.length > 0 || inserts.length > 0 || typeof endInserts !== 'undefined')
	{
		patches.push(makePatch('p-reorder', rootIndex, {
			patches: localPatches,
			inserts: inserts,
			endInserts: endInserts
		}));
	}
}



////////////  CHANGES FROM KEYED DIFF  ////////////


var POSTFIX = '_elmW6BL';


function insertNode(changes, localPatches, key, vnode, bIndex, inserts)
{
	var entry = changes[key];

	// never seen this key before
	if (typeof entry === 'undefined')
	{
		entry = {
			tag: 'insert',
			vnode: vnode,
			index: bIndex,
			data: undefined
		};

		inserts.push({ index: bIndex, entry: entry });
		changes[key] = entry;

		return;
	}

	// this key was removed earlier, a match!
	if (entry.tag === 'remove')
	{
		inserts.push({ index: bIndex, entry: entry });

		entry.tag = 'move';
		var subPatches = [];
		diffHelp(entry.vnode, vnode, subPatches, entry.index);
		entry.index = bIndex;
		entry.data.data = {
			patches: subPatches,
			entry: entry
		};

		return;
	}

	// this key has already been inserted or moved, a duplicate!
	insertNode(changes, localPatches, key + POSTFIX, vnode, bIndex, inserts);
}


function removeNode(changes, localPatches, key, vnode, index)
{
	var entry = changes[key];

	// never seen this key before
	if (typeof entry === 'undefined')
	{
		var patch = makePatch('p-remove', index, undefined);
		localPatches.push(patch);

		changes[key] = {
			tag: 'remove',
			vnode: vnode,
			index: index,
			data: patch
		};

		return;
	}

	// this key was inserted earlier, a match!
	if (entry.tag === 'insert')
	{
		entry.tag = 'move';
		var subPatches = [];
		diffHelp(vnode, entry.vnode, subPatches, index);

		var patch = makePatch('p-remove', index, {
			patches: subPatches,
			entry: entry
		});
		localPatches.push(patch);

		return;
	}

	// this key has already been removed or moved, a duplicate!
	removeNode(changes, localPatches, key + POSTFIX, vnode, index);
}



////////////  ADD DOM NODES  ////////////
//
// Each DOM node has an "index" assigned in order of traversal. It is important
// to minimize our crawl over the actual DOM, so these indexes (along with the
// descendantsCount of virtual nodes) let us skip touching entire subtrees of
// the DOM if we know there are no patches there.


function addDomNodes(domNode, vNode, patches, eventNode)
{
	addDomNodesHelp(domNode, vNode, patches, 0, 0, vNode.descendantsCount, eventNode);
}


// assumes `patches` is non-empty and indexes increase monotonically.
function addDomNodesHelp(domNode, vNode, patches, i, low, high, eventNode)
{
	var patch = patches[i];
	var index = patch.index;

	while (index === low)
	{
		var patchType = patch.type;

		if (patchType === 'p-thunk')
		{
			addDomNodes(domNode, vNode.node, patch.data, eventNode);
		}
		else if (patchType === 'p-reorder')
		{
			patch.domNode = domNode;
			patch.eventNode = eventNode;

			var subPatches = patch.data.patches;
			if (subPatches.length > 0)
			{
				addDomNodesHelp(domNode, vNode, subPatches, 0, low, high, eventNode);
			}
		}
		else if (patchType === 'p-remove')
		{
			patch.domNode = domNode;
			patch.eventNode = eventNode;

			var data = patch.data;
			if (typeof data !== 'undefined')
			{
				data.entry.data = domNode;
				var subPatches = data.patches;
				if (subPatches.length > 0)
				{
					addDomNodesHelp(domNode, vNode, subPatches, 0, low, high, eventNode);
				}
			}
		}
		else
		{
			patch.domNode = domNode;
			patch.eventNode = eventNode;
		}

		i++;

		if (!(patch = patches[i]) || (index = patch.index) > high)
		{
			return i;
		}
	}

	switch (vNode.type)
	{
		case 'tagger':
			var subNode = vNode.node;

			while (subNode.type === "tagger")
			{
				subNode = subNode.node;
			}

			return addDomNodesHelp(domNode, subNode, patches, i, low + 1, high, domNode.elm_event_node_ref);

		case 'node':
			var vChildren = vNode.children;
			var childNodes = domNode.childNodes;
			for (var j = 0; j < vChildren.length; j++)
			{
				low++;
				var vChild = vChildren[j];
				var nextLow = low + (vChild.descendantsCount || 0);
				if (low <= index && index <= nextLow)
				{
					i = addDomNodesHelp(childNodes[j], vChild, patches, i, low, nextLow, eventNode);
					if (!(patch = patches[i]) || (index = patch.index) > high)
					{
						return i;
					}
				}
				low = nextLow;
			}
			return i;

		case 'keyed-node':
			var vChildren = vNode.children;
			var childNodes = domNode.childNodes;
			for (var j = 0; j < vChildren.length; j++)
			{
				low++;
				var vChild = vChildren[j]._1;
				var nextLow = low + (vChild.descendantsCount || 0);
				if (low <= index && index <= nextLow)
				{
					i = addDomNodesHelp(childNodes[j], vChild, patches, i, low, nextLow, eventNode);
					if (!(patch = patches[i]) || (index = patch.index) > high)
					{
						return i;
					}
				}
				low = nextLow;
			}
			return i;

		case 'text':
		case 'thunk':
			throw new Error('should never traverse `text` or `thunk` nodes like this');
	}
}



////////////  APPLY PATCHES  ////////////


function applyPatches(rootDomNode, oldVirtualNode, patches, eventNode)
{
	if (patches.length === 0)
	{
		return rootDomNode;
	}

	addDomNodes(rootDomNode, oldVirtualNode, patches, eventNode);
	return applyPatchesHelp(rootDomNode, patches);
}

function applyPatchesHelp(rootDomNode, patches)
{
	for (var i = 0; i < patches.length; i++)
	{
		var patch = patches[i];
		var localDomNode = patch.domNode
		var newNode = applyPatch(localDomNode, patch);
		if (localDomNode === rootDomNode)
		{
			rootDomNode = newNode;
		}
	}
	return rootDomNode;
}

function applyPatch(domNode, patch)
{
	switch (patch.type)
	{
		case 'p-redraw':
			return applyPatchRedraw(domNode, patch.data, patch.eventNode);

		case 'p-facts':
			applyFacts(domNode, patch.eventNode, patch.data);
			return domNode;

		case 'p-text':
			domNode.replaceData(0, domNode.length, patch.data);
			return domNode;

		case 'p-thunk':
			return applyPatchesHelp(domNode, patch.data);

		case 'p-tagger':
			if (typeof domNode.elm_event_node_ref !== 'undefined')
			{
				domNode.elm_event_node_ref.tagger = patch.data;
			}
			else
			{
				domNode.elm_event_node_ref = { tagger: patch.data, parent: patch.eventNode };
			}
			return domNode;

		case 'p-remove-last':
			var i = patch.data;
			while (i--)
			{
				domNode.removeChild(domNode.lastChild);
			}
			return domNode;

		case 'p-append':
			var newNodes = patch.data;
			for (var i = 0; i < newNodes.length; i++)
			{
				domNode.appendChild(render(newNodes[i], patch.eventNode));
			}
			return domNode;

		case 'p-remove':
			var data = patch.data;
			if (typeof data === 'undefined')
			{
				domNode.parentNode.removeChild(domNode);
				return domNode;
			}
			var entry = data.entry;
			if (typeof entry.index !== 'undefined')
			{
				domNode.parentNode.removeChild(domNode);
			}
			entry.data = applyPatchesHelp(domNode, data.patches);
			return domNode;

		case 'p-reorder':
			return applyPatchReorder(domNode, patch);

		case 'p-custom':
			var impl = patch.data;
			return impl.applyPatch(domNode, impl.data);

		default:
			throw new Error('Ran into an unknown patch!');
	}
}


function applyPatchRedraw(domNode, vNode, eventNode)
{
	var parentNode = domNode.parentNode;
	var newNode = render(vNode, eventNode);

	if (typeof newNode.elm_event_node_ref === 'undefined')
	{
		newNode.elm_event_node_ref = domNode.elm_event_node_ref;
	}

	if (parentNode && newNode !== domNode)
	{
		parentNode.replaceChild(newNode, domNode);
	}
	return newNode;
}


function applyPatchReorder(domNode, patch)
{
	var data = patch.data;

	// remove end inserts
	var frag = applyPatchReorderEndInsertsHelp(data.endInserts, patch);

	// removals
	domNode = applyPatchesHelp(domNode, data.patches);

	// inserts
	var inserts = data.inserts;
	for (var i = 0; i < inserts.length; i++)
	{
		var insert = inserts[i];
		var entry = insert.entry;
		var node = entry.tag === 'move'
			? entry.data
			: render(entry.vnode, patch.eventNode);
		domNode.insertBefore(node, domNode.childNodes[insert.index]);
	}

	// add end inserts
	if (typeof frag !== 'undefined')
	{
		domNode.appendChild(frag);
	}

	return domNode;
}


function applyPatchReorderEndInsertsHelp(endInserts, patch)
{
	if (typeof endInserts === 'undefined')
	{
		return;
	}

	var frag = localDoc.createDocumentFragment();
	for (var i = 0; i < endInserts.length; i++)
	{
		var insert = endInserts[i];
		var entry = insert.entry;
		frag.appendChild(entry.tag === 'move'
			? entry.data
			: render(entry.vnode, patch.eventNode)
		);
	}
	return frag;
}


// PROGRAMS

var program = makeProgram(checkNoFlags);
var programWithFlags = makeProgram(checkYesFlags);

function makeProgram(flagChecker)
{
	return F2(function(debugWrap, impl)
	{
		return function(flagDecoder)
		{
			return function(object, moduleName, debugMetadata)
			{
				var checker = flagChecker(flagDecoder, moduleName);
				if (typeof debugMetadata === 'undefined')
				{
					normalSetup(impl, object, moduleName, checker);
				}
				else
				{
					debugSetup(A2(debugWrap, debugMetadata, impl), object, moduleName, checker);
				}
			};
		};
	});
}

function staticProgram(vNode)
{
	var nothing = _elm_lang$core$Native_Utils.Tuple2(
		_elm_lang$core$Native_Utils.Tuple0,
		_elm_lang$core$Platform_Cmd$none
	);
	return A2(program, _elm_lang$virtual_dom$VirtualDom_Debug$wrap, {
		init: nothing,
		view: function() { return vNode; },
		update: F2(function() { return nothing; }),
		subscriptions: function() { return _elm_lang$core$Platform_Sub$none; }
	})();
}


// FLAG CHECKERS

function checkNoFlags(flagDecoder, moduleName)
{
	return function(init, flags, domNode)
	{
		if (typeof flags === 'undefined')
		{
			return init;
		}

		var errorMessage =
			'The `' + moduleName + '` module does not need flags.\n'
			+ 'Initialize it with no arguments and you should be all set!';

		crash(errorMessage, domNode);
	};
}

function checkYesFlags(flagDecoder, moduleName)
{
	return function(init, flags, domNode)
	{
		if (typeof flagDecoder === 'undefined')
		{
			var errorMessage =
				'Are you trying to sneak a Never value into Elm? Trickster!\n'
				+ 'It looks like ' + moduleName + '.main is defined with `programWithFlags` but has type `Program Never`.\n'
				+ 'Use `program` instead if you do not want flags.'

			crash(errorMessage, domNode);
		}

		var result = A2(_elm_lang$core$Native_Json.run, flagDecoder, flags);
		if (result.ctor === 'Ok')
		{
			return init(result._0);
		}

		var errorMessage =
			'Trying to initialize the `' + moduleName + '` module with an unexpected flag.\n'
			+ 'I tried to convert it to an Elm value, but ran into this problem:\n\n'
			+ result._0;

		crash(errorMessage, domNode);
	};
}

function crash(errorMessage, domNode)
{
	if (domNode)
	{
		domNode.innerHTML =
			'<div style="padding-left:1em;">'
			+ '<h2 style="font-weight:normal;"><b>Oops!</b> Something went wrong when starting your Elm program.</h2>'
			+ '<pre style="padding-left:1em;">' + errorMessage + '</pre>'
			+ '</div>';
	}

	throw new Error(errorMessage);
}


//  NORMAL SETUP

function normalSetup(impl, object, moduleName, flagChecker)
{
	object['embed'] = function embed(node, flags)
	{
		while (node.lastChild)
		{
			node.removeChild(node.lastChild);
		}

		return _elm_lang$core$Native_Platform.initialize(
			flagChecker(impl.init, flags, node),
			impl.update,
			impl.subscriptions,
			normalRenderer(node, impl.view)
		);
	};

	object['fullscreen'] = function fullscreen(flags)
	{
		return _elm_lang$core$Native_Platform.initialize(
			flagChecker(impl.init, flags, document.body),
			impl.update,
			impl.subscriptions,
			normalRenderer(document.body, impl.view)
		);
	};
}

function normalRenderer(parentNode, view)
{
	return function(tagger, initialModel)
	{
		var eventNode = { tagger: tagger, parent: undefined };
		var initialVirtualNode = view(initialModel);
		var domNode = render(initialVirtualNode, eventNode);
		parentNode.appendChild(domNode);
		return makeStepper(domNode, view, initialVirtualNode, eventNode);
	};
}


// STEPPER

var rAF =
	typeof requestAnimationFrame !== 'undefined'
		? requestAnimationFrame
		: function(callback) { setTimeout(callback, 1000 / 60); };

function makeStepper(domNode, view, initialVirtualNode, eventNode)
{
	var state = 'NO_REQUEST';
	var currNode = initialVirtualNode;
	var nextModel;

	function updateIfNeeded()
	{
		switch (state)
		{
			case 'NO_REQUEST':
				throw new Error(
					'Unexpected draw callback.\n' +
					'Please report this to <https://github.com/elm-lang/virtual-dom/issues>.'
				);

			case 'PENDING_REQUEST':
				rAF(updateIfNeeded);
				state = 'EXTRA_REQUEST';

				var nextNode = view(nextModel);
				var patches = diff(currNode, nextNode);
				domNode = applyPatches(domNode, currNode, patches, eventNode);
				currNode = nextNode;

				return;

			case 'EXTRA_REQUEST':
				state = 'NO_REQUEST';
				return;
		}
	}

	return function stepper(model)
	{
		if (state === 'NO_REQUEST')
		{
			rAF(updateIfNeeded);
		}
		state = 'PENDING_REQUEST';
		nextModel = model;
	};
}


// DEBUG SETUP

function debugSetup(impl, object, moduleName, flagChecker)
{
	object['fullscreen'] = function fullscreen(flags)
	{
		var popoutRef = { doc: undefined };
		return _elm_lang$core$Native_Platform.initialize(
			flagChecker(impl.init, flags, document.body),
			impl.update(scrollTask(popoutRef)),
			impl.subscriptions,
			debugRenderer(moduleName, document.body, popoutRef, impl.view, impl.viewIn, impl.viewOut)
		);
	};

	object['embed'] = function fullscreen(node, flags)
	{
		var popoutRef = { doc: undefined };
		return _elm_lang$core$Native_Platform.initialize(
			flagChecker(impl.init, flags, node),
			impl.update(scrollTask(popoutRef)),
			impl.subscriptions,
			debugRenderer(moduleName, node, popoutRef, impl.view, impl.viewIn, impl.viewOut)
		);
	};
}

function scrollTask(popoutRef)
{
	return _elm_lang$core$Native_Scheduler.nativeBinding(function(callback)
	{
		var doc = popoutRef.doc;
		if (doc)
		{
			var msgs = doc.getElementsByClassName('debugger-sidebar-messages')[0];
			if (msgs)
			{
				msgs.scrollTop = msgs.scrollHeight;
			}
		}
		callback(_elm_lang$core$Native_Scheduler.succeed(_elm_lang$core$Native_Utils.Tuple0));
	});
}


function debugRenderer(moduleName, parentNode, popoutRef, view, viewIn, viewOut)
{
	return function(tagger, initialModel)
	{
		var appEventNode = { tagger: tagger, parent: undefined };
		var eventNode = { tagger: tagger, parent: undefined };

		// make normal stepper
		var appVirtualNode = view(initialModel);
		var appNode = render(appVirtualNode, appEventNode);
		parentNode.appendChild(appNode);
		var appStepper = makeStepper(appNode, view, appVirtualNode, appEventNode);

		// make overlay stepper
		var overVirtualNode = viewIn(initialModel)._1;
		var overNode = render(overVirtualNode, eventNode);
		parentNode.appendChild(overNode);
		var wrappedViewIn = wrapViewIn(appEventNode, overNode, viewIn);
		var overStepper = makeStepper(overNode, wrappedViewIn, overVirtualNode, eventNode);

		// make debugger stepper
		var debugStepper = makeDebugStepper(initialModel, viewOut, eventNode, parentNode, moduleName, popoutRef);

		return function stepper(model)
		{
			appStepper(model);
			overStepper(model);
			debugStepper(model);
		}
	};
}

function makeDebugStepper(initialModel, view, eventNode, parentNode, moduleName, popoutRef)
{
	var curr;
	var domNode;

	return function stepper(model)
	{
		if (!model.isDebuggerOpen)
		{
			return;
		}

		if (!popoutRef.doc)
		{
			curr = view(model);
			domNode = openDebugWindow(moduleName, popoutRef, curr, eventNode);
			return;
		}

		// switch to document of popout
		localDoc = popoutRef.doc;

		var next = view(model);
		var patches = diff(curr, next);
		domNode = applyPatches(domNode, curr, patches, eventNode);
		curr = next;

		// switch back to normal document
		localDoc = document;
	};
}

function openDebugWindow(moduleName, popoutRef, virtualNode, eventNode)
{
	var w = 900;
	var h = 360;
	var x = screen.width - w;
	var y = screen.height - h;
	var debugWindow = window.open('', '', 'width=' + w + ',height=' + h + ',left=' + x + ',top=' + y);

	// switch to window document
	localDoc = debugWindow.document;

	popoutRef.doc = localDoc;
	localDoc.title = 'Debugger - ' + moduleName;
	localDoc.body.style.margin = '0';
	localDoc.body.style.padding = '0';
	var domNode = render(virtualNode, eventNode);
	localDoc.body.appendChild(domNode);

	localDoc.addEventListener('keydown', function(event) {
		if (event.metaKey && event.which === 82)
		{
			window.location.reload();
		}
		if (event.which === 38)
		{
			eventNode.tagger({ ctor: 'Up' });
			event.preventDefault();
		}
		if (event.which === 40)
		{
			eventNode.tagger({ ctor: 'Down' });
			event.preventDefault();
		}
	});

	function close()
	{
		popoutRef.doc = undefined;
		debugWindow.close();
	}
	window.addEventListener('unload', close);
	debugWindow.addEventListener('unload', function() {
		popoutRef.doc = undefined;
		window.removeEventListener('unload', close);
		eventNode.tagger({ ctor: 'Close' });
	});

	// switch back to the normal document
	localDoc = document;

	return domNode;
}


// BLOCK EVENTS

function wrapViewIn(appEventNode, overlayNode, viewIn)
{
	var ignorer = makeIgnorer(overlayNode);
	var blocking = 'Normal';
	var overflow;

	var normalTagger = appEventNode.tagger;
	var blockTagger = function() {};

	return function(model)
	{
		var tuple = viewIn(model);
		var newBlocking = tuple._0.ctor;
		appEventNode.tagger = newBlocking === 'Normal' ? normalTagger : blockTagger;
		if (blocking !== newBlocking)
		{
			traverse('removeEventListener', ignorer, blocking);
			traverse('addEventListener', ignorer, newBlocking);

			if (blocking === 'Normal')
			{
				overflow = document.body.style.overflow;
				document.body.style.overflow = 'hidden';
			}

			if (newBlocking === 'Normal')
			{
				document.body.style.overflow = overflow;
			}

			blocking = newBlocking;
		}
		return tuple._1;
	}
}

function traverse(verbEventListener, ignorer, blocking)
{
	switch(blocking)
	{
		case 'Normal':
			return;

		case 'Pause':
			return traverseHelp(verbEventListener, ignorer, mostEvents);

		case 'Message':
			return traverseHelp(verbEventListener, ignorer, allEvents);
	}
}

function traverseHelp(verbEventListener, handler, eventNames)
{
	for (var i = 0; i < eventNames.length; i++)
	{
		document.body[verbEventListener](eventNames[i], handler, true);
	}
}

function makeIgnorer(overlayNode)
{
	return function(event)
	{
		if (event.type === 'keydown' && event.metaKey && event.which === 82)
		{
			return;
		}

		var isScroll = event.type === 'scroll' || event.type === 'wheel';

		var node = event.target;
		while (node !== null)
		{
			if (node.className === 'elm-overlay-message-details' && isScroll)
			{
				return;
			}

			if (node === overlayNode && !isScroll)
			{
				return;
			}
			node = node.parentNode;
		}

		event.stopPropagation();
		event.preventDefault();
	}
}

var mostEvents = [
	'click', 'dblclick', 'mousemove',
	'mouseup', 'mousedown', 'mouseenter', 'mouseleave',
	'touchstart', 'touchend', 'touchcancel', 'touchmove',
	'pointerdown', 'pointerup', 'pointerover', 'pointerout',
	'pointerenter', 'pointerleave', 'pointermove', 'pointercancel',
	'dragstart', 'drag', 'dragend', 'dragenter', 'dragover', 'dragleave', 'drop',
	'keyup', 'keydown', 'keypress',
	'input', 'change',
	'focus', 'blur'
];

var allEvents = mostEvents.concat('wheel', 'scroll');


return {
	node: node,
	text: text,
	custom: custom,
	map: F2(map),

	on: F3(on),
	style: style,
	property: F2(property),
	attribute: F2(attribute),
	attributeNS: F3(attributeNS),
	mapProperty: F2(mapProperty),

	lazy: F2(lazy),
	lazy2: F3(lazy2),
	lazy3: F4(lazy3),
	keyedNode: F3(keyedNode),

	program: program,
	programWithFlags: programWithFlags,
	staticProgram: staticProgram
};

}();

var _elm_lang$virtual_dom$VirtualDom$programWithFlags = function (impl) {
	return A2(_elm_lang$virtual_dom$Native_VirtualDom.programWithFlags, _elm_lang$virtual_dom$VirtualDom_Debug$wrapWithFlags, impl);
};
var _elm_lang$virtual_dom$VirtualDom$program = function (impl) {
	return A2(_elm_lang$virtual_dom$Native_VirtualDom.program, _elm_lang$virtual_dom$VirtualDom_Debug$wrap, impl);
};
var _elm_lang$virtual_dom$VirtualDom$keyedNode = _elm_lang$virtual_dom$Native_VirtualDom.keyedNode;
var _elm_lang$virtual_dom$VirtualDom$lazy3 = _elm_lang$virtual_dom$Native_VirtualDom.lazy3;
var _elm_lang$virtual_dom$VirtualDom$lazy2 = _elm_lang$virtual_dom$Native_VirtualDom.lazy2;
var _elm_lang$virtual_dom$VirtualDom$lazy = _elm_lang$virtual_dom$Native_VirtualDom.lazy;
var _elm_lang$virtual_dom$VirtualDom$defaultOptions = {stopPropagation: false, preventDefault: false};
var _elm_lang$virtual_dom$VirtualDom$onWithOptions = _elm_lang$virtual_dom$Native_VirtualDom.on;
var _elm_lang$virtual_dom$VirtualDom$on = F2(
	function (eventName, decoder) {
		return A3(_elm_lang$virtual_dom$VirtualDom$onWithOptions, eventName, _elm_lang$virtual_dom$VirtualDom$defaultOptions, decoder);
	});
var _elm_lang$virtual_dom$VirtualDom$style = _elm_lang$virtual_dom$Native_VirtualDom.style;
var _elm_lang$virtual_dom$VirtualDom$mapProperty = _elm_lang$virtual_dom$Native_VirtualDom.mapProperty;
var _elm_lang$virtual_dom$VirtualDom$attributeNS = _elm_lang$virtual_dom$Native_VirtualDom.attributeNS;
var _elm_lang$virtual_dom$VirtualDom$attribute = _elm_lang$virtual_dom$Native_VirtualDom.attribute;
var _elm_lang$virtual_dom$VirtualDom$property = _elm_lang$virtual_dom$Native_VirtualDom.property;
var _elm_lang$virtual_dom$VirtualDom$map = _elm_lang$virtual_dom$Native_VirtualDom.map;
var _elm_lang$virtual_dom$VirtualDom$text = _elm_lang$virtual_dom$Native_VirtualDom.text;
var _elm_lang$virtual_dom$VirtualDom$node = _elm_lang$virtual_dom$Native_VirtualDom.node;
var _elm_lang$virtual_dom$VirtualDom$Options = F2(
	function (a, b) {
		return {stopPropagation: a, preventDefault: b};
	});
var _elm_lang$virtual_dom$VirtualDom$Node = {ctor: 'Node'};
var _elm_lang$virtual_dom$VirtualDom$Property = {ctor: 'Property'};

var _elm_lang$html$Html$programWithFlags = _elm_lang$virtual_dom$VirtualDom$programWithFlags;
var _elm_lang$html$Html$program = _elm_lang$virtual_dom$VirtualDom$program;
var _elm_lang$html$Html$beginnerProgram = function (_p0) {
	var _p1 = _p0;
	return _elm_lang$html$Html$program(
		{
			init: A2(
				_elm_lang$core$Platform_Cmd_ops['!'],
				_p1.model,
				{ctor: '[]'}),
			update: F2(
				function (msg, model) {
					return A2(
						_elm_lang$core$Platform_Cmd_ops['!'],
						A2(_p1.update, msg, model),
						{ctor: '[]'});
				}),
			view: _p1.view,
			subscriptions: function (_p2) {
				return _elm_lang$core$Platform_Sub$none;
			}
		});
};
var _elm_lang$html$Html$map = _elm_lang$virtual_dom$VirtualDom$map;
var _elm_lang$html$Html$text = _elm_lang$virtual_dom$VirtualDom$text;
var _elm_lang$html$Html$node = _elm_lang$virtual_dom$VirtualDom$node;
var _elm_lang$html$Html$body = _elm_lang$html$Html$node('body');
var _elm_lang$html$Html$section = _elm_lang$html$Html$node('section');
var _elm_lang$html$Html$nav = _elm_lang$html$Html$node('nav');
var _elm_lang$html$Html$article = _elm_lang$html$Html$node('article');
var _elm_lang$html$Html$aside = _elm_lang$html$Html$node('aside');
var _elm_lang$html$Html$h1 = _elm_lang$html$Html$node('h1');
var _elm_lang$html$Html$h2 = _elm_lang$html$Html$node('h2');
var _elm_lang$html$Html$h3 = _elm_lang$html$Html$node('h3');
var _elm_lang$html$Html$h4 = _elm_lang$html$Html$node('h4');
var _elm_lang$html$Html$h5 = _elm_lang$html$Html$node('h5');
var _elm_lang$html$Html$h6 = _elm_lang$html$Html$node('h6');
var _elm_lang$html$Html$header = _elm_lang$html$Html$node('header');
var _elm_lang$html$Html$footer = _elm_lang$html$Html$node('footer');
var _elm_lang$html$Html$address = _elm_lang$html$Html$node('address');
var _elm_lang$html$Html$main_ = _elm_lang$html$Html$node('main');
var _elm_lang$html$Html$p = _elm_lang$html$Html$node('p');
var _elm_lang$html$Html$hr = _elm_lang$html$Html$node('hr');
var _elm_lang$html$Html$pre = _elm_lang$html$Html$node('pre');
var _elm_lang$html$Html$blockquote = _elm_lang$html$Html$node('blockquote');
var _elm_lang$html$Html$ol = _elm_lang$html$Html$node('ol');
var _elm_lang$html$Html$ul = _elm_lang$html$Html$node('ul');
var _elm_lang$html$Html$li = _elm_lang$html$Html$node('li');
var _elm_lang$html$Html$dl = _elm_lang$html$Html$node('dl');
var _elm_lang$html$Html$dt = _elm_lang$html$Html$node('dt');
var _elm_lang$html$Html$dd = _elm_lang$html$Html$node('dd');
var _elm_lang$html$Html$figure = _elm_lang$html$Html$node('figure');
var _elm_lang$html$Html$figcaption = _elm_lang$html$Html$node('figcaption');
var _elm_lang$html$Html$div = _elm_lang$html$Html$node('div');
var _elm_lang$html$Html$a = _elm_lang$html$Html$node('a');
var _elm_lang$html$Html$em = _elm_lang$html$Html$node('em');
var _elm_lang$html$Html$strong = _elm_lang$html$Html$node('strong');
var _elm_lang$html$Html$small = _elm_lang$html$Html$node('small');
var _elm_lang$html$Html$s = _elm_lang$html$Html$node('s');
var _elm_lang$html$Html$cite = _elm_lang$html$Html$node('cite');
var _elm_lang$html$Html$q = _elm_lang$html$Html$node('q');
var _elm_lang$html$Html$dfn = _elm_lang$html$Html$node('dfn');
var _elm_lang$html$Html$abbr = _elm_lang$html$Html$node('abbr');
var _elm_lang$html$Html$time = _elm_lang$html$Html$node('time');
var _elm_lang$html$Html$code = _elm_lang$html$Html$node('code');
var _elm_lang$html$Html$var = _elm_lang$html$Html$node('var');
var _elm_lang$html$Html$samp = _elm_lang$html$Html$node('samp');
var _elm_lang$html$Html$kbd = _elm_lang$html$Html$node('kbd');
var _elm_lang$html$Html$sub = _elm_lang$html$Html$node('sub');
var _elm_lang$html$Html$sup = _elm_lang$html$Html$node('sup');
var _elm_lang$html$Html$i = _elm_lang$html$Html$node('i');
var _elm_lang$html$Html$b = _elm_lang$html$Html$node('b');
var _elm_lang$html$Html$u = _elm_lang$html$Html$node('u');
var _elm_lang$html$Html$mark = _elm_lang$html$Html$node('mark');
var _elm_lang$html$Html$ruby = _elm_lang$html$Html$node('ruby');
var _elm_lang$html$Html$rt = _elm_lang$html$Html$node('rt');
var _elm_lang$html$Html$rp = _elm_lang$html$Html$node('rp');
var _elm_lang$html$Html$bdi = _elm_lang$html$Html$node('bdi');
var _elm_lang$html$Html$bdo = _elm_lang$html$Html$node('bdo');
var _elm_lang$html$Html$span = _elm_lang$html$Html$node('span');
var _elm_lang$html$Html$br = _elm_lang$html$Html$node('br');
var _elm_lang$html$Html$wbr = _elm_lang$html$Html$node('wbr');
var _elm_lang$html$Html$ins = _elm_lang$html$Html$node('ins');
var _elm_lang$html$Html$del = _elm_lang$html$Html$node('del');
var _elm_lang$html$Html$img = _elm_lang$html$Html$node('img');
var _elm_lang$html$Html$iframe = _elm_lang$html$Html$node('iframe');
var _elm_lang$html$Html$embed = _elm_lang$html$Html$node('embed');
var _elm_lang$html$Html$object = _elm_lang$html$Html$node('object');
var _elm_lang$html$Html$param = _elm_lang$html$Html$node('param');
var _elm_lang$html$Html$video = _elm_lang$html$Html$node('video');
var _elm_lang$html$Html$audio = _elm_lang$html$Html$node('audio');
var _elm_lang$html$Html$source = _elm_lang$html$Html$node('source');
var _elm_lang$html$Html$track = _elm_lang$html$Html$node('track');
var _elm_lang$html$Html$canvas = _elm_lang$html$Html$node('canvas');
var _elm_lang$html$Html$math = _elm_lang$html$Html$node('math');
var _elm_lang$html$Html$table = _elm_lang$html$Html$node('table');
var _elm_lang$html$Html$caption = _elm_lang$html$Html$node('caption');
var _elm_lang$html$Html$colgroup = _elm_lang$html$Html$node('colgroup');
var _elm_lang$html$Html$col = _elm_lang$html$Html$node('col');
var _elm_lang$html$Html$tbody = _elm_lang$html$Html$node('tbody');
var _elm_lang$html$Html$thead = _elm_lang$html$Html$node('thead');
var _elm_lang$html$Html$tfoot = _elm_lang$html$Html$node('tfoot');
var _elm_lang$html$Html$tr = _elm_lang$html$Html$node('tr');
var _elm_lang$html$Html$td = _elm_lang$html$Html$node('td');
var _elm_lang$html$Html$th = _elm_lang$html$Html$node('th');
var _elm_lang$html$Html$form = _elm_lang$html$Html$node('form');
var _elm_lang$html$Html$fieldset = _elm_lang$html$Html$node('fieldset');
var _elm_lang$html$Html$legend = _elm_lang$html$Html$node('legend');
var _elm_lang$html$Html$label = _elm_lang$html$Html$node('label');
var _elm_lang$html$Html$input = _elm_lang$html$Html$node('input');
var _elm_lang$html$Html$button = _elm_lang$html$Html$node('button');
var _elm_lang$html$Html$select = _elm_lang$html$Html$node('select');
var _elm_lang$html$Html$datalist = _elm_lang$html$Html$node('datalist');
var _elm_lang$html$Html$optgroup = _elm_lang$html$Html$node('optgroup');
var _elm_lang$html$Html$option = _elm_lang$html$Html$node('option');
var _elm_lang$html$Html$textarea = _elm_lang$html$Html$node('textarea');
var _elm_lang$html$Html$keygen = _elm_lang$html$Html$node('keygen');
var _elm_lang$html$Html$output = _elm_lang$html$Html$node('output');
var _elm_lang$html$Html$progress = _elm_lang$html$Html$node('progress');
var _elm_lang$html$Html$meter = _elm_lang$html$Html$node('meter');
var _elm_lang$html$Html$details = _elm_lang$html$Html$node('details');
var _elm_lang$html$Html$summary = _elm_lang$html$Html$node('summary');
var _elm_lang$html$Html$menuitem = _elm_lang$html$Html$node('menuitem');
var _elm_lang$html$Html$menu = _elm_lang$html$Html$node('menu');

var _elm_lang$html$Html_Attributes$map = _elm_lang$virtual_dom$VirtualDom$mapProperty;
var _elm_lang$html$Html_Attributes$attribute = _elm_lang$virtual_dom$VirtualDom$attribute;
var _elm_lang$html$Html_Attributes$contextmenu = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'contextmenu', value);
};
var _elm_lang$html$Html_Attributes$draggable = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'draggable', value);
};
var _elm_lang$html$Html_Attributes$itemprop = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'itemprop', value);
};
var _elm_lang$html$Html_Attributes$tabindex = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'tabIndex',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$charset = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'charset', value);
};
var _elm_lang$html$Html_Attributes$height = function (value) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'height',
		_elm_lang$core$Basics$toString(value));
};
var _elm_lang$html$Html_Attributes$width = function (value) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'width',
		_elm_lang$core$Basics$toString(value));
};
var _elm_lang$html$Html_Attributes$formaction = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'formAction', value);
};
var _elm_lang$html$Html_Attributes$list = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'list', value);
};
var _elm_lang$html$Html_Attributes$minlength = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'minLength',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$maxlength = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'maxlength',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$size = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'size',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$form = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'form', value);
};
var _elm_lang$html$Html_Attributes$cols = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'cols',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$rows = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'rows',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$challenge = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'challenge', value);
};
var _elm_lang$html$Html_Attributes$media = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'media', value);
};
var _elm_lang$html$Html_Attributes$rel = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'rel', value);
};
var _elm_lang$html$Html_Attributes$datetime = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'datetime', value);
};
var _elm_lang$html$Html_Attributes$pubdate = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'pubdate', value);
};
var _elm_lang$html$Html_Attributes$colspan = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'colspan',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$rowspan = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$attribute,
		'rowspan',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$manifest = function (value) {
	return A2(_elm_lang$html$Html_Attributes$attribute, 'manifest', value);
};
var _elm_lang$html$Html_Attributes$property = _elm_lang$virtual_dom$VirtualDom$property;
var _elm_lang$html$Html_Attributes$stringProperty = F2(
	function (name, string) {
		return A2(
			_elm_lang$html$Html_Attributes$property,
			name,
			_elm_lang$core$Json_Encode$string(string));
	});
var _elm_lang$html$Html_Attributes$class = function (name) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'className', name);
};
var _elm_lang$html$Html_Attributes$id = function (name) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'id', name);
};
var _elm_lang$html$Html_Attributes$title = function (name) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'title', name);
};
var _elm_lang$html$Html_Attributes$accesskey = function ($char) {
	return A2(
		_elm_lang$html$Html_Attributes$stringProperty,
		'accessKey',
		_elm_lang$core$String$fromChar($char));
};
var _elm_lang$html$Html_Attributes$dir = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'dir', value);
};
var _elm_lang$html$Html_Attributes$dropzone = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'dropzone', value);
};
var _elm_lang$html$Html_Attributes$lang = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'lang', value);
};
var _elm_lang$html$Html_Attributes$content = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'content', value);
};
var _elm_lang$html$Html_Attributes$httpEquiv = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'httpEquiv', value);
};
var _elm_lang$html$Html_Attributes$language = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'language', value);
};
var _elm_lang$html$Html_Attributes$src = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'src', value);
};
var _elm_lang$html$Html_Attributes$alt = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'alt', value);
};
var _elm_lang$html$Html_Attributes$preload = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'preload', value);
};
var _elm_lang$html$Html_Attributes$poster = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'poster', value);
};
var _elm_lang$html$Html_Attributes$kind = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'kind', value);
};
var _elm_lang$html$Html_Attributes$srclang = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'srclang', value);
};
var _elm_lang$html$Html_Attributes$sandbox = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'sandbox', value);
};
var _elm_lang$html$Html_Attributes$srcdoc = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'srcdoc', value);
};
var _elm_lang$html$Html_Attributes$type_ = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'type', value);
};
var _elm_lang$html$Html_Attributes$value = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'value', value);
};
var _elm_lang$html$Html_Attributes$defaultValue = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'defaultValue', value);
};
var _elm_lang$html$Html_Attributes$placeholder = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'placeholder', value);
};
var _elm_lang$html$Html_Attributes$accept = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'accept', value);
};
var _elm_lang$html$Html_Attributes$acceptCharset = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'acceptCharset', value);
};
var _elm_lang$html$Html_Attributes$action = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'action', value);
};
var _elm_lang$html$Html_Attributes$autocomplete = function (bool) {
	return A2(
		_elm_lang$html$Html_Attributes$stringProperty,
		'autocomplete',
		bool ? 'on' : 'off');
};
var _elm_lang$html$Html_Attributes$enctype = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'enctype', value);
};
var _elm_lang$html$Html_Attributes$method = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'method', value);
};
var _elm_lang$html$Html_Attributes$name = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'name', value);
};
var _elm_lang$html$Html_Attributes$pattern = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'pattern', value);
};
var _elm_lang$html$Html_Attributes$for = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'htmlFor', value);
};
var _elm_lang$html$Html_Attributes$max = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'max', value);
};
var _elm_lang$html$Html_Attributes$min = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'min', value);
};
var _elm_lang$html$Html_Attributes$step = function (n) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'step', n);
};
var _elm_lang$html$Html_Attributes$wrap = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'wrap', value);
};
var _elm_lang$html$Html_Attributes$usemap = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'useMap', value);
};
var _elm_lang$html$Html_Attributes$shape = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'shape', value);
};
var _elm_lang$html$Html_Attributes$coords = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'coords', value);
};
var _elm_lang$html$Html_Attributes$keytype = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'keytype', value);
};
var _elm_lang$html$Html_Attributes$align = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'align', value);
};
var _elm_lang$html$Html_Attributes$cite = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'cite', value);
};
var _elm_lang$html$Html_Attributes$href = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'href', value);
};
var _elm_lang$html$Html_Attributes$target = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'target', value);
};
var _elm_lang$html$Html_Attributes$downloadAs = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'download', value);
};
var _elm_lang$html$Html_Attributes$hreflang = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'hreflang', value);
};
var _elm_lang$html$Html_Attributes$ping = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'ping', value);
};
var _elm_lang$html$Html_Attributes$start = function (n) {
	return A2(
		_elm_lang$html$Html_Attributes$stringProperty,
		'start',
		_elm_lang$core$Basics$toString(n));
};
var _elm_lang$html$Html_Attributes$headers = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'headers', value);
};
var _elm_lang$html$Html_Attributes$scope = function (value) {
	return A2(_elm_lang$html$Html_Attributes$stringProperty, 'scope', value);
};
var _elm_lang$html$Html_Attributes$boolProperty = F2(
	function (name, bool) {
		return A2(
			_elm_lang$html$Html_Attributes$property,
			name,
			_elm_lang$core$Json_Encode$bool(bool));
	});
var _elm_lang$html$Html_Attributes$hidden = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'hidden', bool);
};
var _elm_lang$html$Html_Attributes$contenteditable = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'contentEditable', bool);
};
var _elm_lang$html$Html_Attributes$spellcheck = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'spellcheck', bool);
};
var _elm_lang$html$Html_Attributes$async = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'async', bool);
};
var _elm_lang$html$Html_Attributes$defer = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'defer', bool);
};
var _elm_lang$html$Html_Attributes$scoped = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'scoped', bool);
};
var _elm_lang$html$Html_Attributes$autoplay = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'autoplay', bool);
};
var _elm_lang$html$Html_Attributes$controls = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'controls', bool);
};
var _elm_lang$html$Html_Attributes$loop = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'loop', bool);
};
var _elm_lang$html$Html_Attributes$default = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'default', bool);
};
var _elm_lang$html$Html_Attributes$seamless = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'seamless', bool);
};
var _elm_lang$html$Html_Attributes$checked = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'checked', bool);
};
var _elm_lang$html$Html_Attributes$selected = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'selected', bool);
};
var _elm_lang$html$Html_Attributes$autofocus = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'autofocus', bool);
};
var _elm_lang$html$Html_Attributes$disabled = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'disabled', bool);
};
var _elm_lang$html$Html_Attributes$multiple = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'multiple', bool);
};
var _elm_lang$html$Html_Attributes$novalidate = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'noValidate', bool);
};
var _elm_lang$html$Html_Attributes$readonly = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'readOnly', bool);
};
var _elm_lang$html$Html_Attributes$required = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'required', bool);
};
var _elm_lang$html$Html_Attributes$ismap = function (value) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'isMap', value);
};
var _elm_lang$html$Html_Attributes$download = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'download', bool);
};
var _elm_lang$html$Html_Attributes$reversed = function (bool) {
	return A2(_elm_lang$html$Html_Attributes$boolProperty, 'reversed', bool);
};
var _elm_lang$html$Html_Attributes$classList = function (list) {
	return _elm_lang$html$Html_Attributes$class(
		A2(
			_elm_lang$core$String$join,
			' ',
			A2(
				_elm_lang$core$List$map,
				_elm_lang$core$Tuple$first,
				A2(_elm_lang$core$List$filter, _elm_lang$core$Tuple$second, list))));
};
var _elm_lang$html$Html_Attributes$style = _elm_lang$virtual_dom$VirtualDom$style;

var _elm_lang$html$Html_Events$keyCode = A2(_elm_lang$core$Json_Decode$field, 'keyCode', _elm_lang$core$Json_Decode$int);
var _elm_lang$html$Html_Events$targetChecked = A2(
	_elm_lang$core$Json_Decode$at,
	{
		ctor: '::',
		_0: 'target',
		_1: {
			ctor: '::',
			_0: 'checked',
			_1: {ctor: '[]'}
		}
	},
	_elm_lang$core$Json_Decode$bool);
var _elm_lang$html$Html_Events$targetValue = A2(
	_elm_lang$core$Json_Decode$at,
	{
		ctor: '::',
		_0: 'target',
		_1: {
			ctor: '::',
			_0: 'value',
			_1: {ctor: '[]'}
		}
	},
	_elm_lang$core$Json_Decode$string);
var _elm_lang$html$Html_Events$defaultOptions = _elm_lang$virtual_dom$VirtualDom$defaultOptions;
var _elm_lang$html$Html_Events$onWithOptions = _elm_lang$virtual_dom$VirtualDom$onWithOptions;
var _elm_lang$html$Html_Events$on = _elm_lang$virtual_dom$VirtualDom$on;
var _elm_lang$html$Html_Events$onFocus = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'focus',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onBlur = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'blur',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onSubmitOptions = _elm_lang$core$Native_Utils.update(
	_elm_lang$html$Html_Events$defaultOptions,
	{preventDefault: true});
var _elm_lang$html$Html_Events$onSubmit = function (msg) {
	return A3(
		_elm_lang$html$Html_Events$onWithOptions,
		'submit',
		_elm_lang$html$Html_Events$onSubmitOptions,
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onCheck = function (tagger) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'change',
		A2(_elm_lang$core$Json_Decode$map, tagger, _elm_lang$html$Html_Events$targetChecked));
};
var _elm_lang$html$Html_Events$onInput = function (tagger) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'input',
		A2(_elm_lang$core$Json_Decode$map, tagger, _elm_lang$html$Html_Events$targetValue));
};
var _elm_lang$html$Html_Events$onMouseOut = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mouseout',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onMouseOver = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mouseover',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onMouseLeave = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mouseleave',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onMouseEnter = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mouseenter',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onMouseUp = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mouseup',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onMouseDown = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'mousedown',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onDoubleClick = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'dblclick',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$onClick = function (msg) {
	return A2(
		_elm_lang$html$Html_Events$on,
		'click',
		_elm_lang$core$Json_Decode$succeed(msg));
};
var _elm_lang$html$Html_Events$Options = F2(
	function (a, b) {
		return {stopPropagation: a, preventDefault: b};
	});

var _elm_lang$keyboard$Keyboard$onSelfMsg = F3(
	function (router, _p0, state) {
		var _p1 = _p0;
		var _p2 = A2(_elm_lang$core$Dict$get, _p1.category, state);
		if (_p2.ctor === 'Nothing') {
			return _elm_lang$core$Task$succeed(state);
		} else {
			var send = function (tagger) {
				return A2(
					_elm_lang$core$Platform$sendToApp,
					router,
					tagger(_p1.keyCode));
			};
			return A2(
				_elm_lang$core$Task$andThen,
				function (_p3) {
					return _elm_lang$core$Task$succeed(state);
				},
				_elm_lang$core$Task$sequence(
					A2(_elm_lang$core$List$map, send, _p2._0.taggers)));
		}
	});
var _elm_lang$keyboard$Keyboard_ops = _elm_lang$keyboard$Keyboard_ops || {};
_elm_lang$keyboard$Keyboard_ops['&>'] = F2(
	function (task1, task2) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (_p4) {
				return task2;
			},
			task1);
	});
var _elm_lang$keyboard$Keyboard$init = _elm_lang$core$Task$succeed(_elm_lang$core$Dict$empty);
var _elm_lang$keyboard$Keyboard$categorizeHelpHelp = F2(
	function (value, maybeValues) {
		var _p5 = maybeValues;
		if (_p5.ctor === 'Nothing') {
			return _elm_lang$core$Maybe$Just(
				{
					ctor: '::',
					_0: value,
					_1: {ctor: '[]'}
				});
		} else {
			return _elm_lang$core$Maybe$Just(
				{ctor: '::', _0: value, _1: _p5._0});
		}
	});
var _elm_lang$keyboard$Keyboard$categorizeHelp = F2(
	function (subs, subDict) {
		categorizeHelp:
		while (true) {
			var _p6 = subs;
			if (_p6.ctor === '[]') {
				return subDict;
			} else {
				var _v4 = _p6._1,
					_v5 = A3(
					_elm_lang$core$Dict$update,
					_p6._0._0,
					_elm_lang$keyboard$Keyboard$categorizeHelpHelp(_p6._0._1),
					subDict);
				subs = _v4;
				subDict = _v5;
				continue categorizeHelp;
			}
		}
	});
var _elm_lang$keyboard$Keyboard$categorize = function (subs) {
	return A2(_elm_lang$keyboard$Keyboard$categorizeHelp, subs, _elm_lang$core$Dict$empty);
};
var _elm_lang$keyboard$Keyboard$keyCode = A2(_elm_lang$core$Json_Decode$field, 'keyCode', _elm_lang$core$Json_Decode$int);
var _elm_lang$keyboard$Keyboard$subscription = _elm_lang$core$Native_Platform.leaf('Keyboard');
var _elm_lang$keyboard$Keyboard$Watcher = F2(
	function (a, b) {
		return {taggers: a, pid: b};
	});
var _elm_lang$keyboard$Keyboard$Msg = F2(
	function (a, b) {
		return {category: a, keyCode: b};
	});
var _elm_lang$keyboard$Keyboard$onEffects = F3(
	function (router, newSubs, oldState) {
		var rightStep = F3(
			function (category, taggers, task) {
				return A2(
					_elm_lang$core$Task$andThen,
					function (state) {
						return A2(
							_elm_lang$core$Task$andThen,
							function (pid) {
								return _elm_lang$core$Task$succeed(
									A3(
										_elm_lang$core$Dict$insert,
										category,
										A2(_elm_lang$keyboard$Keyboard$Watcher, taggers, pid),
										state));
							},
							_elm_lang$core$Process$spawn(
								A3(
									_elm_lang$dom$Dom_LowLevel$onDocument,
									category,
									_elm_lang$keyboard$Keyboard$keyCode,
									function (_p7) {
										return A2(
											_elm_lang$core$Platform$sendToSelf,
											router,
											A2(_elm_lang$keyboard$Keyboard$Msg, category, _p7));
									})));
					},
					task);
			});
		var bothStep = F4(
			function (category, _p8, taggers, task) {
				var _p9 = _p8;
				return A2(
					_elm_lang$core$Task$map,
					A2(
						_elm_lang$core$Dict$insert,
						category,
						A2(_elm_lang$keyboard$Keyboard$Watcher, taggers, _p9.pid)),
					task);
			});
		var leftStep = F3(
			function (category, _p10, task) {
				var _p11 = _p10;
				return A2(
					_elm_lang$keyboard$Keyboard_ops['&>'],
					_elm_lang$core$Process$kill(_p11.pid),
					task);
			});
		return A6(
			_elm_lang$core$Dict$merge,
			leftStep,
			bothStep,
			rightStep,
			oldState,
			_elm_lang$keyboard$Keyboard$categorize(newSubs),
			_elm_lang$core$Task$succeed(_elm_lang$core$Dict$empty));
	});
var _elm_lang$keyboard$Keyboard$MySub = F2(
	function (a, b) {
		return {ctor: 'MySub', _0: a, _1: b};
	});
var _elm_lang$keyboard$Keyboard$presses = function (tagger) {
	return _elm_lang$keyboard$Keyboard$subscription(
		A2(_elm_lang$keyboard$Keyboard$MySub, 'keypress', tagger));
};
var _elm_lang$keyboard$Keyboard$downs = function (tagger) {
	return _elm_lang$keyboard$Keyboard$subscription(
		A2(_elm_lang$keyboard$Keyboard$MySub, 'keydown', tagger));
};
var _elm_lang$keyboard$Keyboard$ups = function (tagger) {
	return _elm_lang$keyboard$Keyboard$subscription(
		A2(_elm_lang$keyboard$Keyboard$MySub, 'keyup', tagger));
};
var _elm_lang$keyboard$Keyboard$subMap = F2(
	function (func, _p12) {
		var _p13 = _p12;
		return A2(
			_elm_lang$keyboard$Keyboard$MySub,
			_p13._0,
			function (_p14) {
				return func(
					_p13._1(_p14));
			});
	});
_elm_lang$core$Native_Platform.effectManagers['Keyboard'] = {pkg: 'elm-lang/keyboard', init: _elm_lang$keyboard$Keyboard$init, onEffects: _elm_lang$keyboard$Keyboard$onEffects, onSelfMsg: _elm_lang$keyboard$Keyboard$onSelfMsg, tag: 'sub', subMap: _elm_lang$keyboard$Keyboard$subMap};

var _elm_lang$mouse$Mouse_ops = _elm_lang$mouse$Mouse_ops || {};
_elm_lang$mouse$Mouse_ops['&>'] = F2(
	function (t1, t2) {
		return A2(
			_elm_lang$core$Task$andThen,
			function (_p0) {
				return t2;
			},
			t1);
	});
var _elm_lang$mouse$Mouse$onSelfMsg = F3(
	function (router, _p1, state) {
		var _p2 = _p1;
		var _p3 = A2(_elm_lang$core$Dict$get, _p2.category, state);
		if (_p3.ctor === 'Nothing') {
			return _elm_lang$core$Task$succeed(state);
		} else {
			var send = function (tagger) {
				return A2(
					_elm_lang$core$Platform$sendToApp,
					router,
					tagger(_p2.position));
			};
			return A2(
				_elm_lang$mouse$Mouse_ops['&>'],
				_elm_lang$core$Task$sequence(
					A2(_elm_lang$core$List$map, send, _p3._0.taggers)),
				_elm_lang$core$Task$succeed(state));
		}
	});
var _elm_lang$mouse$Mouse$init = _elm_lang$core$Task$succeed(_elm_lang$core$Dict$empty);
var _elm_lang$mouse$Mouse$categorizeHelpHelp = F2(
	function (value, maybeValues) {
		var _p4 = maybeValues;
		if (_p4.ctor === 'Nothing') {
			return _elm_lang$core$Maybe$Just(
				{
					ctor: '::',
					_0: value,
					_1: {ctor: '[]'}
				});
		} else {
			return _elm_lang$core$Maybe$Just(
				{ctor: '::', _0: value, _1: _p4._0});
		}
	});
var _elm_lang$mouse$Mouse$categorizeHelp = F2(
	function (subs, subDict) {
		categorizeHelp:
		while (true) {
			var _p5 = subs;
			if (_p5.ctor === '[]') {
				return subDict;
			} else {
				var _v4 = _p5._1,
					_v5 = A3(
					_elm_lang$core$Dict$update,
					_p5._0._0,
					_elm_lang$mouse$Mouse$categorizeHelpHelp(_p5._0._1),
					subDict);
				subs = _v4;
				subDict = _v5;
				continue categorizeHelp;
			}
		}
	});
var _elm_lang$mouse$Mouse$categorize = function (subs) {
	return A2(_elm_lang$mouse$Mouse$categorizeHelp, subs, _elm_lang$core$Dict$empty);
};
var _elm_lang$mouse$Mouse$subscription = _elm_lang$core$Native_Platform.leaf('Mouse');
var _elm_lang$mouse$Mouse$Position = F2(
	function (a, b) {
		return {x: a, y: b};
	});
var _elm_lang$mouse$Mouse$position = A3(
	_elm_lang$core$Json_Decode$map2,
	_elm_lang$mouse$Mouse$Position,
	A2(_elm_lang$core$Json_Decode$field, 'pageX', _elm_lang$core$Json_Decode$int),
	A2(_elm_lang$core$Json_Decode$field, 'pageY', _elm_lang$core$Json_Decode$int));
var _elm_lang$mouse$Mouse$Watcher = F2(
	function (a, b) {
		return {taggers: a, pid: b};
	});
var _elm_lang$mouse$Mouse$Msg = F2(
	function (a, b) {
		return {category: a, position: b};
	});
var _elm_lang$mouse$Mouse$onEffects = F3(
	function (router, newSubs, oldState) {
		var rightStep = F3(
			function (category, taggers, task) {
				var tracker = A3(
					_elm_lang$dom$Dom_LowLevel$onDocument,
					category,
					_elm_lang$mouse$Mouse$position,
					function (_p6) {
						return A2(
							_elm_lang$core$Platform$sendToSelf,
							router,
							A2(_elm_lang$mouse$Mouse$Msg, category, _p6));
					});
				return A2(
					_elm_lang$core$Task$andThen,
					function (state) {
						return A2(
							_elm_lang$core$Task$andThen,
							function (pid) {
								return _elm_lang$core$Task$succeed(
									A3(
										_elm_lang$core$Dict$insert,
										category,
										A2(_elm_lang$mouse$Mouse$Watcher, taggers, pid),
										state));
							},
							_elm_lang$core$Process$spawn(tracker));
					},
					task);
			});
		var bothStep = F4(
			function (category, _p7, taggers, task) {
				var _p8 = _p7;
				return A2(
					_elm_lang$core$Task$andThen,
					function (state) {
						return _elm_lang$core$Task$succeed(
							A3(
								_elm_lang$core$Dict$insert,
								category,
								A2(_elm_lang$mouse$Mouse$Watcher, taggers, _p8.pid),
								state));
					},
					task);
			});
		var leftStep = F3(
			function (category, _p9, task) {
				var _p10 = _p9;
				return A2(
					_elm_lang$mouse$Mouse_ops['&>'],
					_elm_lang$core$Process$kill(_p10.pid),
					task);
			});
		return A6(
			_elm_lang$core$Dict$merge,
			leftStep,
			bothStep,
			rightStep,
			oldState,
			_elm_lang$mouse$Mouse$categorize(newSubs),
			_elm_lang$core$Task$succeed(_elm_lang$core$Dict$empty));
	});
var _elm_lang$mouse$Mouse$MySub = F2(
	function (a, b) {
		return {ctor: 'MySub', _0: a, _1: b};
	});
var _elm_lang$mouse$Mouse$clicks = function (tagger) {
	return _elm_lang$mouse$Mouse$subscription(
		A2(_elm_lang$mouse$Mouse$MySub, 'click', tagger));
};
var _elm_lang$mouse$Mouse$moves = function (tagger) {
	return _elm_lang$mouse$Mouse$subscription(
		A2(_elm_lang$mouse$Mouse$MySub, 'mousemove', tagger));
};
var _elm_lang$mouse$Mouse$downs = function (tagger) {
	return _elm_lang$mouse$Mouse$subscription(
		A2(_elm_lang$mouse$Mouse$MySub, 'mousedown', tagger));
};
var _elm_lang$mouse$Mouse$ups = function (tagger) {
	return _elm_lang$mouse$Mouse$subscription(
		A2(_elm_lang$mouse$Mouse$MySub, 'mouseup', tagger));
};
var _elm_lang$mouse$Mouse$subMap = F2(
	function (func, _p11) {
		var _p12 = _p11;
		return A2(
			_elm_lang$mouse$Mouse$MySub,
			_p12._0,
			function (_p13) {
				return func(
					_p12._1(_p13));
			});
	});
_elm_lang$core$Native_Platform.effectManagers['Mouse'] = {pkg: 'elm-lang/mouse', init: _elm_lang$mouse$Mouse$init, onEffects: _elm_lang$mouse$Mouse$onEffects, onSelfMsg: _elm_lang$mouse$Mouse$onSelfMsg, tag: 'sub', subMap: _elm_lang$mouse$Mouse$subMap};

var _elm_lang$svg$Svg$map = _elm_lang$virtual_dom$VirtualDom$map;
var _elm_lang$svg$Svg$text = _elm_lang$virtual_dom$VirtualDom$text;
var _elm_lang$svg$Svg$svgNamespace = A2(
	_elm_lang$virtual_dom$VirtualDom$property,
	'namespace',
	_elm_lang$core$Json_Encode$string('http://www.w3.org/2000/svg'));
var _elm_lang$svg$Svg$node = F3(
	function (name, attributes, children) {
		return A3(
			_elm_lang$virtual_dom$VirtualDom$node,
			name,
			{ctor: '::', _0: _elm_lang$svg$Svg$svgNamespace, _1: attributes},
			children);
	});
var _elm_lang$svg$Svg$svg = _elm_lang$svg$Svg$node('svg');
var _elm_lang$svg$Svg$foreignObject = _elm_lang$svg$Svg$node('foreignObject');
var _elm_lang$svg$Svg$animate = _elm_lang$svg$Svg$node('animate');
var _elm_lang$svg$Svg$animateColor = _elm_lang$svg$Svg$node('animateColor');
var _elm_lang$svg$Svg$animateMotion = _elm_lang$svg$Svg$node('animateMotion');
var _elm_lang$svg$Svg$animateTransform = _elm_lang$svg$Svg$node('animateTransform');
var _elm_lang$svg$Svg$mpath = _elm_lang$svg$Svg$node('mpath');
var _elm_lang$svg$Svg$set = _elm_lang$svg$Svg$node('set');
var _elm_lang$svg$Svg$a = _elm_lang$svg$Svg$node('a');
var _elm_lang$svg$Svg$defs = _elm_lang$svg$Svg$node('defs');
var _elm_lang$svg$Svg$g = _elm_lang$svg$Svg$node('g');
var _elm_lang$svg$Svg$marker = _elm_lang$svg$Svg$node('marker');
var _elm_lang$svg$Svg$mask = _elm_lang$svg$Svg$node('mask');
var _elm_lang$svg$Svg$pattern = _elm_lang$svg$Svg$node('pattern');
var _elm_lang$svg$Svg$switch = _elm_lang$svg$Svg$node('switch');
var _elm_lang$svg$Svg$symbol = _elm_lang$svg$Svg$node('symbol');
var _elm_lang$svg$Svg$desc = _elm_lang$svg$Svg$node('desc');
var _elm_lang$svg$Svg$metadata = _elm_lang$svg$Svg$node('metadata');
var _elm_lang$svg$Svg$title = _elm_lang$svg$Svg$node('title');
var _elm_lang$svg$Svg$feBlend = _elm_lang$svg$Svg$node('feBlend');
var _elm_lang$svg$Svg$feColorMatrix = _elm_lang$svg$Svg$node('feColorMatrix');
var _elm_lang$svg$Svg$feComponentTransfer = _elm_lang$svg$Svg$node('feComponentTransfer');
var _elm_lang$svg$Svg$feComposite = _elm_lang$svg$Svg$node('feComposite');
var _elm_lang$svg$Svg$feConvolveMatrix = _elm_lang$svg$Svg$node('feConvolveMatrix');
var _elm_lang$svg$Svg$feDiffuseLighting = _elm_lang$svg$Svg$node('feDiffuseLighting');
var _elm_lang$svg$Svg$feDisplacementMap = _elm_lang$svg$Svg$node('feDisplacementMap');
var _elm_lang$svg$Svg$feFlood = _elm_lang$svg$Svg$node('feFlood');
var _elm_lang$svg$Svg$feFuncA = _elm_lang$svg$Svg$node('feFuncA');
var _elm_lang$svg$Svg$feFuncB = _elm_lang$svg$Svg$node('feFuncB');
var _elm_lang$svg$Svg$feFuncG = _elm_lang$svg$Svg$node('feFuncG');
var _elm_lang$svg$Svg$feFuncR = _elm_lang$svg$Svg$node('feFuncR');
var _elm_lang$svg$Svg$feGaussianBlur = _elm_lang$svg$Svg$node('feGaussianBlur');
var _elm_lang$svg$Svg$feImage = _elm_lang$svg$Svg$node('feImage');
var _elm_lang$svg$Svg$feMerge = _elm_lang$svg$Svg$node('feMerge');
var _elm_lang$svg$Svg$feMergeNode = _elm_lang$svg$Svg$node('feMergeNode');
var _elm_lang$svg$Svg$feMorphology = _elm_lang$svg$Svg$node('feMorphology');
var _elm_lang$svg$Svg$feOffset = _elm_lang$svg$Svg$node('feOffset');
var _elm_lang$svg$Svg$feSpecularLighting = _elm_lang$svg$Svg$node('feSpecularLighting');
var _elm_lang$svg$Svg$feTile = _elm_lang$svg$Svg$node('feTile');
var _elm_lang$svg$Svg$feTurbulence = _elm_lang$svg$Svg$node('feTurbulence');
var _elm_lang$svg$Svg$font = _elm_lang$svg$Svg$node('font');
var _elm_lang$svg$Svg$linearGradient = _elm_lang$svg$Svg$node('linearGradient');
var _elm_lang$svg$Svg$radialGradient = _elm_lang$svg$Svg$node('radialGradient');
var _elm_lang$svg$Svg$stop = _elm_lang$svg$Svg$node('stop');
var _elm_lang$svg$Svg$circle = _elm_lang$svg$Svg$node('circle');
var _elm_lang$svg$Svg$ellipse = _elm_lang$svg$Svg$node('ellipse');
var _elm_lang$svg$Svg$image = _elm_lang$svg$Svg$node('image');
var _elm_lang$svg$Svg$line = _elm_lang$svg$Svg$node('line');
var _elm_lang$svg$Svg$path = _elm_lang$svg$Svg$node('path');
var _elm_lang$svg$Svg$polygon = _elm_lang$svg$Svg$node('polygon');
var _elm_lang$svg$Svg$polyline = _elm_lang$svg$Svg$node('polyline');
var _elm_lang$svg$Svg$rect = _elm_lang$svg$Svg$node('rect');
var _elm_lang$svg$Svg$use = _elm_lang$svg$Svg$node('use');
var _elm_lang$svg$Svg$feDistantLight = _elm_lang$svg$Svg$node('feDistantLight');
var _elm_lang$svg$Svg$fePointLight = _elm_lang$svg$Svg$node('fePointLight');
var _elm_lang$svg$Svg$feSpotLight = _elm_lang$svg$Svg$node('feSpotLight');
var _elm_lang$svg$Svg$altGlyph = _elm_lang$svg$Svg$node('altGlyph');
var _elm_lang$svg$Svg$altGlyphDef = _elm_lang$svg$Svg$node('altGlyphDef');
var _elm_lang$svg$Svg$altGlyphItem = _elm_lang$svg$Svg$node('altGlyphItem');
var _elm_lang$svg$Svg$glyph = _elm_lang$svg$Svg$node('glyph');
var _elm_lang$svg$Svg$glyphRef = _elm_lang$svg$Svg$node('glyphRef');
var _elm_lang$svg$Svg$textPath = _elm_lang$svg$Svg$node('textPath');
var _elm_lang$svg$Svg$text_ = _elm_lang$svg$Svg$node('text');
var _elm_lang$svg$Svg$tref = _elm_lang$svg$Svg$node('tref');
var _elm_lang$svg$Svg$tspan = _elm_lang$svg$Svg$node('tspan');
var _elm_lang$svg$Svg$clipPath = _elm_lang$svg$Svg$node('clipPath');
var _elm_lang$svg$Svg$colorProfile = _elm_lang$svg$Svg$node('colorProfile');
var _elm_lang$svg$Svg$cursor = _elm_lang$svg$Svg$node('cursor');
var _elm_lang$svg$Svg$filter = _elm_lang$svg$Svg$node('filter');
var _elm_lang$svg$Svg$script = _elm_lang$svg$Svg$node('script');
var _elm_lang$svg$Svg$style = _elm_lang$svg$Svg$node('style');
var _elm_lang$svg$Svg$view = _elm_lang$svg$Svg$node('view');

var _elm_lang$svg$Svg_Attributes$writingMode = _elm_lang$virtual_dom$VirtualDom$attribute('writing-mode');
var _elm_lang$svg$Svg_Attributes$wordSpacing = _elm_lang$virtual_dom$VirtualDom$attribute('word-spacing');
var _elm_lang$svg$Svg_Attributes$visibility = _elm_lang$virtual_dom$VirtualDom$attribute('visibility');
var _elm_lang$svg$Svg_Attributes$unicodeBidi = _elm_lang$virtual_dom$VirtualDom$attribute('unicode-bidi');
var _elm_lang$svg$Svg_Attributes$textRendering = _elm_lang$virtual_dom$VirtualDom$attribute('text-rendering');
var _elm_lang$svg$Svg_Attributes$textDecoration = _elm_lang$virtual_dom$VirtualDom$attribute('text-decoration');
var _elm_lang$svg$Svg_Attributes$textAnchor = _elm_lang$virtual_dom$VirtualDom$attribute('text-anchor');
var _elm_lang$svg$Svg_Attributes$stroke = _elm_lang$virtual_dom$VirtualDom$attribute('stroke');
var _elm_lang$svg$Svg_Attributes$strokeWidth = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-width');
var _elm_lang$svg$Svg_Attributes$strokeOpacity = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-opacity');
var _elm_lang$svg$Svg_Attributes$strokeMiterlimit = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-miterlimit');
var _elm_lang$svg$Svg_Attributes$strokeLinejoin = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-linejoin');
var _elm_lang$svg$Svg_Attributes$strokeLinecap = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-linecap');
var _elm_lang$svg$Svg_Attributes$strokeDashoffset = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-dashoffset');
var _elm_lang$svg$Svg_Attributes$strokeDasharray = _elm_lang$virtual_dom$VirtualDom$attribute('stroke-dasharray');
var _elm_lang$svg$Svg_Attributes$stopOpacity = _elm_lang$virtual_dom$VirtualDom$attribute('stop-opacity');
var _elm_lang$svg$Svg_Attributes$stopColor = _elm_lang$virtual_dom$VirtualDom$attribute('stop-color');
var _elm_lang$svg$Svg_Attributes$shapeRendering = _elm_lang$virtual_dom$VirtualDom$attribute('shape-rendering');
var _elm_lang$svg$Svg_Attributes$pointerEvents = _elm_lang$virtual_dom$VirtualDom$attribute('pointer-events');
var _elm_lang$svg$Svg_Attributes$overflow = _elm_lang$virtual_dom$VirtualDom$attribute('overflow');
var _elm_lang$svg$Svg_Attributes$opacity = _elm_lang$virtual_dom$VirtualDom$attribute('opacity');
var _elm_lang$svg$Svg_Attributes$mask = _elm_lang$virtual_dom$VirtualDom$attribute('mask');
var _elm_lang$svg$Svg_Attributes$markerStart = _elm_lang$virtual_dom$VirtualDom$attribute('marker-start');
var _elm_lang$svg$Svg_Attributes$markerMid = _elm_lang$virtual_dom$VirtualDom$attribute('marker-mid');
var _elm_lang$svg$Svg_Attributes$markerEnd = _elm_lang$virtual_dom$VirtualDom$attribute('marker-end');
var _elm_lang$svg$Svg_Attributes$lightingColor = _elm_lang$virtual_dom$VirtualDom$attribute('lighting-color');
var _elm_lang$svg$Svg_Attributes$letterSpacing = _elm_lang$virtual_dom$VirtualDom$attribute('letter-spacing');
var _elm_lang$svg$Svg_Attributes$kerning = _elm_lang$virtual_dom$VirtualDom$attribute('kerning');
var _elm_lang$svg$Svg_Attributes$imageRendering = _elm_lang$virtual_dom$VirtualDom$attribute('image-rendering');
var _elm_lang$svg$Svg_Attributes$glyphOrientationVertical = _elm_lang$virtual_dom$VirtualDom$attribute('glyph-orientation-vertical');
var _elm_lang$svg$Svg_Attributes$glyphOrientationHorizontal = _elm_lang$virtual_dom$VirtualDom$attribute('glyph-orientation-horizontal');
var _elm_lang$svg$Svg_Attributes$fontWeight = _elm_lang$virtual_dom$VirtualDom$attribute('font-weight');
var _elm_lang$svg$Svg_Attributes$fontVariant = _elm_lang$virtual_dom$VirtualDom$attribute('font-variant');
var _elm_lang$svg$Svg_Attributes$fontStyle = _elm_lang$virtual_dom$VirtualDom$attribute('font-style');
var _elm_lang$svg$Svg_Attributes$fontStretch = _elm_lang$virtual_dom$VirtualDom$attribute('font-stretch');
var _elm_lang$svg$Svg_Attributes$fontSize = _elm_lang$virtual_dom$VirtualDom$attribute('font-size');
var _elm_lang$svg$Svg_Attributes$fontSizeAdjust = _elm_lang$virtual_dom$VirtualDom$attribute('font-size-adjust');
var _elm_lang$svg$Svg_Attributes$fontFamily = _elm_lang$virtual_dom$VirtualDom$attribute('font-family');
var _elm_lang$svg$Svg_Attributes$floodOpacity = _elm_lang$virtual_dom$VirtualDom$attribute('flood-opacity');
var _elm_lang$svg$Svg_Attributes$floodColor = _elm_lang$virtual_dom$VirtualDom$attribute('flood-color');
var _elm_lang$svg$Svg_Attributes$filter = _elm_lang$virtual_dom$VirtualDom$attribute('filter');
var _elm_lang$svg$Svg_Attributes$fill = _elm_lang$virtual_dom$VirtualDom$attribute('fill');
var _elm_lang$svg$Svg_Attributes$fillRule = _elm_lang$virtual_dom$VirtualDom$attribute('fill-rule');
var _elm_lang$svg$Svg_Attributes$fillOpacity = _elm_lang$virtual_dom$VirtualDom$attribute('fill-opacity');
var _elm_lang$svg$Svg_Attributes$enableBackground = _elm_lang$virtual_dom$VirtualDom$attribute('enable-background');
var _elm_lang$svg$Svg_Attributes$dominantBaseline = _elm_lang$virtual_dom$VirtualDom$attribute('dominant-baseline');
var _elm_lang$svg$Svg_Attributes$display = _elm_lang$virtual_dom$VirtualDom$attribute('display');
var _elm_lang$svg$Svg_Attributes$direction = _elm_lang$virtual_dom$VirtualDom$attribute('direction');
var _elm_lang$svg$Svg_Attributes$cursor = _elm_lang$virtual_dom$VirtualDom$attribute('cursor');
var _elm_lang$svg$Svg_Attributes$color = _elm_lang$virtual_dom$VirtualDom$attribute('color');
var _elm_lang$svg$Svg_Attributes$colorRendering = _elm_lang$virtual_dom$VirtualDom$attribute('color-rendering');
var _elm_lang$svg$Svg_Attributes$colorProfile = _elm_lang$virtual_dom$VirtualDom$attribute('color-profile');
var _elm_lang$svg$Svg_Attributes$colorInterpolation = _elm_lang$virtual_dom$VirtualDom$attribute('color-interpolation');
var _elm_lang$svg$Svg_Attributes$colorInterpolationFilters = _elm_lang$virtual_dom$VirtualDom$attribute('color-interpolation-filters');
var _elm_lang$svg$Svg_Attributes$clip = _elm_lang$virtual_dom$VirtualDom$attribute('clip');
var _elm_lang$svg$Svg_Attributes$clipRule = _elm_lang$virtual_dom$VirtualDom$attribute('clip-rule');
var _elm_lang$svg$Svg_Attributes$clipPath = _elm_lang$virtual_dom$VirtualDom$attribute('clip-path');
var _elm_lang$svg$Svg_Attributes$baselineShift = _elm_lang$virtual_dom$VirtualDom$attribute('baseline-shift');
var _elm_lang$svg$Svg_Attributes$alignmentBaseline = _elm_lang$virtual_dom$VirtualDom$attribute('alignment-baseline');
var _elm_lang$svg$Svg_Attributes$zoomAndPan = _elm_lang$virtual_dom$VirtualDom$attribute('zoomAndPan');
var _elm_lang$svg$Svg_Attributes$z = _elm_lang$virtual_dom$VirtualDom$attribute('z');
var _elm_lang$svg$Svg_Attributes$yChannelSelector = _elm_lang$virtual_dom$VirtualDom$attribute('yChannelSelector');
var _elm_lang$svg$Svg_Attributes$y2 = _elm_lang$virtual_dom$VirtualDom$attribute('y2');
var _elm_lang$svg$Svg_Attributes$y1 = _elm_lang$virtual_dom$VirtualDom$attribute('y1');
var _elm_lang$svg$Svg_Attributes$y = _elm_lang$virtual_dom$VirtualDom$attribute('y');
var _elm_lang$svg$Svg_Attributes$xmlSpace = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/XML/1998/namespace', 'xml:space');
var _elm_lang$svg$Svg_Attributes$xmlLang = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/XML/1998/namespace', 'xml:lang');
var _elm_lang$svg$Svg_Attributes$xmlBase = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/XML/1998/namespace', 'xml:base');
var _elm_lang$svg$Svg_Attributes$xlinkType = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:type');
var _elm_lang$svg$Svg_Attributes$xlinkTitle = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:title');
var _elm_lang$svg$Svg_Attributes$xlinkShow = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:show');
var _elm_lang$svg$Svg_Attributes$xlinkRole = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:role');
var _elm_lang$svg$Svg_Attributes$xlinkHref = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:href');
var _elm_lang$svg$Svg_Attributes$xlinkArcrole = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:arcrole');
var _elm_lang$svg$Svg_Attributes$xlinkActuate = A2(_elm_lang$virtual_dom$VirtualDom$attributeNS, 'http://www.w3.org/1999/xlink', 'xlink:actuate');
var _elm_lang$svg$Svg_Attributes$xChannelSelector = _elm_lang$virtual_dom$VirtualDom$attribute('xChannelSelector');
var _elm_lang$svg$Svg_Attributes$x2 = _elm_lang$virtual_dom$VirtualDom$attribute('x2');
var _elm_lang$svg$Svg_Attributes$x1 = _elm_lang$virtual_dom$VirtualDom$attribute('x1');
var _elm_lang$svg$Svg_Attributes$xHeight = _elm_lang$virtual_dom$VirtualDom$attribute('x-height');
var _elm_lang$svg$Svg_Attributes$x = _elm_lang$virtual_dom$VirtualDom$attribute('x');
var _elm_lang$svg$Svg_Attributes$widths = _elm_lang$virtual_dom$VirtualDom$attribute('widths');
var _elm_lang$svg$Svg_Attributes$width = _elm_lang$virtual_dom$VirtualDom$attribute('width');
var _elm_lang$svg$Svg_Attributes$viewTarget = _elm_lang$virtual_dom$VirtualDom$attribute('viewTarget');
var _elm_lang$svg$Svg_Attributes$viewBox = _elm_lang$virtual_dom$VirtualDom$attribute('viewBox');
var _elm_lang$svg$Svg_Attributes$vertOriginY = _elm_lang$virtual_dom$VirtualDom$attribute('vert-origin-y');
var _elm_lang$svg$Svg_Attributes$vertOriginX = _elm_lang$virtual_dom$VirtualDom$attribute('vert-origin-x');
var _elm_lang$svg$Svg_Attributes$vertAdvY = _elm_lang$virtual_dom$VirtualDom$attribute('vert-adv-y');
var _elm_lang$svg$Svg_Attributes$version = _elm_lang$virtual_dom$VirtualDom$attribute('version');
var _elm_lang$svg$Svg_Attributes$values = _elm_lang$virtual_dom$VirtualDom$attribute('values');
var _elm_lang$svg$Svg_Attributes$vMathematical = _elm_lang$virtual_dom$VirtualDom$attribute('v-mathematical');
var _elm_lang$svg$Svg_Attributes$vIdeographic = _elm_lang$virtual_dom$VirtualDom$attribute('v-ideographic');
var _elm_lang$svg$Svg_Attributes$vHanging = _elm_lang$virtual_dom$VirtualDom$attribute('v-hanging');
var _elm_lang$svg$Svg_Attributes$vAlphabetic = _elm_lang$virtual_dom$VirtualDom$attribute('v-alphabetic');
var _elm_lang$svg$Svg_Attributes$unitsPerEm = _elm_lang$virtual_dom$VirtualDom$attribute('units-per-em');
var _elm_lang$svg$Svg_Attributes$unicodeRange = _elm_lang$virtual_dom$VirtualDom$attribute('unicode-range');
var _elm_lang$svg$Svg_Attributes$unicode = _elm_lang$virtual_dom$VirtualDom$attribute('unicode');
var _elm_lang$svg$Svg_Attributes$underlineThickness = _elm_lang$virtual_dom$VirtualDom$attribute('underline-thickness');
var _elm_lang$svg$Svg_Attributes$underlinePosition = _elm_lang$virtual_dom$VirtualDom$attribute('underline-position');
var _elm_lang$svg$Svg_Attributes$u2 = _elm_lang$virtual_dom$VirtualDom$attribute('u2');
var _elm_lang$svg$Svg_Attributes$u1 = _elm_lang$virtual_dom$VirtualDom$attribute('u1');
var _elm_lang$svg$Svg_Attributes$type_ = _elm_lang$virtual_dom$VirtualDom$attribute('type');
var _elm_lang$svg$Svg_Attributes$transform = _elm_lang$virtual_dom$VirtualDom$attribute('transform');
var _elm_lang$svg$Svg_Attributes$to = _elm_lang$virtual_dom$VirtualDom$attribute('to');
var _elm_lang$svg$Svg_Attributes$title = _elm_lang$virtual_dom$VirtualDom$attribute('title');
var _elm_lang$svg$Svg_Attributes$textLength = _elm_lang$virtual_dom$VirtualDom$attribute('textLength');
var _elm_lang$svg$Svg_Attributes$targetY = _elm_lang$virtual_dom$VirtualDom$attribute('targetY');
var _elm_lang$svg$Svg_Attributes$targetX = _elm_lang$virtual_dom$VirtualDom$attribute('targetX');
var _elm_lang$svg$Svg_Attributes$target = _elm_lang$virtual_dom$VirtualDom$attribute('target');
var _elm_lang$svg$Svg_Attributes$tableValues = _elm_lang$virtual_dom$VirtualDom$attribute('tableValues');
var _elm_lang$svg$Svg_Attributes$systemLanguage = _elm_lang$virtual_dom$VirtualDom$attribute('systemLanguage');
var _elm_lang$svg$Svg_Attributes$surfaceScale = _elm_lang$virtual_dom$VirtualDom$attribute('surfaceScale');
var _elm_lang$svg$Svg_Attributes$style = _elm_lang$virtual_dom$VirtualDom$attribute('style');
var _elm_lang$svg$Svg_Attributes$string = _elm_lang$virtual_dom$VirtualDom$attribute('string');
var _elm_lang$svg$Svg_Attributes$strikethroughThickness = _elm_lang$virtual_dom$VirtualDom$attribute('strikethrough-thickness');
var _elm_lang$svg$Svg_Attributes$strikethroughPosition = _elm_lang$virtual_dom$VirtualDom$attribute('strikethrough-position');
var _elm_lang$svg$Svg_Attributes$stitchTiles = _elm_lang$virtual_dom$VirtualDom$attribute('stitchTiles');
var _elm_lang$svg$Svg_Attributes$stemv = _elm_lang$virtual_dom$VirtualDom$attribute('stemv');
var _elm_lang$svg$Svg_Attributes$stemh = _elm_lang$virtual_dom$VirtualDom$attribute('stemh');
var _elm_lang$svg$Svg_Attributes$stdDeviation = _elm_lang$virtual_dom$VirtualDom$attribute('stdDeviation');
var _elm_lang$svg$Svg_Attributes$startOffset = _elm_lang$virtual_dom$VirtualDom$attribute('startOffset');
var _elm_lang$svg$Svg_Attributes$spreadMethod = _elm_lang$virtual_dom$VirtualDom$attribute('spreadMethod');
var _elm_lang$svg$Svg_Attributes$speed = _elm_lang$virtual_dom$VirtualDom$attribute('speed');
var _elm_lang$svg$Svg_Attributes$specularExponent = _elm_lang$virtual_dom$VirtualDom$attribute('specularExponent');
var _elm_lang$svg$Svg_Attributes$specularConstant = _elm_lang$virtual_dom$VirtualDom$attribute('specularConstant');
var _elm_lang$svg$Svg_Attributes$spacing = _elm_lang$virtual_dom$VirtualDom$attribute('spacing');
var _elm_lang$svg$Svg_Attributes$slope = _elm_lang$virtual_dom$VirtualDom$attribute('slope');
var _elm_lang$svg$Svg_Attributes$seed = _elm_lang$virtual_dom$VirtualDom$attribute('seed');
var _elm_lang$svg$Svg_Attributes$scale = _elm_lang$virtual_dom$VirtualDom$attribute('scale');
var _elm_lang$svg$Svg_Attributes$ry = _elm_lang$virtual_dom$VirtualDom$attribute('ry');
var _elm_lang$svg$Svg_Attributes$rx = _elm_lang$virtual_dom$VirtualDom$attribute('rx');
var _elm_lang$svg$Svg_Attributes$rotate = _elm_lang$virtual_dom$VirtualDom$attribute('rotate');
var _elm_lang$svg$Svg_Attributes$result = _elm_lang$virtual_dom$VirtualDom$attribute('result');
var _elm_lang$svg$Svg_Attributes$restart = _elm_lang$virtual_dom$VirtualDom$attribute('restart');
var _elm_lang$svg$Svg_Attributes$requiredFeatures = _elm_lang$virtual_dom$VirtualDom$attribute('requiredFeatures');
var _elm_lang$svg$Svg_Attributes$requiredExtensions = _elm_lang$virtual_dom$VirtualDom$attribute('requiredExtensions');
var _elm_lang$svg$Svg_Attributes$repeatDur = _elm_lang$virtual_dom$VirtualDom$attribute('repeatDur');
var _elm_lang$svg$Svg_Attributes$repeatCount = _elm_lang$virtual_dom$VirtualDom$attribute('repeatCount');
var _elm_lang$svg$Svg_Attributes$renderingIntent = _elm_lang$virtual_dom$VirtualDom$attribute('rendering-intent');
var _elm_lang$svg$Svg_Attributes$refY = _elm_lang$virtual_dom$VirtualDom$attribute('refY');
var _elm_lang$svg$Svg_Attributes$refX = _elm_lang$virtual_dom$VirtualDom$attribute('refX');
var _elm_lang$svg$Svg_Attributes$radius = _elm_lang$virtual_dom$VirtualDom$attribute('radius');
var _elm_lang$svg$Svg_Attributes$r = _elm_lang$virtual_dom$VirtualDom$attribute('r');
var _elm_lang$svg$Svg_Attributes$primitiveUnits = _elm_lang$virtual_dom$VirtualDom$attribute('primitiveUnits');
var _elm_lang$svg$Svg_Attributes$preserveAspectRatio = _elm_lang$virtual_dom$VirtualDom$attribute('preserveAspectRatio');
var _elm_lang$svg$Svg_Attributes$preserveAlpha = _elm_lang$virtual_dom$VirtualDom$attribute('preserveAlpha');
var _elm_lang$svg$Svg_Attributes$pointsAtZ = _elm_lang$virtual_dom$VirtualDom$attribute('pointsAtZ');
var _elm_lang$svg$Svg_Attributes$pointsAtY = _elm_lang$virtual_dom$VirtualDom$attribute('pointsAtY');
var _elm_lang$svg$Svg_Attributes$pointsAtX = _elm_lang$virtual_dom$VirtualDom$attribute('pointsAtX');
var _elm_lang$svg$Svg_Attributes$points = _elm_lang$virtual_dom$VirtualDom$attribute('points');
var _elm_lang$svg$Svg_Attributes$pointOrder = _elm_lang$virtual_dom$VirtualDom$attribute('point-order');
var _elm_lang$svg$Svg_Attributes$patternUnits = _elm_lang$virtual_dom$VirtualDom$attribute('patternUnits');
var _elm_lang$svg$Svg_Attributes$patternTransform = _elm_lang$virtual_dom$VirtualDom$attribute('patternTransform');
var _elm_lang$svg$Svg_Attributes$patternContentUnits = _elm_lang$virtual_dom$VirtualDom$attribute('patternContentUnits');
var _elm_lang$svg$Svg_Attributes$pathLength = _elm_lang$virtual_dom$VirtualDom$attribute('pathLength');
var _elm_lang$svg$Svg_Attributes$path = _elm_lang$virtual_dom$VirtualDom$attribute('path');
var _elm_lang$svg$Svg_Attributes$panose1 = _elm_lang$virtual_dom$VirtualDom$attribute('panose-1');
var _elm_lang$svg$Svg_Attributes$overlineThickness = _elm_lang$virtual_dom$VirtualDom$attribute('overline-thickness');
var _elm_lang$svg$Svg_Attributes$overlinePosition = _elm_lang$virtual_dom$VirtualDom$attribute('overline-position');
var _elm_lang$svg$Svg_Attributes$origin = _elm_lang$virtual_dom$VirtualDom$attribute('origin');
var _elm_lang$svg$Svg_Attributes$orientation = _elm_lang$virtual_dom$VirtualDom$attribute('orientation');
var _elm_lang$svg$Svg_Attributes$orient = _elm_lang$virtual_dom$VirtualDom$attribute('orient');
var _elm_lang$svg$Svg_Attributes$order = _elm_lang$virtual_dom$VirtualDom$attribute('order');
var _elm_lang$svg$Svg_Attributes$operator = _elm_lang$virtual_dom$VirtualDom$attribute('operator');
var _elm_lang$svg$Svg_Attributes$offset = _elm_lang$virtual_dom$VirtualDom$attribute('offset');
var _elm_lang$svg$Svg_Attributes$numOctaves = _elm_lang$virtual_dom$VirtualDom$attribute('numOctaves');
var _elm_lang$svg$Svg_Attributes$name = _elm_lang$virtual_dom$VirtualDom$attribute('name');
var _elm_lang$svg$Svg_Attributes$mode = _elm_lang$virtual_dom$VirtualDom$attribute('mode');
var _elm_lang$svg$Svg_Attributes$min = _elm_lang$virtual_dom$VirtualDom$attribute('min');
var _elm_lang$svg$Svg_Attributes$method = _elm_lang$virtual_dom$VirtualDom$attribute('method');
var _elm_lang$svg$Svg_Attributes$media = _elm_lang$virtual_dom$VirtualDom$attribute('media');
var _elm_lang$svg$Svg_Attributes$max = _elm_lang$virtual_dom$VirtualDom$attribute('max');
var _elm_lang$svg$Svg_Attributes$mathematical = _elm_lang$virtual_dom$VirtualDom$attribute('mathematical');
var _elm_lang$svg$Svg_Attributes$maskUnits = _elm_lang$virtual_dom$VirtualDom$attribute('maskUnits');
var _elm_lang$svg$Svg_Attributes$maskContentUnits = _elm_lang$virtual_dom$VirtualDom$attribute('maskContentUnits');
var _elm_lang$svg$Svg_Attributes$markerWidth = _elm_lang$virtual_dom$VirtualDom$attribute('markerWidth');
var _elm_lang$svg$Svg_Attributes$markerUnits = _elm_lang$virtual_dom$VirtualDom$attribute('markerUnits');
var _elm_lang$svg$Svg_Attributes$markerHeight = _elm_lang$virtual_dom$VirtualDom$attribute('markerHeight');
var _elm_lang$svg$Svg_Attributes$local = _elm_lang$virtual_dom$VirtualDom$attribute('local');
var _elm_lang$svg$Svg_Attributes$limitingConeAngle = _elm_lang$virtual_dom$VirtualDom$attribute('limitingConeAngle');
var _elm_lang$svg$Svg_Attributes$lengthAdjust = _elm_lang$virtual_dom$VirtualDom$attribute('lengthAdjust');
var _elm_lang$svg$Svg_Attributes$lang = _elm_lang$virtual_dom$VirtualDom$attribute('lang');
var _elm_lang$svg$Svg_Attributes$keyTimes = _elm_lang$virtual_dom$VirtualDom$attribute('keyTimes');
var _elm_lang$svg$Svg_Attributes$keySplines = _elm_lang$virtual_dom$VirtualDom$attribute('keySplines');
var _elm_lang$svg$Svg_Attributes$keyPoints = _elm_lang$virtual_dom$VirtualDom$attribute('keyPoints');
var _elm_lang$svg$Svg_Attributes$kernelUnitLength = _elm_lang$virtual_dom$VirtualDom$attribute('kernelUnitLength');
var _elm_lang$svg$Svg_Attributes$kernelMatrix = _elm_lang$virtual_dom$VirtualDom$attribute('kernelMatrix');
var _elm_lang$svg$Svg_Attributes$k4 = _elm_lang$virtual_dom$VirtualDom$attribute('k4');
var _elm_lang$svg$Svg_Attributes$k3 = _elm_lang$virtual_dom$VirtualDom$attribute('k3');
var _elm_lang$svg$Svg_Attributes$k2 = _elm_lang$virtual_dom$VirtualDom$attribute('k2');
var _elm_lang$svg$Svg_Attributes$k1 = _elm_lang$virtual_dom$VirtualDom$attribute('k1');
var _elm_lang$svg$Svg_Attributes$k = _elm_lang$virtual_dom$VirtualDom$attribute('k');
var _elm_lang$svg$Svg_Attributes$intercept = _elm_lang$virtual_dom$VirtualDom$attribute('intercept');
var _elm_lang$svg$Svg_Attributes$in2 = _elm_lang$virtual_dom$VirtualDom$attribute('in2');
var _elm_lang$svg$Svg_Attributes$in_ = _elm_lang$virtual_dom$VirtualDom$attribute('in');
var _elm_lang$svg$Svg_Attributes$ideographic = _elm_lang$virtual_dom$VirtualDom$attribute('ideographic');
var _elm_lang$svg$Svg_Attributes$id = _elm_lang$virtual_dom$VirtualDom$attribute('id');
var _elm_lang$svg$Svg_Attributes$horizOriginY = _elm_lang$virtual_dom$VirtualDom$attribute('horiz-origin-y');
var _elm_lang$svg$Svg_Attributes$horizOriginX = _elm_lang$virtual_dom$VirtualDom$attribute('horiz-origin-x');
var _elm_lang$svg$Svg_Attributes$horizAdvX = _elm_lang$virtual_dom$VirtualDom$attribute('horiz-adv-x');
var _elm_lang$svg$Svg_Attributes$height = _elm_lang$virtual_dom$VirtualDom$attribute('height');
var _elm_lang$svg$Svg_Attributes$hanging = _elm_lang$virtual_dom$VirtualDom$attribute('hanging');
var _elm_lang$svg$Svg_Attributes$gradientUnits = _elm_lang$virtual_dom$VirtualDom$attribute('gradientUnits');
var _elm_lang$svg$Svg_Attributes$gradientTransform = _elm_lang$virtual_dom$VirtualDom$attribute('gradientTransform');
var _elm_lang$svg$Svg_Attributes$glyphRef = _elm_lang$virtual_dom$VirtualDom$attribute('glyphRef');
var _elm_lang$svg$Svg_Attributes$glyphName = _elm_lang$virtual_dom$VirtualDom$attribute('glyph-name');
var _elm_lang$svg$Svg_Attributes$g2 = _elm_lang$virtual_dom$VirtualDom$attribute('g2');
var _elm_lang$svg$Svg_Attributes$g1 = _elm_lang$virtual_dom$VirtualDom$attribute('g1');
var _elm_lang$svg$Svg_Attributes$fy = _elm_lang$virtual_dom$VirtualDom$attribute('fy');
var _elm_lang$svg$Svg_Attributes$fx = _elm_lang$virtual_dom$VirtualDom$attribute('fx');
var _elm_lang$svg$Svg_Attributes$from = _elm_lang$virtual_dom$VirtualDom$attribute('from');
var _elm_lang$svg$Svg_Attributes$format = _elm_lang$virtual_dom$VirtualDom$attribute('format');
var _elm_lang$svg$Svg_Attributes$filterUnits = _elm_lang$virtual_dom$VirtualDom$attribute('filterUnits');
var _elm_lang$svg$Svg_Attributes$filterRes = _elm_lang$virtual_dom$VirtualDom$attribute('filterRes');
var _elm_lang$svg$Svg_Attributes$externalResourcesRequired = _elm_lang$virtual_dom$VirtualDom$attribute('externalResourcesRequired');
var _elm_lang$svg$Svg_Attributes$exponent = _elm_lang$virtual_dom$VirtualDom$attribute('exponent');
var _elm_lang$svg$Svg_Attributes$end = _elm_lang$virtual_dom$VirtualDom$attribute('end');
var _elm_lang$svg$Svg_Attributes$elevation = _elm_lang$virtual_dom$VirtualDom$attribute('elevation');
var _elm_lang$svg$Svg_Attributes$edgeMode = _elm_lang$virtual_dom$VirtualDom$attribute('edgeMode');
var _elm_lang$svg$Svg_Attributes$dy = _elm_lang$virtual_dom$VirtualDom$attribute('dy');
var _elm_lang$svg$Svg_Attributes$dx = _elm_lang$virtual_dom$VirtualDom$attribute('dx');
var _elm_lang$svg$Svg_Attributes$dur = _elm_lang$virtual_dom$VirtualDom$attribute('dur');
var _elm_lang$svg$Svg_Attributes$divisor = _elm_lang$virtual_dom$VirtualDom$attribute('divisor');
var _elm_lang$svg$Svg_Attributes$diffuseConstant = _elm_lang$virtual_dom$VirtualDom$attribute('diffuseConstant');
var _elm_lang$svg$Svg_Attributes$descent = _elm_lang$virtual_dom$VirtualDom$attribute('descent');
var _elm_lang$svg$Svg_Attributes$decelerate = _elm_lang$virtual_dom$VirtualDom$attribute('decelerate');
var _elm_lang$svg$Svg_Attributes$d = _elm_lang$virtual_dom$VirtualDom$attribute('d');
var _elm_lang$svg$Svg_Attributes$cy = _elm_lang$virtual_dom$VirtualDom$attribute('cy');
var _elm_lang$svg$Svg_Attributes$cx = _elm_lang$virtual_dom$VirtualDom$attribute('cx');
var _elm_lang$svg$Svg_Attributes$contentStyleType = _elm_lang$virtual_dom$VirtualDom$attribute('contentStyleType');
var _elm_lang$svg$Svg_Attributes$contentScriptType = _elm_lang$virtual_dom$VirtualDom$attribute('contentScriptType');
var _elm_lang$svg$Svg_Attributes$clipPathUnits = _elm_lang$virtual_dom$VirtualDom$attribute('clipPathUnits');
var _elm_lang$svg$Svg_Attributes$class = _elm_lang$virtual_dom$VirtualDom$attribute('class');
var _elm_lang$svg$Svg_Attributes$capHeight = _elm_lang$virtual_dom$VirtualDom$attribute('cap-height');
var _elm_lang$svg$Svg_Attributes$calcMode = _elm_lang$virtual_dom$VirtualDom$attribute('calcMode');
var _elm_lang$svg$Svg_Attributes$by = _elm_lang$virtual_dom$VirtualDom$attribute('by');
var _elm_lang$svg$Svg_Attributes$bias = _elm_lang$virtual_dom$VirtualDom$attribute('bias');
var _elm_lang$svg$Svg_Attributes$begin = _elm_lang$virtual_dom$VirtualDom$attribute('begin');
var _elm_lang$svg$Svg_Attributes$bbox = _elm_lang$virtual_dom$VirtualDom$attribute('bbox');
var _elm_lang$svg$Svg_Attributes$baseProfile = _elm_lang$virtual_dom$VirtualDom$attribute('baseProfile');
var _elm_lang$svg$Svg_Attributes$baseFrequency = _elm_lang$virtual_dom$VirtualDom$attribute('baseFrequency');
var _elm_lang$svg$Svg_Attributes$azimuth = _elm_lang$virtual_dom$VirtualDom$attribute('azimuth');
var _elm_lang$svg$Svg_Attributes$autoReverse = _elm_lang$virtual_dom$VirtualDom$attribute('autoReverse');
var _elm_lang$svg$Svg_Attributes$attributeType = _elm_lang$virtual_dom$VirtualDom$attribute('attributeType');
var _elm_lang$svg$Svg_Attributes$attributeName = _elm_lang$virtual_dom$VirtualDom$attribute('attributeName');
var _elm_lang$svg$Svg_Attributes$ascent = _elm_lang$virtual_dom$VirtualDom$attribute('ascent');
var _elm_lang$svg$Svg_Attributes$arabicForm = _elm_lang$virtual_dom$VirtualDom$attribute('arabic-form');
var _elm_lang$svg$Svg_Attributes$amplitude = _elm_lang$virtual_dom$VirtualDom$attribute('amplitude');
var _elm_lang$svg$Svg_Attributes$allowReorder = _elm_lang$virtual_dom$VirtualDom$attribute('allowReorder');
var _elm_lang$svg$Svg_Attributes$alphabetic = _elm_lang$virtual_dom$VirtualDom$attribute('alphabetic');
var _elm_lang$svg$Svg_Attributes$additive = _elm_lang$virtual_dom$VirtualDom$attribute('additive');
var _elm_lang$svg$Svg_Attributes$accumulate = _elm_lang$virtual_dom$VirtualDom$attribute('accumulate');
var _elm_lang$svg$Svg_Attributes$accelerate = _elm_lang$virtual_dom$VirtualDom$attribute('accelerate');
var _elm_lang$svg$Svg_Attributes$accentHeight = _elm_lang$virtual_dom$VirtualDom$attribute('accent-height');

var _ianmackenzie$acorn_demo$Geometry_Types$Vector2d = function (a) {
	return {ctor: 'Vector2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Vector3d = function (a) {
	return {ctor: 'Vector3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Direction2d = function (a) {
	return {ctor: 'Direction2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Direction3d = function (a) {
	return {ctor: 'Direction3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Point2d = function (a) {
	return {ctor: 'Point2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Point3d = function (a) {
	return {ctor: 'Point3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Axis2d = function (a) {
	return {ctor: 'Axis2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Axis3d = function (a) {
	return {ctor: 'Axis3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Plane3d = function (a) {
	return {ctor: 'Plane3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Frame2d = function (a) {
	return {ctor: 'Frame2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Frame3d = function (a) {
	return {ctor: 'Frame3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$SketchPlane3d = function (a) {
	return {ctor: 'SketchPlane3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$LineSegment2d = function (a) {
	return {ctor: 'LineSegment2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$LineSegment3d = function (a) {
	return {ctor: 'LineSegment3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Triangle2d = function (a) {
	return {ctor: 'Triangle2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Triangle3d = function (a) {
	return {ctor: 'Triangle3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$BoundingBox2d = function (a) {
	return {ctor: 'BoundingBox2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$BoundingBox3d = function (a) {
	return {ctor: 'BoundingBox3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d = function (a) {
	return {ctor: 'Rectangle2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Rectangle3d = function (a) {
	return {ctor: 'Rectangle3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Block3d = function (a) {
	return {ctor: 'Block3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Polyline2d = function (a) {
	return {ctor: 'Polyline2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Polyline3d = function (a) {
	return {ctor: 'Polyline3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d = function (a) {
	return {ctor: 'Polygon2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Circle2d = function (a) {
	return {ctor: 'Circle2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Circle3d = function (a) {
	return {ctor: 'Circle3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Ellipse2d = function (a) {
	return {ctor: 'Ellipse2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Sphere3d = function (a) {
	return {ctor: 'Sphere3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$LargeNegative = {ctor: 'LargeNegative'};
var _ianmackenzie$acorn_demo$Geometry_Types$LargePositive = {ctor: 'LargePositive'};
var _ianmackenzie$acorn_demo$Geometry_Types$SmallNegative = {ctor: 'SmallNegative'};
var _ianmackenzie$acorn_demo$Geometry_Types$SmallPositive = {ctor: 'SmallPositive'};
var _ianmackenzie$acorn_demo$Geometry_Types$Arc2d = function (a) {
	return {ctor: 'Arc2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$Arc3d = function (a) {
	return {ctor: 'Arc3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$QuadraticSpline2d = function (a) {
	return {ctor: 'QuadraticSpline2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$QuadraticSpline3d = function (a) {
	return {ctor: 'QuadraticSpline3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$CubicSpline2d = function (a) {
	return {ctor: 'CubicSpline2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$CubicSpline3d = function (a) {
	return {ctor: 'CubicSpline3d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$EllipticalArc2d = function (a) {
	return {ctor: 'EllipticalArc2d', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_Types$MaxError = function (a) {
	return {ctor: 'MaxError', _0: a};
};

var _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$Bootstrap_Direction2d$unsafe = _ianmackenzie$acorn_demo$Geometry_Types$Direction2d;
var _ianmackenzie$acorn_demo$Bootstrap_Direction2d$flip = function (direction) {
	var _p2 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(direction);
	var x = _p2._0;
	var y = _p2._1;
	return _ianmackenzie$acorn_demo$Bootstrap_Direction2d$unsafe(
		{ctor: '_Tuple2', _0: 0 - x, _1: 0 - y});
};
var _ianmackenzie$acorn_demo$Bootstrap_Direction2d$perpendicularTo = function (direction) {
	var _p3 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(direction);
	var x = _p3._0;
	var y = _p3._1;
	return _ianmackenzie$acorn_demo$Bootstrap_Direction2d$unsafe(
		{ctor: '_Tuple2', _0: 0 - y, _1: x});
};

var _ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction = function (_p0) {
	var _p1 = _p0;
	return _p1._0.direction;
};
var _ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint = function (_p2) {
	var _p3 = _p2;
	return _p3._0.originPoint;
};

var _ianmackenzie$acorn_demo$Bootstrap_Frame2d$yDirection = function (_p0) {
	var _p1 = _p0;
	return _p1._0.yDirection;
};
var _ianmackenzie$acorn_demo$Bootstrap_Frame2d$xDirection = function (_p2) {
	var _p3 = _p2;
	return _p3._0.xDirection;
};
var _ianmackenzie$acorn_demo$Bootstrap_Frame2d$originPoint = function (_p4) {
	var _p5 = _p4;
	return _p5._0.originPoint;
};

var _ianmackenzie$acorn_demo$Bootstrap_Point2d$coordinates = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$Bootstrap_Point2d$fromCoordinates = _ianmackenzie$acorn_demo$Geometry_Types$Point2d;

var _ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom = F3(
	function (start, end, parameter) {
		return (_elm_lang$core$Native_Utils.cmp(parameter, 0.5) < 1) ? (start + (parameter * (end - start))) : (end + ((1 - parameter) * (start - end)));
	});
var _ianmackenzie$elm_float_extra$Float_Extra$equalWithin = F3(
	function (tolerance, firstValue, secondValue) {
		return _elm_lang$core$Native_Utils.cmp(
			_elm_lang$core$Basics$abs(secondValue - firstValue),
			tolerance) < 1;
	});

var _ianmackenzie$acorn_demo$Vector2d$yComponent = function (_p0) {
	var _p1 = _p0;
	return _p1._0._1;
};
var _ianmackenzie$acorn_demo$Vector2d$xComponent = function (_p2) {
	var _p3 = _p2;
	return _p3._0._0;
};
var _ianmackenzie$acorn_demo$Vector2d$components = function (_p4) {
	var _p5 = _p4;
	return _p5._0;
};
var _ianmackenzie$acorn_demo$Vector2d$componentIn = F2(
	function (direction_, vector) {
		var _p6 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var vx = _p6._0;
		var vy = _p6._1;
		var _p7 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(direction_);
		var dx = _p7._0;
		var dy = _p7._1;
		return (vx * dx) + (vy * dy);
	});
var _ianmackenzie$acorn_demo$Vector2d$polarComponents = function (vector) {
	return _elm_lang$core$Basics$toPolar(
		_ianmackenzie$acorn_demo$Vector2d$components(vector));
};
var _ianmackenzie$acorn_demo$Vector2d$squaredLength = function (vector) {
	var _p8 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
	var x = _p8._0;
	var y = _p8._1;
	return (x * x) + (y * y);
};
var _ianmackenzie$acorn_demo$Vector2d$length = function (vector) {
	return _elm_lang$core$Basics$sqrt(
		_ianmackenzie$acorn_demo$Vector2d$squaredLength(vector));
};
var _ianmackenzie$acorn_demo$Vector2d$dotProduct = F2(
	function (firstVector, secondVector) {
		var _p9 = _ianmackenzie$acorn_demo$Vector2d$components(secondVector);
		var x2 = _p9._0;
		var y2 = _p9._1;
		var _p10 = _ianmackenzie$acorn_demo$Vector2d$components(firstVector);
		var x1 = _p10._0;
		var y1 = _p10._1;
		return (x1 * x2) + (y1 * y2);
	});
var _ianmackenzie$acorn_demo$Vector2d$crossProduct = F2(
	function (firstVector, secondVector) {
		var _p11 = _ianmackenzie$acorn_demo$Vector2d$components(secondVector);
		var x2 = _p11._0;
		var y2 = _p11._1;
		var _p12 = _ianmackenzie$acorn_demo$Vector2d$components(firstVector);
		var x1 = _p12._0;
		var y1 = _p12._1;
		return (x1 * y2) - (y1 * x2);
	});
var _ianmackenzie$acorn_demo$Vector2d$fromComponents = _ianmackenzie$acorn_demo$Geometry_Types$Vector2d;
var _ianmackenzie$acorn_demo$Vector2d$fromPolarComponents = function (polarComponents_) {
	return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		_elm_lang$core$Basics$fromPolar(polarComponents_));
};
var _ianmackenzie$acorn_demo$Vector2d$from = F2(
	function (firstPoint, secondPoint) {
		var _p13 = _ianmackenzie$acorn_demo$Bootstrap_Point2d$coordinates(secondPoint);
		var x2 = _p13._0;
		var y2 = _p13._1;
		var _p14 = _ianmackenzie$acorn_demo$Bootstrap_Point2d$coordinates(firstPoint);
		var x1 = _p14._0;
		var y1 = _p14._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: x2 - x1, _1: y2 - y1});
	});
var _ianmackenzie$acorn_demo$Vector2d$withLength = F2(
	function (length_, direction_) {
		var _p15 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(direction_);
		var dx = _p15._0;
		var dy = _p15._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: length_ * dx, _1: length_ * dy});
	});
var _ianmackenzie$acorn_demo$Vector2d$projectionIn = F2(
	function (direction_, vector) {
		return A2(
			_ianmackenzie$acorn_demo$Vector2d$withLength,
			A2(_ianmackenzie$acorn_demo$Vector2d$componentIn, direction_, vector),
			direction_);
	});
var _ianmackenzie$acorn_demo$Vector2d$projectOnto = F2(
	function (axis, vector) {
		return A2(
			_ianmackenzie$acorn_demo$Vector2d$projectionIn,
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction(axis),
			vector);
	});
var _ianmackenzie$acorn_demo$Vector2d$interpolateFrom = F3(
	function (v1, v2, t) {
		var _p16 = _ianmackenzie$acorn_demo$Vector2d$components(v2);
		var x2 = _p16._0;
		var y2 = _p16._1;
		var _p17 = _ianmackenzie$acorn_demo$Vector2d$components(v1);
		var x1 = _p17._0;
		var y1 = _p17._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{
				ctor: '_Tuple2',
				_0: A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, x1, x2, t),
				_1: A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, y1, y2, t)
			});
	});
var _ianmackenzie$acorn_demo$Vector2d$sum = F2(
	function (firstVector, secondVector) {
		var _p18 = _ianmackenzie$acorn_demo$Vector2d$components(secondVector);
		var x2 = _p18._0;
		var y2 = _p18._1;
		var _p19 = _ianmackenzie$acorn_demo$Vector2d$components(firstVector);
		var x1 = _p19._0;
		var y1 = _p19._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: x1 + x2, _1: y1 + y2});
	});
var _ianmackenzie$acorn_demo$Vector2d$difference = F2(
	function (firstVector, secondVector) {
		var _p20 = _ianmackenzie$acorn_demo$Vector2d$components(secondVector);
		var x2 = _p20._0;
		var y2 = _p20._1;
		var _p21 = _ianmackenzie$acorn_demo$Vector2d$components(firstVector);
		var x1 = _p21._0;
		var y1 = _p21._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: x1 - x2, _1: y1 - y2});
	});
var _ianmackenzie$acorn_demo$Vector2d$equalWithin = F3(
	function (tolerance, firstVector, secondVector) {
		return _elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$Vector2d$squaredLength(
				A2(_ianmackenzie$acorn_demo$Vector2d$difference, firstVector, secondVector)),
			tolerance * tolerance) < 1;
	});
var _ianmackenzie$acorn_demo$Vector2d$flip = function (vector) {
	var _p22 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
	var x = _p22._0;
	var y = _p22._1;
	return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		{ctor: '_Tuple2', _0: 0 - x, _1: 0 - y});
};
var _ianmackenzie$acorn_demo$Vector2d$scaleBy = F2(
	function (scale, vector) {
		var _p23 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var x = _p23._0;
		var y = _p23._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: x * scale, _1: y * scale});
	});
var _ianmackenzie$acorn_demo$Vector2d$lengthAndDirection = function (vector) {
	var vectorLength = _ianmackenzie$acorn_demo$Vector2d$length(vector);
	if (_elm_lang$core$Native_Utils.eq(vectorLength, 0.0)) {
		return _elm_lang$core$Maybe$Nothing;
	} else {
		var normalizedVector = A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, 1 / vectorLength, vector);
		var vectorDirection = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$unsafe(
			_ianmackenzie$acorn_demo$Vector2d$components(normalizedVector));
		return _elm_lang$core$Maybe$Just(
			{ctor: '_Tuple2', _0: vectorLength, _1: vectorDirection});
	}
};
var _ianmackenzie$acorn_demo$Vector2d$rotateBy = function (angle) {
	var sine = _elm_lang$core$Basics$sin(angle);
	var cosine = _elm_lang$core$Basics$cos(angle);
	return function (vector) {
		var _p24 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var x = _p24._0;
		var y = _p24._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: (x * cosine) - (y * sine), _1: (y * cosine) + (x * sine)});
	};
};
var _ianmackenzie$acorn_demo$Vector2d$rotateCounterclockwise = function (vector) {
	var _p25 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
	var x = _p25._0;
	var y = _p25._1;
	return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		{ctor: '_Tuple2', _0: 0 - y, _1: x});
};
var _ianmackenzie$acorn_demo$Vector2d$perpendicularTo = function (vector) {
	return _ianmackenzie$acorn_demo$Vector2d$rotateCounterclockwise(vector);
};
var _ianmackenzie$acorn_demo$Vector2d$rotateClockwise = function (vector) {
	var _p26 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
	var x = _p26._0;
	var y = _p26._1;
	return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		{ctor: '_Tuple2', _0: y, _1: 0 - x});
};
var _ianmackenzie$acorn_demo$Vector2d$mirrorAcross = function (axis) {
	var _p27 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(
		_ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction(axis));
	var dx = _p27._0;
	var dy = _p27._1;
	var a = 1 - ((2 * dy) * dy);
	var b = (2 * dx) * dy;
	var c = 1 - ((2 * dx) * dx);
	return function (vector) {
		var _p28 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var vx = _p28._0;
		var vy = _p28._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: (a * vx) + (b * vy), _1: (c * vy) + (b * vx)});
	};
};
var _ianmackenzie$acorn_demo$Vector2d$relativeTo = F2(
	function (frame, vector) {
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{
				ctor: '_Tuple2',
				_0: A2(
					_ianmackenzie$acorn_demo$Vector2d$componentIn,
					_ianmackenzie$acorn_demo$Bootstrap_Frame2d$xDirection(frame),
					vector),
				_1: A2(
					_ianmackenzie$acorn_demo$Vector2d$componentIn,
					_ianmackenzie$acorn_demo$Bootstrap_Frame2d$yDirection(frame),
					vector)
			});
	});
var _ianmackenzie$acorn_demo$Vector2d$placeIn = function (frame) {
	var _p29 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(
		_ianmackenzie$acorn_demo$Bootstrap_Frame2d$yDirection(frame));
	var x2 = _p29._0;
	var y2 = _p29._1;
	var _p30 = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components(
		_ianmackenzie$acorn_demo$Bootstrap_Frame2d$xDirection(frame));
	var x1 = _p30._0;
	var y1 = _p30._1;
	return function (vector) {
		var _p31 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var x = _p31._0;
		var y = _p31._1;
		return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
			{ctor: '_Tuple2', _0: (x1 * x) + (x2 * y), _1: (y1 * x) + (y2 * y)});
	};
};
var _ianmackenzie$acorn_demo$Vector2d$zero = _ianmackenzie$acorn_demo$Vector2d$fromComponents(
	{ctor: '_Tuple2', _0: 0, _1: 0});
var _ianmackenzie$acorn_demo$Vector2d$direction = function (vector) {
	if (_elm_lang$core$Native_Utils.eq(vector, _ianmackenzie$acorn_demo$Vector2d$zero)) {
		return _elm_lang$core$Maybe$Nothing;
	} else {
		var normalizedVector = A2(
			_ianmackenzie$acorn_demo$Vector2d$scaleBy,
			1 / _ianmackenzie$acorn_demo$Vector2d$length(vector),
			vector);
		return _elm_lang$core$Maybe$Just(
			_ianmackenzie$acorn_demo$Bootstrap_Direction2d$unsafe(
				_ianmackenzie$acorn_demo$Vector2d$components(normalizedVector)));
	}
};
var _ianmackenzie$acorn_demo$Vector2d$normalize = function (vector) {
	return _elm_lang$core$Native_Utils.eq(vector, _ianmackenzie$acorn_demo$Vector2d$zero) ? _ianmackenzie$acorn_demo$Vector2d$zero : A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		1 / _ianmackenzie$acorn_demo$Vector2d$length(vector),
		vector);
};

var _ianmackenzie$acorn_demo$Direction2d$flip = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$flip;
var _ianmackenzie$acorn_demo$Direction2d$yComponent = function (_p0) {
	var _p1 = _p0;
	return _p1._0._1;
};
var _ianmackenzie$acorn_demo$Direction2d$xComponent = function (_p2) {
	var _p3 = _p2;
	return _p3._0._0;
};
var _ianmackenzie$acorn_demo$Direction2d$components = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$components;
var _ianmackenzie$acorn_demo$Direction2d$toVector = function (direction) {
	return _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		_ianmackenzie$acorn_demo$Direction2d$components(direction));
};
var _ianmackenzie$acorn_demo$Direction2d$componentIn = F2(
	function (firstDirection, secondDirection) {
		return A2(
			_ianmackenzie$acorn_demo$Vector2d$componentIn,
			firstDirection,
			_ianmackenzie$acorn_demo$Direction2d$toVector(secondDirection));
	});
var _ianmackenzie$acorn_demo$Direction2d$angleFrom = F2(
	function (firstDirection, secondDirection) {
		var secondVector = _ianmackenzie$acorn_demo$Direction2d$toVector(secondDirection);
		var firstVector = _ianmackenzie$acorn_demo$Direction2d$toVector(firstDirection);
		return A2(
			_elm_lang$core$Basics$atan2,
			A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, firstVector, secondVector),
			A2(_ianmackenzie$acorn_demo$Vector2d$dotProduct, firstVector, secondVector));
	});
var _ianmackenzie$acorn_demo$Direction2d$equalWithin = F3(
	function (angle, firstDirection, secondDirection) {
		return _elm_lang$core$Native_Utils.cmp(
			_elm_lang$core$Basics$abs(
				A2(_ianmackenzie$acorn_demo$Direction2d$angleFrom, firstDirection, secondDirection)),
			angle) < 1;
	});
var _ianmackenzie$acorn_demo$Direction2d$toAngle = function (direction) {
	var _p4 = _ianmackenzie$acorn_demo$Direction2d$components(direction);
	var xComponent_ = _p4._0;
	var yComponent_ = _p4._1;
	return A2(_elm_lang$core$Basics$atan2, yComponent_, xComponent_);
};
var _ianmackenzie$acorn_demo$Direction2d$perpendicularTo = _ianmackenzie$acorn_demo$Bootstrap_Direction2d$perpendicularTo;
var _ianmackenzie$acorn_demo$Direction2d$orthonormalize = F2(
	function (xVector, xyVector) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (xDirection) {
				var yDirection = _ianmackenzie$acorn_demo$Direction2d$perpendicularTo(xDirection);
				var perpendicularComponent = A2(_ianmackenzie$acorn_demo$Vector2d$componentIn, yDirection, xyVector);
				return (_elm_lang$core$Native_Utils.cmp(perpendicularComponent, 0.0) > 0) ? _elm_lang$core$Maybe$Just(
					{ctor: '_Tuple2', _0: xDirection, _1: yDirection}) : ((_elm_lang$core$Native_Utils.cmp(perpendicularComponent, 0.0) < 0) ? _elm_lang$core$Maybe$Just(
					{
						ctor: '_Tuple2',
						_0: xDirection,
						_1: _ianmackenzie$acorn_demo$Direction2d$flip(yDirection)
					}) : _elm_lang$core$Maybe$Nothing);
			},
			_ianmackenzie$acorn_demo$Vector2d$direction(xVector));
	});
var _ianmackenzie$acorn_demo$Direction2d$orthogonalize = F2(
	function (xDirection, yDirection) {
		return A2(
			_ianmackenzie$acorn_demo$Direction2d$orthonormalize,
			_ianmackenzie$acorn_demo$Direction2d$toVector(xDirection),
			_ianmackenzie$acorn_demo$Direction2d$toVector(yDirection));
	});
var _ianmackenzie$acorn_demo$Direction2d$from = F2(
	function (firstPoint, secondPoint) {
		return _ianmackenzie$acorn_demo$Vector2d$direction(
			A2(_ianmackenzie$acorn_demo$Vector2d$from, firstPoint, secondPoint));
	});
var _ianmackenzie$acorn_demo$Direction2d$unsafe = _ianmackenzie$acorn_demo$Geometry_Types$Direction2d;
var _ianmackenzie$acorn_demo$Direction2d$fromAngle = function (angle) {
	return _ianmackenzie$acorn_demo$Direction2d$unsafe(
		{
			ctor: '_Tuple2',
			_0: _elm_lang$core$Basics$cos(angle),
			_1: _elm_lang$core$Basics$sin(angle)
		});
};
var _ianmackenzie$acorn_demo$Direction2d$rotateClockwise = function (direction) {
	var _p5 = _ianmackenzie$acorn_demo$Direction2d$components(direction);
	var xComponent_ = _p5._0;
	var yComponent_ = _p5._1;
	return _ianmackenzie$acorn_demo$Direction2d$unsafe(
		{ctor: '_Tuple2', _0: yComponent_, _1: 0 - xComponent_});
};
var _ianmackenzie$acorn_demo$Direction2d$rotateCounterclockwise = function (direction) {
	var _p6 = _ianmackenzie$acorn_demo$Direction2d$components(direction);
	var xComponent_ = _p6._0;
	var yComponent_ = _p6._1;
	return _ianmackenzie$acorn_demo$Direction2d$unsafe(
		{ctor: '_Tuple2', _0: 0 - yComponent_, _1: xComponent_});
};
var _ianmackenzie$acorn_demo$Direction2d$negativeY = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: 0, _1: -1});
var _ianmackenzie$acorn_demo$Direction2d$positiveY = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: 0, _1: 1});
var _ianmackenzie$acorn_demo$Direction2d$negativeX = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: -1, _1: 0});
var _ianmackenzie$acorn_demo$Direction2d$positiveX = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: 1, _1: 0});
var _ianmackenzie$acorn_demo$Direction2d$y = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: 0, _1: 1});
var _ianmackenzie$acorn_demo$Direction2d$x = _ianmackenzie$acorn_demo$Direction2d$unsafe(
	{ctor: '_Tuple2', _0: 1, _1: 0});
var _ianmackenzie$acorn_demo$Direction2d$toDirection = function (vector) {
	return _ianmackenzie$acorn_demo$Direction2d$unsafe(
		_ianmackenzie$acorn_demo$Vector2d$components(vector));
};
var _ianmackenzie$acorn_demo$Direction2d$rotateBy = F2(
	function (angle, direction) {
		return _ianmackenzie$acorn_demo$Direction2d$toDirection(
			A2(
				_ianmackenzie$acorn_demo$Vector2d$rotateBy,
				angle,
				_ianmackenzie$acorn_demo$Direction2d$toVector(direction)));
	});
var _ianmackenzie$acorn_demo$Direction2d$mirrorAcross = F2(
	function (axis, direction) {
		return _ianmackenzie$acorn_demo$Direction2d$toDirection(
			A2(
				_ianmackenzie$acorn_demo$Vector2d$mirrorAcross,
				axis,
				_ianmackenzie$acorn_demo$Direction2d$toVector(direction)));
	});
var _ianmackenzie$acorn_demo$Direction2d$relativeTo = F2(
	function (frame, direction) {
		return _ianmackenzie$acorn_demo$Direction2d$toDirection(
			A2(
				_ianmackenzie$acorn_demo$Vector2d$relativeTo,
				frame,
				_ianmackenzie$acorn_demo$Direction2d$toVector(direction)));
	});
var _ianmackenzie$acorn_demo$Direction2d$placeIn = F2(
	function (frame, direction) {
		return _ianmackenzie$acorn_demo$Direction2d$toDirection(
			A2(
				_ianmackenzie$acorn_demo$Vector2d$placeIn,
				frame,
				_ianmackenzie$acorn_demo$Direction2d$toVector(direction)));
	});

var _ianmackenzie$acorn_demo$Point2d$signedDistanceFrom = F2(
	function (axis, point) {
		var displacementVector = A2(
			_ianmackenzie$acorn_demo$Vector2d$from,
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
			point);
		var directionVector = _ianmackenzie$acorn_demo$Direction2d$toVector(
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction(axis));
		return A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, directionVector, displacementVector);
	});
var _ianmackenzie$acorn_demo$Point2d$signedDistanceAlong = F2(
	function (axis, point) {
		return A2(
			_ianmackenzie$acorn_demo$Vector2d$componentIn,
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction(axis),
			A2(
				_ianmackenzie$acorn_demo$Vector2d$from,
				_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
				point));
	});
var _ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom = F2(
	function (firstPoint, secondPoint) {
		return _ianmackenzie$acorn_demo$Vector2d$squaredLength(
			A2(_ianmackenzie$acorn_demo$Vector2d$from, firstPoint, secondPoint));
	});
var _ianmackenzie$acorn_demo$Point2d$distanceFrom = F2(
	function (firstPoint, secondPoint) {
		return _elm_lang$core$Basics$sqrt(
			A2(_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom, firstPoint, secondPoint));
	});
var _ianmackenzie$acorn_demo$Point2d$equalWithin = F3(
	function (tolerance, firstPoint, secondPoint) {
		return _elm_lang$core$Native_Utils.cmp(
			A2(_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom, firstPoint, secondPoint),
			tolerance * tolerance) < 1;
	});
var _ianmackenzie$acorn_demo$Point2d$yCoordinate = function (_p0) {
	var _p1 = _p0;
	return _p1._0._1;
};
var _ianmackenzie$acorn_demo$Point2d$xCoordinate = function (_p2) {
	var _p3 = _p2;
	return _p3._0._0;
};
var _ianmackenzie$acorn_demo$Point2d$coordinates = function (_p4) {
	var _p5 = _p4;
	return _p5._0;
};
var _ianmackenzie$acorn_demo$Point2d$polarCoordinates = function (point) {
	return _elm_lang$core$Basics$toPolar(
		_ianmackenzie$acorn_demo$Point2d$coordinates(point));
};
var _ianmackenzie$acorn_demo$Point2d$fromCoordinates = _ianmackenzie$acorn_demo$Geometry_Types$Point2d;
var _ianmackenzie$acorn_demo$Point2d$fromPolarCoordinates = function (polarCoordinates_) {
	return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
		_elm_lang$core$Basics$fromPolar(polarCoordinates_));
};
var _ianmackenzie$acorn_demo$Point2d$interpolateFrom = F3(
	function (p1, p2, t) {
		var _p6 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
		var x2 = _p6._0;
		var y2 = _p6._1;
		var _p7 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
		var x1 = _p7._0;
		var y1 = _p7._1;
		return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{
				ctor: '_Tuple2',
				_0: A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, x1, x2, t),
				_1: A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, y1, y2, t)
			});
	});
var _ianmackenzie$acorn_demo$Point2d$midpoint = F2(
	function (firstPoint, secondPoint) {
		return A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, firstPoint, secondPoint, 0.5);
	});
var _ianmackenzie$acorn_demo$Point2d$circumcenter = F3(
	function (p1, p2, p3) {
		var c2 = A2(_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom, p3, p1);
		var b2 = A2(_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom, p2, p3);
		var a2 = A2(_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom, p1, p2);
		var t1 = a2 * ((b2 + c2) - a2);
		var t2 = b2 * ((c2 + a2) - b2);
		var t3 = c2 * ((a2 + b2) - c2);
		var sum = (t1 + t2) + t3;
		if (_elm_lang$core$Native_Utils.eq(sum, 0)) {
			return _elm_lang$core$Maybe$Nothing;
		} else {
			var _p8 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
			var x3 = _p8._0;
			var y3 = _p8._1;
			var _p9 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
			var x2 = _p9._0;
			var y2 = _p9._1;
			var _p10 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
			var x1 = _p10._0;
			var y1 = _p10._1;
			var w3 = t3 / sum;
			var w2 = t2 / sum;
			var w1 = t1 / sum;
			return _elm_lang$core$Maybe$Just(
				_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
					{ctor: '_Tuple2', _0: ((w1 * x3) + (w2 * x1)) + (w3 * x2), _1: ((w1 * y3) + (w2 * y1)) + (w3 * y2)}));
		}
	});
var _ianmackenzie$acorn_demo$Point2d$translateBy = F2(
	function (vector, point) {
		var _p11 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var px = _p11._0;
		var py = _p11._1;
		var _p12 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var vx = _p12._0;
		var vy = _p12._1;
		return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{ctor: '_Tuple2', _0: px + vx, _1: py + vy});
	});
var _ianmackenzie$acorn_demo$Point2d$along = F2(
	function (axis, distance) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$translateBy,
			A2(
				_ianmackenzie$acorn_demo$Vector2d$withLength,
				distance,
				_ianmackenzie$acorn_demo$Bootstrap_Axis2d$direction(axis)),
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis));
	});
var _ianmackenzie$acorn_demo$Point2d$translateIn = F3(
	function (direction, distance, point) {
		var _p13 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var px = _p13._0;
		var py = _p13._1;
		var _p14 = _ianmackenzie$acorn_demo$Direction2d$components(direction);
		var dx = _p14._0;
		var dy = _p14._1;
		return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{ctor: '_Tuple2', _0: px + (distance * dx), _1: py + (distance * dy)});
	});
var _ianmackenzie$acorn_demo$Point2d$relativeTo = F2(
	function (frame, point) {
		return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			_ianmackenzie$acorn_demo$Vector2d$components(
				A2(
					_ianmackenzie$acorn_demo$Vector2d$relativeTo,
					frame,
					A2(
						_ianmackenzie$acorn_demo$Vector2d$from,
						_ianmackenzie$acorn_demo$Bootstrap_Frame2d$originPoint(frame),
						point))));
	});
var _ianmackenzie$acorn_demo$Point2d$origin = _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
	{ctor: '_Tuple2', _0: 0, _1: 0});
var _ianmackenzie$acorn_demo$Point2d$addTo = F2(
	function (point, vector) {
		return A2(_ianmackenzie$acorn_demo$Point2d$translateBy, vector, point);
	});
var _ianmackenzie$acorn_demo$Point2d$scaleAbout = F3(
	function (centerPoint, scale, point) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$addTo,
			centerPoint,
			A2(
				_ianmackenzie$acorn_demo$Vector2d$scaleBy,
				scale,
				A2(_ianmackenzie$acorn_demo$Vector2d$from, centerPoint, point)));
	});
var _ianmackenzie$acorn_demo$Point2d$rotateAround = F2(
	function (centerPoint, angle) {
		return function (_p15) {
			return A2(
				_ianmackenzie$acorn_demo$Point2d$addTo,
				centerPoint,
				A2(
					_ianmackenzie$acorn_demo$Vector2d$rotateBy,
					angle,
					A2(_ianmackenzie$acorn_demo$Vector2d$from, centerPoint, _p15)));
		};
	});
var _ianmackenzie$acorn_demo$Point2d$mirrorAcross = function (axis) {
	return function (_p16) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$addTo,
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
			A2(
				_ianmackenzie$acorn_demo$Vector2d$mirrorAcross,
				axis,
				A2(
					_ianmackenzie$acorn_demo$Vector2d$from,
					_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
					_p16)));
	};
};
var _ianmackenzie$acorn_demo$Point2d$projectOnto = function (axis) {
	return function (_p17) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$addTo,
			_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
			A2(
				_ianmackenzie$acorn_demo$Vector2d$projectOnto,
				axis,
				A2(
					_ianmackenzie$acorn_demo$Vector2d$from,
					_ianmackenzie$acorn_demo$Bootstrap_Axis2d$originPoint(axis),
					_p17)));
	};
};
var _ianmackenzie$acorn_demo$Point2d$placeIn = F2(
	function (frame, point) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$addTo,
			_ianmackenzie$acorn_demo$Bootstrap_Frame2d$originPoint(frame),
			A2(
				_ianmackenzie$acorn_demo$Vector2d$placeIn,
				frame,
				_ianmackenzie$acorn_demo$Vector2d$fromComponents(
					_ianmackenzie$acorn_demo$Point2d$coordinates(point))));
	});
var _ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn = F2(
	function (frame, localCoordinates) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$placeIn,
			frame,
			_ianmackenzie$acorn_demo$Point2d$fromCoordinates(localCoordinates));
	});
var _ianmackenzie$acorn_demo$Point2d$fromPolarCoordinatesIn = F2(
	function (frame, polarCoordinates_) {
		return A2(
			_ianmackenzie$acorn_demo$Point2d$placeIn,
			frame,
			_ianmackenzie$acorn_demo$Point2d$fromPolarCoordinates(polarCoordinates_));
	});

var _ianmackenzie$acorn_demo$Axis2d$direction = function (_p0) {
	var _p1 = _p0;
	return _p1._0.direction;
};
var _ianmackenzie$acorn_demo$Axis2d$originPoint = function (_p2) {
	var _p3 = _p2;
	return _p3._0.originPoint;
};
var _ianmackenzie$acorn_demo$Axis2d$withDirection = F2(
	function (direction_, originPoint_) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Axis2d(
			{originPoint: originPoint_, direction: direction_});
	});
var _ianmackenzie$acorn_demo$Axis2d$through = F2(
	function (point, direction_) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Axis2d(
			{originPoint: point, direction: direction_});
	});
var _ianmackenzie$acorn_demo$Axis2d$flip = function (_p4) {
	var _p5 = _p4;
	var _p6 = _p5._0;
	return A2(
		_ianmackenzie$acorn_demo$Axis2d$through,
		_p6.originPoint,
		_ianmackenzie$acorn_demo$Direction2d$flip(_p6.direction));
};
var _ianmackenzie$acorn_demo$Axis2d$moveTo = F2(
	function (newOrigin, _p7) {
		var _p8 = _p7;
		return A2(_ianmackenzie$acorn_demo$Axis2d$through, newOrigin, _p8._0.direction);
	});
var _ianmackenzie$acorn_demo$Axis2d$rotateAround = F2(
	function (centerPoint, angle) {
		var rotateDirection = _ianmackenzie$acorn_demo$Direction2d$rotateBy(angle);
		var rotatePoint = A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, centerPoint, angle);
		return function (_p9) {
			var _p10 = _p9;
			var _p11 = _p10._0;
			return A2(
				_ianmackenzie$acorn_demo$Axis2d$through,
				rotatePoint(_p11.originPoint),
				rotateDirection(_p11.direction));
		};
	});
var _ianmackenzie$acorn_demo$Axis2d$translateBy = F2(
	function (vector, _p12) {
		var _p13 = _p12;
		var _p14 = _p13._0;
		return A2(
			_ianmackenzie$acorn_demo$Axis2d$through,
			A2(_ianmackenzie$acorn_demo$Point2d$translateBy, vector, _p14.originPoint),
			_p14.direction);
	});
var _ianmackenzie$acorn_demo$Axis2d$translateIn = F3(
	function (translationDirection, distance, axis) {
		return A2(
			_ianmackenzie$acorn_demo$Axis2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, translationDirection),
			axis);
	});
var _ianmackenzie$acorn_demo$Axis2d$mirrorAcross = F2(
	function (otherAxis, _p15) {
		var _p16 = _p15;
		var _p17 = _p16._0;
		return A2(
			_ianmackenzie$acorn_demo$Axis2d$through,
			A2(_ianmackenzie$acorn_demo$Point2d$mirrorAcross, otherAxis, _p17.originPoint),
			A2(_ianmackenzie$acorn_demo$Direction2d$mirrorAcross, otherAxis, _p17.direction));
	});
var _ianmackenzie$acorn_demo$Axis2d$relativeTo = F2(
	function (frame, _p18) {
		var _p19 = _p18;
		var _p20 = _p19._0;
		return A2(
			_ianmackenzie$acorn_demo$Axis2d$through,
			A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p20.originPoint),
			A2(_ianmackenzie$acorn_demo$Direction2d$relativeTo, frame, _p20.direction));
	});
var _ianmackenzie$acorn_demo$Axis2d$placeIn = F2(
	function (frame, _p21) {
		var _p22 = _p21;
		var _p23 = _p22._0;
		return A2(
			_ianmackenzie$acorn_demo$Axis2d$through,
			A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p23.originPoint),
			A2(_ianmackenzie$acorn_demo$Direction2d$placeIn, frame, _p23.direction));
	});
var _ianmackenzie$acorn_demo$Axis2d$y = A2(_ianmackenzie$acorn_demo$Axis2d$through, _ianmackenzie$acorn_demo$Point2d$origin, _ianmackenzie$acorn_demo$Direction2d$y);
var _ianmackenzie$acorn_demo$Axis2d$x = A2(_ianmackenzie$acorn_demo$Axis2d$through, _ianmackenzie$acorn_demo$Point2d$origin, _ianmackenzie$acorn_demo$Direction2d$x);

var _ianmackenzie$acorn_demo$Frame2d$yAxis = function (_p0) {
	var _p1 = _p0;
	var _p2 = _p1._0;
	return A2(_ianmackenzie$acorn_demo$Axis2d$through, _p2.originPoint, _p2.yDirection);
};
var _ianmackenzie$acorn_demo$Frame2d$xAxis = function (_p3) {
	var _p4 = _p3;
	var _p5 = _p4._0;
	return A2(_ianmackenzie$acorn_demo$Axis2d$through, _p5.originPoint, _p5.xDirection);
};
var _ianmackenzie$acorn_demo$Frame2d$yDirection = function (_p6) {
	var _p7 = _p6;
	return _p7._0.yDirection;
};
var _ianmackenzie$acorn_demo$Frame2d$xDirection = function (_p8) {
	var _p9 = _p8;
	return _p9._0.xDirection;
};
var _ianmackenzie$acorn_demo$Frame2d$isRightHanded = function (frame) {
	var yVector = _ianmackenzie$acorn_demo$Direction2d$toVector(
		_ianmackenzie$acorn_demo$Frame2d$yDirection(frame));
	var xVector = _ianmackenzie$acorn_demo$Direction2d$toVector(
		_ianmackenzie$acorn_demo$Frame2d$xDirection(frame));
	return _elm_lang$core$Native_Utils.cmp(
		A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, xVector, yVector),
		0) > 0;
};
var _ianmackenzie$acorn_demo$Frame2d$originPoint = function (_p10) {
	var _p11 = _p10;
	return _p11._0.originPoint;
};
var _ianmackenzie$acorn_demo$Frame2d$unsafe = _ianmackenzie$acorn_demo$Geometry_Types$Frame2d;
var _ianmackenzie$acorn_demo$Frame2d$atPoint = function (point) {
	return _ianmackenzie$acorn_demo$Frame2d$unsafe(
		{originPoint: point, xDirection: _ianmackenzie$acorn_demo$Direction2d$x, yDirection: _ianmackenzie$acorn_demo$Direction2d$y});
};
var _ianmackenzie$acorn_demo$Frame2d$atCoordinates = function (coordinates) {
	return _ianmackenzie$acorn_demo$Frame2d$atPoint(
		_ianmackenzie$acorn_demo$Point2d$fromCoordinates(coordinates));
};
var _ianmackenzie$acorn_demo$Frame2d$flipX = function (frame) {
	return _ianmackenzie$acorn_demo$Frame2d$unsafe(
		{
			originPoint: _ianmackenzie$acorn_demo$Frame2d$originPoint(frame),
			xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
				_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
			yDirection: _ianmackenzie$acorn_demo$Frame2d$yDirection(frame)
		});
};
var _ianmackenzie$acorn_demo$Frame2d$flipY = function (frame) {
	return _ianmackenzie$acorn_demo$Frame2d$unsafe(
		{
			originPoint: _ianmackenzie$acorn_demo$Frame2d$originPoint(frame),
			xDirection: _ianmackenzie$acorn_demo$Frame2d$xDirection(frame),
			yDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
				_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
		});
};
var _ianmackenzie$acorn_demo$Frame2d$moveTo = F2(
	function (newOrigin, frame) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: newOrigin,
				xDirection: _ianmackenzie$acorn_demo$Frame2d$xDirection(frame),
				yDirection: _ianmackenzie$acorn_demo$Frame2d$yDirection(frame)
			});
	});
var _ianmackenzie$acorn_demo$Frame2d$rotateBy = F2(
	function (angle, frame) {
		var rotateDirection = _ianmackenzie$acorn_demo$Direction2d$rotateBy(angle);
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: _ianmackenzie$acorn_demo$Frame2d$originPoint(frame),
				xDirection: rotateDirection(
					_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
				yDirection: rotateDirection(
					_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
			});
	});
var _ianmackenzie$acorn_demo$Frame2d$rotateAround = F2(
	function (centerPoint, angle) {
		var rotateDirection = _ianmackenzie$acorn_demo$Direction2d$rotateBy(angle);
		var rotatePoint = A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, centerPoint, angle);
		return function (frame) {
			return _ianmackenzie$acorn_demo$Frame2d$unsafe(
				{
					originPoint: rotatePoint(
						_ianmackenzie$acorn_demo$Frame2d$originPoint(frame)),
					xDirection: rotateDirection(
						_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
					yDirection: rotateDirection(
						_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
				});
		};
	});
var _ianmackenzie$acorn_demo$Frame2d$translateBy = F2(
	function (vector, frame) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: A2(
					_ianmackenzie$acorn_demo$Point2d$translateBy,
					vector,
					_ianmackenzie$acorn_demo$Frame2d$originPoint(frame)),
				xDirection: _ianmackenzie$acorn_demo$Frame2d$xDirection(frame),
				yDirection: _ianmackenzie$acorn_demo$Frame2d$yDirection(frame)
			});
	});
var _ianmackenzie$acorn_demo$Frame2d$translateIn = F3(
	function (direction, distance, frame) {
		return A2(
			_ianmackenzie$acorn_demo$Frame2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			frame);
	});
var _ianmackenzie$acorn_demo$Frame2d$translateAlongOwn = F3(
	function (axis, distance, frame) {
		var displacement = A2(
			_ianmackenzie$acorn_demo$Vector2d$withLength,
			distance,
			_ianmackenzie$acorn_demo$Axis2d$direction(
				axis(frame)));
		return A2(_ianmackenzie$acorn_demo$Frame2d$translateBy, displacement, frame);
	});
var _ianmackenzie$acorn_demo$Frame2d$mirrorAcross = function (axis) {
	var mirrorDirection = _ianmackenzie$acorn_demo$Direction2d$mirrorAcross(axis);
	var mirrorPoint = _ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis);
	return function (frame) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: mirrorPoint(
					_ianmackenzie$acorn_demo$Frame2d$originPoint(frame)),
				xDirection: mirrorDirection(
					_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
				yDirection: mirrorDirection(
					_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
			});
	};
};
var _ianmackenzie$acorn_demo$Frame2d$relativeTo = function (otherFrame) {
	var relativeDirection = _ianmackenzie$acorn_demo$Direction2d$relativeTo(otherFrame);
	var relativePoint = _ianmackenzie$acorn_demo$Point2d$relativeTo(otherFrame);
	return function (frame) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: relativePoint(
					_ianmackenzie$acorn_demo$Frame2d$originPoint(frame)),
				xDirection: relativeDirection(
					_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
				yDirection: relativeDirection(
					_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
			});
	};
};
var _ianmackenzie$acorn_demo$Frame2d$placeIn = function (otherFrame) {
	var placeDirection = _ianmackenzie$acorn_demo$Direction2d$placeIn(otherFrame);
	var placePoint = _ianmackenzie$acorn_demo$Point2d$placeIn(otherFrame);
	return function (frame) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: placePoint(
					_ianmackenzie$acorn_demo$Frame2d$originPoint(frame)),
				xDirection: placeDirection(
					_ianmackenzie$acorn_demo$Frame2d$xDirection(frame)),
				yDirection: placeDirection(
					_ianmackenzie$acorn_demo$Frame2d$yDirection(frame))
			});
	};
};
var _ianmackenzie$acorn_demo$Frame2d$withYDirection = F2(
	function (yDirection_, originPoint_) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: originPoint_,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$rotateClockwise(yDirection_),
				yDirection: yDirection_
			});
	});
var _ianmackenzie$acorn_demo$Frame2d$withXDirection = F2(
	function (xDirection_, originPoint_) {
		return _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: originPoint_,
				xDirection: xDirection_,
				yDirection: _ianmackenzie$acorn_demo$Direction2d$rotateCounterclockwise(xDirection_)
			});
	});
var _ianmackenzie$acorn_demo$Frame2d$xy = _ianmackenzie$acorn_demo$Frame2d$atPoint(_ianmackenzie$acorn_demo$Point2d$origin);

var _ianmackenzie$acorn_demo$Geometry_Accuracy$maxError = _ianmackenzie$acorn_demo$Geometry_Types$MaxError;

var _ianmackenzie$acorn_demo$Geometry_Parameter$singleStep = {
	ctor: '::',
	_0: 0,
	_1: {
		ctor: '::',
		_0: 1,
		_1: {ctor: '[]'}
	}
};
var _ianmackenzie$acorn_demo$Geometry_Parameter$linspaced = function (n) {
	return _elm_lang$core$Native_Utils.eq(n, 1) ? _ianmackenzie$acorn_demo$Geometry_Parameter$singleStep : A2(
		_elm_lang$core$List$map,
		function (i) {
			return A3(
				_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom,
				0,
				1,
				_elm_lang$core$Basics$toFloat(i) / _elm_lang$core$Basics$toFloat(n));
		},
		A2(_elm_lang$core$List$range, 0, n));
};
var _ianmackenzie$acorn_demo$Geometry_Parameter$numSteps = function (n) {
	return (_elm_lang$core$Native_Utils.cmp(n, 1) > -1) ? _ianmackenzie$acorn_demo$Geometry_Parameter$linspaced(n) : {ctor: '[]'};
};
var _ianmackenzie$acorn_demo$Geometry_Parameter$maxStepSize = function (x) {
	return (_elm_lang$core$Native_Utils.cmp(x, 1) > -1) ? _ianmackenzie$acorn_demo$Geometry_Parameter$singleStep : ((_elm_lang$core$Native_Utils.cmp(x, 0) > 0) ? _ianmackenzie$acorn_demo$Geometry_Parameter$linspaced(
		_elm_lang$core$Basics$ceiling(1 / x)) : {ctor: '[]'});
};

var _ianmackenzie$acorn_demo$Geometry_SweptAngle$largeNegative = _ianmackenzie$acorn_demo$Geometry_Types$LargeNegative;
var _ianmackenzie$acorn_demo$Geometry_SweptAngle$largePositive = _ianmackenzie$acorn_demo$Geometry_Types$LargePositive;
var _ianmackenzie$acorn_demo$Geometry_SweptAngle$smallNegative = _ianmackenzie$acorn_demo$Geometry_Types$SmallNegative;
var _ianmackenzie$acorn_demo$Geometry_SweptAngle$smallPositive = _ianmackenzie$acorn_demo$Geometry_Types$SmallPositive;

var _ianmackenzie$acorn_demo$BoundingBox2d$alwaysFalse = F2(
	function (firstBox, secondBox) {
		return false;
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$midY = function (_p0) {
	var _p1 = _p0;
	var _p2 = _p1._0;
	return _p2.minY + (0.5 * (_p2.maxY - _p2.minY));
};
var _ianmackenzie$acorn_demo$BoundingBox2d$midX = function (_p3) {
	var _p4 = _p3;
	var _p5 = _p4._0;
	return _p5.minX + (0.5 * (_p5.maxX - _p5.minX));
};
var _ianmackenzie$acorn_demo$BoundingBox2d$centroid = function (boundingBox) {
	return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
		{
			ctor: '_Tuple2',
			_0: _ianmackenzie$acorn_demo$BoundingBox2d$midX(boundingBox),
			_1: _ianmackenzie$acorn_demo$BoundingBox2d$midY(boundingBox)
		});
};
var _ianmackenzie$acorn_demo$BoundingBox2d$maxY = function (_p6) {
	var _p7 = _p6;
	return _p7._0.maxY;
};
var _ianmackenzie$acorn_demo$BoundingBox2d$minY = function (_p8) {
	var _p9 = _p8;
	return _p9._0.minY;
};
var _ianmackenzie$acorn_demo$BoundingBox2d$maxX = function (_p10) {
	var _p11 = _p10;
	return _p11._0.maxX;
};
var _ianmackenzie$acorn_demo$BoundingBox2d$minX = function (_p12) {
	var _p13 = _p12;
	return _p13._0.minX;
};
var _ianmackenzie$acorn_demo$BoundingBox2d$dimensions = function (boundingBox) {
	return {
		ctor: '_Tuple2',
		_0: _ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox) - _ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox),
		_1: _ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox) - _ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox)
	};
};
var _ianmackenzie$acorn_demo$BoundingBox2d$contains = F2(
	function (point, boundingBox) {
		var _p14 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var x = _p14._0;
		var y = _p14._1;
		return ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox),
			x) < 1) && (_elm_lang$core$Native_Utils.cmp(
			x,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox)) < 1)) && ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox),
			y) < 1) && (_elm_lang$core$Native_Utils.cmp(
			y,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox)) < 1));
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$intersects = F2(
	function (other, boundingBox) {
		return (_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(other)) < 1) && ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(other)) > -1) && ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(other)) < 1) && (_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(other)) > -1)));
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount = F2(
	function (firstBox, secondBox) {
		var yOverlap = A2(
			_elm_lang$core$Basics$min,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(secondBox)) - A2(
			_elm_lang$core$Basics$max,
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(secondBox));
		var xOverlap = A2(
			_elm_lang$core$Basics$min,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(secondBox)) - A2(
			_elm_lang$core$Basics$max,
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(secondBox));
		return ((_elm_lang$core$Native_Utils.cmp(xOverlap, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(yOverlap, 0) > -1)) ? _elm_lang$core$Maybe$Just(
			A2(_elm_lang$core$Basics$min, xOverlap, yOverlap)) : _elm_lang$core$Maybe$Nothing;
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$overlappingBy = F2(
	function (order, tolerance) {
		var _p15 = order;
		switch (_p15.ctor) {
			case 'LT':
				return (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > 0) ? F2(
					function (firstBox, secondBox) {
						var _p16 = A2(_ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount, firstBox, secondBox);
						if (_p16.ctor === 'Just') {
							return _elm_lang$core$Native_Utils.cmp(_p16._0, tolerance) < 0;
						} else {
							return true;
						}
					}) : (_elm_lang$core$Native_Utils.eq(tolerance, 0) ? F2(
					function (firstBox, secondBox) {
						return _elm_lang$core$Native_Utils.eq(
							A2(_ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount, firstBox, secondBox),
							_elm_lang$core$Maybe$Nothing);
					}) : _ianmackenzie$acorn_demo$BoundingBox2d$alwaysFalse);
			case 'GT':
				return (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > -1) ? F2(
					function (firstBox, secondBox) {
						var _p17 = A2(_ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount, firstBox, secondBox);
						if (_p17.ctor === 'Just') {
							return _elm_lang$core$Native_Utils.cmp(_p17._0, tolerance) > 0;
						} else {
							return false;
						}
					}) : F2(
					function (firstBox, secondBox) {
						return !_elm_lang$core$Native_Utils.eq(
							A2(_ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount, firstBox, secondBox),
							_elm_lang$core$Maybe$Nothing);
					});
			default:
				if (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > -1) {
					var expected = _elm_lang$core$Maybe$Just(tolerance);
					return F2(
						function (firstBox, secondBox) {
							return _elm_lang$core$Native_Utils.eq(
								A2(_ianmackenzie$acorn_demo$BoundingBox2d$overlapAmount, firstBox, secondBox),
								expected);
						});
				} else {
					return _ianmackenzie$acorn_demo$BoundingBox2d$alwaysFalse;
				}
		}
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount = F2(
	function (firstBox, secondBox) {
		var ySeparation = A2(
			_elm_lang$core$Basics$max,
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(secondBox)) - A2(
			_elm_lang$core$Basics$min,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(secondBox));
		var xSeparation = A2(
			_elm_lang$core$Basics$max,
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(secondBox)) - A2(
			_elm_lang$core$Basics$min,
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(firstBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(secondBox));
		return ((_elm_lang$core$Native_Utils.cmp(xSeparation, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(ySeparation, 0) > 0)) ? _elm_lang$core$Maybe$Just((xSeparation * xSeparation) + (ySeparation * ySeparation)) : ((_elm_lang$core$Native_Utils.cmp(xSeparation, 0) > 0) ? _elm_lang$core$Maybe$Just(xSeparation * xSeparation) : ((_elm_lang$core$Native_Utils.cmp(ySeparation, 0) > 0) ? _elm_lang$core$Maybe$Just(ySeparation * ySeparation) : ((_elm_lang$core$Native_Utils.eq(xSeparation, 0) || _elm_lang$core$Native_Utils.eq(ySeparation, 0)) ? _elm_lang$core$Maybe$Just(0) : _elm_lang$core$Maybe$Nothing)));
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$separatedBy = F2(
	function (order, tolerance) {
		var _p18 = order;
		switch (_p18.ctor) {
			case 'LT':
				return (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > 0) ? F2(
					function (firstBox, secondBox) {
						var _p19 = A2(_ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount, firstBox, secondBox);
						if (_p19.ctor === 'Just') {
							return _elm_lang$core$Native_Utils.cmp(_p19._0, tolerance * tolerance) < 0;
						} else {
							return true;
						}
					}) : (_elm_lang$core$Native_Utils.eq(tolerance, 0) ? F2(
					function (firstBox, secondBox) {
						return _elm_lang$core$Native_Utils.eq(
							A2(_ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount, firstBox, secondBox),
							_elm_lang$core$Maybe$Nothing);
					}) : _ianmackenzie$acorn_demo$BoundingBox2d$alwaysFalse);
			case 'GT':
				return (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > -1) ? F2(
					function (firstBox, secondBox) {
						var _p20 = A2(_ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount, firstBox, secondBox);
						if (_p20.ctor === 'Just') {
							return _elm_lang$core$Native_Utils.cmp(_p20._0, tolerance * tolerance) > 0;
						} else {
							return false;
						}
					}) : F2(
					function (firstBox, secondBox) {
						return !_elm_lang$core$Native_Utils.eq(
							A2(_ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount, firstBox, secondBox),
							_elm_lang$core$Maybe$Nothing);
					});
			default:
				if (_elm_lang$core$Native_Utils.cmp(tolerance, 0) > -1) {
					var expected = _elm_lang$core$Maybe$Just(tolerance * tolerance);
					return F2(
						function (firstBox, secondBox) {
							return _elm_lang$core$Native_Utils.eq(
								A2(_ianmackenzie$acorn_demo$BoundingBox2d$squaredSeparationAmount, firstBox, secondBox),
								expected);
						});
				} else {
					return _ianmackenzie$acorn_demo$BoundingBox2d$alwaysFalse;
				}
		}
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$isContainedIn = F2(
	function (other, boundingBox) {
		return ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(other),
			_ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox)) < 1) && (_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxX(other)) < 1)) && ((_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(other),
			_ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox)) < 1) && (_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox),
			_ianmackenzie$acorn_demo$BoundingBox2d$maxY(other)) < 1));
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$extrema = function (_p21) {
	var _p22 = _p21;
	return _p22._0;
};
var _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema = function (extrema_) {
	return ((_elm_lang$core$Native_Utils.cmp(extrema_.minX, extrema_.maxX) < 1) && (_elm_lang$core$Native_Utils.cmp(extrema_.minY, extrema_.maxY) < 1)) ? _ianmackenzie$acorn_demo$Geometry_Types$BoundingBox2d(extrema_) : _ianmackenzie$acorn_demo$Geometry_Types$BoundingBox2d(
		{
			minX: A2(_elm_lang$core$Basics$min, extrema_.minX, extrema_.maxX),
			maxX: A2(_elm_lang$core$Basics$max, extrema_.minX, extrema_.maxX),
			minY: A2(_elm_lang$core$Basics$min, extrema_.minY, extrema_.maxY),
			maxY: A2(_elm_lang$core$Basics$max, extrema_.minY, extrema_.maxY)
		});
};
var _ianmackenzie$acorn_demo$BoundingBox2d$singleton = function (point) {
	var _p23 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
	var x = _p23._0;
	var y = _p23._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{minX: x, maxX: x, minY: y, maxY: y});
};
var _ianmackenzie$acorn_demo$BoundingBox2d$from = F2(
	function (firstPoint, secondPoint) {
		var _p24 = _ianmackenzie$acorn_demo$Point2d$coordinates(secondPoint);
		var x2 = _p24._0;
		var y2 = _p24._1;
		var _p25 = _ianmackenzie$acorn_demo$Point2d$coordinates(firstPoint);
		var x1 = _p25._0;
		var y1 = _p25._1;
		return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
			{
				minX: A2(_elm_lang$core$Basics$min, x1, x2),
				maxX: A2(_elm_lang$core$Basics$max, x1, x2),
				minY: A2(_elm_lang$core$Basics$min, y1, y2),
				maxY: A2(_elm_lang$core$Basics$max, y1, y2)
			});
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$hull = F2(
	function (firstBox, secondBox) {
		return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
			{
				minX: A2(
					_elm_lang$core$Basics$min,
					_ianmackenzie$acorn_demo$BoundingBox2d$minX(firstBox),
					_ianmackenzie$acorn_demo$BoundingBox2d$minX(secondBox)),
				maxX: A2(
					_elm_lang$core$Basics$max,
					_ianmackenzie$acorn_demo$BoundingBox2d$maxX(firstBox),
					_ianmackenzie$acorn_demo$BoundingBox2d$maxX(secondBox)),
				minY: A2(
					_elm_lang$core$Basics$min,
					_ianmackenzie$acorn_demo$BoundingBox2d$minY(firstBox),
					_ianmackenzie$acorn_demo$BoundingBox2d$minY(secondBox)),
				maxY: A2(
					_elm_lang$core$Basics$max,
					_ianmackenzie$acorn_demo$BoundingBox2d$maxY(firstBox),
					_ianmackenzie$acorn_demo$BoundingBox2d$maxY(secondBox))
			});
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$aggregate = function (boundingBoxes) {
	var _p26 = boundingBoxes;
	if (_p26.ctor === '::') {
		return _elm_lang$core$Maybe$Just(
			A3(_elm_lang$core$List$foldl, _ianmackenzie$acorn_demo$BoundingBox2d$hull, _p26._0, _p26._1));
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _ianmackenzie$acorn_demo$BoundingBox2d$containingPoints = function (points) {
	return _ianmackenzie$acorn_demo$BoundingBox2d$aggregate(
		A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$BoundingBox2d$singleton, points));
};
var _ianmackenzie$acorn_demo$BoundingBox2d$intersection = F2(
	function (firstBox, secondBox) {
		return A2(_ianmackenzie$acorn_demo$BoundingBox2d$intersects, firstBox, secondBox) ? _elm_lang$core$Maybe$Just(
			_ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
				{
					minX: A2(
						_elm_lang$core$Basics$max,
						_ianmackenzie$acorn_demo$BoundingBox2d$minX(firstBox),
						_ianmackenzie$acorn_demo$BoundingBox2d$minX(secondBox)),
					maxX: A2(
						_elm_lang$core$Basics$min,
						_ianmackenzie$acorn_demo$BoundingBox2d$maxX(firstBox),
						_ianmackenzie$acorn_demo$BoundingBox2d$maxX(secondBox)),
					minY: A2(
						_elm_lang$core$Basics$max,
						_ianmackenzie$acorn_demo$BoundingBox2d$minY(firstBox),
						_ianmackenzie$acorn_demo$BoundingBox2d$minY(secondBox)),
					maxY: A2(
						_elm_lang$core$Basics$min,
						_ianmackenzie$acorn_demo$BoundingBox2d$maxY(firstBox),
						_ianmackenzie$acorn_demo$BoundingBox2d$maxY(secondBox))
				})) : _elm_lang$core$Maybe$Nothing;
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$scaleAbout = F3(
	function (point, scale, boundingBox) {
		var _p27 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var x0 = _p27._0;
		var y0 = _p27._1;
		return (_elm_lang$core$Native_Utils.cmp(scale, 0) > -1) ? _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
			{
				minX: x0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox) - x0)),
				maxX: x0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox) - x0)),
				minY: y0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox) - y0)),
				maxY: y0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox) - y0))
			}) : _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
			{
				minX: x0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox) - x0)),
				maxX: x0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox) - x0)),
				minY: y0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox) - y0)),
				maxY: y0 + (scale * (_ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox) - y0))
			});
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$translateBy = F2(
	function (displacement, boundingBox) {
		var _p28 = _ianmackenzie$acorn_demo$Vector2d$components(displacement);
		var dx = _p28._0;
		var dy = _p28._1;
		return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
			{
				minX: _ianmackenzie$acorn_demo$BoundingBox2d$minX(boundingBox) + dx,
				maxX: _ianmackenzie$acorn_demo$BoundingBox2d$maxX(boundingBox) + dx,
				minY: _ianmackenzie$acorn_demo$BoundingBox2d$minY(boundingBox) + dy,
				maxY: _ianmackenzie$acorn_demo$BoundingBox2d$maxY(boundingBox) + dy
			});
	});
var _ianmackenzie$acorn_demo$BoundingBox2d$translateIn = F3(
	function (direction, distance, boundingBox) {
		return A2(
			_ianmackenzie$acorn_demo$BoundingBox2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			boundingBox);
	});

var _ianmackenzie$acorn_demo$LineSegment2d$endpoints = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$LineSegment2d$interpolate = function (lineSegment) {
	var _p2 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
	var start = _p2._0;
	var end = _p2._1;
	return A2(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, start, end);
};
var _ianmackenzie$acorn_demo$LineSegment2d$midpoint = function (lineSegment) {
	return A2(_ianmackenzie$acorn_demo$LineSegment2d$interpolate, lineSegment, 0.5);
};
var _ianmackenzie$acorn_demo$LineSegment2d$vector = function (lineSegment) {
	var _p3 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
	var p1 = _p3._0;
	var p2 = _p3._1;
	return A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
};
var _ianmackenzie$acorn_demo$LineSegment2d$length = function (_p4) {
	return _ianmackenzie$acorn_demo$Vector2d$length(
		_ianmackenzie$acorn_demo$LineSegment2d$vector(_p4));
};
var _ianmackenzie$acorn_demo$LineSegment2d$squaredLength = function (_p5) {
	return _ianmackenzie$acorn_demo$Vector2d$squaredLength(
		_ianmackenzie$acorn_demo$LineSegment2d$vector(_p5));
};
var _ianmackenzie$acorn_demo$LineSegment2d$direction = function (_p6) {
	return _ianmackenzie$acorn_demo$Vector2d$direction(
		_ianmackenzie$acorn_demo$LineSegment2d$vector(_p6));
};
var _ianmackenzie$acorn_demo$LineSegment2d$perpendicularDirection = function (_p7) {
	return _ianmackenzie$acorn_demo$Vector2d$direction(
		_ianmackenzie$acorn_demo$Vector2d$perpendicularTo(
			_ianmackenzie$acorn_demo$LineSegment2d$vector(_p7)));
};
var _ianmackenzie$acorn_demo$LineSegment2d$intersectionPoint = F2(
	function (lineSegment1, lineSegment2) {
		var s = _ianmackenzie$acorn_demo$LineSegment2d$vector(lineSegment2);
		var r = _ianmackenzie$acorn_demo$LineSegment2d$vector(lineSegment1);
		var _p8 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment2);
		var q = _p8._0;
		var q_ = _p8._1;
		var _p9 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment1);
		var p = _p9._0;
		var p_ = _p9._1;
		var pq = A2(_ianmackenzie$acorn_demo$Vector2d$from, p, q);
		var pqXr = A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, pq, r);
		var pqXs = A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, pq, s);
		var pq_ = A2(_ianmackenzie$acorn_demo$Vector2d$from, p, q_);
		var rXpq_ = A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, r, pq_);
		var uDenominator = pqXr + rXpq_;
		var qp_ = A2(_ianmackenzie$acorn_demo$Vector2d$from, q, p_);
		var sXqp_ = A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, s, qp_);
		var tDenominator = pqXs - sXqp_;
		if (_elm_lang$core$Native_Utils.eq(tDenominator, 0) || _elm_lang$core$Native_Utils.eq(uDenominator, 0)) {
			return (_elm_lang$core$Native_Utils.cmp(
				A2(_ianmackenzie$acorn_demo$Vector2d$dotProduct, r, s),
				0) < 0) ? (_elm_lang$core$Native_Utils.eq(p_, q_) ? _elm_lang$core$Maybe$Just(p_) : (_elm_lang$core$Native_Utils.eq(p, q) ? _elm_lang$core$Maybe$Just(p) : _elm_lang$core$Maybe$Nothing)) : (_elm_lang$core$Native_Utils.eq(p_, q) ? _elm_lang$core$Maybe$Just(p_) : (_elm_lang$core$Native_Utils.eq(p, q_) ? _elm_lang$core$Maybe$Just(p) : _elm_lang$core$Maybe$Nothing));
		} else {
			var u = pqXr / uDenominator;
			var t = pqXs / tDenominator;
			if (((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) && ((_elm_lang$core$Native_Utils.cmp(0, u) < 1) && (_elm_lang$core$Native_Utils.cmp(u, 1) < 1))) {
				var intersection = (_elm_lang$core$Native_Utils.cmp(
					A2(_elm_lang$core$Basics$min, t, 1 - t),
					A2(_elm_lang$core$Basics$min, u, 1 - u)) < 1) ? A2(_ianmackenzie$acorn_demo$LineSegment2d$interpolate, lineSegment1, t) : A2(_ianmackenzie$acorn_demo$LineSegment2d$interpolate, lineSegment2, u);
				return _elm_lang$core$Maybe$Just(intersection);
			} else {
				return _elm_lang$core$Maybe$Nothing;
			}
		}
	});
var _ianmackenzie$acorn_demo$LineSegment2d$boundingBox = function (lineSegment) {
	var _p10 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
	var p1 = _p10._0;
	var p2 = _p10._1;
	return A2(_ianmackenzie$acorn_demo$BoundingBox2d$from, p1, p2);
};
var _ianmackenzie$acorn_demo$LineSegment2d$endPoint = function (_p11) {
	var _p12 = _p11;
	return _p12._0._1;
};
var _ianmackenzie$acorn_demo$LineSegment2d$startPoint = function (_p13) {
	var _p14 = _p13;
	return _p14._0._0;
};
var _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints = _ianmackenzie$acorn_demo$Geometry_Types$LineSegment2d;
var _ianmackenzie$acorn_demo$LineSegment2d$from = F2(
	function (startPoint_, endPoint_) {
		return _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{ctor: '_Tuple2', _0: startPoint_, _1: endPoint_});
	});
var _ianmackenzie$acorn_demo$LineSegment2d$along = F3(
	function (axis, start, end) {
		return _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{
				ctor: '_Tuple2',
				_0: A2(_ianmackenzie$acorn_demo$Point2d$along, axis, start),
				_1: A2(_ianmackenzie$acorn_demo$Point2d$along, axis, end)
			});
	});
var _ianmackenzie$acorn_demo$LineSegment2d$reverse = function (lineSegment) {
	var _p15 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
	var p1 = _p15._0;
	var p2 = _p15._1;
	return _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
		{ctor: '_Tuple2', _0: p2, _1: p1});
};
var _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints = F2(
	function ($function, lineSegment) {
		var _p16 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
		var p1 = _p16._0;
		var p2 = _p16._1;
		return _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{
				ctor: '_Tuple2',
				_0: $function(p1),
				_1: $function(p2)
			});
	});
var _ianmackenzie$acorn_demo$LineSegment2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$LineSegment2d$rotateAround = F2(
	function (centerPoint, angle) {
		return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, centerPoint, angle));
	});
var _ianmackenzie$acorn_demo$LineSegment2d$translateBy = function (displacementVector) {
	return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
		_ianmackenzie$acorn_demo$Point2d$translateBy(displacementVector));
};
var _ianmackenzie$acorn_demo$LineSegment2d$translateIn = F3(
	function (translationDirection, distance, lineSegment) {
		return A2(
			_ianmackenzie$acorn_demo$LineSegment2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, translationDirection),
			lineSegment);
	});
var _ianmackenzie$acorn_demo$LineSegment2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$LineSegment2d$projectOnto = function (axis) {
	return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
		_ianmackenzie$acorn_demo$Point2d$projectOnto(axis));
};
var _ianmackenzie$acorn_demo$LineSegment2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$LineSegment2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$LineSegment2d$mapEndpoints(
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame));
};

var _ianmackenzie$acorn_demo$Polyline2d$vertices = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$Polyline2d$segments = function (polyline) {
	var _p2 = _ianmackenzie$acorn_demo$Polyline2d$vertices(polyline);
	if (_p2.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		return A3(_elm_lang$core$List$map2, _ianmackenzie$acorn_demo$LineSegment2d$from, _p2, _p2._1);
	}
};
var _ianmackenzie$acorn_demo$Polyline2d$length = function (_p3) {
	return _elm_lang$core$List$sum(
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$LineSegment2d$length,
			_ianmackenzie$acorn_demo$Polyline2d$segments(_p3)));
};
var _ianmackenzie$acorn_demo$Polyline2d$boundingBox = function (polyline) {
	return _ianmackenzie$acorn_demo$BoundingBox2d$containingPoints(
		_ianmackenzie$acorn_demo$Polyline2d$vertices(polyline));
};
var _ianmackenzie$acorn_demo$Polyline2d$fromVertices = _ianmackenzie$acorn_demo$Geometry_Types$Polyline2d;
var _ianmackenzie$acorn_demo$Polyline2d$mapVertices = function ($function) {
	return function (_p4) {
		return _ianmackenzie$acorn_demo$Polyline2d$fromVertices(
			A2(
				_elm_lang$core$List$map,
				$function,
				_ianmackenzie$acorn_demo$Polyline2d$vertices(_p4)));
	};
};
var _ianmackenzie$acorn_demo$Polyline2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$Polyline2d$rotateAround = F2(
	function (point, angle) {
		return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle));
	});
var _ianmackenzie$acorn_demo$Polyline2d$translateBy = function (vector) {
	return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$translateBy(vector));
};
var _ianmackenzie$acorn_demo$Polyline2d$translateIn = F3(
	function (direction, distance, polyline) {
		return A2(
			_ianmackenzie$acorn_demo$Polyline2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			polyline);
	});
var _ianmackenzie$acorn_demo$Polyline2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$Polyline2d$projectOnto = function (axis) {
	return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$projectOnto(axis));
};
var _ianmackenzie$acorn_demo$Polyline2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$Polyline2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$Polyline2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame));
};

var _ianmackenzie$acorn_demo$Arc2d$placeIn = F2(
	function (frame, _p0) {
		var _p1 = _p0;
		var _p2 = _p1._0;
		return _ianmackenzie$acorn_demo$Frame2d$isRightHanded(frame) ? _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p2.startPoint),
				sweptAngle: _p2.sweptAngle,
				signedLength: _p2.signedLength,
				xDirection: A2(_ianmackenzie$acorn_demo$Direction2d$placeIn, frame, _p2.xDirection)
			}) : _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p2.startPoint),
				sweptAngle: 0 - _p2.sweptAngle,
				signedLength: 0 - _p2.signedLength,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
					A2(_ianmackenzie$acorn_demo$Direction2d$placeIn, frame, _p2.xDirection))
			});
	});
var _ianmackenzie$acorn_demo$Arc2d$relativeTo = F2(
	function (frame, _p3) {
		var _p4 = _p3;
		var _p5 = _p4._0;
		return _ianmackenzie$acorn_demo$Frame2d$isRightHanded(frame) ? _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p5.startPoint),
				sweptAngle: _p5.sweptAngle,
				signedLength: _p5.signedLength,
				xDirection: A2(_ianmackenzie$acorn_demo$Direction2d$relativeTo, frame, _p5.xDirection)
			}) : _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p5.startPoint),
				sweptAngle: 0 - _p5.sweptAngle,
				signedLength: 0 - _p5.signedLength,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
					A2(_ianmackenzie$acorn_demo$Direction2d$relativeTo, frame, _p5.xDirection))
			});
	});
var _ianmackenzie$acorn_demo$Arc2d$mirrorAcross = function (axis) {
	var mirrorDirection = _ianmackenzie$acorn_demo$Direction2d$mirrorAcross(axis);
	var mirrorPoint = _ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis);
	return function (_p6) {
		var _p7 = _p6;
		var _p8 = _p7._0;
		return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: mirrorPoint(_p8.startPoint),
				sweptAngle: 0 - _p8.sweptAngle,
				signedLength: 0 - _p8.signedLength,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
					mirrorDirection(_p8.xDirection))
			});
	};
};
var _ianmackenzie$acorn_demo$Arc2d$translateBy = F2(
	function (displacement, _p9) {
		var _p10 = _p9;
		var _p11 = _p10._0;
		return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$translateBy, displacement, _p11.startPoint),
				sweptAngle: _p11.sweptAngle,
				signedLength: _p11.signedLength,
				xDirection: _p11.xDirection
			});
	});
var _ianmackenzie$acorn_demo$Arc2d$translateIn = F3(
	function (direction, distance, arc) {
		return A2(
			_ianmackenzie$acorn_demo$Arc2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			arc);
	});
var _ianmackenzie$acorn_demo$Arc2d$rotateAround = F2(
	function (point, angle) {
		var rotateDirection = _ianmackenzie$acorn_demo$Direction2d$rotateBy(angle);
		var rotatePoint = A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle);
		return function (_p12) {
			var _p13 = _p12;
			var _p14 = _p13._0;
			return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
				{
					startPoint: rotatePoint(_p14.startPoint),
					sweptAngle: _p14.sweptAngle,
					signedLength: _p14.signedLength,
					xDirection: rotateDirection(_p14.xDirection)
				});
		};
	});
var _ianmackenzie$acorn_demo$Arc2d$scaleAbout = F3(
	function (point, scale, _p15) {
		var _p16 = _p15;
		var _p17 = _p16._0;
		return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
			{
				startPoint: A3(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale, _p17.startPoint),
				sweptAngle: _p17.sweptAngle,
				signedLength: _elm_lang$core$Basics$abs(scale) * _p17.signedLength,
				xDirection: (_elm_lang$core$Native_Utils.cmp(scale, 0) > -1) ? _p17.xDirection : _ianmackenzie$acorn_demo$Direction2d$flip(_p17.xDirection)
			});
	});
var _ianmackenzie$acorn_demo$Arc2d$derivativeVector = function (_p18) {
	var _p19 = _p18;
	var _p20 = _p19._0;
	var startDerivative = A2(_ianmackenzie$acorn_demo$Vector2d$withLength, _p20.signedLength, _p20.xDirection);
	return function (t) {
		return ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) ? _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$acorn_demo$Vector2d$rotateBy, t * _p20.sweptAngle, startDerivative)) : _elm_lang$core$Maybe$Nothing;
	};
};
var _ianmackenzie$acorn_demo$Arc2d$derivativeVectors = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$Arc2d$derivativeVector(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$Arc2d$pointOn = function (_p21) {
	var _p22 = _p21;
	var _p25 = _p22._0;
	var arcSweptAngle = _p25.sweptAngle;
	var arcSignedLength = _p25.signedLength;
	var _p23 = _ianmackenzie$acorn_demo$Direction2d$components(_p25.xDirection);
	var dx = _p23._0;
	var dy = _p23._1;
	var _p24 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p25.startPoint);
	var x0 = _p24._0;
	var y0 = _p24._1;
	if (_elm_lang$core$Native_Utils.eq(arcSweptAngle, 0.0)) {
		return function (t) {
			if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
				var distance = t * arcSignedLength;
				return _elm_lang$core$Maybe$Just(
					_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
						{ctor: '_Tuple2', _0: x0 + (distance * dx), _1: y0 + (distance * dy)}));
			} else {
				return _elm_lang$core$Maybe$Nothing;
			}
		};
	} else {
		var arcRadius = arcSignedLength / arcSweptAngle;
		return function (t) {
			if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
				var theta = t * arcSweptAngle;
				var x = arcRadius * _elm_lang$core$Basics$sin(theta);
				var y = (_elm_lang$core$Native_Utils.cmp(
					_elm_lang$core$Basics$abs(theta),
					_elm_lang$core$Basics$pi / 2) < 0) ? (x * _elm_lang$core$Basics$tan(theta / 2)) : (arcRadius * (1 - _elm_lang$core$Basics$cos(theta)));
				return _elm_lang$core$Maybe$Just(
					_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
						{ctor: '_Tuple2', _0: (x0 + (x * dx)) - (y * dy), _1: (y0 + (x * dy)) + (y * dx)}));
			} else {
				return _elm_lang$core$Maybe$Nothing;
			}
		};
	}
};
var _ianmackenzie$acorn_demo$Arc2d$pointsOn = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$Arc2d$pointOn(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$Arc2d$sample = function (arc) {
	var derivativeOfArc = _ianmackenzie$acorn_demo$Arc2d$derivativeVector(arc);
	var pointOnArc = _ianmackenzie$acorn_demo$Arc2d$pointOn(arc);
	return function (t) {
		return A3(
			_elm_lang$core$Maybe$map2,
			F2(
				function (p, v) {
					return {ctor: '_Tuple2', _0: p, _1: v};
				}),
			pointOnArc(t),
			derivativeOfArc(t));
	};
};
var _ianmackenzie$acorn_demo$Arc2d$samples = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$Arc2d$sample(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$Arc2d$sweptAngle = function (_p26) {
	var _p27 = _p26;
	return _p27._0.sweptAngle;
};
var _ianmackenzie$acorn_demo$Arc2d$startPoint = function (_p28) {
	var _p29 = _p28;
	return _p29._0.startPoint;
};
var _ianmackenzie$acorn_demo$Arc2d$endPoint = function (arc) {
	var _p30 = A2(_ianmackenzie$acorn_demo$Arc2d$pointOn, arc, 1.0);
	if (_p30.ctor === 'Just') {
		return _p30._0;
	} else {
		return _ianmackenzie$acorn_demo$Arc2d$startPoint(arc);
	}
};
var _ianmackenzie$acorn_demo$Arc2d$reverse = function (_p31) {
	var _p32 = _p31;
	var _p33 = _p32._0;
	return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
		{
			startPoint: _ianmackenzie$acorn_demo$Arc2d$endPoint(_p32),
			sweptAngle: 0 - _p33.sweptAngle,
			signedLength: 0 - _p33.signedLength,
			xDirection: A2(_ianmackenzie$acorn_demo$Direction2d$rotateBy, _p33.sweptAngle, _p33.xDirection)
		});
};
var _ianmackenzie$acorn_demo$Arc2d$radius = function (_p34) {
	var _p35 = _p34;
	var _p36 = _p35._0;
	return _p36.signedLength / _p36.sweptAngle;
};
var _ianmackenzie$acorn_demo$Arc2d$numApproximationSegments = F2(
	function (tolerance, arc) {
		if (_elm_lang$core$Native_Utils.eq(
			_ianmackenzie$acorn_demo$Arc2d$sweptAngle(arc),
			0)) {
			return 1;
		} else {
			if (_elm_lang$core$Native_Utils.cmp(tolerance, 0) < 1) {
				return 0;
			} else {
				if (_elm_lang$core$Native_Utils.cmp(
					tolerance,
					2 * _ianmackenzie$acorn_demo$Arc2d$radius(arc)) > -1) {
					return 1;
				} else {
					var maxSegmentAngle = 2 * _elm_lang$core$Basics$acos(
						1 - (tolerance / _ianmackenzie$acorn_demo$Arc2d$radius(arc)));
					return _elm_lang$core$Basics$ceiling(
						_elm_lang$core$Basics$abs(
							_ianmackenzie$acorn_demo$Arc2d$sweptAngle(arc)) / maxSegmentAngle);
				}
			}
		}
	});
var _ianmackenzie$acorn_demo$Arc2d$toPolyline = F2(
	function (_p37, arc) {
		var _p38 = _p37;
		var numSegments = A2(_ianmackenzie$acorn_demo$Arc2d$numApproximationSegments, _p38._0, arc);
		var points = A2(
			_ianmackenzie$acorn_demo$Arc2d$pointsOn,
			arc,
			_ianmackenzie$acorn_demo$Geometry_Parameter$numSteps(numSegments));
		return _ianmackenzie$acorn_demo$Polyline2d$fromVertices(points);
	});
var _ianmackenzie$acorn_demo$Arc2d$centerPoint = function (_p39) {
	var _p40 = _p39;
	var _p43 = _p40._0;
	var r = _p43.signedLength / _p43.sweptAngle;
	var _p41 = _ianmackenzie$acorn_demo$Direction2d$components(_p43.xDirection);
	var dx = _p41._0;
	var dy = _p41._1;
	var _p42 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p43.startPoint);
	var x0 = _p42._0;
	var y0 = _p42._1;
	return _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
		{ctor: '_Tuple2', _0: x0 - (r * dy), _1: y0 + (r * dx)});
};
var _ianmackenzie$acorn_demo$Arc2d$sweptAround = F3(
	function (centerPoint_, sweptAngle_, startPoint_) {
		var _p44 = _ianmackenzie$acorn_demo$Vector2d$lengthAndDirection(
			A2(_ianmackenzie$acorn_demo$Vector2d$from, startPoint_, centerPoint_));
		if (_p44.ctor === 'Just') {
			return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
				{
					startPoint: startPoint_,
					xDirection: _ianmackenzie$acorn_demo$Direction2d$rotateClockwise(_p44._0._1),
					sweptAngle: sweptAngle_,
					signedLength: _p44._0._0 * sweptAngle_
				});
		} else {
			return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
				{startPoint: startPoint_, xDirection: _ianmackenzie$acorn_demo$Direction2d$x, sweptAngle: sweptAngle_, signedLength: 0});
		}
	});
var _ianmackenzie$acorn_demo$Arc2d$throughPoints = F3(
	function (firstPoint, secondPoint, thirdPoint) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (centerPoint_) {
				var thirdVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, centerPoint_, thirdPoint);
				var secondVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, centerPoint_, secondPoint);
				var firstVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, centerPoint_, firstPoint);
				return A4(
					_elm_lang$core$Maybe$map3,
					F3(
						function (firstDirection, secondDirection, thirdDirection) {
							var full = A2(_ianmackenzie$acorn_demo$Direction2d$angleFrom, firstDirection, thirdDirection);
							var partial = A2(_ianmackenzie$acorn_demo$Direction2d$angleFrom, firstDirection, secondDirection);
							var sweptAngle_ = ((_elm_lang$core$Native_Utils.cmp(partial, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(full, partial) > -1)) ? full : (((_elm_lang$core$Native_Utils.cmp(partial, 0) < 1) && (_elm_lang$core$Native_Utils.cmp(full, partial) < 1)) ? full : ((_elm_lang$core$Native_Utils.cmp(full, 0) > -1) ? (full - (2 * _elm_lang$core$Basics$pi)) : (full + (2 * _elm_lang$core$Basics$pi))));
							return A3(_ianmackenzie$acorn_demo$Arc2d$sweptAround, centerPoint_, sweptAngle_, firstPoint);
						}),
					_ianmackenzie$acorn_demo$Vector2d$direction(firstVector),
					_ianmackenzie$acorn_demo$Vector2d$direction(secondVector),
					_ianmackenzie$acorn_demo$Vector2d$direction(thirdVector));
			},
			A3(_ianmackenzie$acorn_demo$Point2d$circumcenter, firstPoint, secondPoint, thirdPoint));
	});
var _ianmackenzie$acorn_demo$Arc2d$withRadius = F4(
	function (radius_, sweptAngle_, startPoint_, endPoint_) {
		var squaredRadius = radius_ * radius_;
		var chord = A2(_ianmackenzie$acorn_demo$LineSegment2d$from, startPoint_, endPoint_);
		var squaredHalfLength = _ianmackenzie$acorn_demo$LineSegment2d$squaredLength(chord) / 4;
		return (_elm_lang$core$Native_Utils.cmp(squaredRadius, squaredHalfLength) > -1) ? A2(
			_elm_lang$core$Maybe$map,
			function (offsetDirection) {
				var halfLength = _elm_lang$core$Basics$sqrt(squaredHalfLength);
				var shortAngle = 2 * _elm_lang$core$Basics$asin(halfLength / radius_);
				var sweptAngleInRadians = function () {
					var _p45 = sweptAngle_;
					switch (_p45.ctor) {
						case 'SmallPositive':
							return shortAngle;
						case 'SmallNegative':
							return 0 - shortAngle;
						case 'LargePositive':
							return (2 * _elm_lang$core$Basics$pi) - shortAngle;
						default:
							return shortAngle - (2 * _elm_lang$core$Basics$pi);
					}
				}();
				var midpoint = _ianmackenzie$acorn_demo$LineSegment2d$midpoint(chord);
				var offsetMagnitude = _elm_lang$core$Basics$sqrt(squaredRadius - squaredHalfLength);
				var offsetDistance = function () {
					var _p46 = sweptAngle_;
					switch (_p46.ctor) {
						case 'SmallPositive':
							return offsetMagnitude;
						case 'SmallNegative':
							return 0 - offsetMagnitude;
						case 'LargeNegative':
							return offsetMagnitude;
						default:
							return 0 - offsetMagnitude;
					}
				}();
				var offset = A2(_ianmackenzie$acorn_demo$Vector2d$withLength, offsetDistance, offsetDirection);
				var centerPoint_ = A2(_ianmackenzie$acorn_demo$Point2d$translateBy, offset, midpoint);
				return A3(_ianmackenzie$acorn_demo$Arc2d$sweptAround, centerPoint_, sweptAngleInRadians, startPoint_);
			},
			_ianmackenzie$acorn_demo$LineSegment2d$perpendicularDirection(chord)) : _elm_lang$core$Maybe$Nothing;
	});
var _ianmackenzie$acorn_demo$Arc2d$with = function (properties) {
	var _p47 = _ianmackenzie$acorn_demo$Point2d$coordinates(properties.centerPoint);
	var x0 = _p47._0;
	var y0 = _p47._1;
	return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
		{
			startPoint: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
				{
					ctor: '_Tuple2',
					_0: x0 + (properties.radius * _elm_lang$core$Basics$cos(properties.startAngle)),
					_1: y0 + (properties.radius * _elm_lang$core$Basics$sin(properties.startAngle))
				}),
			sweptAngle: properties.sweptAngle,
			xDirection: _ianmackenzie$acorn_demo$Direction2d$fromAngle(
				properties.startAngle + _elm_lang$core$Basics$degrees(90)),
			signedLength: _elm_lang$core$Basics$abs(properties.radius) * properties.sweptAngle
		});
};
var _ianmackenzie$acorn_demo$Arc2d$twoPi = 2 * _elm_lang$core$Basics$pi;
var _ianmackenzie$acorn_demo$Arc2d$from = F3(
	function (startPoint_, endPoint_, sweptAngle_) {
		var displacement = A2(_ianmackenzie$acorn_demo$Vector2d$from, startPoint_, endPoint_);
		var _p48 = _ianmackenzie$acorn_demo$Vector2d$lengthAndDirection(displacement);
		if (_p48.ctor === 'Just') {
			var _p49 = _p48._0._0;
			var radius_ = _p49 / (2 * _elm_lang$core$Basics$abs(
				_elm_lang$core$Basics$sin(sweptAngle_ / 2)));
			var angleModTwoPi = sweptAngle_ - (_ianmackenzie$acorn_demo$Arc2d$twoPi * _elm_lang$core$Basics$toFloat(
				_elm_lang$core$Basics$floor(sweptAngle_ / _ianmackenzie$acorn_demo$Arc2d$twoPi)));
			return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
				{
					startPoint: startPoint_,
					sweptAngle: sweptAngle_,
					xDirection: A2(_ianmackenzie$acorn_demo$Direction2d$rotateBy, (0 - angleModTwoPi) / 2, _p48._0._1),
					signedLength: _elm_lang$core$Native_Utils.eq(sweptAngle_, 0.0) ? _p49 : (radius_ * sweptAngle_)
				});
		} else {
			return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
				{startPoint: startPoint_, sweptAngle: sweptAngle_, xDirection: _ianmackenzie$acorn_demo$Direction2d$x, signedLength: 0});
		}
	});

var _ianmackenzie$acorn_demo$Background$colorWith = function (_p0) {
	var _p1 = _p0;
	return A4(_elm_lang$core$Color$rgba, 93, 93, 93, _p1.alpha);
};
var _ianmackenzie$acorn_demo$Background$color = _ianmackenzie$acorn_demo$Background$colorWith(
	{alpha: 1});

var _ianmackenzie$acorn_demo$Circle2d$toArc = function (_p0) {
	var _p1 = _p0;
	var _p3 = _p1._0;
	var _p2 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p3.centerPoint);
	var x0 = _p2._0;
	var y0 = _p2._1;
	return _ianmackenzie$acorn_demo$Geometry_Types$Arc2d(
		{
			startPoint: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
				{ctor: '_Tuple2', _0: x0 + _p3.radius, _1: y0}),
			xDirection: _ianmackenzie$acorn_demo$Direction2d$y,
			sweptAngle: 2 * _elm_lang$core$Basics$pi,
			signedLength: (2 * _elm_lang$core$Basics$pi) * _p3.radius
		});
};
var _ianmackenzie$acorn_demo$Circle2d$radius = function (_p4) {
	var _p5 = _p4;
	return _p5._0.radius;
};
var _ianmackenzie$acorn_demo$Circle2d$diameter = function (circle) {
	return 2 * _ianmackenzie$acorn_demo$Circle2d$radius(circle);
};
var _ianmackenzie$acorn_demo$Circle2d$area = function (circle) {
	var r = _ianmackenzie$acorn_demo$Circle2d$radius(circle);
	return (_elm_lang$core$Basics$pi * r) * r;
};
var _ianmackenzie$acorn_demo$Circle2d$circumference = function (circle) {
	return (2 * _elm_lang$core$Basics$pi) * _ianmackenzie$acorn_demo$Circle2d$radius(circle);
};
var _ianmackenzie$acorn_demo$Circle2d$centerPoint = function (_p6) {
	var _p7 = _p6;
	return _p7._0.centerPoint;
};
var _ianmackenzie$acorn_demo$Circle2d$contains = F2(
	function (point, circle) {
		var r = _ianmackenzie$acorn_demo$Circle2d$radius(circle);
		return _elm_lang$core$Native_Utils.cmp(
			A2(
				_ianmackenzie$acorn_demo$Point2d$squaredDistanceFrom,
				_ianmackenzie$acorn_demo$Circle2d$centerPoint(circle),
				point),
			r * r) < 1;
	});
var _ianmackenzie$acorn_demo$Circle2d$boundingBox = function (circle) {
	var r = _ianmackenzie$acorn_demo$Circle2d$radius(circle);
	var _p8 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$Circle2d$centerPoint(circle));
	var x = _p8._0;
	var y = _p8._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{minX: x - r, maxX: x + r, minY: y - r, maxY: y + r});
};
var _ianmackenzie$acorn_demo$Circle2d$withRadius = F2(
	function (radius_, centerPoint_) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Circle2d(
			{
				radius: _elm_lang$core$Basics$abs(radius_),
				centerPoint: centerPoint_
			});
	});
var _ianmackenzie$acorn_demo$Circle2d$unit = A2(_ianmackenzie$acorn_demo$Circle2d$withRadius, 1, _ianmackenzie$acorn_demo$Point2d$origin);
var _ianmackenzie$acorn_demo$Circle2d$throughPoints = F3(
	function (p1, p2, p3) {
		return A2(
			_elm_lang$core$Maybe$map,
			function (p0) {
				var r3 = A2(_ianmackenzie$acorn_demo$Point2d$distanceFrom, p0, p3);
				var r2 = A2(_ianmackenzie$acorn_demo$Point2d$distanceFrom, p0, p2);
				var r1 = A2(_ianmackenzie$acorn_demo$Point2d$distanceFrom, p0, p1);
				var r = ((r1 + r2) + r3) / 3;
				return A2(_ianmackenzie$acorn_demo$Circle2d$withRadius, r, p0);
			},
			A3(_ianmackenzie$acorn_demo$Point2d$circumcenter, p1, p2, p3));
	});
var _ianmackenzie$acorn_demo$Circle2d$sweptAround = F2(
	function (centerPoint_, point) {
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			A2(_ianmackenzie$acorn_demo$Point2d$distanceFrom, centerPoint_, point),
			centerPoint_);
	});
var _ianmackenzie$acorn_demo$Circle2d$scaleAbout = F3(
	function (point, scale, _p9) {
		var _p10 = _p9;
		var _p11 = _p10._0;
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			_elm_lang$core$Basics$abs(scale) * _p11.radius,
			A3(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale, _p11.centerPoint));
	});
var _ianmackenzie$acorn_demo$Circle2d$rotateAround = F2(
	function (point, angle) {
		var rotatePoint = A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle);
		return function (_p12) {
			var _p13 = _p12;
			var _p14 = _p13._0;
			return A2(
				_ianmackenzie$acorn_demo$Circle2d$withRadius,
				_p14.radius,
				rotatePoint(_p14.centerPoint));
		};
	});
var _ianmackenzie$acorn_demo$Circle2d$translateBy = F2(
	function (displacement, _p15) {
		var _p16 = _p15;
		var _p17 = _p16._0;
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			_p17.radius,
			A2(_ianmackenzie$acorn_demo$Point2d$translateBy, displacement, _p17.centerPoint));
	});
var _ianmackenzie$acorn_demo$Circle2d$translateIn = F3(
	function (direction, distance, circle) {
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			circle);
	});
var _ianmackenzie$acorn_demo$Circle2d$mirrorAcross = F2(
	function (axis, _p18) {
		var _p19 = _p18;
		var _p20 = _p19._0;
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			_p20.radius,
			A2(_ianmackenzie$acorn_demo$Point2d$mirrorAcross, axis, _p20.centerPoint));
	});
var _ianmackenzie$acorn_demo$Circle2d$relativeTo = F2(
	function (frame, _p21) {
		var _p22 = _p21;
		var _p23 = _p22._0;
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			_p23.radius,
			A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p23.centerPoint));
	});
var _ianmackenzie$acorn_demo$Circle2d$placeIn = F2(
	function (frame, _p24) {
		var _p25 = _p24;
		var _p26 = _p25._0;
		return A2(
			_ianmackenzie$acorn_demo$Circle2d$withRadius,
			_p26.radius,
			A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p26.centerPoint));
	});

var _xarvh$elm_gamepad$Gamepad$estimateThreshold = function (_p0) {
	var _p1 = _p0;
	return (_elm_lang$core$Native_Utils.cmp(_p1._1, 0.5) < 0) ? _elm_lang$core$Maybe$Nothing : _elm_lang$core$Maybe$Just(_p1._0);
};
var _xarvh$elm_gamepad$Gamepad$boolToNumber = function (bool) {
	return bool ? 1 : 0;
};
var _xarvh$elm_gamepad$Gamepad$getIndex = function (_p2) {
	var _p3 = _p2;
	return _p3._1.index;
};
var _xarvh$elm_gamepad$Gamepad$unknownGetIndex = function (_p4) {
	var _p5 = _p4;
	return _p5._0.index;
};
var _xarvh$elm_gamepad$Gamepad$unknownGetId = function (_p6) {
	var _p7 = _p6;
	return _p7._0.id;
};
var _xarvh$elm_gamepad$Gamepad$reverseAxis = F2(
	function (isReverse, n) {
		return isReverse ? (0 - n) : n;
	});
var _xarvh$elm_gamepad$Gamepad$buttonToAxis = function (b) {
	return b ? 1 : 0;
};
var _xarvh$elm_gamepad$Gamepad$axisToButton = function (n) {
	return _elm_lang$core$Native_Utils.cmp(n, 0.1) > 0;
};
var _xarvh$elm_gamepad$Gamepad$maybeToReverse = function (maybeReverse) {
	var _p8 = maybeReverse;
	if ((_p8.ctor === 'Just') && (_p8._0 === '-')) {
		return true;
	} else {
		return false;
	}
};
var _xarvh$elm_gamepad$Gamepad$isConnected = function (rawGamepad) {
	return rawGamepad.connected && (_elm_lang$core$Native_Utils.cmp(rawGamepad.timestamp, 0) > 0);
};
var _xarvh$elm_gamepad$Gamepad$getRawGamepads = function (blob) {
	return A2(
		_elm_lang$core$List$filter,
		_xarvh$elm_gamepad$Gamepad$isConnected,
		A2(_elm_lang$core$List$filterMap, _elm_lang$core$Basics$identity, blob));
};
var _xarvh$elm_gamepad$Gamepad$buttonMapDivider = ',,,';
var _xarvh$elm_gamepad$Gamepad$databaseToString = function (_p9) {
	var _p10 = _p9;
	var tupleToString = function (_p11) {
		var _p12 = _p11;
		return A2(
			_elm_lang$core$Basics_ops['++'],
			_p12._0,
			A2(
				_elm_lang$core$Basics_ops['++'],
				_xarvh$elm_gamepad$Gamepad$buttonMapDivider,
				A2(_elm_lang$core$Basics_ops['++'], _p12._1, '\n')));
	};
	return A2(
		_elm_lang$core$String$join,
		'',
		A2(
			_elm_lang$core$List$sortBy,
			_elm_lang$core$Basics$identity,
			A2(
				_elm_lang$core$List$map,
				tupleToString,
				_elm_lang$core$Dict$toList(_p10._0))));
};
var _xarvh$elm_gamepad$Gamepad$intToString = _elm_lang$core$Basics$toString;
var _xarvh$elm_gamepad$Gamepad$destinationToString = function (destination) {
	var _p13 = destination;
	switch (_p13.ctor) {
		case 'A':
			return 'a';
		case 'B':
			return 'b';
		case 'X':
			return 'x';
		case 'Y':
			return 'y';
		case 'Start':
			return 'start';
		case 'Back':
			return 'back';
		case 'Home':
			return 'home';
		case 'LeftLeft':
			return 'leftleft';
		case 'LeftRight':
			return 'leftright';
		case 'LeftUp':
			return 'leftup';
		case 'LeftDown':
			return 'leftdown';
		case 'LeftStick':
			return 'leftstick';
		case 'LeftBumper':
			return 'leftbumper';
		case 'LeftTrigger':
			return 'lefttrigger';
		case 'RightLeft':
			return 'rightleft';
		case 'RightRight':
			return 'rightright';
		case 'RightUp':
			return 'rightup';
		case 'RightDown':
			return 'rightdown';
		case 'RightStick':
			return 'rightstick';
		case 'RightBumper':
			return 'rightbumper';
		case 'RightTrigger':
			return 'righttrigger';
		case 'DpadUp':
			return 'dpadup';
		case 'DpadDown':
			return 'dpaddown';
		case 'DpadLeft':
			return 'dpadleft';
		default:
			return 'dpadright';
	}
};
var _xarvh$elm_gamepad$Gamepad$fixAxisCoupling = F2(
	function (_p14, map) {
		var _p15 = _p14;
		var _p17 = _p15._0;
		var _p16 = {
			ctor: '_Tuple2',
			_0: A2(
				_elm_lang$core$Dict$get,
				_xarvh$elm_gamepad$Gamepad$destinationToString(_p17),
				map),
			_1: A2(
				_elm_lang$core$Dict$get,
				_xarvh$elm_gamepad$Gamepad$destinationToString(_p15._1),
				map)
		};
		if ((((_p16._0.ctor === 'Just') && (_p16._0._0._1.ctor === 'Axis')) && (_p16._1.ctor === 'Just')) && (_p16._1._0._1.ctor === 'Axis')) {
			return _elm_lang$core$Native_Utils.eq(_p16._0._0._2, _p16._1._0._2) ? A2(
				_elm_lang$core$Dict$remove,
				_xarvh$elm_gamepad$Gamepad$destinationToString(_p17),
				map) : map;
		} else {
			return map;
		}
	});
var _xarvh$elm_gamepad$Gamepad$RawGamepad = F7(
	function (a, b, c, d, e, f, g) {
		return {axes: a, buttons: b, connected: c, id: d, index: e, mapping: f, timestamp: g};
	});
var _xarvh$elm_gamepad$Gamepad$Gamepad = F2(
	function (a, b) {
		return {ctor: 'Gamepad', _0: a, _1: b};
	});
var _xarvh$elm_gamepad$Gamepad$UnknownGamepad = function (a) {
	return {ctor: 'UnknownGamepad', _0: a};
};
var _xarvh$elm_gamepad$Gamepad$getAllGamepadsAsUnknown = function (blob) {
	return A2(
		_elm_lang$core$List$map,
		_xarvh$elm_gamepad$Gamepad$UnknownGamepad,
		_xarvh$elm_gamepad$Gamepad$getRawGamepads(blob));
};
var _xarvh$elm_gamepad$Gamepad$Database = function (a) {
	return {ctor: 'Database', _0: a};
};
var _xarvh$elm_gamepad$Gamepad$emptyDatabase = _xarvh$elm_gamepad$Gamepad$Database(_elm_lang$core$Dict$empty);
var _xarvh$elm_gamepad$Gamepad$databaseFromString = function (databaseAsString) {
	var stringToTuple = function (dbEntry) {
		var _p18 = A2(_elm_lang$core$String$split, _xarvh$elm_gamepad$Gamepad$buttonMapDivider, dbEntry);
		if (((_p18.ctor === '::') && (_p18._1.ctor === '::')) && (_p18._1._1.ctor === '[]')) {
			return _elm_lang$core$Maybe$Just(
				{ctor: '_Tuple2', _0: _p18._0, _1: _p18._1._0});
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	};
	return _elm_lang$core$Result$Ok(
		_xarvh$elm_gamepad$Gamepad$Database(
			_elm_lang$core$Dict$fromList(
				A2(
					_elm_lang$core$List$filterMap,
					_elm_lang$core$Basics$identity,
					A2(
						_elm_lang$core$List$map,
						stringToTuple,
						A2(_elm_lang$core$String$split, '\n', databaseAsString))))));
};
var _xarvh$elm_gamepad$Gamepad$Origin = F3(
	function (a, b, c) {
		return {ctor: 'Origin', _0: a, _1: b, _2: c};
	});
var _xarvh$elm_gamepad$Gamepad$Button = {ctor: 'Button'};
var _xarvh$elm_gamepad$Gamepad$buttonToEstimate = F2(
	function (originIndex, _p19) {
		var _p20 = _p19;
		return {
			ctor: '_Tuple2',
			_0: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, originIndex),
			_1: _xarvh$elm_gamepad$Gamepad$boolToNumber(_p20._0)
		};
	});
var _xarvh$elm_gamepad$Gamepad$Axis = {ctor: 'Axis'};
var _xarvh$elm_gamepad$Gamepad$stringToInputType = function (s) {
	var _p21 = s;
	switch (_p21) {
		case 'a':
			return _elm_lang$core$Maybe$Just(_xarvh$elm_gamepad$Gamepad$Axis);
		case 'b':
			return _elm_lang$core$Maybe$Just(_xarvh$elm_gamepad$Gamepad$Button);
		default:
			return _elm_lang$core$Maybe$Nothing;
	}
};
var _xarvh$elm_gamepad$Gamepad$regexMatchToInputTuple = function (match) {
	var _p22 = match.submatches;
	if ((((((_p22.ctor === '::') && (_p22._1.ctor === '::')) && (_p22._1._1.ctor === '::')) && (_p22._1._1._0.ctor === 'Just')) && (_p22._1._1._1.ctor === '::')) && (_p22._1._1._1._0.ctor === 'Just')) {
		return A4(
			_elm_lang$core$Maybe$map3,
			F3(
				function (v0, v1, v2) {
					return {ctor: '_Tuple3', _0: v0, _1: v1, _2: v2};
				}),
			_xarvh$elm_gamepad$Gamepad$stringToInputType(_p22._1._1._0._0),
			_elm_lang$core$Result$toMaybe(
				_elm_lang$core$String$toInt(_p22._1._1._1._0._0)),
			_elm_lang$core$Maybe$Just(
				_xarvh$elm_gamepad$Gamepad$maybeToReverse(_p22._1._0)));
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _xarvh$elm_gamepad$Gamepad$mappingToRawIndex = F2(
	function (destination, mapping) {
		var regex = A2(
			_elm_lang$core$Basics_ops['++'],
			'(^|,)',
			A2(
				_elm_lang$core$Basics_ops['++'],
				_xarvh$elm_gamepad$Gamepad$destinationToString(destination),
				':(-)?([a-z]?)([0-9]+)(,|$)'));
		return A2(
			_elm_lang$core$Maybe$andThen,
			_xarvh$elm_gamepad$Gamepad$regexMatchToInputTuple,
			_elm_lang$core$List$head(
				A3(
					_elm_lang$core$Regex$find,
					_elm_lang$core$Regex$AtMost(1),
					_elm_lang$core$Regex$regex(regex),
					mapping)));
	});
var _xarvh$elm_gamepad$Gamepad$isPressed = F2(
	function (destination, _p23) {
		var _p24 = _p23;
		var _p26 = _p24._1;
		var _p25 = A2(_xarvh$elm_gamepad$Gamepad$mappingToRawIndex, destination, _p24._0);
		if (_p25.ctor === 'Nothing') {
			return false;
		} else {
			if (_p25._0._0.ctor === 'Axis') {
				return _xarvh$elm_gamepad$Gamepad$axisToButton(
					A2(
						_xarvh$elm_gamepad$Gamepad$reverseAxis,
						_p25._0._2,
						A2(
							_elm_lang$core$Maybe$withDefault,
							0,
							A2(_elm_lang$core$Array$get, _p25._0._1, _p26.axes))));
			} else {
				return A2(
					_elm_lang$core$Maybe$withDefault,
					false,
					A2(
						_elm_lang$core$Maybe$map,
						_elm_lang$core$Tuple$first,
						A2(_elm_lang$core$Array$get, _p25._0._1, _p26.buttons)));
			}
		}
	});
var _xarvh$elm_gamepad$Gamepad$getValue = F2(
	function (destination, _p27) {
		var _p28 = _p27;
		var _p30 = _p28._1;
		var _p29 = A2(_xarvh$elm_gamepad$Gamepad$mappingToRawIndex, destination, _p28._0);
		if (_p29.ctor === 'Nothing') {
			return 0;
		} else {
			if (_p29._0._0.ctor === 'Axis') {
				return A2(
					_xarvh$elm_gamepad$Gamepad$reverseAxis,
					_p29._0._2,
					A2(
						_elm_lang$core$Maybe$withDefault,
						0,
						A2(_elm_lang$core$Array$get, _p29._0._1, _p30.axes)));
			} else {
				return A2(
					_elm_lang$core$Maybe$withDefault,
					0,
					A2(
						_elm_lang$core$Maybe$map,
						_elm_lang$core$Tuple$second,
						A2(_elm_lang$core$Array$get, _p29._0._1, _p30.buttons)));
			}
		}
	});
var _xarvh$elm_gamepad$Gamepad$getAxis = F3(
	function (negativeDestination, positiveDestination, pad) {
		return A3(
			_elm_lang$core$Basics$clamp,
			-1,
			1,
			A2(_xarvh$elm_gamepad$Gamepad$getValue, positiveDestination, pad) - A2(_xarvh$elm_gamepad$Gamepad$getValue, negativeDestination, pad));
	});
var _xarvh$elm_gamepad$Gamepad$axisToEstimate = F2(
	function (originIndex, value) {
		return {
			ctor: '_Tuple2',
			_0: A3(
				_xarvh$elm_gamepad$Gamepad$Origin,
				_elm_lang$core$Native_Utils.cmp(value, 0) < 0,
				_xarvh$elm_gamepad$Gamepad$Axis,
				originIndex),
			_1: _elm_lang$core$Basics$abs(value)
		};
	});
var _xarvh$elm_gamepad$Gamepad$estimateOrigin = function (_p31) {
	var _p32 = _p31;
	var _p33 = _p32._0;
	var buttonsEstimates = A2(_elm_lang$core$Array$indexedMap, _xarvh$elm_gamepad$Gamepad$buttonToEstimate, _p33.buttons);
	var axesEstimates = A2(_elm_lang$core$Array$indexedMap, _xarvh$elm_gamepad$Gamepad$axisToEstimate, _p33.axes);
	return A2(
		_elm_lang$core$Maybe$andThen,
		_xarvh$elm_gamepad$Gamepad$estimateThreshold,
		_elm_lang$core$List$head(
			_elm_lang$core$List$reverse(
				A2(
					_elm_lang$core$List$sortBy,
					_elm_lang$core$Tuple$second,
					_elm_lang$core$Array$toList(
						A2(_elm_lang$core$Array$append, axesEstimates, buttonsEstimates))))));
};
var _xarvh$elm_gamepad$Gamepad$DpadRight = {ctor: 'DpadRight'};
var _xarvh$elm_gamepad$Gamepad$dpadRightIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$DpadRight);
var _xarvh$elm_gamepad$Gamepad$DpadLeft = {ctor: 'DpadLeft'};
var _xarvh$elm_gamepad$Gamepad$dpadLeftIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$DpadLeft);
var _xarvh$elm_gamepad$Gamepad$dpadX = function (pad) {
	return _xarvh$elm_gamepad$Gamepad$dpadLeftIsPressed(pad) ? -1 : (_xarvh$elm_gamepad$Gamepad$dpadRightIsPressed(pad) ? 1 : 0);
};
var _xarvh$elm_gamepad$Gamepad$DpadDown = {ctor: 'DpadDown'};
var _xarvh$elm_gamepad$Gamepad$dpadDownIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$DpadDown);
var _xarvh$elm_gamepad$Gamepad$DpadUp = {ctor: 'DpadUp'};
var _xarvh$elm_gamepad$Gamepad$dpadUpIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$DpadUp);
var _xarvh$elm_gamepad$Gamepad$dpadY = function (pad) {
	return _xarvh$elm_gamepad$Gamepad$dpadUpIsPressed(pad) ? 1 : (_xarvh$elm_gamepad$Gamepad$dpadDownIsPressed(pad) ? -1 : 0);
};
var _xarvh$elm_gamepad$Gamepad$RightTrigger = {ctor: 'RightTrigger'};
var _xarvh$elm_gamepad$Gamepad$rightTriggerIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$RightTrigger);
var _xarvh$elm_gamepad$Gamepad$rightTriggerValue = _xarvh$elm_gamepad$Gamepad$getValue(_xarvh$elm_gamepad$Gamepad$RightTrigger);
var _xarvh$elm_gamepad$Gamepad$RightBumper = {ctor: 'RightBumper'};
var _xarvh$elm_gamepad$Gamepad$rightBumperIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$RightBumper);
var _xarvh$elm_gamepad$Gamepad$RightStick = {ctor: 'RightStick'};
var _xarvh$elm_gamepad$Gamepad$rightStickIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$RightStick);
var _xarvh$elm_gamepad$Gamepad$RightDown = {ctor: 'RightDown'};
var _xarvh$elm_gamepad$Gamepad$RightUp = {ctor: 'RightUp'};
var _xarvh$elm_gamepad$Gamepad$rightY = A2(_xarvh$elm_gamepad$Gamepad$getAxis, _xarvh$elm_gamepad$Gamepad$RightDown, _xarvh$elm_gamepad$Gamepad$RightUp);
var _xarvh$elm_gamepad$Gamepad$RightRight = {ctor: 'RightRight'};
var _xarvh$elm_gamepad$Gamepad$RightLeft = {ctor: 'RightLeft'};
var _xarvh$elm_gamepad$Gamepad$rightX = A2(_xarvh$elm_gamepad$Gamepad$getAxis, _xarvh$elm_gamepad$Gamepad$RightLeft, _xarvh$elm_gamepad$Gamepad$RightRight);
var _xarvh$elm_gamepad$Gamepad$LeftTrigger = {ctor: 'LeftTrigger'};
var _xarvh$elm_gamepad$Gamepad$leftTriggerIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$LeftTrigger);
var _xarvh$elm_gamepad$Gamepad$leftTriggerValue = _xarvh$elm_gamepad$Gamepad$getValue(_xarvh$elm_gamepad$Gamepad$LeftTrigger);
var _xarvh$elm_gamepad$Gamepad$LeftBumper = {ctor: 'LeftBumper'};
var _xarvh$elm_gamepad$Gamepad$leftBumperIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$LeftBumper);
var _xarvh$elm_gamepad$Gamepad$LeftStick = {ctor: 'LeftStick'};
var _xarvh$elm_gamepad$Gamepad$leftStickIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$LeftStick);
var _xarvh$elm_gamepad$Gamepad$LeftDown = {ctor: 'LeftDown'};
var _xarvh$elm_gamepad$Gamepad$LeftUp = {ctor: 'LeftUp'};
var _xarvh$elm_gamepad$Gamepad$leftY = A2(_xarvh$elm_gamepad$Gamepad$getAxis, _xarvh$elm_gamepad$Gamepad$LeftDown, _xarvh$elm_gamepad$Gamepad$LeftUp);
var _xarvh$elm_gamepad$Gamepad$LeftRight = {ctor: 'LeftRight'};
var _xarvh$elm_gamepad$Gamepad$LeftLeft = {ctor: 'LeftLeft'};
var _xarvh$elm_gamepad$Gamepad$fixAllAxesCoupling = function (map) {
	return _elm_lang$core$Dict$toList(
		A3(
			_elm_lang$core$List$foldr,
			_xarvh$elm_gamepad$Gamepad$fixAxisCoupling,
			_elm_lang$core$Dict$fromList(map),
			{
				ctor: '::',
				_0: {ctor: '_Tuple2', _0: _xarvh$elm_gamepad$Gamepad$LeftLeft, _1: _xarvh$elm_gamepad$Gamepad$LeftRight},
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: _xarvh$elm_gamepad$Gamepad$LeftUp, _1: _xarvh$elm_gamepad$Gamepad$LeftDown},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: _xarvh$elm_gamepad$Gamepad$RightLeft, _1: _xarvh$elm_gamepad$Gamepad$RightRight},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: _xarvh$elm_gamepad$Gamepad$RightUp, _1: _xarvh$elm_gamepad$Gamepad$RightDown},
							_1: {ctor: '[]'}
						}
					}
				}
			}));
};
var _xarvh$elm_gamepad$Gamepad$buttonMap = function (map) {
	var tupleDestinationToString = function (_p34) {
		var _p35 = _p34;
		return {
			ctor: '_Tuple2',
			_0: _xarvh$elm_gamepad$Gamepad$destinationToString(_p35._0),
			_1: _p35._1
		};
	};
	var typeToString = function (originType) {
		var _p36 = originType;
		if (_p36.ctor === 'Axis') {
			return 'a';
		} else {
			return 'b';
		}
	};
	var hasMinus = function (isReverse) {
		return isReverse ? '-' : '';
	};
	var originToCode = function (_p37) {
		var _p38 = _p37;
		return A2(
			_elm_lang$core$Basics_ops['++'],
			hasMinus(_p38._0),
			A2(
				_elm_lang$core$Basics_ops['++'],
				typeToString(_p38._1),
				_xarvh$elm_gamepad$Gamepad$intToString(_p38._2)));
	};
	var tupleToString = function (_p39) {
		var _p40 = _p39;
		return A2(
			_elm_lang$core$Basics_ops['++'],
			_p40._0,
			A2(
				_elm_lang$core$Basics_ops['++'],
				':',
				originToCode(_p40._1)));
	};
	return A2(
		_elm_lang$core$String$join,
		',',
		A2(
			_elm_lang$core$List$sortBy,
			_elm_lang$core$Basics$identity,
			A2(
				_elm_lang$core$List$map,
				tupleToString,
				_xarvh$elm_gamepad$Gamepad$fixAllAxesCoupling(
					A2(_elm_lang$core$List$map, tupleDestinationToString, map)))));
};
var _xarvh$elm_gamepad$Gamepad$buttonMapToUpdateDatabase = F3(
	function (unknownGamepad, map, _p41) {
		var _p42 = _p41;
		return _xarvh$elm_gamepad$Gamepad$Database(
			A3(
				_elm_lang$core$Dict$insert,
				_xarvh$elm_gamepad$Gamepad$unknownGetId(unknownGamepad),
				_xarvh$elm_gamepad$Gamepad$buttonMap(map),
				_p42._0));
	});
var _xarvh$elm_gamepad$Gamepad$leftX = A2(_xarvh$elm_gamepad$Gamepad$getAxis, _xarvh$elm_gamepad$Gamepad$LeftLeft, _xarvh$elm_gamepad$Gamepad$LeftRight);
var _xarvh$elm_gamepad$Gamepad$Home = {ctor: 'Home'};
var _xarvh$elm_gamepad$Gamepad$homeIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$Home);
var _xarvh$elm_gamepad$Gamepad$Back = {ctor: 'Back'};
var _xarvh$elm_gamepad$Gamepad$backIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$Back);
var _xarvh$elm_gamepad$Gamepad$Start = {ctor: 'Start'};
var _xarvh$elm_gamepad$Gamepad$startIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$Start);
var _xarvh$elm_gamepad$Gamepad$Y = {ctor: 'Y'};
var _xarvh$elm_gamepad$Gamepad$yIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$Y);
var _xarvh$elm_gamepad$Gamepad$X = {ctor: 'X'};
var _xarvh$elm_gamepad$Gamepad$xIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$X);
var _xarvh$elm_gamepad$Gamepad$B = {ctor: 'B'};
var _xarvh$elm_gamepad$Gamepad$bIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$B);
var _xarvh$elm_gamepad$Gamepad$A = {ctor: 'A'};
var _xarvh$elm_gamepad$Gamepad$standardButtonMaps = _elm_lang$core$Dict$fromList(
	{
		ctor: '::',
		_0: {
			ctor: '_Tuple2',
			_0: 'standard',
			_1: _xarvh$elm_gamepad$Gamepad$buttonMap(
				{
					ctor: '::',
					_0: {
						ctor: '_Tuple2',
						_0: _xarvh$elm_gamepad$Gamepad$A,
						_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 0)
					},
					_1: {
						ctor: '::',
						_0: {
							ctor: '_Tuple2',
							_0: _xarvh$elm_gamepad$Gamepad$B,
							_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 1)
						},
						_1: {
							ctor: '::',
							_0: {
								ctor: '_Tuple2',
								_0: _xarvh$elm_gamepad$Gamepad$X,
								_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 2)
							},
							_1: {
								ctor: '::',
								_0: {
									ctor: '_Tuple2',
									_0: _xarvh$elm_gamepad$Gamepad$Y,
									_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 3)
								},
								_1: {
									ctor: '::',
									_0: {
										ctor: '_Tuple2',
										_0: _xarvh$elm_gamepad$Gamepad$Start,
										_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 9)
									},
									_1: {
										ctor: '::',
										_0: {
											ctor: '_Tuple2',
											_0: _xarvh$elm_gamepad$Gamepad$Back,
											_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 8)
										},
										_1: {
											ctor: '::',
											_0: {
												ctor: '_Tuple2',
												_0: _xarvh$elm_gamepad$Gamepad$Home,
												_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 16)
											},
											_1: {
												ctor: '::',
												_0: {
													ctor: '_Tuple2',
													_0: _xarvh$elm_gamepad$Gamepad$LeftRight,
													_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Axis, 0)
												},
												_1: {
													ctor: '::',
													_0: {
														ctor: '_Tuple2',
														_0: _xarvh$elm_gamepad$Gamepad$LeftDown,
														_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Axis, 1)
													},
													_1: {
														ctor: '::',
														_0: {
															ctor: '_Tuple2',
															_0: _xarvh$elm_gamepad$Gamepad$LeftStick,
															_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 10)
														},
														_1: {
															ctor: '::',
															_0: {
																ctor: '_Tuple2',
																_0: _xarvh$elm_gamepad$Gamepad$LeftBumper,
																_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 4)
															},
															_1: {
																ctor: '::',
																_0: {
																	ctor: '_Tuple2',
																	_0: _xarvh$elm_gamepad$Gamepad$LeftTrigger,
																	_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 6)
																},
																_1: {
																	ctor: '::',
																	_0: {
																		ctor: '_Tuple2',
																		_0: _xarvh$elm_gamepad$Gamepad$RightRight,
																		_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Axis, 2)
																	},
																	_1: {
																		ctor: '::',
																		_0: {
																			ctor: '_Tuple2',
																			_0: _xarvh$elm_gamepad$Gamepad$RightDown,
																			_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Axis, 3)
																		},
																		_1: {
																			ctor: '::',
																			_0: {
																				ctor: '_Tuple2',
																				_0: _xarvh$elm_gamepad$Gamepad$RightStick,
																				_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 11)
																			},
																			_1: {
																				ctor: '::',
																				_0: {
																					ctor: '_Tuple2',
																					_0: _xarvh$elm_gamepad$Gamepad$RightBumper,
																					_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 5)
																				},
																				_1: {
																					ctor: '::',
																					_0: {
																						ctor: '_Tuple2',
																						_0: _xarvh$elm_gamepad$Gamepad$RightTrigger,
																						_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 7)
																					},
																					_1: {
																						ctor: '::',
																						_0: {
																							ctor: '_Tuple2',
																							_0: _xarvh$elm_gamepad$Gamepad$DpadUp,
																							_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 12)
																						},
																						_1: {
																							ctor: '::',
																							_0: {
																								ctor: '_Tuple2',
																								_0: _xarvh$elm_gamepad$Gamepad$DpadDown,
																								_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 13)
																							},
																							_1: {
																								ctor: '::',
																								_0: {
																									ctor: '_Tuple2',
																									_0: _xarvh$elm_gamepad$Gamepad$DpadLeft,
																									_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 14)
																								},
																								_1: {
																									ctor: '::',
																									_0: {
																										ctor: '_Tuple2',
																										_0: _xarvh$elm_gamepad$Gamepad$DpadRight,
																										_1: A3(_xarvh$elm_gamepad$Gamepad$Origin, false, _xarvh$elm_gamepad$Gamepad$Button, 15)
																									},
																									_1: {ctor: '[]'}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				})
		},
		_1: {ctor: '[]'}
	});
var _xarvh$elm_gamepad$Gamepad$getGamepadButtonMap = F2(
	function (_p43, rawGamepad) {
		var _p44 = _p43;
		var _p45 = A2(_elm_lang$core$Dict$get, rawGamepad.id, _p44._0);
		if (_p45.ctor === 'Just') {
			return _elm_lang$core$Maybe$Just(_p45._0);
		} else {
			return A2(_elm_lang$core$Dict$get, rawGamepad.mapping, _xarvh$elm_gamepad$Gamepad$standardButtonMaps);
		}
	});
var _xarvh$elm_gamepad$Gamepad$getKnownAndUnknownGamepads = F2(
	function (database, blob) {
		var foldRawGamepad = F2(
			function (rawGamepad, _p46) {
				var _p47 = _p46;
				var _p50 = _p47._1;
				var _p49 = _p47._0;
				var _p48 = A2(_xarvh$elm_gamepad$Gamepad$getGamepadButtonMap, database, rawGamepad);
				if (_p48.ctor === 'Nothing') {
					return {
						ctor: '_Tuple2',
						_0: _p49,
						_1: {
							ctor: '::',
							_0: _xarvh$elm_gamepad$Gamepad$UnknownGamepad(rawGamepad),
							_1: _p50
						}
					};
				} else {
					return {
						ctor: '_Tuple2',
						_0: {
							ctor: '::',
							_0: A2(_xarvh$elm_gamepad$Gamepad$Gamepad, _p48._0, rawGamepad),
							_1: _p49
						},
						_1: _p50
					};
				}
			});
		return A3(
			_elm_lang$core$List$foldr,
			foldRawGamepad,
			{
				ctor: '_Tuple2',
				_0: {ctor: '[]'},
				_1: {ctor: '[]'}
			},
			_xarvh$elm_gamepad$Gamepad$getRawGamepads(blob));
	});
var _xarvh$elm_gamepad$Gamepad$getGamepads = F2(
	function (database, blob) {
		return _elm_lang$core$Tuple$first(
			A2(_xarvh$elm_gamepad$Gamepad$getKnownAndUnknownGamepads, database, blob));
	});
var _xarvh$elm_gamepad$Gamepad$getUnknownGamepads = F2(
	function (database, blob) {
		return _elm_lang$core$Tuple$second(
			A2(_xarvh$elm_gamepad$Gamepad$getKnownAndUnknownGamepads, database, blob));
	});
var _xarvh$elm_gamepad$Gamepad$aIsPressed = _xarvh$elm_gamepad$Gamepad$isPressed(_xarvh$elm_gamepad$Gamepad$A);

var _ianmackenzie$elm_interval$Interval$endpoints = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$elm_interval$Interval$minValue = function (interval) {
	return _elm_lang$core$Tuple$first(
		_ianmackenzie$elm_interval$Interval$endpoints(interval));
};
var _ianmackenzie$elm_interval$Interval$maxValue = function (interval) {
	return _elm_lang$core$Tuple$second(
		_ianmackenzie$elm_interval$Interval$endpoints(interval));
};
var _ianmackenzie$elm_interval$Interval$midpoint = function (interval) {
	var _p2 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
	var minValue = _p2._0;
	var maxValue = _p2._1;
	return minValue + (0.5 * (maxValue - minValue));
};
var _ianmackenzie$elm_interval$Interval$width = function (interval) {
	var _p3 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
	var minValue = _p3._0;
	var maxValue = _p3._1;
	return maxValue - minValue;
};
var _ianmackenzie$elm_interval$Interval$interpolate = F2(
	function (interval, t) {
		var _p4 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
		var minValue = _p4._0;
		var maxValue = _p4._1;
		return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, minValue, maxValue, t);
	});
var _ianmackenzie$elm_interval$Interval$contains = F2(
	function (value, interval) {
		var _p5 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
		var minValue = _p5._0;
		var maxValue = _p5._1;
		return (_elm_lang$core$Native_Utils.cmp(minValue, value) < 1) && (_elm_lang$core$Native_Utils.cmp(value, maxValue) < 1);
	});
var _ianmackenzie$elm_interval$Interval$intersects = F2(
	function (firstInterval, secondInterval) {
		var _p6 = _ianmackenzie$elm_interval$Interval$endpoints(secondInterval);
		var min2 = _p6._0;
		var max2 = _p6._1;
		var _p7 = _ianmackenzie$elm_interval$Interval$endpoints(firstInterval);
		var min1 = _p7._0;
		var max1 = _p7._1;
		return (_elm_lang$core$Native_Utils.cmp(min1, max2) < 1) && (_elm_lang$core$Native_Utils.cmp(max1, min2) > -1);
	});
var _ianmackenzie$elm_interval$Interval$isContainedIn = F2(
	function (firstInterval, secondInterval) {
		var _p8 = _ianmackenzie$elm_interval$Interval$endpoints(secondInterval);
		var min2 = _p8._0;
		var max2 = _p8._1;
		var _p9 = _ianmackenzie$elm_interval$Interval$endpoints(firstInterval);
		var min1 = _p9._0;
		var max1 = _p9._1;
		return (_elm_lang$core$Native_Utils.cmp(min1, min2) < 1) && (_elm_lang$core$Native_Utils.cmp(max2, max1) < 1);
	});
var _ianmackenzie$elm_interval$Interval$isSingleton = function (interval) {
	var _p10 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
	var minValue = _p10._0;
	var maxValue = _p10._1;
	return _elm_lang$core$Native_Utils.eq(minValue, maxValue);
};
var _ianmackenzie$elm_interval$Interval$cosIncludesMax = function (interval) {
	var _p11 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
	var minValue = _p11._0;
	var maxValue = _p11._1;
	var minBranch = _elm_lang$core$Basics$floor(minValue / (2 * _elm_lang$core$Basics$pi));
	var maxBranch = _elm_lang$core$Basics$floor(maxValue / (2 * _elm_lang$core$Basics$pi));
	return !_elm_lang$core$Native_Utils.eq(minBranch, maxBranch);
};
var _ianmackenzie$elm_interval$Interval$Interval = function (a) {
	return {ctor: 'Interval', _0: a};
};
var _ianmackenzie$elm_interval$Interval$singleton = function (value) {
	return _ianmackenzie$elm_interval$Interval$Interval(
		{ctor: '_Tuple2', _0: value, _1: value});
};
var _ianmackenzie$elm_interval$Interval$fromEndpoints = function (endpoints) {
	var _p12 = endpoints;
	var firstValue = _p12._0;
	var secondValue = _p12._1;
	return (_elm_lang$core$Native_Utils.cmp(firstValue, secondValue) < 1) ? _ianmackenzie$elm_interval$Interval$Interval(endpoints) : _ianmackenzie$elm_interval$Interval$Interval(
		{ctor: '_Tuple2', _0: secondValue, _1: firstValue});
};
var _ianmackenzie$elm_interval$Interval$from = F2(
	function (firstValue, secondValue) {
		return (_elm_lang$core$Native_Utils.cmp(firstValue, secondValue) < 1) ? _ianmackenzie$elm_interval$Interval$Interval(
			{ctor: '_Tuple2', _0: firstValue, _1: secondValue}) : _ianmackenzie$elm_interval$Interval$Interval(
			{ctor: '_Tuple2', _0: secondValue, _1: firstValue});
	});
var _ianmackenzie$elm_interval$Interval$containingValues = function (values) {
	return A3(
		_elm_lang$core$Maybe$map2,
		_ianmackenzie$elm_interval$Interval$from,
		_elm_lang$core$List$minimum(values),
		_elm_lang$core$List$maximum(values));
};
var _ianmackenzie$elm_interval$Interval$hull = F2(
	function (firstInterval, secondInterval) {
		var _p13 = _ianmackenzie$elm_interval$Interval$endpoints(secondInterval);
		var min2 = _p13._0;
		var max2 = _p13._1;
		var _p14 = _ianmackenzie$elm_interval$Interval$endpoints(firstInterval);
		var min1 = _p14._0;
		var max1 = _p14._1;
		return _ianmackenzie$elm_interval$Interval$Interval(
			{
				ctor: '_Tuple2',
				_0: A2(_elm_lang$core$Basics$min, min1, min2),
				_1: A2(_elm_lang$core$Basics$max, max1, max2)
			});
	});
var _ianmackenzie$elm_interval$Interval$aggregate = function (intervals) {
	var _p15 = intervals;
	if (_p15.ctor === '::') {
		return _elm_lang$core$Maybe$Just(
			A3(_elm_lang$core$List$foldl, _ianmackenzie$elm_interval$Interval$hull, _p15._0, _p15._1));
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _ianmackenzie$elm_interval$Interval$intersection = F2(
	function (firstInterval, secondInterval) {
		var _p16 = _ianmackenzie$elm_interval$Interval$endpoints(secondInterval);
		var min2 = _p16._0;
		var max2 = _p16._1;
		var _p17 = _ianmackenzie$elm_interval$Interval$endpoints(firstInterval);
		var min1 = _p17._0;
		var max1 = _p17._1;
		var minValue = A2(_elm_lang$core$Basics$max, min1, min2);
		var maxValue = A2(_elm_lang$core$Basics$min, max1, max2);
		return (_elm_lang$core$Native_Utils.cmp(minValue, maxValue) < 1) ? _elm_lang$core$Maybe$Just(
			_ianmackenzie$elm_interval$Interval$Interval(
				{ctor: '_Tuple2', _0: minValue, _1: maxValue})) : _elm_lang$core$Maybe$Nothing;
	});
var _ianmackenzie$elm_interval$Interval$shiftBy = F2(
	function (delta, interval) {
		var _p18 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
		var minValue = _p18._0;
		var maxValue = _p18._1;
		return _ianmackenzie$elm_interval$Interval$Interval(
			{ctor: '_Tuple2', _0: minValue + delta, _1: maxValue + delta});
	});
var _ianmackenzie$elm_interval$Interval$cosIncludesMinMax = function (interval) {
	return {
		ctor: '_Tuple2',
		_0: _ianmackenzie$elm_interval$Interval$cosIncludesMax(
			A2(_ianmackenzie$elm_interval$Interval$shiftBy, _elm_lang$core$Basics$pi, interval)),
		_1: _ianmackenzie$elm_interval$Interval$cosIncludesMax(interval)
	};
};
var _ianmackenzie$elm_interval$Interval$cos = function (interval) {
	if (_ianmackenzie$elm_interval$Interval$isSingleton(interval)) {
		return _ianmackenzie$elm_interval$Interval$singleton(
			_elm_lang$core$Basics$cos(
				_ianmackenzie$elm_interval$Interval$minValue(interval)));
	} else {
		var _p19 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
		var minValue = _p19._0;
		var maxValue = _p19._1;
		var _p20 = _ianmackenzie$elm_interval$Interval$cosIncludesMinMax(interval);
		var includesMin = _p20._0;
		var includesMax = _p20._1;
		var newMin = includesMin ? -1 : A2(
			_elm_lang$core$Basics$min,
			_elm_lang$core$Basics$cos(minValue),
			_elm_lang$core$Basics$cos(maxValue));
		var newMax = includesMax ? 1 : A2(
			_elm_lang$core$Basics$max,
			_elm_lang$core$Basics$cos(minValue),
			_elm_lang$core$Basics$cos(maxValue));
		return _ianmackenzie$elm_interval$Interval$fromEndpoints(
			{ctor: '_Tuple2', _0: newMin, _1: newMax});
	}
};
var _ianmackenzie$elm_interval$Interval$sinIncludesMinMax = function (interval) {
	return _ianmackenzie$elm_interval$Interval$cosIncludesMinMax(
		A2(_ianmackenzie$elm_interval$Interval$shiftBy, (0 - _elm_lang$core$Basics$pi) / 2, interval));
};
var _ianmackenzie$elm_interval$Interval$sin = function (interval) {
	if (_ianmackenzie$elm_interval$Interval$isSingleton(interval)) {
		return _ianmackenzie$elm_interval$Interval$singleton(
			_elm_lang$core$Basics$sin(
				_ianmackenzie$elm_interval$Interval$minValue(interval)));
	} else {
		var _p21 = _ianmackenzie$elm_interval$Interval$endpoints(interval);
		var minValue = _p21._0;
		var maxValue = _p21._1;
		var _p22 = _ianmackenzie$elm_interval$Interval$sinIncludesMinMax(interval);
		var includesMin = _p22._0;
		var includesMax = _p22._1;
		var newMin = includesMin ? -1 : A2(
			_elm_lang$core$Basics$min,
			_elm_lang$core$Basics$sin(minValue),
			_elm_lang$core$Basics$sin(maxValue));
		var newMax = includesMax ? 1 : A2(
			_elm_lang$core$Basics$max,
			_elm_lang$core$Basics$sin(minValue),
			_elm_lang$core$Basics$sin(maxValue));
		return _ianmackenzie$elm_interval$Interval$fromEndpoints(
			{ctor: '_Tuple2', _0: newMin, _1: newMax});
	}
};

var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$paramAtStart = function (tree) {
	var _p0 = tree;
	if (_p0.ctor === 'Node') {
		return _p0._0.paramAtStart;
	} else {
		return _p0._0.param0;
	}
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$unsafeToArcLength = F2(
	function (tree, t) {
		unsafeToArcLength:
		while (true) {
			var _p1 = tree;
			if (_p1.ctor === 'Leaf') {
				var _p16 = _p1._0.param7;
				var _p15 = _p1._0.param6;
				var _p14 = _p1._0.param5;
				var _p13 = _p1._0.param4;
				var _p12 = _p1._0.param3;
				var _p11 = _p1._0.param2;
				var _p10 = _p1._0.param1;
				var _p9 = _p1._0.param0;
				var _p8 = _p1._0.length7;
				var _p7 = _p1._0.length6;
				var _p6 = _p1._0.length5;
				var _p5 = _p1._0.length4;
				var _p4 = _p1._0.length3;
				var _p3 = _p1._0.length2;
				var _p2 = _p1._0.length1;
				if (_elm_lang$core$Native_Utils.cmp(t, _p13) < 1) {
					if (_elm_lang$core$Native_Utils.cmp(t, _p11) < 1) {
						if (_elm_lang$core$Native_Utils.cmp(t, _p10) < 1) {
							var paramFraction = (t - _p9) / (_p10 - _p9);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p1._0.length0, _p2, paramFraction);
						} else {
							var paramFraction = (t - _p10) / (_p11 - _p10);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p2, _p3, paramFraction);
						}
					} else {
						if (_elm_lang$core$Native_Utils.cmp(t, _p12) < 1) {
							var paramFraction = (t - _p11) / (_p12 - _p11);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p3, _p4, paramFraction);
						} else {
							var paramFraction = (t - _p12) / (_p13 - _p12);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p4, _p5, paramFraction);
						}
					}
				} else {
					if (_elm_lang$core$Native_Utils.cmp(t, _p15) < 1) {
						if (_elm_lang$core$Native_Utils.cmp(t, _p14) < 1) {
							var paramFraction = (t - _p13) / (_p14 - _p13);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p5, _p6, paramFraction);
						} else {
							var paramFraction = (t - _p14) / (_p15 - _p14);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p6, _p7, paramFraction);
						}
					} else {
						if (_elm_lang$core$Native_Utils.cmp(t, _p16) < 1) {
							var paramFraction = (t - _p15) / (_p16 - _p15);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p7, _p8, paramFraction);
						} else {
							var paramFraction = (t - _p16) / (_p1._0.param8 - _p16);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p8, _p1._0.length8, paramFraction);
						}
					}
				}
			} else {
				var _p17 = _p1._0.rightBranch;
				if (_elm_lang$core$Native_Utils.cmp(
					t,
					_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$paramAtStart(_p17)) < 0) {
					var _v2 = _p1._0.leftBranch,
						_v3 = t;
					tree = _v2;
					t = _v3;
					continue unsafeToArcLength;
				} else {
					var _v4 = _p17,
						_v5 = t;
					tree = _v4;
					t = _v5;
					continue unsafeToArcLength;
				}
			}
		}
	});
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$parameterValueToArcLength = F2(
	function (t, _p18) {
		var _p19 = _p18;
		return _elm_lang$core$Native_Utils.eq(t, 0) ? _elm_lang$core$Maybe$Just(0) : (((_elm_lang$core$Native_Utils.cmp(t, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) ? _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$unsafeToArcLength, _p19._0, t)) : _elm_lang$core$Maybe$Nothing);
	});
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtEnd = function (tree) {
	var _p20 = tree;
	if (_p20.ctor === 'Node') {
		return _p20._0.lengthAtEnd;
	} else {
		return _p20._0.length8;
	}
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$totalArcLength = function (_p21) {
	var _p22 = _p21;
	return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtEnd(_p22._0);
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtStart = function (tree) {
	var _p23 = tree;
	if (_p23.ctor === 'Node') {
		return _p23._0.lengthAtStart;
	} else {
		return _p23._0.length0;
	}
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$unsafeToParameterValue = F2(
	function (tree, s) {
		unsafeToParameterValue:
		while (true) {
			var _p24 = tree;
			if (_p24.ctor === 'Leaf') {
				var _p39 = _p24._0.param7;
				var _p38 = _p24._0.param6;
				var _p37 = _p24._0.param5;
				var _p36 = _p24._0.param4;
				var _p35 = _p24._0.param3;
				var _p34 = _p24._0.param2;
				var _p33 = _p24._0.param1;
				var _p32 = _p24._0.length7;
				var _p31 = _p24._0.length6;
				var _p30 = _p24._0.length5;
				var _p29 = _p24._0.length4;
				var _p28 = _p24._0.length3;
				var _p27 = _p24._0.length2;
				var _p26 = _p24._0.length1;
				var _p25 = _p24._0.length0;
				if (_elm_lang$core$Native_Utils.cmp(s, _p29) < 1) {
					if (_elm_lang$core$Native_Utils.cmp(s, _p27) < 1) {
						if (_elm_lang$core$Native_Utils.cmp(s, _p26) < 1) {
							var lengthFraction = (s - _p25) / (_p26 - _p25);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p24._0.param0, _p33, lengthFraction);
						} else {
							var lengthFraction = (s - _p26) / (_p27 - _p26);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p33, _p34, lengthFraction);
						}
					} else {
						if (_elm_lang$core$Native_Utils.cmp(s, _p28) < 1) {
							var lengthFraction = (s - _p27) / (_p28 - _p27);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p34, _p35, lengthFraction);
						} else {
							var lengthFraction = (s - _p28) / (_p29 - _p28);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p35, _p36, lengthFraction);
						}
					}
				} else {
					if (_elm_lang$core$Native_Utils.cmp(s, _p31) < 1) {
						if (_elm_lang$core$Native_Utils.cmp(s, _p30) < 1) {
							var lengthFraction = (s - _p29) / (_p30 - _p29);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p36, _p37, lengthFraction);
						} else {
							var lengthFraction = (s - _p30) / (_p31 - _p30);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p37, _p38, lengthFraction);
						}
					} else {
						if (_elm_lang$core$Native_Utils.cmp(s, _p32) < 1) {
							var lengthFraction = (s - _p31) / (_p32 - _p31);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p38, _p39, lengthFraction);
						} else {
							var lengthFraction = (s - _p32) / (_p24._0.length8 - _p32);
							return A3(_ianmackenzie$elm_float_extra$Float_Extra$interpolateFrom, _p39, _p24._0.param8, lengthFraction);
						}
					}
				}
			} else {
				var _p40 = _p24._0.rightBranch;
				if (_elm_lang$core$Native_Utils.cmp(
					s,
					_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtStart(_p40)) < 0) {
					var _v11 = _p24._0.leftBranch,
						_v12 = s;
					tree = _v11;
					s = _v12;
					continue unsafeToParameterValue;
				} else {
					var _v13 = _p40,
						_v14 = s;
					tree = _v13;
					s = _v14;
					continue unsafeToParameterValue;
				}
			}
		}
	});
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue = F2(
	function (s, _p41) {
		var _p42 = _p41;
		var _p43 = _p42._0;
		return _elm_lang$core$Native_Utils.eq(s, 0) ? _elm_lang$core$Maybe$Just(0) : (((_elm_lang$core$Native_Utils.cmp(s, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(
			s,
			_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtEnd(_p43)) < 1)) ? _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$unsafeToParameterValue, _p43, s)) : _elm_lang$core$Maybe$Nothing);
	});
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$segmentsPerLeaf = 8;
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$ArcLengthParameterization = function (a) {
	return {ctor: 'ArcLengthParameterization', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$Leaf = function (a) {
	return {ctor: 'Leaf', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$Node = function (a) {
	return {ctor: 'Node', _0: a};
};
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$buildTree = F5(
	function (derivativeMagnitude, lengthAtStart_, paramAtStart_, paramAtEnd, height) {
		var paramDelta = paramAtEnd - paramAtStart_;
		if (_elm_lang$core$Native_Utils.eq(height, 0)) {
			var length0 = lengthAtStart_;
			var paramStep = 0.125 * paramDelta;
			var offset = 6.25e-2 * paramDelta;
			var param8 = paramAtEnd;
			var param7 = paramAtEnd - (0.125 * paramDelta);
			var param6 = paramAtEnd - (0.25 * paramDelta);
			var param5 = paramAtEnd - (0.375 * paramDelta);
			var param4 = paramAtStart_ + (0.5 * paramDelta);
			var param3 = paramAtStart_ + (0.375 * paramDelta);
			var param2 = paramAtStart_ + (0.25 * paramDelta);
			var param1 = paramAtStart_ + (0.125 * paramDelta);
			var param0 = paramAtStart_;
			var length1 = length0 + (derivativeMagnitude(param0 + offset) * paramStep);
			var length2 = length1 + (derivativeMagnitude(param1 + offset) * paramStep);
			var length3 = length2 + (derivativeMagnitude(param2 + offset) * paramStep);
			var length4 = length3 + (derivativeMagnitude(param3 + offset) * paramStep);
			var length5 = length4 + (derivativeMagnitude(param4 + offset) * paramStep);
			var length6 = length5 + (derivativeMagnitude(param5 + offset) * paramStep);
			var length7 = length6 + (derivativeMagnitude(param6 + offset) * paramStep);
			var length8 = length7 + (derivativeMagnitude(param7 + offset) * paramStep);
			return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$Leaf(
				{param0: param0, param1: param1, param2: param2, param3: param3, param4: param4, param5: param5, param6: param6, param7: param7, param8: param8, length0: length0, length1: length1, length2: length2, length3: length3, length4: length4, length5: length5, length6: length6, length7: length7, length8: length8});
		} else {
			var paramAtMid = paramAtStart_ + (0.5 * paramDelta);
			var branchHeight = height - 1;
			var leftBranch = A5(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$buildTree, derivativeMagnitude, lengthAtStart_, paramAtStart_, paramAtMid, branchHeight);
			var lengthAtLeftEnd = _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtEnd(leftBranch);
			var rightBranch = A5(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$buildTree, derivativeMagnitude, lengthAtLeftEnd, paramAtMid, paramAtEnd, branchHeight);
			return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$Node(
				{
					lengthAtStart: lengthAtStart_,
					lengthAtEnd: _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$lengthAtEnd(rightBranch),
					paramAtStart: paramAtStart_,
					leftBranch: leftBranch,
					rightBranch: rightBranch
				});
		}
	});
var _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$build = function (_p44) {
	var _p45 = _p44;
	var _p46 = _p45.tolerance;
	var height = function () {
		if (_elm_lang$core$Native_Utils.cmp(_p46, 0) < 1) {
			return 0;
		} else {
			var numSegments = _p45.maxSecondDerivativeMagnitude / (8 * _p46);
			var numLeaves = numSegments / _elm_lang$core$Basics$toFloat(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$segmentsPerLeaf);
			return A2(
				_elm_lang$core$Basics$max,
				0,
				_elm_lang$core$Basics$ceiling(
					A2(_elm_lang$core$Basics$logBase, 2, numLeaves)));
		}
	}();
	return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$ArcLengthParameterization(
		A5(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$buildTree, _p45.derivativeMagnitude, 0, 0, 1, height));
};

var _ianmackenzie$acorn_demo$QuadraticSpline2d$underlyingSpline = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$parameterValueToArcLength = F2(
	function (_p2, t) {
		var _p3 = _p2;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$parameterValueToArcLength, t, _p3._1);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$arcLengthToParameterValue = F2(
	function (_p4, s) {
		var _p5 = _p4;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p5._1);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$arcLength = function (_p6) {
	var _p7 = _p6;
	return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$totalArcLength(_p7._1);
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint = function (_p8) {
	var _p9 = _p8;
	return _p9._0.controlPoint;
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint = function (_p10) {
	var _p11 = _p10;
	return _p11._0.endPoint;
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$endDerivative = function (spline) {
	return A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		2,
		A2(
			_ianmackenzie$acorn_demo$Vector2d$from,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline),
			_ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline)));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint = function (_p12) {
	var _p13 = _p12;
	return _p13._0.startPoint;
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$startDerivative = function (spline) {
	return A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		2,
		A2(
			_ianmackenzie$acorn_demo$Vector2d$from,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline),
			_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline)));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$boundingBox = function (spline) {
	var _p14 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline));
	var x3 = _p14._0;
	var y3 = _p14._1;
	var _p15 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline));
	var x2 = _p15._0;
	var y2 = _p15._1;
	var _p16 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline));
	var x1 = _p16._0;
	var y1 = _p16._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{
			minX: A2(
				_elm_lang$core$Basics$min,
				x1,
				A2(_elm_lang$core$Basics$min, x2, x3)),
			maxX: A2(
				_elm_lang$core$Basics$max,
				x1,
				A2(_elm_lang$core$Basics$max, x2, x3)),
			minY: A2(
				_elm_lang$core$Basics$min,
				y1,
				A2(_elm_lang$core$Basics$min, y2, y3)),
			maxY: A2(
				_elm_lang$core$Basics$max,
				y1,
				A2(_elm_lang$core$Basics$max, y2, y3))
		});
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$pointOn = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p3 = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline);
			var p2 = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline);
			var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
			var p1 = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline);
			var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
			return _elm_lang$core$Maybe$Just(
				A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$pointsOn = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$pointOn(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$pointAlong = F2(
	function (_p17, s) {
		var _p18 = _p17;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$pointOn(_p18._0),
			A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p18._1));
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$derivative = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p3 = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline);
			var p2 = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline);
			var v2 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p2, p3);
			var p1 = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline);
			var v1 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
			return _elm_lang$core$Maybe$Just(
				A2(
					_ianmackenzie$acorn_demo$Vector2d$scaleBy,
					2,
					A3(_ianmackenzie$acorn_demo$Vector2d$interpolateFrom, v1, v2, t)));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$derivatives = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$derivative(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$tangentAlong = F2(
	function (_p19, s) {
		var _p20 = _p19;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$Vector2d$direction,
			A2(
				_elm_lang$core$Maybe$andThen,
				_ianmackenzie$acorn_demo$QuadraticSpline2d$derivative(_p20._0),
				A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p20._1)));
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$derivativeMagnitude = function (spline) {
	var _p21 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline));
	var x3 = _p21._0;
	var y3 = _p21._1;
	var _p22 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline));
	var x2 = _p22._0;
	var y2 = _p22._1;
	var x23 = x3 - x2;
	var y23 = y3 - y2;
	var _p23 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline));
	var x1 = _p23._0;
	var y1 = _p23._1;
	var x12 = x2 - x1;
	var x123 = x23 - x12;
	var y12 = y2 - y1;
	var y123 = y23 - y12;
	return function (t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var y13 = y12 + (t * y123);
			var x13 = x12 + (t * x123);
			return 2 * _elm_lang$core$Basics$sqrt((x13 * x13) + (y13 * y13));
		} else {
			return 0;
		}
	};
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$sample = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p3 = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline);
			var p2 = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline);
			var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
			var p1 = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline);
			var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
			return _elm_lang$core$Maybe$Just(
				{
					ctor: '_Tuple2',
					_0: A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t),
					_1: A2(
						_ianmackenzie$acorn_demo$Vector2d$scaleBy,
						2,
						A2(_ianmackenzie$acorn_demo$Vector2d$from, q1, q2))
				});
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$samples = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$QuadraticSpline2d$sample(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$secondDerivative = function (spline) {
	var p3 = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline);
	var p2 = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline);
	var v2 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p2, p3);
	var p1 = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline);
	var v1 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
	return A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		2,
		A2(_ianmackenzie$acorn_demo$Vector2d$difference, v2, v1));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$with = _ianmackenzie$acorn_demo$Geometry_Types$QuadraticSpline2d;
var _ianmackenzie$acorn_demo$QuadraticSpline2d$reverse = function (spline) {
	return _ianmackenzie$acorn_demo$QuadraticSpline2d$with(
		{
			startPoint: _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline),
			controlPoint: _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline),
			endPoint: _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline)
		});
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints = F2(
	function ($function, spline) {
		return _ianmackenzie$acorn_demo$QuadraticSpline2d$with(
			{
				startPoint: $function(
					_ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline)),
				controlPoint: $function(
					_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline)),
				endPoint: $function(
					_ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline))
			});
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$rotateAround = F2(
	function (point, angle) {
		return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle));
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$translateBy = function (displacement) {
	return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$translateBy(displacement));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$translateIn = F3(
	function (direction, distance, spline) {
		return A2(
			_ianmackenzie$acorn_demo$QuadraticSpline2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			spline);
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$QuadraticSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame));
};
var _ianmackenzie$acorn_demo$QuadraticSpline2d$splitAt = F2(
	function (t, spline) {
		var p3 = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline);
		var p2 = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline);
		var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
		var p1 = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline);
		var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
		var r = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t);
		return {
			ctor: '_Tuple2',
			_0: _ianmackenzie$acorn_demo$QuadraticSpline2d$with(
				{startPoint: p1, controlPoint: q1, endPoint: r}),
			_1: _ianmackenzie$acorn_demo$QuadraticSpline2d$with(
				{startPoint: r, controlPoint: q2, endPoint: p3})
		};
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$bisect = _ianmackenzie$acorn_demo$QuadraticSpline2d$splitAt(0.5);
var _ianmackenzie$acorn_demo$QuadraticSpline2d$ArcLengthParameterized = F2(
	function (a, b) {
		return {ctor: 'ArcLengthParameterized', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$QuadraticSpline2d$arcLengthParameterized = F2(
	function (_p24, spline) {
		var _p25 = _p24;
		var maxSecondDerivativeMagnitude = _ianmackenzie$acorn_demo$Vector2d$length(
			_ianmackenzie$acorn_demo$QuadraticSpline2d$secondDerivative(spline));
		var parameterization = _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$build(
			{
				tolerance: _p25._0,
				derivativeMagnitude: _ianmackenzie$acorn_demo$QuadraticSpline2d$derivativeMagnitude(spline),
				maxSecondDerivativeMagnitude: maxSecondDerivativeMagnitude
			});
		return A2(_ianmackenzie$acorn_demo$QuadraticSpline2d$ArcLengthParameterized, spline, parameterization);
	});

var _ianmackenzie$acorn_demo$CubicSpline2d$underlyingSpline = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$CubicSpline2d$parameterValueToArcLength = F2(
	function (_p2, t) {
		var _p3 = _p2;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$parameterValueToArcLength, t, _p3._1);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$arcLengthToParameterValue = F2(
	function (_p4, s) {
		var _p5 = _p4;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p5._1);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$arcLength = function (_p6) {
	var _p7 = _p6;
	return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$totalArcLength(_p7._1);
};
var _ianmackenzie$acorn_demo$CubicSpline2d$endPoint = function (_p8) {
	var _p9 = _p8;
	return _p9._0.endPoint;
};
var _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint = function (_p10) {
	var _p11 = _p10;
	return _p11._0.endControlPoint;
};
var _ianmackenzie$acorn_demo$CubicSpline2d$endDerivative = function (spline) {
	return A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		3,
		A2(
			_ianmackenzie$acorn_demo$Vector2d$from,
			_ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline),
			_ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline)));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint = function (_p12) {
	var _p13 = _p12;
	return _p13._0.startControlPoint;
};
var _ianmackenzie$acorn_demo$CubicSpline2d$startPoint = function (_p14) {
	var _p15 = _p14;
	return _p15._0.startPoint;
};
var _ianmackenzie$acorn_demo$CubicSpline2d$startDerivative = function (spline) {
	return A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		3,
		A2(
			_ianmackenzie$acorn_demo$Vector2d$from,
			_ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline),
			_ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline)));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$boundingBox = function (spline) {
	var _p16 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline));
	var x4 = _p16._0;
	var y4 = _p16._1;
	var _p17 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline));
	var x3 = _p17._0;
	var y3 = _p17._1;
	var _p18 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline));
	var x2 = _p18._0;
	var y2 = _p18._1;
	var _p19 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline));
	var x1 = _p19._0;
	var y1 = _p19._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{
			minX: A2(
				_elm_lang$core$Basics$min,
				A2(_elm_lang$core$Basics$min, x1, x2),
				A2(_elm_lang$core$Basics$min, x3, x4)),
			maxX: A2(
				_elm_lang$core$Basics$max,
				A2(_elm_lang$core$Basics$max, x1, x2),
				A2(_elm_lang$core$Basics$max, x3, x4)),
			minY: A2(
				_elm_lang$core$Basics$min,
				A2(_elm_lang$core$Basics$min, y1, y2),
				A2(_elm_lang$core$Basics$min, y3, y4)),
			maxY: A2(
				_elm_lang$core$Basics$max,
				A2(_elm_lang$core$Basics$max, y1, y2),
				A2(_elm_lang$core$Basics$max, y3, y4))
		});
};
var _ianmackenzie$acorn_demo$CubicSpline2d$pointOn = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
			var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
			var q3 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p3, p4, t);
			var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
			var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
			var r2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q2, q3, t);
			var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
			var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
			var r1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t);
			return _elm_lang$core$Maybe$Just(
				A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, r1, r2, t));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$pointsOn = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$CubicSpline2d$pointOn(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$pointAlong = F2(
	function (_p20, s) {
		var _p21 = _p20;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$CubicSpline2d$pointOn(_p21._0),
			A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p21._1));
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$derivative = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
			var _p22 = _ianmackenzie$acorn_demo$Point2d$coordinates(p4);
			var x4 = _p22._0;
			var y4 = _p22._1;
			var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
			var _p23 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
			var x3 = _p23._0;
			var y3 = _p23._1;
			var vx3 = x4 - x3;
			var vy3 = y4 - y3;
			var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
			var _p24 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
			var x2 = _p24._0;
			var y2 = _p24._1;
			var vx2 = x3 - x2;
			var vy2 = y3 - y2;
			var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
			var _p25 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
			var x1 = _p25._0;
			var y1 = _p25._1;
			var vx1 = x2 - x1;
			var vy1 = y2 - y1;
			if (_elm_lang$core$Native_Utils.cmp(t, 0.5) < 1) {
				var wy2 = vy2 + (t * (vy3 - vy2));
				var wx2 = vx2 + (t * (vx3 - vx2));
				var wy1 = vy1 + (t * (vy2 - vy1));
				var wx1 = vx1 + (t * (vx2 - vx1));
				return _elm_lang$core$Maybe$Just(
					_ianmackenzie$acorn_demo$Vector2d$fromComponents(
						{ctor: '_Tuple2', _0: 3 * (wx1 + (t * (wx2 - wx1))), _1: 3 * (wy1 + (t * (wy2 - wy1)))}));
			} else {
				var u = 1 - t;
				var wx1 = vx2 + (u * (vx1 - vx2));
				var wy1 = vy2 + (u * (vy1 - vy2));
				var wx2 = vx3 + (u * (vx2 - vx3));
				var wy2 = vy3 + (u * (vy2 - vy3));
				return _elm_lang$core$Maybe$Just(
					_ianmackenzie$acorn_demo$Vector2d$fromComponents(
						{ctor: '_Tuple2', _0: 3 * (wx2 + (u * (wx1 - wx2))), _1: 3 * (wy2 + (u * (wy1 - wy2)))}));
			}
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$derivatives = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$CubicSpline2d$derivative(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$tangentAlong = F2(
	function (_p26, s) {
		var _p27 = _p26;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$Vector2d$direction,
			A2(
				_elm_lang$core$Maybe$andThen,
				_ianmackenzie$acorn_demo$CubicSpline2d$derivative(_p27._0),
				A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p27._1)));
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$derivativeMagnitude = function (spline) {
	var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
	var _p28 = _ianmackenzie$acorn_demo$Point2d$coordinates(p4);
	var x4 = _p28._0;
	var y4 = _p28._1;
	var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
	var _p29 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
	var x3 = _p29._0;
	var y3 = _p29._1;
	var x34 = x4 - x3;
	var y34 = y4 - y3;
	var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
	var _p30 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
	var x2 = _p30._0;
	var y2 = _p30._1;
	var x23 = x3 - x2;
	var x234 = x34 - x23;
	var y23 = y3 - y2;
	var y234 = y34 - y23;
	var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
	var _p31 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
	var x1 = _p31._0;
	var y1 = _p31._1;
	var x12 = x2 - x1;
	var x123 = x23 - x12;
	var y12 = y2 - y1;
	var y123 = y23 - y12;
	return function (t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var y24 = y23 + (t * y234);
			var x24 = x23 + (t * x234);
			var y13 = y12 + (t * y123);
			var y14 = y13 + (t * (y24 - y13));
			var x13 = x12 + (t * x123);
			var x14 = x13 + (t * (x24 - x13));
			return 3 * _elm_lang$core$Basics$sqrt((x14 * x14) + (y14 * y14));
		} else {
			return 0;
		}
	};
};
var _ianmackenzie$acorn_demo$CubicSpline2d$sample = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
			var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
			var q3 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p3, p4, t);
			var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
			var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
			var r2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q2, q3, t);
			var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
			var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
			var r1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t);
			return _elm_lang$core$Maybe$Just(
				{
					ctor: '_Tuple2',
					_0: A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, r1, r2, t),
					_1: A2(
						_ianmackenzie$acorn_demo$Vector2d$scaleBy,
						3,
						A2(_ianmackenzie$acorn_demo$Vector2d$from, r1, r2))
				});
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$samples = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$CubicSpline2d$sample(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$maxSecondDerivativeMagnitude = function (spline) {
	var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
	var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
	var u3 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p3, p4);
	var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
	var u2 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p2, p3);
	var v2 = A2(_ianmackenzie$acorn_demo$Vector2d$difference, u3, u2);
	var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
	var u1 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
	var v1 = A2(_ianmackenzie$acorn_demo$Vector2d$difference, u2, u1);
	return 6 * A2(
		_elm_lang$core$Basics$max,
		_ianmackenzie$acorn_demo$Vector2d$length(v1),
		_ianmackenzie$acorn_demo$Vector2d$length(v2));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$secondDerivative = F2(
	function (spline, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
			var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
			var u3 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p3, p4);
			var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
			var u2 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p2, p3);
			var v2 = A2(_ianmackenzie$acorn_demo$Vector2d$difference, u3, u2);
			var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
			var u1 = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
			var v1 = A2(_ianmackenzie$acorn_demo$Vector2d$difference, u2, u1);
			return _elm_lang$core$Maybe$Just(
				A2(
					_ianmackenzie$acorn_demo$Vector2d$scaleBy,
					6,
					A3(_ianmackenzie$acorn_demo$Vector2d$interpolateFrom, v1, v2, t)));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$secondDerivatives = F2(
	function (spline, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$CubicSpline2d$secondDerivative(spline),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$with = _ianmackenzie$acorn_demo$Geometry_Types$CubicSpline2d;
var _ianmackenzie$acorn_demo$CubicSpline2d$fromEndpoints = function ($arguments) {
	var endControlPoint_ = A2(
		_ianmackenzie$acorn_demo$Point2d$translateBy,
		A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, -1 / 3, $arguments.endDerivative),
		$arguments.endPoint);
	var startControlPoint_ = A2(
		_ianmackenzie$acorn_demo$Point2d$translateBy,
		A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, 1 / 3, $arguments.startDerivative),
		$arguments.startPoint);
	return _ianmackenzie$acorn_demo$CubicSpline2d$with(
		{startPoint: $arguments.startPoint, startControlPoint: startControlPoint_, endControlPoint: endControlPoint_, endPoint: $arguments.endPoint});
};
var _ianmackenzie$acorn_demo$CubicSpline2d$fromQuadraticSpline = function (quadraticSpline) {
	var endPoint_ = _ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(quadraticSpline);
	var controlPoint_ = _ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(quadraticSpline);
	var endControlPoint_ = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, endPoint_, controlPoint_, 2 / 3);
	var startPoint_ = _ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(quadraticSpline);
	var startControlPoint_ = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, startPoint_, controlPoint_, 2 / 3);
	return _ianmackenzie$acorn_demo$CubicSpline2d$with(
		{startPoint: startPoint_, startControlPoint: startControlPoint_, endControlPoint: endControlPoint_, endPoint: endPoint_});
};
var _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints = F2(
	function ($function, spline) {
		return _ianmackenzie$acorn_demo$CubicSpline2d$with(
			{
				startPoint: $function(
					_ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline)),
				startControlPoint: $function(
					_ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline)),
				endControlPoint: $function(
					_ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline)),
				endPoint: $function(
					_ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline))
			});
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$rotateAround = F2(
	function (point, angle) {
		return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle));
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$translateBy = function (displacement) {
	return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$translateBy(displacement));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$translateIn = F3(
	function (direction, distance, spline) {
		return A2(
			_ianmackenzie$acorn_demo$CubicSpline2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			spline);
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$CubicSpline2d$mapControlPoints(
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame));
};
var _ianmackenzie$acorn_demo$CubicSpline2d$reverse = function (spline) {
	return _ianmackenzie$acorn_demo$CubicSpline2d$with(
		{
			startPoint: _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline),
			startControlPoint: _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline),
			endControlPoint: _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline),
			endPoint: _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline)
		});
};
var _ianmackenzie$acorn_demo$CubicSpline2d$splitAt = F2(
	function (t, spline) {
		var p4 = _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline);
		var p3 = _ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline);
		var q3 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p3, p4, t);
		var p2 = _ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline);
		var q2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p2, p3, t);
		var r2 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q2, q3, t);
		var p1 = _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline);
		var q1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, p1, p2, t);
		var r1 = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, q1, q2, t);
		var s = A3(_ianmackenzie$acorn_demo$Point2d$interpolateFrom, r1, r2, t);
		return {
			ctor: '_Tuple2',
			_0: _ianmackenzie$acorn_demo$CubicSpline2d$with(
				{startPoint: p1, startControlPoint: q1, endControlPoint: r1, endPoint: s}),
			_1: _ianmackenzie$acorn_demo$CubicSpline2d$with(
				{startPoint: s, startControlPoint: r2, endControlPoint: q3, endPoint: p4})
		};
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$bisect = _ianmackenzie$acorn_demo$CubicSpline2d$splitAt(0.5);
var _ianmackenzie$acorn_demo$CubicSpline2d$ArcLengthParameterized = F2(
	function (a, b) {
		return {ctor: 'ArcLengthParameterized', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$CubicSpline2d$arcLengthParameterized = F2(
	function (_p32, spline) {
		var _p33 = _p32;
		var parameterization = _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$build(
			{
				tolerance: _p33._0,
				derivativeMagnitude: _ianmackenzie$acorn_demo$CubicSpline2d$derivativeMagnitude(spline),
				maxSecondDerivativeMagnitude: _ianmackenzie$acorn_demo$CubicSpline2d$maxSecondDerivativeMagnitude(spline)
			});
		return A2(_ianmackenzie$acorn_demo$CubicSpline2d$ArcLengthParameterized, spline, parameterization);
	});

var _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Outside = {ctor: 'Outside'};
var _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Inside = {ctor: 'Inside'};
var _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Centered = {ctor: 'Centered'};

var _ianmackenzie$acorn_demo$Drawing2d_Border$outside = _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Outside;
var _ianmackenzie$acorn_demo$Drawing2d_Border$inside = _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Inside;
var _ianmackenzie$acorn_demo$Drawing2d_Border$centered = _ianmackenzie$acorn_demo$Drawing2d_BorderPosition$Centered;

var _ianmackenzie$acorn_demo$Drawing2d_Color$strings = function (color) {
	var _p0 = _elm_lang$core$Color$toRgb(color);
	var red = _p0.red;
	var green = _p0.green;
	var blue = _p0.blue;
	var alpha = _p0.alpha;
	var rgbString = A2(
		_elm_lang$core$Basics_ops['++'],
		'rgb(',
		A2(
			_elm_lang$core$Basics_ops['++'],
			_elm_lang$core$Basics$toString(red),
			A2(
				_elm_lang$core$Basics_ops['++'],
				',',
				A2(
					_elm_lang$core$Basics_ops['++'],
					_elm_lang$core$Basics$toString(green),
					A2(
						_elm_lang$core$Basics_ops['++'],
						',',
						A2(
							_elm_lang$core$Basics_ops['++'],
							_elm_lang$core$Basics$toString(blue),
							')'))))));
	return {
		ctor: '_Tuple2',
		_0: rgbString,
		_1: _elm_lang$core$Basics$toString(alpha)
	};
};

var _ianmackenzie$acorn_demo$Drawing2d_Context$init = function (renderBounds) {
	var _p0 = _ianmackenzie$acorn_demo$BoundingBox2d$extrema(renderBounds);
	var minX = _p0.minX;
	var maxY = _p0.maxY;
	var topLeftFrame = _ianmackenzie$acorn_demo$Frame2d$flipY(
		_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
			{ctor: '_Tuple2', _0: minX, _1: maxY}));
	return {
		dotRadius: 0,
		bordersEnabled: false,
		borderPosition: _ianmackenzie$acorn_demo$Drawing2d_Border$centered,
		placementFrame: A2(_ianmackenzie$acorn_demo$Frame2d$relativeTo, topLeftFrame, _ianmackenzie$acorn_demo$Frame2d$xy)
	};
};
var _ianmackenzie$acorn_demo$Drawing2d_Context$Context = F4(
	function (a, b, c, d) {
		return {dotRadius: a, bordersEnabled: b, borderPosition: c, placementFrame: d};
	});

var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$stops = function (_p0) {
	var _p1 = _p0;
	return _p1._0.stops;
};
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$endPoint = function (_p2) {
	var _p3 = _p2;
	return _p3._0.endPoint;
};
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$startPoint = function (_p4) {
	var _p5 = _p4;
	return _p5._0.startPoint;
};
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient = function (a) {
	return {ctor: 'LinearGradient', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$along = F2(
	function (axis, distanceStops) {
		var _p6 = distanceStops;
		if (_p6.ctor === '[]') {
			return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
				{
					startPoint: _ianmackenzie$acorn_demo$Point2d$origin,
					endPoint: _ianmackenzie$acorn_demo$Point2d$origin,
					stops: {ctor: '[]'}
				});
		} else {
			if (_p6._1.ctor === '[]') {
				return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
					{
						startPoint: _ianmackenzie$acorn_demo$Point2d$origin,
						endPoint: _ianmackenzie$acorn_demo$Point2d$origin,
						stops: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 0, _1: _p6._0._1},
							_1: {ctor: '[]'}
						}
					});
			} else {
				var lastDistanceStop = A3(_elm_lang$core$List$foldl, _elm_lang$core$Basics$always, _p6._1._0, _p6._1._1);
				var _p7 = lastDistanceStop;
				var endDistance = _p7._0;
				var endColor = _p7._1;
				var endPoint = A2(_ianmackenzie$acorn_demo$Point2d$along, axis, endDistance);
				var _p8 = _p6._0;
				var startDistance = _p8._0;
				var startPoint = A2(_ianmackenzie$acorn_demo$Point2d$along, axis, startDistance);
				var stops = function () {
					if (_elm_lang$core$Native_Utils.eq(startDistance, endDistance)) {
						return {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 0, _1: endColor},
							_1: {ctor: '[]'}
						};
					} else {
						var delta = endDistance - startDistance;
						return A2(
							_elm_lang$core$List$map,
							function (_p9) {
								var _p10 = _p9;
								return {ctor: '_Tuple2', _0: (_p10._0 - startDistance) / delta, _1: _p10._1};
							},
							distanceStops);
					}
				}();
				return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
					{startPoint: startPoint, endPoint: endPoint, stops: stops});
			}
		}
	});
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$from = F2(
	function (_p12, _p11) {
		var _p13 = _p12;
		var _p14 = _p11;
		return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
			{
				startPoint: _p13._0,
				endPoint: _p14._0,
				stops: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: 0, _1: _p13._1},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 1, _1: _p14._1},
						_1: {ctor: '[]'}
					}
				}
			});
	});
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$relativeTo = F2(
	function (frame, _p15) {
		var _p16 = _p15;
		var _p17 = _p16._0;
		return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p17.startPoint),
				endPoint: A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, frame, _p17.endPoint),
				stops: _p17.stops
			});
	});
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$placeIn = F2(
	function (frame, _p18) {
		var _p19 = _p18;
		var _p20 = _p19._0;
		return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
			{
				startPoint: A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p20.startPoint),
				endPoint: A2(_ianmackenzie$acorn_demo$Point2d$placeIn, frame, _p20.endPoint),
				stops: _p20.stops
			});
	});
var _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$scaleAbout = F3(
	function (centerPoint, scale, _p21) {
		var _p22 = _p21;
		var _p23 = _p22._0;
		return _ianmackenzie$acorn_demo$Drawing2d_LinearGradient$LinearGradient(
			{
				startPoint: A3(_ianmackenzie$acorn_demo$Point2d$scaleAbout, centerPoint, scale, _p23.startPoint),
				endPoint: A3(_ianmackenzie$acorn_demo$Point2d$scaleAbout, centerPoint, scale, _p23.endPoint),
				stops: _p23.stops
			});
	});

var _ianmackenzie$acorn_demo$Drawing2d_Defs$gradientUnitsAttribute = _elm_lang$svg$Svg_Attributes$gradientUnits('userSpaceOnUse');
var _ianmackenzie$acorn_demo$Drawing2d_Defs$stopElement = function (_p0) {
	var _p1 = _p0;
	var _p2 = _ianmackenzie$acorn_demo$Drawing2d_Color$strings(_p1._1);
	var colorString = _p2._0;
	var opacityString = _p2._1;
	return A2(
		_elm_lang$svg$Svg$stop,
		{
			ctor: '::',
			_0: _elm_lang$svg$Svg_Attributes$offset(
				_elm_lang$core$Basics$toString(_p1._0)),
			_1: {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$stopColor(colorString),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$stopOpacity(opacityString),
					_1: {ctor: '[]'}
				}
			}
		},
		{ctor: '[]'});
};
var _ianmackenzie$acorn_demo$Drawing2d_Defs$entryToElement = function (_p3) {
	var _p4 = _p3;
	var _p5 = _p4._1;
	var _p8 = _p5._0;
	var _p6 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$endPoint(_p8));
	var x2 = _p6._0;
	var y2 = _p6._1;
	var _p7 = _ianmackenzie$acorn_demo$Point2d$coordinates(
		_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$startPoint(_p8));
	var x1 = _p7._0;
	var y1 = _p7._1;
	return A2(
		_elm_lang$svg$Svg$linearGradient,
		{
			ctor: '::',
			_0: _elm_lang$svg$Svg_Attributes$id(_p4._0),
			_1: {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$x1(
					_elm_lang$core$Basics$toString(x1)),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$y1(
						_elm_lang$core$Basics$toString(y1)),
					_1: {
						ctor: '::',
						_0: _elm_lang$svg$Svg_Attributes$x2(
							_elm_lang$core$Basics$toString(x2)),
						_1: {
							ctor: '::',
							_0: _elm_lang$svg$Svg_Attributes$y2(
								_elm_lang$core$Basics$toString(y2)),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Defs$gradientUnitsAttribute,
								_1: {ctor: '[]'}
							}
						}
					}
				}
			}
		},
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$Drawing2d_Defs$stopElement,
			_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$stops(_p8)));
};
var _ianmackenzie$acorn_demo$Drawing2d_Defs$toSvgElement = function (_p9) {
	var _p10 = _p9;
	return A2(
		_elm_lang$svg$Svg$defs,
		{ctor: '[]'},
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$Drawing2d_Defs$entryToElement,
			_elm_lang$core$List$reverse(_p10._0.entries)));
};
var _ianmackenzie$acorn_demo$Drawing2d_Defs$LinearGradient = function (a) {
	return {ctor: 'LinearGradient', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Defs$Defs = function (a) {
	return {ctor: 'Defs', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Defs$init = _ianmackenzie$acorn_demo$Drawing2d_Defs$Defs(
	{
		nextIndex: 1,
		entries: {ctor: '[]'}
	});
var _ianmackenzie$acorn_demo$Drawing2d_Defs$add = F2(
	function (def, _p11) {
		var _p12 = _p11;
		var _p13 = _p12._0;
		var id = A2(
			_elm_lang$core$Basics_ops['++'],
			'defs',
			_elm_lang$core$Basics$toString(_p13.nextIndex));
		var updatedDefs = _ianmackenzie$acorn_demo$Drawing2d_Defs$Defs(
			_elm_lang$core$Native_Utils.update(
				_p13,
				{
					nextIndex: _p13.nextIndex + 1,
					entries: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: id, _1: def},
						_1: _p13.entries
					}
				}));
		return {ctor: '_Tuple2', _0: id, _1: updatedDefs};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Defs$addLinearGradient = function (linearGradient) {
	return _ianmackenzie$acorn_demo$Drawing2d_Defs$add(
		_ianmackenzie$acorn_demo$Drawing2d_Defs$LinearGradient(linearGradient));
};

var _ianmackenzie$acorn_demo$Drawing2d_Font$monospace = 'monospace';
var _ianmackenzie$acorn_demo$Drawing2d_Font$sansSerif = 'sans-serif';
var _ianmackenzie$acorn_demo$Drawing2d_Font$serif = 'serif';

var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$toSvgAttributes = function (anchor) {
	var _p0 = anchor;
	switch (_p0.ctor) {
		case 'TopLeft':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('start'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('hanging'),
					_1: {ctor: '[]'}
				}
			};
		case 'TopCenter':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('middle'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('hanging'),
					_1: {ctor: '[]'}
				}
			};
		case 'TopRight':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('end'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('hanging'),
					_1: {ctor: '[]'}
				}
			};
		case 'CenterLeft':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('start'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('middle'),
					_1: {ctor: '[]'}
				}
			};
		case 'Center':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('middle'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('middle'),
					_1: {ctor: '[]'}
				}
			};
		case 'CenterRight':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('end'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('middle'),
					_1: {ctor: '[]'}
				}
			};
		case 'BottomLeft':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('start'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$dominantBaseline('alphabetic'),
					_1: {ctor: '[]'}
				}
			};
		case 'BottomCenter':
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('middle'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$alignmentBaseline('alphabetic'),
					_1: {ctor: '[]'}
				}
			};
		default:
			return {
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$textAnchor('end'),
				_1: {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$alignmentBaseline('alphabetic'),
					_1: {ctor: '[]'}
				}
			};
	}
};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomRight = {ctor: 'BottomRight'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomCenter = {ctor: 'BottomCenter'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomLeft = {ctor: 'BottomLeft'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$CenterRight = {ctor: 'CenterRight'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$Center = {ctor: 'Center'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$CenterLeft = {ctor: 'CenterLeft'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopRight = {ctor: 'TopRight'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopCenter = {ctor: 'TopCenter'};
var _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopLeft = {ctor: 'TopLeft'};

var _ianmackenzie$acorn_demo$Drawing2d_Text$bottomRight = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomRight;
var _ianmackenzie$acorn_demo$Drawing2d_Text$bottomCenter = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomCenter;
var _ianmackenzie$acorn_demo$Drawing2d_Text$bottomLeft = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$BottomLeft;
var _ianmackenzie$acorn_demo$Drawing2d_Text$centerRight = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$CenterRight;
var _ianmackenzie$acorn_demo$Drawing2d_Text$center = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$Center;
var _ianmackenzie$acorn_demo$Drawing2d_Text$centerLeft = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$CenterLeft;
var _ianmackenzie$acorn_demo$Drawing2d_Text$topRight = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopRight;
var _ianmackenzie$acorn_demo$Drawing2d_Text$topCenter = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopCenter;
var _ianmackenzie$acorn_demo$Drawing2d_Text$topLeft = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$TopLeft;

var _ianmackenzie$acorn_demo$Drawing2d_Attribute$normalizeFont = function (font) {
	return _elm_lang$core$Native_Utils.eq(font, _ianmackenzie$acorn_demo$Drawing2d_Font$serif) ? font : (_elm_lang$core$Native_Utils.eq(font, _ianmackenzie$acorn_demo$Drawing2d_Font$sansSerif) ? font : (_elm_lang$core$Native_Utils.eq(font, _ianmackenzie$acorn_demo$Drawing2d_Font$monospace) ? font : A2(
		_elm_lang$core$Basics_ops['++'],
		'\"',
		A2(_elm_lang$core$Basics_ops['++'], font, '\"'))));
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$apply = F3(
	function (attribute, context, defs) {
		var _p0 = attribute;
		switch (_p0.ctor) {
			case 'FillStyle':
				switch (_p0._0.ctor) {
					case 'FillColor':
						var _p1 = _ianmackenzie$acorn_demo$Drawing2d_Color$strings(_p0._0._0);
						var rgbString = _p1._0;
						var alphaString = _p1._1;
						var newAttributes = {
							ctor: '::',
							_0: _elm_lang$svg$Svg_Attributes$fill(rgbString),
							_1: {
								ctor: '::',
								_0: _elm_lang$svg$Svg_Attributes$fillOpacity(alphaString),
								_1: {ctor: '[]'}
							}
						};
						return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
					case 'NoFill':
						var newAttributes = {
							ctor: '::',
							_0: _elm_lang$svg$Svg_Attributes$fill('none'),
							_1: {ctor: '[]'}
						};
						return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
					default:
						var placedGradient = A2(_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$placeIn, context.placementFrame, _p0._0._0);
						var _p2 = A2(_ianmackenzie$acorn_demo$Drawing2d_Defs$addLinearGradient, placedGradient, defs);
						var id = _p2._0;
						var updatedDefs = _p2._1;
						var newAttributes = {
							ctor: '::',
							_0: _elm_lang$svg$Svg_Attributes$fill(
								A2(
									_elm_lang$core$Basics_ops['++'],
									'url(#',
									A2(_elm_lang$core$Basics_ops['++'], id, ')'))),
							_1: {ctor: '[]'}
						};
						return {ctor: '_Tuple3', _0: context, _1: updatedDefs, _2: newAttributes};
				}
			case 'StrokeColor':
				var _p3 = _ianmackenzie$acorn_demo$Drawing2d_Color$strings(_p0._0);
				var rgbString = _p3._0;
				var alphaString = _p3._1;
				var newAttributes = {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$stroke(rgbString),
					_1: {
						ctor: '::',
						_0: _elm_lang$svg$Svg_Attributes$strokeOpacity(alphaString),
						_1: {ctor: '[]'}
					}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'StrokeWidth':
				var newAttributes = {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$strokeWidth(
						A2(
							_elm_lang$core$Basics_ops['++'],
							_elm_lang$core$Basics$toString(_p0._0),
							'px')),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'BordersEnabled':
				var updatedContext = _elm_lang$core$Native_Utils.update(
					context,
					{bordersEnabled: _p0._0});
				return {
					ctor: '_Tuple3',
					_0: updatedContext,
					_1: defs,
					_2: {ctor: '[]'}
				};
			case 'BorderPosition':
				var updatedContext = _elm_lang$core$Native_Utils.update(
					context,
					{borderPosition: _p0._0});
				return {
					ctor: '_Tuple3',
					_0: updatedContext,
					_1: defs,
					_2: {ctor: '[]'}
				};
			case 'DotRadius':
				var updatedContext = _elm_lang$core$Native_Utils.update(
					context,
					{dotRadius: _p0._0});
				return {
					ctor: '_Tuple3',
					_0: updatedContext,
					_1: defs,
					_2: {ctor: '[]'}
				};
			case 'TextAnchor':
				var newAttributes = _ianmackenzie$acorn_demo$Drawing2d_TextAnchor$toSvgAttributes(_p0._0);
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'TextColor':
				var textColor = _elm_lang$core$Tuple$first(
					_ianmackenzie$acorn_demo$Drawing2d_Color$strings(_p0._0));
				var newAttributes = {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$color(textColor),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'FontSize':
				var newAttributes = {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$fontSize(
						_elm_lang$core$Basics$toString(_p0._0)),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'FontFamily':
				var fontFamily = A2(
					_elm_lang$core$String$join,
					',',
					A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Drawing2d_Attribute$normalizeFont, _p0._0));
				var newAttributes = {
					ctor: '::',
					_0: _elm_lang$svg$Svg_Attributes$fontFamily(fontFamily),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			case 'OnClick':
				var newAttributes = {
					ctor: '::',
					_0: A3(
						_elm_lang$html$Html_Events$onWithOptions,
						'click',
						{preventDefault: true, stopPropagation: true},
						_elm_lang$core$Json_Decode$succeed(_p0._0)),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
			default:
				var newAttributes = {
					ctor: '::',
					_0: A3(
						_elm_lang$html$Html_Events$onWithOptions,
						'mousedown',
						{preventDefault: true, stopPropagation: true},
						A2(_elm_lang$core$Json_Decode$map, _p0._0, _elm_lang$mouse$Mouse$position)),
					_1: {ctor: '[]'}
				};
				return {ctor: '_Tuple3', _0: context, _1: defs, _2: newAttributes};
		}
	});
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$LinearGradientFill = function (a) {
	return {ctor: 'LinearGradientFill', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillColor = function (a) {
	return {ctor: 'FillColor', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$NoFill = {ctor: 'NoFill'};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$BorderPosition = function (a) {
	return {ctor: 'BorderPosition', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$BordersEnabled = function (a) {
	return {ctor: 'BordersEnabled', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnMouseDown = function (a) {
	return {ctor: 'OnMouseDown', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnClick = function (a) {
	return {ctor: 'OnClick', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontFamily = function (a) {
	return {ctor: 'FontFamily', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontSize = function (a) {
	return {ctor: 'FontSize', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextColor = function (a) {
	return {ctor: 'TextColor', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextAnchor = function (a) {
	return {ctor: 'TextAnchor', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$DotRadius = function (a) {
	return {ctor: 'DotRadius', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeWidth = function (a) {
	return {ctor: 'StrokeWidth', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeColor = function (a) {
	return {ctor: 'StrokeColor', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle = function (a) {
	return {ctor: 'FillStyle', _0: a};
};
var _ianmackenzie$acorn_demo$Drawing2d_Attribute$map = F2(
	function ($function, attribute) {
		var _p4 = attribute;
		switch (_p4.ctor) {
			case 'FillStyle':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle(_p4._0);
			case 'StrokeColor':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeColor(_p4._0);
			case 'StrokeWidth':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeWidth(_p4._0);
			case 'BordersEnabled':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$BordersEnabled(_p4._0);
			case 'BorderPosition':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$BorderPosition(_p4._0);
			case 'DotRadius':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$DotRadius(_p4._0);
			case 'TextAnchor':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextAnchor(_p4._0);
			case 'TextColor':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextColor(_p4._0);
			case 'FontSize':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontSize(_p4._0);
			case 'FontFamily':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontFamily(_p4._0);
			case 'OnClick':
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnClick(
					$function(_p4._0));
			default:
				return _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnMouseDown(
					function (_p5) {
						return $function(
							_p4._0(_p5));
					});
		}
	});

var _ianmackenzie$acorn_demo$Drawing2d_Attributes$map = _ianmackenzie$acorn_demo$Drawing2d_Attribute$map;
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontFamily = function (fonts) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontFamily(fonts);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize = function (px) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FontSize(px);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor = function (color) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextColor(color);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$whiteText = _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$white);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackText = _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$black);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor = function (anchor) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$TextAnchor(anchor);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$onMouseDown = function (handler) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnMouseDown(handler);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$onClick = function (message) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$OnClick(message);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth = function (width) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeWidth(width);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$borderPosition = function (position) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$BorderPosition(position);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokedBorder = _ianmackenzie$acorn_demo$Drawing2d_Attribute$BordersEnabled(true);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$noBorder = _ianmackenzie$acorn_demo$Drawing2d_Attribute$BordersEnabled(false);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor = function (color) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$StrokeColor(color);
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackStroke = _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_elm_lang$core$Color$black);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$whiteStroke = _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_elm_lang$core$Color$white);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$gradientFillFrom = F2(
	function (start, end) {
		return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle(
			_ianmackenzie$acorn_demo$Drawing2d_Attribute$LinearGradientFill(
				A2(_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$from, start, end)));
	});
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$gradientFillAlong = F2(
	function (axis, distanceStops) {
		return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle(
			_ianmackenzie$acorn_demo$Drawing2d_Attribute$LinearGradientFill(
				A2(_ianmackenzie$acorn_demo$Drawing2d_LinearGradient$along, axis, distanceStops)));
	});
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$noFill = _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle(_ianmackenzie$acorn_demo$Drawing2d_Attribute$NoFill);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor = function (color) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$FillStyle(
		_ianmackenzie$acorn_demo$Drawing2d_Attribute$FillColor(color));
};
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackFill = _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$black);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$whiteFill = _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$white);
var _ianmackenzie$acorn_demo$Drawing2d_Attributes$dotRadius = function (radius) {
	return _ianmackenzie$acorn_demo$Drawing2d_Attribute$DotRadius(radius);
};

var _ianmackenzie$acorn_demo$Ellipse2d$transformBy = F2(
	function (axesTransformation, _p0) {
		var _p1 = _p0;
		var _p2 = _p1._0;
		return _ianmackenzie$acorn_demo$Geometry_Types$Ellipse2d(
			_elm_lang$core$Native_Utils.update(
				_p2,
				{
					axes: axesTransformation(_p2.axes)
				}));
	});
var _ianmackenzie$acorn_demo$Ellipse2d$rotateAround = F2(
	function (point, angle) {
		return _ianmackenzie$acorn_demo$Ellipse2d$transformBy(
			A2(_ianmackenzie$acorn_demo$Frame2d$rotateAround, point, angle));
	});
var _ianmackenzie$acorn_demo$Ellipse2d$translateBy = function (displacement) {
	return _ianmackenzie$acorn_demo$Ellipse2d$transformBy(
		_ianmackenzie$acorn_demo$Frame2d$translateBy(displacement));
};
var _ianmackenzie$acorn_demo$Ellipse2d$translateIn = F3(
	function (direction, distance, ellipse) {
		return A2(
			_ianmackenzie$acorn_demo$Ellipse2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			ellipse);
	});
var _ianmackenzie$acorn_demo$Ellipse2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$Ellipse2d$transformBy(
		_ianmackenzie$acorn_demo$Frame2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$Ellipse2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$Ellipse2d$transformBy(
		_ianmackenzie$acorn_demo$Frame2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$Ellipse2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$Ellipse2d$transformBy(
		_ianmackenzie$acorn_demo$Frame2d$placeIn(frame));
};
var _ianmackenzie$acorn_demo$Ellipse2d$yRadius = function (_p3) {
	var _p4 = _p3;
	return _p4._0.yRadius;
};
var _ianmackenzie$acorn_demo$Ellipse2d$xRadius = function (_p5) {
	var _p6 = _p5;
	return _p6._0.xRadius;
};
var _ianmackenzie$acorn_demo$Ellipse2d$area = function (ellipse) {
	return (_elm_lang$core$Basics$pi * _ianmackenzie$acorn_demo$Ellipse2d$xRadius(ellipse)) * _ianmackenzie$acorn_demo$Ellipse2d$yRadius(ellipse);
};
var _ianmackenzie$acorn_demo$Ellipse2d$axes = function (_p7) {
	var _p8 = _p7;
	return _p8._0.axes;
};
var _ianmackenzie$acorn_demo$Ellipse2d$xAxis = function (ellipse) {
	return _ianmackenzie$acorn_demo$Frame2d$xAxis(
		_ianmackenzie$acorn_demo$Ellipse2d$axes(ellipse));
};
var _ianmackenzie$acorn_demo$Ellipse2d$yAxis = function (ellipse) {
	return _ianmackenzie$acorn_demo$Frame2d$yAxis(
		_ianmackenzie$acorn_demo$Ellipse2d$axes(ellipse));
};
var _ianmackenzie$acorn_demo$Ellipse2d$xDirection = function (ellipse) {
	return _ianmackenzie$acorn_demo$Frame2d$xDirection(
		_ianmackenzie$acorn_demo$Ellipse2d$axes(ellipse));
};
var _ianmackenzie$acorn_demo$Ellipse2d$yDirection = function (ellipse) {
	return _ianmackenzie$acorn_demo$Frame2d$yDirection(
		_ianmackenzie$acorn_demo$Ellipse2d$axes(ellipse));
};
var _ianmackenzie$acorn_demo$Ellipse2d$centerPoint = function (ellipse) {
	return _ianmackenzie$acorn_demo$Frame2d$originPoint(
		_ianmackenzie$acorn_demo$Ellipse2d$axes(ellipse));
};
var _ianmackenzie$acorn_demo$Ellipse2d$scaleAbout = F3(
	function (point, scale, ellipse) {
		var newCenterPoint = A3(
			_ianmackenzie$acorn_demo$Point2d$scaleAbout,
			point,
			scale,
			_ianmackenzie$acorn_demo$Ellipse2d$centerPoint(ellipse));
		var newAxes = (_elm_lang$core$Native_Utils.cmp(scale, 0) > -1) ? _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: newCenterPoint,
				xDirection: _ianmackenzie$acorn_demo$Ellipse2d$xDirection(ellipse),
				yDirection: _ianmackenzie$acorn_demo$Ellipse2d$yDirection(ellipse)
			}) : _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: newCenterPoint,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
					_ianmackenzie$acorn_demo$Ellipse2d$xDirection(ellipse)),
				yDirection: _ianmackenzie$acorn_demo$Direction2d$flip(
					_ianmackenzie$acorn_demo$Ellipse2d$yDirection(ellipse))
			});
		return _ianmackenzie$acorn_demo$Geometry_Types$Ellipse2d(
			{
				axes: newAxes,
				xRadius: _elm_lang$core$Basics$abs(
					scale * _ianmackenzie$acorn_demo$Ellipse2d$xRadius(ellipse)),
				yRadius: _elm_lang$core$Basics$abs(
					scale * _ianmackenzie$acorn_demo$Ellipse2d$yRadius(ellipse))
			});
	});
var _ianmackenzie$acorn_demo$Ellipse2d$with = function (properties) {
	return _ianmackenzie$acorn_demo$Geometry_Types$Ellipse2d(
		{
			axes: A2(_ianmackenzie$acorn_demo$Frame2d$withXDirection, properties.xDirection, properties.centerPoint),
			xRadius: _elm_lang$core$Basics$abs(properties.xRadius),
			yRadius: _elm_lang$core$Basics$abs(properties.yRadius)
		});
};

var _ianmackenzie$acorn_demo$EllipticalArc2d$underlyingArc = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$parameterValueToArcLength = F2(
	function (_p2, t) {
		var _p3 = _p2;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$parameterValueToArcLength, t, _p3._1);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$arcLengthToParameterValue = F2(
	function (_p4, s) {
		var _p5 = _p4;
		return A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p5._1);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$arcLength = function (_p6) {
	var _p7 = _p6;
	return _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$totalArcLength(_p7._1);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy = F2(
	function (ellipseTransformation, _p8) {
		var _p9 = _p8;
		var _p10 = _p9._0;
		return _ianmackenzie$acorn_demo$Geometry_Types$EllipticalArc2d(
			_elm_lang$core$Native_Utils.update(
				_p10,
				{
					ellipse: ellipseTransformation(_p10.ellipse)
				}));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
			A2(_ianmackenzie$acorn_demo$Ellipse2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$rotateAround = F2(
	function (point, angle) {
		return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
			A2(_ianmackenzie$acorn_demo$Ellipse2d$rotateAround, point, angle));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$translateBy = function (displacement) {
	return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
		_ianmackenzie$acorn_demo$Ellipse2d$translateBy(displacement));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$translateIn = F3(
	function (direction, distance, arc) {
		return A2(
			_ianmackenzie$acorn_demo$EllipticalArc2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			arc);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
		_ianmackenzie$acorn_demo$Ellipse2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
		_ianmackenzie$acorn_demo$Ellipse2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$EllipticalArc2d$transformBy(
		_ianmackenzie$acorn_demo$Ellipse2d$placeIn(frame));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$reverse = function (_p11) {
	var _p12 = _p11;
	var _p13 = _p12._0;
	return _ianmackenzie$acorn_demo$Geometry_Types$EllipticalArc2d(
		_elm_lang$core$Native_Utils.update(
			_p13,
			{startAngle: _p13.startAngle + _p13.sweptAngle, sweptAngle: 0 - _p13.sweptAngle}));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle = function (_p14) {
	var _p15 = _p14;
	return _p15._0.sweptAngle;
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$startAngle = function (_p16) {
	var _p17 = _p16;
	return _p17._0.startAngle;
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$yRadius = function (_p18) {
	var _p19 = _p18;
	return _ianmackenzie$acorn_demo$Ellipse2d$yRadius(_p19._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius = function (_p20) {
	var _p21 = _p20;
	return _ianmackenzie$acorn_demo$Ellipse2d$xRadius(_p21._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$maxSecondDerivativeMagnitude = function (arc) {
	var ry = _ianmackenzie$acorn_demo$EllipticalArc2d$yRadius(arc);
	var rx = _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius(arc);
	var dTheta = _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle(arc);
	var dThetaSquared = dTheta * dTheta;
	var kx = dThetaSquared * rx;
	var ky = dThetaSquared * ry;
	var theta0 = _ianmackenzie$acorn_demo$EllipticalArc2d$startAngle(arc);
	var theta1 = theta0 + dTheta;
	var thetaInterval = A2(_ianmackenzie$elm_interval$Interval$from, theta0, theta1);
	var sinThetaInterval = _ianmackenzie$elm_interval$Interval$sin(thetaInterval);
	var includeKx = A2(_ianmackenzie$elm_interval$Interval$contains, 0, sinThetaInterval);
	var includeKy = _elm_lang$core$Native_Utils.eq(
		_ianmackenzie$elm_interval$Interval$maxValue(sinThetaInterval),
		1) || _elm_lang$core$Native_Utils.eq(
		_ianmackenzie$elm_interval$Interval$minValue(sinThetaInterval),
		-1);
	if ((_elm_lang$core$Native_Utils.cmp(kx, ky) > -1) && includeKx) {
		return kx;
	} else {
		if ((_elm_lang$core$Native_Utils.cmp(ky, kx) > -1) && includeKy) {
			return ky;
		} else {
			var sinTheta1 = _elm_lang$core$Basics$sin(theta1);
			var cosTheta1 = _elm_lang$core$Basics$cos(theta1);
			var sinTheta0 = _elm_lang$core$Basics$sin(theta0);
			var cosTheta0 = _elm_lang$core$Basics$cos(theta0);
			var rySquared = ry * ry;
			var rxSquared = rx * rx;
			var d0 = ((rxSquared * cosTheta0) * cosTheta0) + ((rySquared * sinTheta0) * sinTheta0);
			var d1 = ((rxSquared * cosTheta1) * cosTheta1) + ((rySquared * sinTheta1) * sinTheta1);
			return dThetaSquared * _elm_lang$core$Basics$sqrt(
				A2(_elm_lang$core$Basics$max, d0, d1));
		}
	}
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$derivativeMagnitude = function (arc) {
	var dTheta = _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle(arc);
	var absDTheta = _elm_lang$core$Basics$abs(dTheta);
	var theta0 = _ianmackenzie$acorn_demo$EllipticalArc2d$startAngle(arc);
	var ry = _ianmackenzie$acorn_demo$EllipticalArc2d$yRadius(arc);
	var rx = _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius(arc);
	return function (t) {
		var theta = theta0 + (t * dTheta);
		var dx = rx * _elm_lang$core$Basics$sin(theta);
		var dy = ry * _elm_lang$core$Basics$cos(theta);
		return absDTheta * _elm_lang$core$Basics$sqrt((dx * dx) + (dy * dy));
	};
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$yAxis = function (_p22) {
	var _p23 = _p22;
	return _ianmackenzie$acorn_demo$Ellipse2d$yAxis(_p23._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$xAxis = function (_p24) {
	var _p25 = _p24;
	return _ianmackenzie$acorn_demo$Ellipse2d$xAxis(_p25._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$axes = function (_p26) {
	var _p27 = _p26;
	return _ianmackenzie$acorn_demo$Ellipse2d$axes(_p27._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$pointOn = F2(
	function (arc, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var theta = _ianmackenzie$acorn_demo$EllipticalArc2d$startAngle(arc) + (t * _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle(arc));
			return _elm_lang$core$Maybe$Just(
				A2(
					_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
					_ianmackenzie$acorn_demo$EllipticalArc2d$axes(arc),
					{
						ctor: '_Tuple2',
						_0: _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius(arc) * _elm_lang$core$Basics$cos(theta),
						_1: _ianmackenzie$acorn_demo$EllipticalArc2d$yRadius(arc) * _elm_lang$core$Basics$sin(theta)
					}));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$pointsOn = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$pointAlong = F2(
	function (_p28, s) {
		var _p29 = _p28;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn(_p29._0),
			A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p29._1));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$pointsAlong = F2(
	function (parameterizedArc, distances) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$pointAlong(parameterizedArc),
			distances);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$derivative = F2(
	function (arc, t) {
		if ((_elm_lang$core$Native_Utils.cmp(0, t) < 1) && (_elm_lang$core$Native_Utils.cmp(t, 1) < 1)) {
			var deltaTheta = _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle(arc);
			var theta = _ianmackenzie$acorn_demo$EllipticalArc2d$startAngle(arc) + (t * deltaTheta);
			return _elm_lang$core$Maybe$Just(
				A2(
					_ianmackenzie$acorn_demo$Vector2d$placeIn,
					_ianmackenzie$acorn_demo$EllipticalArc2d$axes(arc),
					_ianmackenzie$acorn_demo$Vector2d$fromComponents(
						{
							ctor: '_Tuple2',
							_0: ((0 - _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius(arc)) * deltaTheta) * _elm_lang$core$Basics$sin(theta),
							_1: (_ianmackenzie$acorn_demo$EllipticalArc2d$yRadius(arc) * deltaTheta) * _elm_lang$core$Basics$cos(theta)
						})));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$derivatives = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$derivative(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$sample = F2(
	function (arc, t) {
		return A3(
			_elm_lang$core$Maybe$map2,
			F2(
				function (p, v) {
					return {ctor: '_Tuple2', _0: p, _1: v};
				}),
			A2(_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn, arc, t),
			A2(_ianmackenzie$acorn_demo$EllipticalArc2d$derivative, arc, t));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$samples = F2(
	function (arc, parameterValues) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$sample(arc),
			parameterValues);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$sampleAlong = F2(
	function (_p30, s) {
		var _p31 = _p30;
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (_p32) {
				var _p33 = _p32;
				var _p34 = _ianmackenzie$acorn_demo$Vector2d$direction(_p33._1);
				if (_p34.ctor === 'Just') {
					return _elm_lang$core$Maybe$Just(
						{ctor: '_Tuple2', _0: _p33._0, _1: _p34._0});
				} else {
					return _elm_lang$core$Maybe$Nothing;
				}
			},
			A2(
				_elm_lang$core$Maybe$andThen,
				_ianmackenzie$acorn_demo$EllipticalArc2d$sample(_p31._0),
				A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p31._1)));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$samplesAlong = F2(
	function (parameterizedArc, distances) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$sampleAlong(parameterizedArc),
			distances);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$tangentAlong = F2(
	function (_p35, s) {
		var _p36 = _p35;
		return A2(
			_elm_lang$core$Maybe$andThen,
			_ianmackenzie$acorn_demo$Vector2d$direction,
			A2(
				_elm_lang$core$Maybe$andThen,
				_ianmackenzie$acorn_demo$EllipticalArc2d$derivative(_p36._0),
				A2(_ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$arcLengthToParameterValue, s, _p36._1)));
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$tangentsAlong = F2(
	function (parameterizedArc, distances) {
		return A2(
			_elm_lang$core$List$filterMap,
			_ianmackenzie$acorn_demo$EllipticalArc2d$tangentAlong(parameterizedArc),
			distances);
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$xDirection = function (arc) {
	return _ianmackenzie$acorn_demo$Frame2d$xDirection(
		_ianmackenzie$acorn_demo$EllipticalArc2d$axes(arc));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$yDirection = function (arc) {
	return _ianmackenzie$acorn_demo$Frame2d$yDirection(
		_ianmackenzie$acorn_demo$EllipticalArc2d$axes(arc));
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$centerPoint = function (_p37) {
	var _p38 = _p37;
	return _ianmackenzie$acorn_demo$Ellipse2d$centerPoint(_p38._0.ellipse);
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$startPoint = function (arc) {
	var _p39 = A2(_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn, arc, 0);
	if (_p39.ctor === 'Just') {
		return _p39._0;
	} else {
		return _ianmackenzie$acorn_demo$EllipticalArc2d$centerPoint(arc);
	}
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$endPoint = function (arc) {
	var _p40 = A2(_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn, arc, 1);
	if (_p40.ctor === 'Just') {
		return _p40._0;
	} else {
		return _ianmackenzie$acorn_demo$EllipticalArc2d$centerPoint(arc);
	}
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$with = function (properties) {
	return _ianmackenzie$acorn_demo$Geometry_Types$EllipticalArc2d(
		{
			ellipse: _ianmackenzie$acorn_demo$Ellipse2d$with(
				{centerPoint: properties.centerPoint, xDirection: properties.xDirection, xRadius: properties.xRadius, yRadius: properties.yRadius}),
			startAngle: properties.startAngle,
			sweptAngle: properties.sweptAngle
		});
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$fromEndpoints = function ($arguments) {
	if ((_elm_lang$core$Native_Utils.cmp($arguments.xRadius, 0) > 0) && (_elm_lang$core$Native_Utils.cmp($arguments.yRadius, 0) > 0)) {
		var temporaryFrame = A2(
			_ianmackenzie$acorn_demo$Frame2d$withXDirection,
			$arguments.xDirection,
			A3(_ianmackenzie$acorn_demo$Point2d$translateIn, $arguments.xDirection, 0 - $arguments.xRadius, $arguments.startPoint));
		var _p41 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, temporaryFrame, $arguments.endPoint));
		var x2Ellipse = _p41._0;
		var y2Ellipse = _p41._1;
		var x2 = x2Ellipse / $arguments.xRadius;
		var cx2 = x2 - 1;
		var y2 = y2Ellipse / $arguments.yRadius;
		var cy2 = y2;
		var d = _elm_lang$core$Basics$sqrt((cx2 * cx2) + (cy2 * cy2)) / 2;
		if ((_elm_lang$core$Native_Utils.cmp(d, 0) > 0) && (_elm_lang$core$Native_Utils.cmp(d, 1) < 0)) {
			var offsetAngle = _elm_lang$core$Basics$acos(d);
			var midAngle = A2(_elm_lang$core$Basics$atan2, 0 - cy2, 0 - cx2);
			var _p42 = function () {
				var _p43 = $arguments.sweptAngle;
				switch (_p43.ctor) {
					case 'SmallPositive':
						return {ctor: '_Tuple2', _0: midAngle + offsetAngle, _1: _elm_lang$core$Basics$pi - (2 * offsetAngle)};
					case 'SmallNegative':
						return {ctor: '_Tuple2', _0: midAngle - offsetAngle, _1: (0 - _elm_lang$core$Basics$pi) + (2 * offsetAngle)};
					case 'LargePositive':
						return {ctor: '_Tuple2', _0: midAngle - offsetAngle, _1: _elm_lang$core$Basics$pi + (2 * offsetAngle)};
					default:
						return {ctor: '_Tuple2', _0: midAngle + offsetAngle, _1: (0 - _elm_lang$core$Basics$pi) - (2 * offsetAngle)};
				}
			}();
			var startAngle_ = _p42._0;
			var sweptAngleInRadians = _p42._1;
			var centerPoint_ = A2(
				_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
				temporaryFrame,
				{
					ctor: '_Tuple2',
					_0: $arguments.xRadius * (1 - _elm_lang$core$Basics$cos(startAngle_)),
					_1: (0 - $arguments.yRadius) * _elm_lang$core$Basics$sin(startAngle_)
				});
			return _elm_lang$core$Maybe$Just(
				_ianmackenzie$acorn_demo$EllipticalArc2d$with(
					{
						centerPoint: centerPoint_,
						xDirection: $arguments.xDirection,
						xRadius: $arguments.xRadius,
						yRadius: $arguments.yRadius,
						startAngle: (_elm_lang$core$Native_Utils.cmp(startAngle_, _elm_lang$core$Basics$pi) > 0) ? (startAngle_ - (2 * _elm_lang$core$Basics$pi)) : ((_elm_lang$core$Native_Utils.cmp(startAngle_, 0 - _elm_lang$core$Basics$pi) < 0) ? (startAngle_ + (2 * _elm_lang$core$Basics$pi)) : startAngle_),
						sweptAngle: sweptAngleInRadians
					}));
		} else {
			return _elm_lang$core$Maybe$Nothing;
		}
	} else {
		return _elm_lang$core$Maybe$Nothing;
	}
};
var _ianmackenzie$acorn_demo$EllipticalArc2d$ArcLengthParameterized = F2(
	function (a, b) {
		return {ctor: 'ArcLengthParameterized', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$EllipticalArc2d$arcLengthParameterized = F2(
	function (_p44, arc) {
		var _p45 = _p44;
		var parameterization = _ianmackenzie$acorn_demo$Geometry_ArcLengthParameterization$build(
			{
				tolerance: _p45._0,
				derivativeMagnitude: _ianmackenzie$acorn_demo$EllipticalArc2d$derivativeMagnitude(arc),
				maxSecondDerivativeMagnitude: _ianmackenzie$acorn_demo$EllipticalArc2d$maxSecondDerivativeMagnitude(arc)
			});
		return A2(_ianmackenzie$acorn_demo$EllipticalArc2d$ArcLengthParameterized, arc, parameterization);
	});

var _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$leftOf = F2(
	function (point, _p0) {
		var _p1 = _p0;
		var _p2 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var x = _p2._0;
		var y = _p2._1;
		return A2(
			_elm_lang$core$Maybe$map,
			function (_p3) {
				var _p4 = _p3;
				return _p4._1._0;
			},
			A3(
				_elm_lang$core$List$foldl,
				F2(
					function (edge, current) {
						var _p5 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(
							_elm_lang$core$Tuple$second(edge));
						var p1 = _p5._0;
						var p2 = _p5._1;
						var _p6 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
						var x1 = _p6._0;
						var y1 = _p6._1;
						var _p7 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
						var x2 = _p7._0;
						var y2 = _p7._1;
						var dx = _elm_lang$core$Native_Utils.eq(y1, y2) ? (x - A2(_elm_lang$core$Basics$max, x1, x2)) : (x - (x1 + (((y - y1) / (y2 - y1)) * (x2 - x1))));
						if (_elm_lang$core$Native_Utils.cmp(dx, 0) > -1) {
							var _p8 = current;
							if (_p8.ctor === 'Nothing') {
								return _elm_lang$core$Maybe$Just(
									{ctor: '_Tuple2', _0: dx, _1: edge});
							} else {
								return (_elm_lang$core$Native_Utils.cmp(dx, _p8._0._0) < 1) ? _elm_lang$core$Maybe$Just(
									{ctor: '_Tuple2', _0: dx, _1: edge}) : current;
							}
						} else {
							return current;
						}
					}),
				_elm_lang$core$Maybe$Nothing,
				_p1._0));
	});
var _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$EdgeSet = function (a) {
	return {ctor: 'EdgeSet', _0: a};
};
var _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$empty = _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$EdgeSet(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$insert = F2(
	function (edge, _p9) {
		var _p10 = _p9;
		return _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$EdgeSet(
			{ctor: '::', _0: edge, _1: _p10._0});
	});
var _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$remove = F2(
	function (edge, _p11) {
		var _p12 = _p11;
		return _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$EdgeSet(
			A2(
				_elm_lang$core$List$filter,
				F2(
					function (x, y) {
						return !_elm_lang$core$Native_Utils.eq(x, y);
					})(edge),
				_p12._0));
	});

var _ianmackenzie$acorn_demo$Triangle2d$vertices = function (_p0) {
	var _p1 = _p0;
	return _p1._0;
};
var _ianmackenzie$acorn_demo$Triangle2d$edges = function (triangle) {
	var _p2 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
	var p1 = _p2._0;
	var p2 = _p2._1;
	var p3 = _p2._2;
	return {
		ctor: '_Tuple3',
		_0: _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{ctor: '_Tuple2', _0: p1, _1: p2}),
		_1: _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{ctor: '_Tuple2', _0: p2, _1: p3}),
		_2: _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
			{ctor: '_Tuple2', _0: p3, _1: p1})
	};
};
var _ianmackenzie$acorn_demo$Triangle2d$centroid = function (triangle) {
	var _p3 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
	var p1 = _p3._0;
	var p2 = _p3._1;
	var p3 = _p3._2;
	var firstVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
	var secondVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p3);
	var displacement = A2(
		_ianmackenzie$acorn_demo$Vector2d$scaleBy,
		1.0 / 3.0,
		A2(_ianmackenzie$acorn_demo$Vector2d$sum, firstVector, secondVector));
	return A2(_ianmackenzie$acorn_demo$Point2d$translateBy, displacement, p1);
};
var _ianmackenzie$acorn_demo$Triangle2d$contains = F2(
	function (point, triangle) {
		var crossProduct = F2(
			function (startVertex, endVertex) {
				var segmentVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, startVertex, endVertex);
				var vectorToPoint = A2(_ianmackenzie$acorn_demo$Vector2d$from, startVertex, point);
				return A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, segmentVector, vectorToPoint);
			});
		var _p4 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
		var p1 = _p4._0;
		var p2 = _p4._1;
		var p3 = _p4._2;
		var firstProduct = A2(crossProduct, p1, p2);
		var secondProduct = A2(crossProduct, p2, p3);
		var thirdProduct = A2(crossProduct, p3, p1);
		return ((_elm_lang$core$Native_Utils.cmp(firstProduct, 0) > -1) && ((_elm_lang$core$Native_Utils.cmp(secondProduct, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(thirdProduct, 0) > -1))) || ((_elm_lang$core$Native_Utils.cmp(firstProduct, 0) < 1) && ((_elm_lang$core$Native_Utils.cmp(secondProduct, 0) < 1) && (_elm_lang$core$Native_Utils.cmp(thirdProduct, 0) < 1)));
	});
var _ianmackenzie$acorn_demo$Triangle2d$counterclockwiseArea = function (triangle) {
	var _p5 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
	var p1 = _p5._0;
	var p2 = _p5._1;
	var p3 = _p5._2;
	var firstVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p2);
	var secondVector = A2(_ianmackenzie$acorn_demo$Vector2d$from, p1, p3);
	return 0.5 * A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, firstVector, secondVector);
};
var _ianmackenzie$acorn_demo$Triangle2d$area = function (_p6) {
	return _elm_lang$core$Basics$abs(
		_ianmackenzie$acorn_demo$Triangle2d$counterclockwiseArea(_p6));
};
var _ianmackenzie$acorn_demo$Triangle2d$clockwiseArea = function (triangle) {
	return 0 - _ianmackenzie$acorn_demo$Triangle2d$counterclockwiseArea(triangle);
};
var _ianmackenzie$acorn_demo$Triangle2d$boundingBox = function (triangle) {
	var _p7 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
	var p1 = _p7._0;
	var p2 = _p7._1;
	var p3 = _p7._2;
	var _p8 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
	var x1 = _p8._0;
	var y1 = _p8._1;
	var _p9 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
	var x2 = _p9._0;
	var y2 = _p9._1;
	var _p10 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
	var x3 = _p10._0;
	var y3 = _p10._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{
			minX: A2(
				_elm_lang$core$Basics$min,
				x1,
				A2(_elm_lang$core$Basics$min, x2, x3)),
			maxX: A2(
				_elm_lang$core$Basics$max,
				x1,
				A2(_elm_lang$core$Basics$max, x2, x3)),
			minY: A2(
				_elm_lang$core$Basics$min,
				y1,
				A2(_elm_lang$core$Basics$min, y2, y3)),
			maxY: A2(
				_elm_lang$core$Basics$max,
				y1,
				A2(_elm_lang$core$Basics$max, y2, y3))
		});
};
var _ianmackenzie$acorn_demo$Triangle2d$circumcircle = function (triangle) {
	var _p11 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
	var p1 = _p11._0;
	var p2 = _p11._1;
	var p3 = _p11._2;
	return A3(_ianmackenzie$acorn_demo$Circle2d$throughPoints, p1, p2, p3);
};
var _ianmackenzie$acorn_demo$Triangle2d$fromVertices = _ianmackenzie$acorn_demo$Geometry_Types$Triangle2d;
var _ianmackenzie$acorn_demo$Triangle2d$mapVertices = F2(
	function ($function, triangle) {
		var _p12 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
		var p1 = _p12._0;
		var p2 = _p12._1;
		var p3 = _p12._2;
		return _ianmackenzie$acorn_demo$Triangle2d$fromVertices(
			{
				ctor: '_Tuple3',
				_0: $function(p1),
				_1: $function(p2),
				_2: $function(p3)
			});
	});
var _ianmackenzie$acorn_demo$Triangle2d$scaleAbout = F2(
	function (point, scale) {
		return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale));
	});
var _ianmackenzie$acorn_demo$Triangle2d$rotateAround = F2(
	function (centerPoint, angle) {
		return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, centerPoint, angle));
	});
var _ianmackenzie$acorn_demo$Triangle2d$translateBy = function (vector) {
	return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$translateBy(vector));
};
var _ianmackenzie$acorn_demo$Triangle2d$translateIn = F3(
	function (direction, distance, triangle) {
		return A2(
			_ianmackenzie$acorn_demo$Triangle2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			triangle);
	});
var _ianmackenzie$acorn_demo$Triangle2d$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis));
};
var _ianmackenzie$acorn_demo$Triangle2d$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame));
};
var _ianmackenzie$acorn_demo$Triangle2d$placeIn = function (frame) {
	return _ianmackenzie$acorn_demo$Triangle2d$mapVertices(
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame));
};

var _ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize = F2(
	function (i, j) {
		return (_elm_lang$core$Native_Utils.cmp(i, j) < 1) ? {ctor: '_Tuple2', _0: i, _1: j} : {ctor: '_Tuple2', _0: j, _1: i};
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices = function (_p0) {
	var _p1 = _p0;
	return _p1._0.faceIndices;
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$edgeIndices = function (mesh) {
	var addFace = F2(
		function (_p2, edgeSet) {
			var _p3 = _p2;
			var _p6 = _p3._2;
			var _p5 = _p3._1;
			var _p4 = _p3._0;
			return A2(
				_elm_lang$core$Set$insert,
				A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p6, _p4),
				A2(
					_elm_lang$core$Set$insert,
					A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p5, _p6),
					A2(
						_elm_lang$core$Set$insert,
						A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p4, _p5),
						edgeSet)));
		});
	return _elm_lang$core$Set$toList(
		A3(
			_elm_lang$core$List$foldl,
			addFace,
			_elm_lang$core$Set$empty,
			_ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices(mesh)));
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$edgeFaceCounts = function (mesh) {
	var increment = function (count) {
		var _p7 = count;
		if (_p7.ctor === 'Just') {
			return _elm_lang$core$Maybe$Just(_p7._0 + 1);
		} else {
			return _elm_lang$core$Maybe$Just(1);
		}
	};
	var add = F2(
		function (edgeIndices, edgeDict) {
			return A3(_elm_lang$core$Dict$update, edgeIndices, increment, edgeDict);
		});
	var addEdges = F2(
		function (_p8, edgeDict) {
			var _p9 = _p8;
			var _p12 = _p9._2;
			var _p11 = _p9._1;
			var _p10 = _p9._0;
			return A2(
				add,
				A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p12, _p10),
				A2(
					add,
					A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p11, _p12),
					A2(
						add,
						A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$canonicalize, _p10, _p11),
						edgeDict)));
		});
	return A3(
		_elm_lang$core$List$foldl,
		addEdges,
		_elm_lang$core$Dict$empty,
		_ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices(mesh));
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$vertices = function (_p13) {
	var _p14 = _p13;
	return _p14._0.vertices;
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex = F2(
	function (index, mesh) {
		return A2(
			_Skinney$elm_array_exploration$Array_Hamt$get,
			index,
			_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertices(mesh));
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$faceVertices = function (mesh) {
	var toFace = function (_p15) {
		var _p16 = _p15;
		return A4(
			_elm_lang$core$Maybe$map3,
			F3(
				function (v0, v1, v2) {
					return {ctor: '_Tuple3', _0: v0, _1: v1, _2: v2};
				}),
			A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p16._0, mesh),
			A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p16._1, mesh),
			A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p16._2, mesh));
	};
	return A2(
		_elm_lang$core$List$filterMap,
		toFace,
		_ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices(mesh));
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$edgeVertices = function (mesh) {
	var toEdge = function (_p17) {
		var _p18 = _p17;
		return A3(
			_elm_lang$core$Maybe$map2,
			F2(
				function (v0, v1) {
					return {ctor: '_Tuple2', _0: v0, _1: v1};
				}),
			A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p18._0, mesh),
			A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p18._1, mesh));
	};
	return A2(
		_elm_lang$core$List$filterMap,
		toEdge,
		_ianmackenzie$elm_triangular_mesh$TriangularMesh$edgeIndices(mesh));
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$openEdges = function (mesh) {
	var prependTo = F3(
		function (accumulated, firstVertex, secondVertex) {
			return {
				ctor: '::',
				_0: {ctor: '_Tuple2', _0: firstVertex, _1: secondVertex},
				_1: accumulated
			};
		});
	var prependIfOpen = F3(
		function (_p19, edgeCount, accumulated) {
			var _p20 = _p19;
			return _elm_lang$core$Native_Utils.eq(edgeCount, 1) ? A2(
				_elm_lang$core$Maybe$withDefault,
				accumulated,
				A3(
					_elm_lang$core$Maybe$map2,
					prependTo(accumulated),
					A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p20._0, mesh),
					A2(_ianmackenzie$elm_triangular_mesh$TriangularMesh$vertex, _p20._1, mesh))) : accumulated;
		});
	return A3(
		_elm_lang$core$Dict$foldr,
		prependIfOpen,
		{ctor: '[]'},
		_ianmackenzie$elm_triangular_mesh$TriangularMesh$edgeFaceCounts(mesh));
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh = function (a) {
	return {ctor: 'TriangularMesh', _0: a};
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$empty = _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
	{
		vertices: _Skinney$elm_array_exploration$Array_Hamt$empty,
		faceIndices: {ctor: '[]'}
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$indexed = F2(
	function (vertices, faceIndices) {
		var numVertices = _Skinney$elm_array_exploration$Array_Hamt$length(vertices);
		var validIndices = function (_p21) {
			var _p22 = _p21;
			var _p25 = _p22._2;
			var _p24 = _p22._1;
			var _p23 = _p22._0;
			return ((_elm_lang$core$Native_Utils.cmp(_p23, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(_p23, numVertices) < 0)) && (((_elm_lang$core$Native_Utils.cmp(_p24, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(_p24, numVertices) < 0)) && ((_elm_lang$core$Native_Utils.cmp(_p25, 0) > -1) && (_elm_lang$core$Native_Utils.cmp(_p25, numVertices) < 0)));
		};
		return A2(_elm_lang$core$List$all, validIndices, faceIndices) ? _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
			{vertices: vertices, faceIndices: faceIndices}) : _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
			{
				vertices: vertices,
				faceIndices: A2(_elm_lang$core$List$filter, validIndices, faceIndices)
			});
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$triangles = function (faceVertices) {
	return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
		{
			vertices: _Skinney$elm_array_exploration$Array_Hamt$fromList(
				_elm_lang$core$List$concat(
					A2(
						_elm_lang$core$List$map,
						function (_p26) {
							var _p27 = _p26;
							return {
								ctor: '::',
								_0: _p27._0,
								_1: {
									ctor: '::',
									_0: _p27._1,
									_1: {
										ctor: '::',
										_0: _p27._2,
										_1: {ctor: '[]'}
									}
								}
							};
						},
						faceVertices))),
			faceIndices: A2(
				_elm_lang$core$List$map,
				function (i) {
					return {ctor: '_Tuple3', _0: 3 * i, _1: (3 * i) + 1, _2: (3 * i) + 2};
				},
				A2(
					_elm_lang$core$List$range,
					0,
					_elm_lang$core$List$length(faceVertices) - 1))
		});
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$fan = F2(
	function (origin, vertices) {
		var _p28 = vertices;
		if ((_p28.ctor === '::') && (_p28._1.ctor === '::')) {
			return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
				{
					vertices: _Skinney$elm_array_exploration$Array_Hamt$fromList(
						{ctor: '::', _0: origin, _1: vertices}),
					faceIndices: A2(
						_elm_lang$core$List$map,
						function (i) {
							return {ctor: '_Tuple3', _0: 0, _1: 1 + i, _2: 2 + i};
						},
						A2(
							_elm_lang$core$List$range,
							0,
							_elm_lang$core$List$length(_p28._1._1)))
				});
		} else {
			return _ianmackenzie$elm_triangular_mesh$TriangularMesh$empty;
		}
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$strip = F2(
	function (bottom, top) {
		var pairs = A3(
			_elm_lang$core$List$map2,
			F2(
				function (v0, v1) {
					return {ctor: '_Tuple2', _0: v0, _1: v1};
				}),
			bottom,
			top);
		var numPairs = _elm_lang$core$List$length(pairs);
		if (_elm_lang$core$Native_Utils.cmp(numPairs, 2) > -1) {
			var faceIndices = _elm_lang$core$List$concat(
				A2(
					_elm_lang$core$List$map,
					function (i) {
						return {
							ctor: '::',
							_0: {ctor: '_Tuple3', _0: 2 * i, _1: (2 * i) + 2, _2: (2 * i) + 3},
							_1: {
								ctor: '::',
								_0: {ctor: '_Tuple3', _0: 2 * i, _1: (2 * i) + 3, _2: (2 * i) + 1},
								_1: {ctor: '[]'}
							}
						};
					},
					A2(_elm_lang$core$List$range, 0, numPairs - 2)));
			var vertices = _Skinney$elm_array_exploration$Array_Hamt$fromList(
				_elm_lang$core$List$concat(
					A2(
						_elm_lang$core$List$map,
						function (_p29) {
							var _p30 = _p29;
							return {
								ctor: '::',
								_0: _p30._0,
								_1: {
									ctor: '::',
									_0: _p30._1,
									_1: {ctor: '[]'}
								}
							};
						},
						pairs)));
			return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
				{vertices: vertices, faceIndices: faceIndices});
		} else {
			return _ianmackenzie$elm_triangular_mesh$TriangularMesh$empty;
		}
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$mapVertices = F2(
	function ($function, _p31) {
		var _p32 = _p31;
		return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
			{
				vertices: A2(_Skinney$elm_array_exploration$Array_Hamt$map, $function, _p32._0.vertices),
				faceIndices: _p32._0.faceIndices
			});
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$reverseFaceIndices = function (_p33) {
	var _p34 = _p33;
	return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
		{
			vertices: _p34._0.vertices,
			faceIndices: _elm_lang$core$List$reverse(_p34._0.faceIndices)
		});
};
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$addMesh = F2(
	function (mesh, accumulated) {
		var accumulatedFaceIndices = _ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices(accumulated);
		var accumulatedVertices = _ianmackenzie$elm_triangular_mesh$TriangularMesh$vertices(accumulated);
		var offset = _Skinney$elm_array_exploration$Array_Hamt$length(accumulatedVertices);
		var prependFace = F2(
			function (_p35, accumulatedFaces) {
				var _p36 = _p35;
				return {
					ctor: '::',
					_0: {ctor: '_Tuple3', _0: _p36._0 + offset, _1: _p36._1 + offset, _2: _p36._2 + offset},
					_1: accumulatedFaces
				};
			});
		var meshFaceIndices = _ianmackenzie$elm_triangular_mesh$TriangularMesh$faceIndices(mesh);
		var combinedFaceIndices = A3(_elm_lang$core$List$foldl, prependFace, accumulatedFaceIndices, meshFaceIndices);
		var meshVertices = _ianmackenzie$elm_triangular_mesh$TriangularMesh$vertices(mesh);
		return _ianmackenzie$elm_triangular_mesh$TriangularMesh$TriangularMesh(
			{
				vertices: A2(_Skinney$elm_array_exploration$Array_Hamt$append, accumulatedVertices, meshVertices),
				faceIndices: combinedFaceIndices
			});
	});
var _ianmackenzie$elm_triangular_mesh$TriangularMesh$combine = function (meshes) {
	var _p37 = meshes;
	if (_p37.ctor === '::') {
		return _ianmackenzie$elm_triangular_mesh$TriangularMesh$reverseFaceIndices(
			A3(
				_elm_lang$core$List$foldl,
				_ianmackenzie$elm_triangular_mesh$TriangularMesh$addMesh,
				_ianmackenzie$elm_triangular_mesh$TriangularMesh$reverseFaceIndices(_p37._0),
				_p37._1));
	} else {
		return _ianmackenzie$elm_triangular_mesh$TriangularMesh$empty;
	}
};

var _ianmackenzie$acorn_demo$Polygon2d_Monotone$startNewLeftChain = F2(
	function (vertex, state) {
		var collectFaces = F3(
			function (firstVertex, otherVertices, accumulated) {
				collectFaces:
				while (true) {
					var _p0 = otherVertices;
					if (_p0.ctor === '[]') {
						var newFace = {ctor: '_Tuple3', _0: vertex.index, _1: firstVertex.index, _2: state.chainStart.index};
						return {ctor: '::', _0: newFace, _1: accumulated};
					} else {
						var _p1 = _p0._0;
						var newFace = {ctor: '_Tuple3', _0: vertex.index, _1: firstVertex.index, _2: _p1.index};
						var _v1 = _p1,
							_v2 = _p0._1,
							_v3 = {ctor: '::', _0: newFace, _1: accumulated};
						firstVertex = _v1;
						otherVertices = _v2;
						accumulated = _v3;
						continue collectFaces;
					}
				}
			});
		return {
			chainStart: state.chainEnd,
			chainInterior: {ctor: '[]'},
			chainEnd: vertex,
			faces: A3(collectFaces, state.chainEnd, state.chainInterior, state.faces)
		};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$startNewRightChain = F2(
	function (vertex, state) {
		var collectFaces = F3(
			function (firstVertex, otherVertices, accumulated) {
				collectFaces:
				while (true) {
					var _p2 = otherVertices;
					if (_p2.ctor === '[]') {
						var newFace = {ctor: '_Tuple3', _0: firstVertex.index, _1: vertex.index, _2: state.chainStart.index};
						return {ctor: '::', _0: newFace, _1: accumulated};
					} else {
						var _p3 = _p2._0;
						var newFace = {ctor: '_Tuple3', _0: firstVertex.index, _1: vertex.index, _2: _p3.index};
						var _v5 = _p3,
							_v6 = _p2._1,
							_v7 = {ctor: '::', _0: newFace, _1: accumulated};
						firstVertex = _v5;
						otherVertices = _v6;
						accumulated = _v7;
						continue collectFaces;
					}
				}
			});
		return {
			chainStart: state.chainEnd,
			chainInterior: {ctor: '[]'},
			chainEnd: vertex,
			faces: A3(collectFaces, state.chainEnd, state.chainInterior, state.faces)
		};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$signedArea = F3(
	function (first, second, third) {
		return _ianmackenzie$acorn_demo$Triangle2d$counterclockwiseArea(
			_ianmackenzie$acorn_demo$Triangle2d$fromVertices(
				{ctor: '_Tuple3', _0: first.position, _1: second.position, _2: third.position}));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$addLeftChainVertex = F2(
	function (vertex, state) {
		addLeftChainVertex:
		while (true) {
			var _p4 = state.chainInterior;
			if (_p4.ctor === '[]') {
				if (_elm_lang$core$Native_Utils.cmp(
					A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$signedArea, state.chainStart, state.chainEnd, vertex),
					0) > 0) {
					var newFace = {ctor: '_Tuple3', _0: state.chainStart.index, _1: state.chainEnd.index, _2: vertex.index};
					return {
						chainStart: state.chainStart,
						chainInterior: {ctor: '[]'},
						chainEnd: vertex,
						faces: {ctor: '::', _0: newFace, _1: state.faces}
					};
				} else {
					return {
						chainStart: state.chainStart,
						chainInterior: {
							ctor: '::',
							_0: state.chainEnd,
							_1: {ctor: '[]'}
						},
						chainEnd: vertex,
						faces: state.faces
					};
				}
			} else {
				var _p5 = _p4._0;
				if (_elm_lang$core$Native_Utils.cmp(
					A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$signedArea, _p5, state.chainEnd, vertex),
					0) > 0) {
					var newFace = {ctor: '_Tuple3', _0: _p5.index, _1: state.chainEnd.index, _2: vertex.index};
					var _v9 = vertex,
						_v10 = {
						chainStart: state.chainStart,
						chainInterior: _p4._1,
						chainEnd: _p5,
						faces: {ctor: '::', _0: newFace, _1: state.faces}
					};
					vertex = _v9;
					state = _v10;
					continue addLeftChainVertex;
				} else {
					return {
						chainStart: state.chainStart,
						chainInterior: {ctor: '::', _0: state.chainEnd, _1: state.chainInterior},
						chainEnd: vertex,
						faces: state.faces
					};
				}
			}
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$addRightChainVertex = F2(
	function (vertex, state) {
		addRightChainVertex:
		while (true) {
			var _p6 = state.chainInterior;
			if (_p6.ctor === '[]') {
				if (_elm_lang$core$Native_Utils.cmp(
					A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$signedArea, vertex, state.chainEnd, state.chainStart),
					0) > 0) {
					var newFace = {ctor: '_Tuple3', _0: vertex.index, _1: state.chainEnd.index, _2: state.chainStart.index};
					return {
						chainStart: state.chainStart,
						chainInterior: {ctor: '[]'},
						chainEnd: vertex,
						faces: {ctor: '::', _0: newFace, _1: state.faces}
					};
				} else {
					return {
						chainStart: state.chainStart,
						chainInterior: {
							ctor: '::',
							_0: state.chainEnd,
							_1: {ctor: '[]'}
						},
						chainEnd: vertex,
						faces: state.faces
					};
				}
			} else {
				var _p7 = _p6._0;
				if (_elm_lang$core$Native_Utils.cmp(
					A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$signedArea, vertex, state.chainEnd, _p7),
					0) > 0) {
					var newFace = {ctor: '_Tuple3', _0: vertex.index, _1: state.chainEnd.index, _2: _p7.index};
					var _v12 = vertex,
						_v13 = {
						chainStart: state.chainStart,
						chainInterior: _p6._1,
						chainEnd: _p7,
						faces: {ctor: '::', _0: newFace, _1: state.faces}
					};
					vertex = _v12;
					state = _v13;
					continue addRightChainVertex;
				} else {
					return {
						chainStart: state.chainStart,
						chainInterior: {ctor: '::', _0: state.chainEnd, _1: state.chainInterior},
						chainEnd: vertex,
						faces: state.faces
					};
				}
			}
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$testPolygon = function () {
	var loop = _elm_lang$core$List$map(_ianmackenzie$acorn_demo$Point2d$fromCoordinates);
	var outerLoop = loop(
		{
			ctor: '::',
			_0: {ctor: '_Tuple2', _0: 0, _1: 0},
			_1: {
				ctor: '::',
				_0: {ctor: '_Tuple2', _0: 5, _1: 0},
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: 5, _1: 3},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 0, _1: 3},
						_1: {ctor: '[]'}
					}
				}
			}
		});
	var innerLoops = {
		ctor: '::',
		_0: loop(
			{
				ctor: '::',
				_0: {ctor: '_Tuple2', _0: 1, _1: 2},
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: 2, _1: 2},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 2, _1: 1},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 1, _1: 1},
							_1: {ctor: '[]'}
						}
					}
				}
			}),
		_1: {
			ctor: '::',
			_0: loop(
				{
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: 3, _1: 2},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 4, _1: 1.5},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 3, _1: 1},
							_1: {ctor: '[]'}
						}
					}
				}),
			_1: {ctor: '[]'}
		}
	};
	return _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d(
		{outerLoop: outerLoop, innerLoops: innerLoops});
}();
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$getLeftEdge = F2(
	function (point, state) {
		return A2(_ianmackenzie$acorn_demo$Polygon2d_EdgeSet$leftOf, point, state.edgeSet);
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf = F2(
	function (edgeIndex, state) {
		return A2(_elm_lang$core$Dict$get, edgeIndex, state.helpers);
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$setNextEdge = F2(
	function (index, edge) {
		return _elm_lang$core$Native_Utils.update(
			edge,
			{nextEdgeIndex: index});
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$setPreviousEdge = F2(
	function (index, edge) {
		return _elm_lang$core$Native_Utils.update(
			edge,
			{previousEdgeIndex: index});
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$updateAt = F3(
	function (index, $function, array) {
		var _p8 = A2(_Skinney$elm_array_exploration$Array_Hamt$get, index, array);
		if (_p8.ctor === 'Just') {
			return A3(
				_Skinney$elm_array_exploration$Array_Hamt$set,
				index,
				$function(_p8._0),
				array);
		} else {
			return array;
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf = F3(
	function (edgeIndex, helperVertex, state) {
		return _elm_lang$core$Native_Utils.update(
			state,
			{
				helpers: A3(_elm_lang$core$Dict$insert, edgeIndex, helperVertex, state.helpers)
			});
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$error = function (defaultValue) {
	var _p9 = A2(_elm_lang$core$Debug$log, 'ERROR: please file a bug report at https://github.com/ianmackenzie/elm-geometry/issues', 'Internal error in Polygon2d.Monotone module');
	return defaultValue;
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo = F2(
	function (defaultValue, maybeValue) {
		var _p10 = maybeValue;
		if (_p10.ctor === 'Just') {
			return _p10._0;
		} else {
			return _ianmackenzie$acorn_demo$Polygon2d_Monotone$error(defaultValue);
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal = F3(
	function (vertexIndex, helperVertex, state) {
		var n = _Skinney$elm_array_exploration$Array_Hamt$length(state.edges);
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			{ctor: '_Tuple2', _0: state, _1: -1},
			A5(
				_elm_lang$core$Maybe$map4,
				F4(
					function (vi, vj, ei, ej) {
						return {
							ctor: '_Tuple2',
							_0: _elm_lang$core$Native_Utils.update(
								state,
								{
									edges: A2(
										_Skinney$elm_array_exploration$Array_Hamt$push,
										{startVertexIndex: helperVertex.index, endVertexIndex: vertexIndex, previousEdgeIndex: ej.previousEdgeIndex, nextEdgeIndex: vertexIndex},
										A2(
											_Skinney$elm_array_exploration$Array_Hamt$push,
											{startVertexIndex: vertexIndex, endVertexIndex: helperVertex.index, previousEdgeIndex: ei.previousEdgeIndex, nextEdgeIndex: helperVertex.outgoingEdgeIndex},
											A3(
												_ianmackenzie$acorn_demo$Polygon2d_Monotone$updateAt,
												ej.previousEdgeIndex,
												_ianmackenzie$acorn_demo$Polygon2d_Monotone$setNextEdge(n + 1),
												A3(
													_ianmackenzie$acorn_demo$Polygon2d_Monotone$updateAt,
													ei.previousEdgeIndex,
													_ianmackenzie$acorn_demo$Polygon2d_Monotone$setNextEdge(n),
													A3(
														_ianmackenzie$acorn_demo$Polygon2d_Monotone$updateAt,
														helperVertex.outgoingEdgeIndex,
														_ianmackenzie$acorn_demo$Polygon2d_Monotone$setPreviousEdge(n),
														A3(
															_ianmackenzie$acorn_demo$Polygon2d_Monotone$updateAt,
															vertexIndex,
															_ianmackenzie$acorn_demo$Polygon2d_Monotone$setPreviousEdge(n + 1),
															state.edges))))))
								}),
							_1: n
						};
					}),
				A2(_Skinney$elm_array_exploration$Array_Hamt$get, vertexIndex, state.vertices),
				A2(_Skinney$elm_array_exploration$Array_Hamt$get, helperVertex.index, state.vertices),
				A2(_Skinney$elm_array_exploration$Array_Hamt$get, vertexIndex, state.edges),
				A2(_Skinney$elm_array_exploration$Array_Hamt$get, helperVertex.outgoingEdgeIndex, state.edges)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge = F2(
	function (index, state) {
		return A2(_Skinney$elm_array_exploration$Array_Hamt$get, index, state.edges);
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$buildLoop = F5(
	function (state, points, startIndex, currentIndex, _p11) {
		buildLoop:
		while (true) {
			var _p12 = _p11;
			var _p16 = _p12._0;
			var _p13 = A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge, currentIndex, state);
			if (_p13.ctor === 'Just') {
				var _p15 = _p13._0;
				var _p14 = A2(_Skinney$elm_array_exploration$Array_Hamt$get, _p15.startVertexIndex, points);
				if (_p14.ctor === 'Just') {
					var nextIndex = _p15.nextEdgeIndex;
					var newVertex = {index: _p15.startVertexIndex, position: _p14._0, nextVertexIndex: _p15.endVertexIndex};
					var newAccumulated = {ctor: '::', _0: newVertex, _1: _p12._1};
					var updatedEdgeIndices = A2(_elm_lang$core$Set$insert, currentIndex, _p16);
					if (_elm_lang$core$Native_Utils.eq(nextIndex, startIndex)) {
						return {
							ctor: '_Tuple2',
							_0: updatedEdgeIndices,
							_1: _elm_lang$core$List$reverse(newAccumulated)
						};
					} else {
						var _v19 = state,
							_v20 = points,
							_v21 = startIndex,
							_v22 = nextIndex,
							_v23 = {ctor: '_Tuple2', _0: updatedEdgeIndices, _1: newAccumulated};
						state = _v19;
						points = _v20;
						startIndex = _v21;
						currentIndex = _v22;
						_p11 = _v23;
						continue buildLoop;
					}
				} else {
					return _ianmackenzie$acorn_demo$Polygon2d_Monotone$error(
						{
							ctor: '_Tuple2',
							_0: _p16,
							_1: {ctor: '[]'}
						});
				}
			} else {
				return _ianmackenzie$acorn_demo$Polygon2d_Monotone$error(
					{
						ctor: '_Tuple2',
						_0: _p16,
						_1: {ctor: '[]'}
					});
			}
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$collectMonotoneLoops = function (state) {
	var allEdgeIndices = A2(
		_elm_lang$core$List$range,
		0,
		_Skinney$elm_array_exploration$Array_Hamt$length(state.edges) - 1);
	var points = A2(
		_Skinney$elm_array_exploration$Array_Hamt$map,
		function (_) {
			return _.position;
		},
		state.vertices);
	var processStartEdge = F2(
		function (index, accumulated) {
			var _p17 = accumulated;
			var processedEdgeIndices = _p17._0;
			var accumulatedLoops = _p17._1;
			if (A2(_elm_lang$core$Set$member, index, processedEdgeIndices)) {
				return accumulated;
			} else {
				var _p18 = A5(
					_ianmackenzie$acorn_demo$Polygon2d_Monotone$buildLoop,
					state,
					points,
					index,
					index,
					{
						ctor: '_Tuple2',
						_0: processedEdgeIndices,
						_1: {ctor: '[]'}
					});
				var updatedEdgeIndices = _p18._0;
				var loop = _p18._1;
				return {
					ctor: '_Tuple2',
					_0: updatedEdgeIndices,
					_1: {ctor: '::', _0: loop, _1: accumulatedLoops}
				};
			}
		});
	var _p19 = A3(
		_elm_lang$core$List$foldl,
		processStartEdge,
		{
			ctor: '_Tuple2',
			_0: _elm_lang$core$Set$empty,
			_1: {ctor: '[]'}
		},
		allEdgeIndices);
	var loops = _p19._1;
	return {ctor: '_Tuple2', _0: points, _1: loops};
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$getVertex = F2(
	function (index, state) {
		return A2(_Skinney$elm_array_exploration$Array_Hamt$get, index, state.vertices);
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$processLeftEdge = F3(
	function (insertOrRemove, edgeIndex, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (edge) {
					return A3(
						_elm_lang$core$Maybe$map2,
						F2(
							function (startVertex, endVertex) {
								var lineSegment = _ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
									{ctor: '_Tuple2', _0: startVertex.position, _1: endVertex.position});
								return _elm_lang$core$Native_Utils.update(
									state,
									{
										edgeSet: A2(
											insertOrRemove,
											{ctor: '_Tuple2', _0: edgeIndex, _1: lineSegment},
											state.edgeSet)
									});
							}),
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getVertex, edge.startVertexIndex, state),
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getVertex, edge.endVertexIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge, edgeIndex, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$insertLeftEdge = _ianmackenzie$acorn_demo$Polygon2d_Monotone$processLeftEdge(_ianmackenzie$acorn_demo$Polygon2d_EdgeSet$insert);
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$removeLeftEdge = _ianmackenzie$acorn_demo$Polygon2d_Monotone$processLeftEdge(_ianmackenzie$acorn_demo$Polygon2d_EdgeSet$remove);
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleEndVertex = F2(
	function (index, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (edge) {
					return A2(
						_elm_lang$core$Maybe$map,
						function (helperVertex) {
							var diagonalAdded = helperVertex.isMerge ? _elm_lang$core$Tuple$first(
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, helperVertex, state)) : state;
							return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$removeLeftEdge, edge.previousEdgeIndex, diagonalAdded);
						},
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, edge.previousEdgeIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge, index, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$accumulateDistinctPoints = F3(
	function (previousPoint, points, accumulatedPoints) {
		accumulateDistinctPoints:
		while (true) {
			var _p20 = points;
			if (_p20.ctor === '[]') {
				return accumulatedPoints;
			} else {
				var _p21 = _p20._0;
				var updatedPoints = _elm_lang$core$Native_Utils.eq(_p21, previousPoint) ? accumulatedPoints : {ctor: '::', _0: _p21, _1: accumulatedPoints};
				var _v25 = _p21,
					_v26 = _p20._1,
					_v27 = updatedPoints;
				previousPoint = _v25;
				points = _v26;
				accumulatedPoints = _v27;
				continue accumulateDistinctPoints;
			}
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$removeDuplicates = function (points) {
	var _p22 = points;
	if (_p22.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		var _p24 = _p22._0;
		var accumulatedPoints = A3(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$accumulateDistinctPoints,
			_p24,
			_p22._1,
			{ctor: '[]'});
		var _p23 = accumulatedPoints;
		if (_p23.ctor === '::') {
			return _elm_lang$core$Native_Utils.eq(_p23._0, _p24) ? {
				ctor: '::',
				_0: _p24,
				_1: _elm_lang$core$List$reverse(_p23._1)
			} : {
				ctor: '::',
				_0: _p24,
				_1: _elm_lang$core$List$reverse(accumulatedPoints)
			};
		} else {
			return {
				ctor: '::',
				_0: _p24,
				_1: {ctor: '[]'}
			};
		}
	}
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$leftTurn = F3(
	function (p1, p2, p3) {
		var _p25 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
		var x3 = _p25._0;
		var y3 = _p25._1;
		var _p26 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
		var x2 = _p26._0;
		var y2 = _p26._1;
		var _p27 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
		var x1 = _p27._0;
		var y1 = _p27._1;
		return _elm_lang$core$Native_Utils.cmp(((x2 - x1) * (y3 - y2)) - ((y2 - y1) * (x3 - x2)), 0) > 0;
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$comparePoints = F2(
	function (p1, p2) {
		var _p28 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
		var x2 = _p28._0;
		var y2 = _p28._1;
		var _p29 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
		var x1 = _p29._0;
		var y1 = _p29._1;
		return (_elm_lang$core$Native_Utils.cmp(y1, y2) < 0) ? _elm_lang$core$Basics$LT : ((_elm_lang$core$Native_Utils.cmp(y1, y2) > 0) ? _elm_lang$core$Basics$GT : A2(_elm_lang$core$Basics$compare, x2, x1));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$faces = function (vertices) {
	var sortedVertices = A2(
		_elm_lang$core$List$sortWith,
		F2(
			function (first, second) {
				return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$comparePoints, second.position, first.position);
			}),
		vertices);
	var _p30 = sortedVertices;
	if (_p30.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		if (_p30._1.ctor === '[]') {
			return {ctor: '[]'};
		} else {
			var processVertex = F2(
				function (vertex, state) {
					return _elm_lang$core$Native_Utils.eq(vertex.nextVertexIndex, state.chainStart.index) ? A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$startNewRightChain, vertex, state) : (_elm_lang$core$Native_Utils.eq(state.chainStart.nextVertexIndex, vertex.index) ? A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$startNewLeftChain, vertex, state) : (_elm_lang$core$Native_Utils.eq(vertex.nextVertexIndex, state.chainEnd.index) ? A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addRightChainVertex, vertex, state) : (_elm_lang$core$Native_Utils.eq(state.chainEnd.nextVertexIndex, vertex.index) ? A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addLeftChainVertex, vertex, state) : _ianmackenzie$acorn_demo$Polygon2d_Monotone$error(state))));
				});
			var initialState = {
				chainStart: _p30._0,
				chainInterior: {ctor: '[]'},
				chainEnd: _p30._1._0,
				faces: {ctor: '[]'}
			};
			return function (_) {
				return _.faces;
			}(
				A3(_elm_lang$core$List$foldl, processVertex, initialState, _p30._1._1));
		}
	}
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Vertex = F2(
	function (a, b) {
		return {position: a, kind: b};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Edge = F4(
	function (a, b, c, d) {
		return {startVertexIndex: a, endVertexIndex: b, nextEdgeIndex: c, previousEdgeIndex: d};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Loops = F2(
	function (a, b) {
		return {vertices: a, edges: b};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex = F3(
	function (a, b, c) {
		return {index: a, outgoingEdgeIndex: b, isMerge: c};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleStartVertex = F2(
	function (index, state) {
		return A3(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
			index,
			A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, index, false),
			A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$insertLeftEdge, index, state));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleSplitVertex = F3(
	function (index, point, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (edgeIndex) {
					return A2(
						_elm_lang$core$Maybe$map,
						function (helperVertex) {
							var _p31 = A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, helperVertex, state);
							var updatedState = _p31._0;
							var outgoingEdgeIndex = _p31._1;
							return A3(
								_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
								index,
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, index, false),
								A2(
									_ianmackenzie$acorn_demo$Polygon2d_Monotone$insertLeftEdge,
									index,
									A3(
										_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
										edgeIndex,
										A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, outgoingEdgeIndex, false),
										updatedState)));
						},
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, edgeIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getLeftEdge, point, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleMergeVertex = F3(
	function (index, point, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (edge) {
					return A2(
						_elm_lang$core$Maybe$andThen,
						function (rightHelper) {
							var rightDiagonalAdded = rightHelper.isMerge ? _elm_lang$core$Tuple$first(
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, rightHelper, state)) : state;
							var rightUpdated = A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$removeLeftEdge, edge.previousEdgeIndex, rightDiagonalAdded);
							return A2(
								_elm_lang$core$Maybe$andThen,
								function (leftEdgeIndex) {
									return A2(
										_elm_lang$core$Maybe$map,
										function (leftHelper) {
											var _p32 = leftHelper.isMerge ? A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, leftHelper, rightUpdated) : {ctor: '_Tuple2', _0: rightUpdated, _1: index};
											var leftDiagonalAdded = _p32._0;
											var leftOutgoing = _p32._1;
											return A3(
												_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
												leftEdgeIndex,
												A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, leftOutgoing, true),
												leftDiagonalAdded);
										},
										A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, leftEdgeIndex, state));
								},
								A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getLeftEdge, point, rightUpdated));
						},
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, edge.previousEdgeIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge, index, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleRightVertex = F3(
	function (index, point, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (leftEdgeIndex) {
					return A2(
						_elm_lang$core$Maybe$map,
						function (helperVertex) {
							var _p33 = helperVertex.isMerge ? A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, helperVertex, state) : {ctor: '_Tuple2', _0: state, _1: index};
							var diagonalAdded = _p33._0;
							var outgoingEdgeIndex = _p33._1;
							return A3(
								_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
								leftEdgeIndex,
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, outgoingEdgeIndex, false),
								diagonalAdded);
						},
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, leftEdgeIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getLeftEdge, point, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$handleLeftVertex = F2(
	function (index, state) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d_Monotone$defaultTo,
			state,
			A2(
				_elm_lang$core$Maybe$andThen,
				function (edge) {
					return A2(
						_elm_lang$core$Maybe$map,
						function (helperVertex) {
							var diagonalAdded = helperVertex.isMerge ? _elm_lang$core$Tuple$first(
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$addDiagonal, index, helperVertex, state)) : state;
							return A3(
								_ianmackenzie$acorn_demo$Polygon2d_Monotone$setHelperOf,
								index,
								A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$HelperVertex, index, index, false),
								A2(
									_ianmackenzie$acorn_demo$Polygon2d_Monotone$insertLeftEdge,
									index,
									A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$removeLeftEdge, edge.previousEdgeIndex, diagonalAdded)));
						},
						A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getHelperOf, edge.previousEdgeIndex, state));
				},
				A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$getEdge, index, state)));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$State = F4(
	function (a, b, c, d) {
		return {edgeSet: a, helpers: b, vertices: c, edges: d};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$MonotoneVertex = F3(
	function (a, b, c) {
		return {index: a, position: b, nextVertexIndex: c};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$TriangulationState = F4(
	function (a, b, c, d) {
		return {chainStart: a, chainInterior: b, chainEnd: c, faces: d};
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Merge = {ctor: 'Merge'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Split = {ctor: 'Split'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Right = {ctor: 'Right'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Left = {ctor: 'Left'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$End = {ctor: 'End'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$Start = {ctor: 'Start'};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$kind = F3(
	function (previous, current, next) {
		var compareToNext = A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$comparePoints, current, next);
		var compareToPrevious = A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$comparePoints, current, previous);
		return (_elm_lang$core$Native_Utils.eq(compareToPrevious, _elm_lang$core$Basics$GT) && _elm_lang$core$Native_Utils.eq(compareToNext, _elm_lang$core$Basics$GT)) ? (A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$leftTurn, previous, current, next) ? _ianmackenzie$acorn_demo$Polygon2d_Monotone$Start : _ianmackenzie$acorn_demo$Polygon2d_Monotone$Split) : ((_elm_lang$core$Native_Utils.eq(compareToPrevious, _elm_lang$core$Basics$LT) && _elm_lang$core$Native_Utils.eq(compareToNext, _elm_lang$core$Basics$LT)) ? (A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$leftTurn, previous, current, next) ? _ianmackenzie$acorn_demo$Polygon2d_Monotone$End : _ianmackenzie$acorn_demo$Polygon2d_Monotone$Merge) : (_elm_lang$core$Native_Utils.eq(compareToPrevious, _elm_lang$core$Basics$GT) ? _ianmackenzie$acorn_demo$Polygon2d_Monotone$Right : _ianmackenzie$acorn_demo$Polygon2d_Monotone$Left));
	});
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$toVertices = function (points) {
	var _p34 = points;
	if (_p34.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		var _p39 = _p34._0;
		var collect = F3(
			function (previousPoint, currentPoints, accumulated) {
				collect:
				while (true) {
					var _p35 = currentPoints;
					if (_p35.ctor === '[]') {
						return {ctor: '[]'};
					} else {
						var _p38 = _p35._1;
						var _p37 = _p35._0;
						var newVertex = {
							position: _p37,
							kind: A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$kind, previousPoint, _p37, _p39)
						};
						var _p36 = _p38;
						if (_p36.ctor === '[]') {
							return _elm_lang$core$List$reverse(
								{ctor: '::', _0: newVertex, _1: accumulated});
						} else {
							var _v34 = _p37,
								_v35 = _p38,
								_v36 = {ctor: '::', _0: newVertex, _1: accumulated};
							previousPoint = _v34;
							currentPoints = _v35;
							accumulated = _v36;
							continue collect;
						}
					}
				}
			});
		var lastPoint = A3(_elm_lang$core$List$foldl, _elm_lang$core$Basics$always, _p39, _p34._1);
		return A3(
			collect,
			lastPoint,
			points,
			{ctor: '[]'});
	}
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$init = function (_p40) {
	var _p41 = _p40;
	var allLoops = A2(
		_elm_lang$core$List$map,
		function (loop) {
			return _ianmackenzie$acorn_demo$Polygon2d_Monotone$removeDuplicates(loop);
		},
		{ctor: '::', _0: _p41._0.outerLoop, _1: _p41._0.innerLoops});
	var vertices = _elm_lang$core$List$concat(
		A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Polygon2d_Monotone$toVertices, allLoops));
	var edges = _elm_lang$core$Tuple$second(
		A3(
			_elm_lang$core$List$foldl,
			F2(
				function (loop, _p42) {
					var _p43 = _p42;
					var _p44 = _p43._0;
					var length = _elm_lang$core$List$length(loop);
					var newEdges = A2(
						_Skinney$elm_array_exploration$Array_Hamt$initialize,
						length,
						function (index) {
							return {
								startVertexIndex: index + _p44,
								endVertexIndex: A2(_elm_lang$core$Basics_ops['%'], index + 1, length) + _p44,
								nextEdgeIndex: A2(_elm_lang$core$Basics_ops['%'], index + 1, length) + _p44,
								previousEdgeIndex: A2(_elm_lang$core$Basics_ops['%'], index - 1, length) + _p44
							};
						});
					return {
						ctor: '_Tuple2',
						_0: _p44 + length,
						_1: A2(_Skinney$elm_array_exploration$Array_Hamt$append, _p43._1, newEdges)
					};
				}),
			{ctor: '_Tuple2', _0: 0, _1: _Skinney$elm_array_exploration$Array_Hamt$empty},
			allLoops));
	return {vertices: vertices, edges: edges};
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$monotonePolygons = function (polygon) {
	var handleVertex = F2(
		function (_p45, current) {
			var _p46 = _p45;
			var _p49 = _p46._1;
			var _p48 = _p46._0;
			var _p47 = _p49.kind;
			switch (_p47.ctor) {
				case 'Start':
					return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleStartVertex, _p48, current);
				case 'End':
					return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleEndVertex, _p48, current);
				case 'Right':
					return A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleRightVertex, _p48, _p49.position, current);
				case 'Left':
					return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleLeftVertex, _p48, current);
				case 'Split':
					return A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleSplitVertex, _p48, _p49.position, current);
				default:
					return A3(_ianmackenzie$acorn_demo$Polygon2d_Monotone$handleMergeVertex, _p48, _p49.position, current);
			}
		});
	var _p50 = _ianmackenzie$acorn_demo$Polygon2d_Monotone$init(polygon);
	var vertices = _p50.vertices;
	var edges = _p50.edges;
	var priorityQueue = A2(
		_elm_lang$core$List$sortWith,
		F2(
			function (_p52, _p51) {
				var _p53 = _p52;
				var _p54 = _p51;
				return A2(_ianmackenzie$acorn_demo$Polygon2d_Monotone$comparePoints, _p54._1.position, _p53._1.position);
			}),
		A2(
			_elm_lang$core$List$indexedMap,
			F2(
				function (i, v) {
					return {ctor: '_Tuple2', _0: i, _1: v};
				}),
			vertices));
	var initialState = {
		edgeSet: _ianmackenzie$acorn_demo$Polygon2d_EdgeSet$empty,
		helpers: _elm_lang$core$Dict$empty,
		vertices: _Skinney$elm_array_exploration$Array_Hamt$fromList(vertices),
		edges: edges
	};
	var finalState = A3(_elm_lang$core$List$foldl, handleVertex, initialState, priorityQueue);
	var vertexArray = _Skinney$elm_array_exploration$Array_Hamt$fromList(vertices);
	return _ianmackenzie$acorn_demo$Polygon2d_Monotone$collectMonotoneLoops(finalState);
};
var _ianmackenzie$acorn_demo$Polygon2d_Monotone$triangulation = function (polygon) {
	var _p55 = _ianmackenzie$acorn_demo$Polygon2d_Monotone$monotonePolygons(polygon);
	var points = _p55._0;
	var loops = _p55._1;
	return A2(
		_ianmackenzie$elm_triangular_mesh$TriangularMesh$indexed,
		points,
		_elm_lang$core$List$concat(
			A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Polygon2d_Monotone$faces, loops)));
};

var _ianmackenzie$acorn_demo$Polygon2d$triangulate = function (polygon) {
	return _ianmackenzie$acorn_demo$Polygon2d_Monotone$triangulation(polygon);
};
var _ianmackenzie$acorn_demo$Polygon2d$loopEdges = function (vertices_) {
	var _p0 = vertices_;
	if (_p0.ctor === '[]') {
		return {ctor: '[]'};
	} else {
		return A3(
			_elm_lang$core$List$map2,
			_ianmackenzie$acorn_demo$LineSegment2d$from,
			_p0,
			A2(
				_elm_lang$core$Basics_ops['++'],
				_p0._1,
				{
					ctor: '::',
					_0: _p0._0,
					_1: {ctor: '[]'}
				}));
	}
};
var _ianmackenzie$acorn_demo$Polygon2d$innerLoops = function (_p1) {
	var _p2 = _p1;
	return _p2._0.innerLoops;
};
var _ianmackenzie$acorn_demo$Polygon2d$outerLoop = function (_p3) {
	var _p4 = _p3;
	return _p4._0.outerLoop;
};
var _ianmackenzie$acorn_demo$Polygon2d$vertices = function (polygon) {
	return _elm_lang$core$List$concat(
		{
			ctor: '::',
			_0: _ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon),
			_1: _ianmackenzie$acorn_demo$Polygon2d$innerLoops(polygon)
		});
};
var _ianmackenzie$acorn_demo$Polygon2d$edges = function (polygon) {
	var innerEdges = A2(
		_elm_lang$core$List$map,
		_ianmackenzie$acorn_demo$Polygon2d$loopEdges,
		_ianmackenzie$acorn_demo$Polygon2d$innerLoops(polygon));
	var outerEdges = _ianmackenzie$acorn_demo$Polygon2d$loopEdges(
		_ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon));
	return _elm_lang$core$List$concat(
		{ctor: '::', _0: outerEdges, _1: innerEdges});
};
var _ianmackenzie$acorn_demo$Polygon2d$perimeter = function (_p5) {
	return _elm_lang$core$List$sum(
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$LineSegment2d$length,
			_ianmackenzie$acorn_demo$Polygon2d$edges(_p5)));
};
var _ianmackenzie$acorn_demo$Polygon2d$mapVertices = F3(
	function ($function, invert, polygon) {
		var mappedInnerLoops = A2(
			_elm_lang$core$List$map,
			_elm_lang$core$List$map($function),
			_ianmackenzie$acorn_demo$Polygon2d$innerLoops(polygon));
		var mappedOuterLoop = A2(
			_elm_lang$core$List$map,
			$function,
			_ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon));
		return invert ? _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d(
			{
				outerLoop: _elm_lang$core$List$reverse(mappedOuterLoop),
				innerLoops: A2(_elm_lang$core$List$map, _elm_lang$core$List$reverse, mappedInnerLoops)
			}) : _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d(
			{outerLoop: mappedOuterLoop, innerLoops: mappedInnerLoops});
	});
var _ianmackenzie$acorn_demo$Polygon2d$scaleAbout = F2(
	function (point, scale) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
			A2(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale),
			_elm_lang$core$Native_Utils.cmp(scale, 0) < 0);
	});
var _ianmackenzie$acorn_demo$Polygon2d$rotateAround = F2(
	function (point, angle) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
			A2(_ianmackenzie$acorn_demo$Point2d$rotateAround, point, angle),
			false);
	});
var _ianmackenzie$acorn_demo$Polygon2d$translateBy = function (vector) {
	return A2(
		_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
		_ianmackenzie$acorn_demo$Point2d$translateBy(vector),
		false);
};
var _ianmackenzie$acorn_demo$Polygon2d$translateIn = F3(
	function (direction, distance, polygon) {
		return A2(
			_ianmackenzie$acorn_demo$Polygon2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			polygon);
	});
var _ianmackenzie$acorn_demo$Polygon2d$mirrorAcross = function (axis) {
	return A2(
		_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
		_ianmackenzie$acorn_demo$Point2d$mirrorAcross(axis),
		true);
};
var _ianmackenzie$acorn_demo$Polygon2d$relativeTo = function (frame) {
	return A2(
		_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
		_ianmackenzie$acorn_demo$Point2d$relativeTo(frame),
		!_ianmackenzie$acorn_demo$Frame2d$isRightHanded(frame));
};
var _ianmackenzie$acorn_demo$Polygon2d$placeIn = function (frame) {
	return A2(
		_ianmackenzie$acorn_demo$Polygon2d$mapVertices,
		_ianmackenzie$acorn_demo$Point2d$placeIn(frame),
		!_ianmackenzie$acorn_demo$Frame2d$isRightHanded(frame));
};
var _ianmackenzie$acorn_demo$Polygon2d$boundingBox = function (polygon) {
	return _ianmackenzie$acorn_demo$BoundingBox2d$containingPoints(
		_ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon));
};
var _ianmackenzie$acorn_demo$Polygon2d$counterclockwiseAround = F3(
	function (origin, a, b) {
		return _elm_lang$core$Native_Utils.cmp(
			A2(
				_ianmackenzie$acorn_demo$Vector2d$crossProduct,
				A2(_ianmackenzie$acorn_demo$Vector2d$from, origin, a),
				A2(_ianmackenzie$acorn_demo$Vector2d$from, origin, b)),
			0) > -1;
	});
var _ianmackenzie$acorn_demo$Polygon2d$chainHelp = F2(
	function (acc, list) {
		chainHelp:
		while (true) {
			var _p6 = {ctor: '_Tuple2', _0: acc, _1: list};
			if (_p6._1.ctor === '::') {
				if ((_p6._0.ctor === '::') && (_p6._0._1.ctor === '::')) {
					var _p9 = _p6._1._1;
					var _p8 = _p6._1._0;
					var _p7 = _p6._0._1._0;
					if (A3(_ianmackenzie$acorn_demo$Polygon2d$counterclockwiseAround, _p7, _p6._0._0, _p8)) {
						var _v4 = {ctor: '::', _0: _p7, _1: _p6._0._1._1},
							_v5 = {ctor: '::', _0: _p8, _1: _p9};
						acc = _v4;
						list = _v5;
						continue chainHelp;
					} else {
						var _v6 = {ctor: '::', _0: _p8, _1: acc},
							_v7 = _p9;
						acc = _v6;
						list = _v7;
						continue chainHelp;
					}
				} else {
					var _v8 = {ctor: '::', _0: _p6._1._0, _1: acc},
						_v9 = _p6._1._1;
					acc = _v8;
					list = _v9;
					continue chainHelp;
				}
			} else {
				return A2(_elm_lang$core$List$drop, 1, acc);
			}
		}
	});
var _ianmackenzie$acorn_demo$Polygon2d$chain = _ianmackenzie$acorn_demo$Polygon2d$chainHelp(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Polygon2d$counterclockwiseArea = function (vertices_) {
	var _p10 = vertices_;
	if (_p10.ctor === '[]') {
		return 0;
	} else {
		if (_p10._1.ctor === '[]') {
			return 0;
		} else {
			if (_p10._1._1.ctor === '[]') {
				return 0;
			} else {
				var _p11 = _p10._1._1;
				var segmentArea = F2(
					function (start, end) {
						return _ianmackenzie$acorn_demo$Triangle2d$counterclockwiseArea(
							_ianmackenzie$acorn_demo$Triangle2d$fromVertices(
								{ctor: '_Tuple3', _0: _p10._0, _1: start, _2: end}));
					});
				var segmentAreas = A3(
					_elm_lang$core$List$map2,
					segmentArea,
					{ctor: '::', _0: _p10._1._0, _1: _p11},
					_p11);
				return _elm_lang$core$List$sum(segmentAreas);
			}
		}
	}
};
var _ianmackenzie$acorn_demo$Polygon2d$makeOuterLoop = function (vertices_) {
	return (_elm_lang$core$Native_Utils.cmp(
		_ianmackenzie$acorn_demo$Polygon2d$counterclockwiseArea(vertices_),
		0) > -1) ? vertices_ : _elm_lang$core$List$reverse(vertices_);
};
var _ianmackenzie$acorn_demo$Polygon2d$singleLoop = function (vertices_) {
	return _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d(
		{
			outerLoop: _ianmackenzie$acorn_demo$Polygon2d$makeOuterLoop(vertices_),
			innerLoops: {ctor: '[]'}
		});
};
var _ianmackenzie$acorn_demo$Polygon2d$convexHull = function (points) {
	var sorted = A2(_elm_lang$core$List$sortBy, _ianmackenzie$acorn_demo$Point2d$coordinates, points);
	var lower = _ianmackenzie$acorn_demo$Polygon2d$chain(sorted);
	var upper = _ianmackenzie$acorn_demo$Polygon2d$chain(
		_elm_lang$core$List$reverse(sorted));
	return _ianmackenzie$acorn_demo$Polygon2d$singleLoop(
		A2(_elm_lang$core$Basics_ops['++'], lower, upper));
};
var _ianmackenzie$acorn_demo$Polygon2d$makeInnerLoop = function (vertices_) {
	return (_elm_lang$core$Native_Utils.cmp(
		_ianmackenzie$acorn_demo$Polygon2d$counterclockwiseArea(vertices_),
		0) < 1) ? vertices_ : _elm_lang$core$List$reverse(vertices_);
};
var _ianmackenzie$acorn_demo$Polygon2d$with = function ($arguments) {
	return _ianmackenzie$acorn_demo$Geometry_Types$Polygon2d(
		{
			outerLoop: _ianmackenzie$acorn_demo$Polygon2d$makeOuterLoop($arguments.outerLoop),
			innerLoops: A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Polygon2d$makeInnerLoop, $arguments.innerLoops)
		});
};
var _ianmackenzie$acorn_demo$Polygon2d$area = function (polygon) {
	return _ianmackenzie$acorn_demo$Polygon2d$counterclockwiseArea(
		_ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon)) + _elm_lang$core$List$sum(
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$Polygon2d$counterclockwiseArea,
			_ianmackenzie$acorn_demo$Polygon2d$innerLoops(polygon)));
};

var _ianmackenzie$acorn_demo$Rectangle2d$dimensions = function (_p0) {
	var _p1 = _p0;
	return _p1._0.dimensions;
};
var _ianmackenzie$acorn_demo$Rectangle2d$area = function (rectangle) {
	var _p2 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle);
	var width = _p2._0;
	var height = _p2._1;
	return width * height;
};
var _ianmackenzie$acorn_demo$Rectangle2d$axes = function (_p3) {
	var _p4 = _p3;
	return _p4._0.axes;
};
var _ianmackenzie$acorn_demo$Rectangle2d$xAxis = function (rectangle) {
	return _ianmackenzie$acorn_demo$Frame2d$xAxis(
		_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle));
};
var _ianmackenzie$acorn_demo$Rectangle2d$yAxis = function (rectangle) {
	return _ianmackenzie$acorn_demo$Frame2d$yAxis(
		_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle));
};
var _ianmackenzie$acorn_demo$Rectangle2d$centerPoint = function (rectangle) {
	return _ianmackenzie$acorn_demo$Frame2d$originPoint(
		_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle));
};
var _ianmackenzie$acorn_demo$Rectangle2d$vertices = function (rectangle) {
	var _p5 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle);
	var width = _p5._0;
	var height = _p5._1;
	var halfWidth = width / 2;
	var halfHeight = height / 2;
	var localFrame = _ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle);
	return {
		ctor: '_Tuple4',
		_0: A2(
			_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
			localFrame,
			{ctor: '_Tuple2', _0: 0 - halfWidth, _1: 0 - halfHeight}),
		_1: A2(
			_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
			localFrame,
			{ctor: '_Tuple2', _0: halfWidth, _1: 0 - halfHeight}),
		_2: A2(
			_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
			localFrame,
			{ctor: '_Tuple2', _0: halfWidth, _1: halfHeight}),
		_3: A2(
			_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
			localFrame,
			{ctor: '_Tuple2', _0: 0 - halfWidth, _1: halfHeight})
	};
};
var _ianmackenzie$acorn_demo$Rectangle2d$edges = function (rectangle) {
	var _p6 = _ianmackenzie$acorn_demo$Rectangle2d$vertices(rectangle);
	var p1 = _p6._0;
	var p2 = _p6._1;
	var p3 = _p6._2;
	var p4 = _p6._3;
	return {
		ctor: '_Tuple4',
		_0: A2(_ianmackenzie$acorn_demo$LineSegment2d$from, p1, p2),
		_1: A2(_ianmackenzie$acorn_demo$LineSegment2d$from, p2, p3),
		_2: A2(_ianmackenzie$acorn_demo$LineSegment2d$from, p3, p4),
		_3: A2(_ianmackenzie$acorn_demo$LineSegment2d$from, p4, p1)
	};
};
var _ianmackenzie$acorn_demo$Rectangle2d$boundingBox = function (rectangle) {
	var _p7 = _ianmackenzie$acorn_demo$Rectangle2d$vertices(rectangle);
	var p1 = _p7._0;
	var p2 = _p7._1;
	var p3 = _p7._2;
	var p4 = _p7._3;
	var _p8 = _ianmackenzie$acorn_demo$Point2d$coordinates(p1);
	var x1 = _p8._0;
	var y1 = _p8._1;
	var _p9 = _ianmackenzie$acorn_demo$Point2d$coordinates(p2);
	var x2 = _p9._0;
	var y2 = _p9._1;
	var _p10 = _ianmackenzie$acorn_demo$Point2d$coordinates(p3);
	var x3 = _p10._0;
	var y3 = _p10._1;
	var _p11 = _ianmackenzie$acorn_demo$Point2d$coordinates(p4);
	var x4 = _p11._0;
	var y4 = _p11._1;
	return _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{
			minX: A2(
				_elm_lang$core$Basics$min,
				A2(_elm_lang$core$Basics$min, x1, x2),
				A2(_elm_lang$core$Basics$min, x3, x4)),
			maxX: A2(
				_elm_lang$core$Basics$max,
				A2(_elm_lang$core$Basics$max, x1, x2),
				A2(_elm_lang$core$Basics$max, x3, x4)),
			minY: A2(
				_elm_lang$core$Basics$min,
				A2(_elm_lang$core$Basics$min, y1, y2),
				A2(_elm_lang$core$Basics$min, y3, y4)),
			maxY: A2(
				_elm_lang$core$Basics$max,
				A2(_elm_lang$core$Basics$max, y1, y2),
				A2(_elm_lang$core$Basics$max, y3, y4))
		});
};
var _ianmackenzie$acorn_demo$Rectangle2d$contains = F2(
	function (point, rectangle) {
		var _p12 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle);
		var width = _p12._0;
		var height = _p12._1;
		var localFrame = _ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle);
		var _p13 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			A2(_ianmackenzie$acorn_demo$Point2d$relativeTo, localFrame, point));
		var x = _p13._0;
		var y = _p13._1;
		return (_elm_lang$core$Native_Utils.cmp(
			_elm_lang$core$Basics$abs(x),
			width / 2) < 1) && (_elm_lang$core$Native_Utils.cmp(
			_elm_lang$core$Basics$abs(y),
			height / 2) < 1);
	});
var _ianmackenzie$acorn_demo$Rectangle2d$scaleAbout = F3(
	function (point, scale, rectangle) {
		var _p14 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle);
		var currentWidth = _p14._0;
		var currentHeight = _p14._1;
		var newWidth = _elm_lang$core$Basics$abs(scale * currentWidth);
		var newHeight = _elm_lang$core$Basics$abs(scale * currentHeight);
		var currentFrame = _ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle);
		var currentXDirection = _ianmackenzie$acorn_demo$Frame2d$xDirection(currentFrame);
		var currentYDirection = _ianmackenzie$acorn_demo$Frame2d$yDirection(currentFrame);
		var newCenterPoint = A3(
			_ianmackenzie$acorn_demo$Point2d$scaleAbout,
			point,
			scale,
			_ianmackenzie$acorn_demo$Frame2d$originPoint(currentFrame));
		var newAxes = (_elm_lang$core$Native_Utils.cmp(scale, 0) > -1) ? _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{originPoint: newCenterPoint, xDirection: currentXDirection, yDirection: currentYDirection}) : _ianmackenzie$acorn_demo$Frame2d$unsafe(
			{
				originPoint: newCenterPoint,
				xDirection: _ianmackenzie$acorn_demo$Direction2d$flip(currentXDirection),
				yDirection: _ianmackenzie$acorn_demo$Direction2d$flip(currentYDirection)
			});
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: newAxes,
				dimensions: {ctor: '_Tuple2', _0: newWidth, _1: newHeight}
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$rotateAround = F2(
	function (point, angle) {
		var rotateFrame = A2(_ianmackenzie$acorn_demo$Frame2d$rotateAround, point, angle);
		return function (rectangle) {
			return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
				{
					axes: rotateFrame(
						_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle)),
					dimensions: _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle)
				});
		};
	});
var _ianmackenzie$acorn_demo$Rectangle2d$translateBy = F2(
	function (displacement, rectangle) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: A2(
					_ianmackenzie$acorn_demo$Frame2d$translateBy,
					displacement,
					_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle)),
				dimensions: _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle)
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$translateIn = F3(
	function (direction, distance, rectangle) {
		return A2(
			_ianmackenzie$acorn_demo$Rectangle2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			rectangle);
	});
var _ianmackenzie$acorn_demo$Rectangle2d$mirrorAcross = F2(
	function (axis, rectangle) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: A2(
					_ianmackenzie$acorn_demo$Frame2d$mirrorAcross,
					axis,
					_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle)),
				dimensions: _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle)
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$placeIn = F2(
	function (frame, rectangle) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: A2(
					_ianmackenzie$acorn_demo$Frame2d$placeIn,
					frame,
					_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle)),
				dimensions: _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle)
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$relativeTo = F2(
	function (frame, rectangle) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: A2(
					_ianmackenzie$acorn_demo$Frame2d$relativeTo,
					frame,
					_ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle)),
				dimensions: _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle)
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$toPolygon = function (rectangle) {
	var _p15 = _ianmackenzie$acorn_demo$Rectangle2d$vertices(rectangle);
	var p1 = _p15._0;
	var p2 = _p15._1;
	var p3 = _p15._2;
	var p4 = _p15._3;
	return _ianmackenzie$acorn_demo$Polygon2d$singleLoop(
		{
			ctor: '::',
			_0: p1,
			_1: {
				ctor: '::',
				_0: p2,
				_1: {
					ctor: '::',
					_0: p3,
					_1: {
						ctor: '::',
						_0: p4,
						_1: {ctor: '[]'}
					}
				}
			}
		});
};
var _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema = function (_p16) {
	var _p17 = _p16;
	var _p19 = _p17.minY;
	var _p18 = _p17.minX;
	var height = _p17.maxY - _p19;
	var midY = _p19 + (0.5 * height);
	var width = _p17.maxX - _p18;
	var midX = _p18 + (0.5 * width);
	var centerPoint = _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
		{ctor: '_Tuple2', _0: midX, _1: midY});
	return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
		{
			axes: _ianmackenzie$acorn_demo$Frame2d$atPoint(centerPoint),
			dimensions: {ctor: '_Tuple2', _0: width, _1: height}
		});
};
var _ianmackenzie$acorn_demo$Rectangle2d$from = F2(
	function (firstPoint, secondPoint) {
		var _p20 = _ianmackenzie$acorn_demo$Point2d$coordinates(secondPoint);
		var x2 = _p20._0;
		var y2 = _p20._1;
		var _p21 = _ianmackenzie$acorn_demo$Point2d$coordinates(firstPoint);
		var x1 = _p21._0;
		var y1 = _p21._1;
		var centerPoint = A2(_ianmackenzie$acorn_demo$Point2d$midpoint, firstPoint, secondPoint);
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: _ianmackenzie$acorn_demo$Frame2d$atPoint(centerPoint),
				dimensions: {
					ctor: '_Tuple2',
					_0: _elm_lang$core$Basics$abs(x2 - x1),
					_1: _elm_lang$core$Basics$abs(y2 - y1)
				}
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$fromExtremaIn = F2(
	function (localFrame, _p22) {
		var _p23 = _p22;
		var _p25 = _p23.minY;
		var _p24 = _p23.minX;
		var height = _p23.maxY - _p25;
		var midY = _p25 + (0.5 * height);
		var width = _p23.maxX - _p24;
		var midX = _p24 + (0.5 * width);
		var centerPoint = A2(
			_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
			localFrame,
			{ctor: '_Tuple2', _0: midX, _1: midY});
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{
				axes: A2(_ianmackenzie$acorn_demo$Frame2d$moveTo, centerPoint, localFrame),
				dimensions: {ctor: '_Tuple2', _0: width, _1: height}
			});
	});
var _ianmackenzie$acorn_demo$Rectangle2d$centeredOn = F2(
	function (axes, dimensions) {
		return _ianmackenzie$acorn_demo$Geometry_Types$Rectangle2d(
			{axes: axes, dimensions: dimensions});
	});

var _ianmackenzie$acorn_demo$Geometry_Svg$placeIn = F2(
	function (frame, element) {
		var _p0 = _ianmackenzie$acorn_demo$Direction2d$components(
			_ianmackenzie$acorn_demo$Frame2d$yDirection(frame));
		var x2 = _p0._0;
		var y2 = _p0._1;
		var _p1 = _ianmackenzie$acorn_demo$Direction2d$components(
			_ianmackenzie$acorn_demo$Frame2d$xDirection(frame));
		var x1 = _p1._0;
		var y1 = _p1._1;
		var _p2 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$Frame2d$originPoint(frame));
		var px = _p2._0;
		var py = _p2._1;
		var components = A2(
			_elm_lang$core$List$map,
			_elm_lang$core$Basics$toString,
			{
				ctor: '::',
				_0: x1,
				_1: {
					ctor: '::',
					_0: y1,
					_1: {
						ctor: '::',
						_0: x2,
						_1: {
							ctor: '::',
							_0: y2,
							_1: {
								ctor: '::',
								_0: px,
								_1: {
									ctor: '::',
									_0: py,
									_1: {ctor: '[]'}
								}
							}
						}
					}
				}
			});
		var transform = A2(
			_elm_lang$core$Basics_ops['++'],
			'matrix(',
			A2(
				_elm_lang$core$Basics_ops['++'],
				A2(_elm_lang$core$String$join, ' ', components),
				')'));
		return A2(
			_elm_lang$svg$Svg$g,
			{
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$transform(transform),
				_1: {ctor: '[]'}
			},
			{
				ctor: '::',
				_0: element,
				_1: {ctor: '[]'}
			});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$relativeTo = function (frame) {
	return _ianmackenzie$acorn_demo$Geometry_Svg$placeIn(
		A2(_ianmackenzie$acorn_demo$Frame2d$relativeTo, frame, _ianmackenzie$acorn_demo$Frame2d$xy));
};
var _ianmackenzie$acorn_demo$Geometry_Svg$mirrorAcross = function (axis) {
	return _ianmackenzie$acorn_demo$Geometry_Svg$placeIn(
		A2(_ianmackenzie$acorn_demo$Frame2d$mirrorAcross, axis, _ianmackenzie$acorn_demo$Frame2d$xy));
};
var _ianmackenzie$acorn_demo$Geometry_Svg$translateBy = F2(
	function (vector, element) {
		var _p3 = _ianmackenzie$acorn_demo$Vector2d$components(vector);
		var x = _p3._0;
		var y = _p3._1;
		var translate = A2(
			_elm_lang$core$Basics_ops['++'],
			'translate(',
			A2(
				_elm_lang$core$Basics_ops['++'],
				_elm_lang$core$Basics$toString(x),
				A2(
					_elm_lang$core$Basics_ops['++'],
					' ',
					A2(
						_elm_lang$core$Basics_ops['++'],
						_elm_lang$core$Basics$toString(y),
						')'))));
		return A2(
			_elm_lang$svg$Svg$g,
			{
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$transform(translate),
				_1: {ctor: '[]'}
			},
			{
				ctor: '::',
				_0: element,
				_1: {ctor: '[]'}
			});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$rotateAround = F3(
	function (point, angle, element) {
		var angleString = _elm_lang$core$Basics$toString(
			_elm_community$basics_extra$Basics_Extra$inDegrees(angle));
		var _p4 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
		var x = _p4._0;
		var y = _p4._1;
		var xString = _elm_lang$core$Basics$toString(x);
		var yString = _elm_lang$core$Basics$toString(y);
		var rotate = A2(
			_elm_lang$core$Basics_ops['++'],
			'rotate(',
			A2(
				_elm_lang$core$Basics_ops['++'],
				angleString,
				A2(
					_elm_lang$core$Basics_ops['++'],
					' ',
					A2(
						_elm_lang$core$Basics_ops['++'],
						xString,
						A2(
							_elm_lang$core$Basics_ops['++'],
							' ',
							A2(_elm_lang$core$Basics_ops['++'], yString, ')'))))));
		return A2(
			_elm_lang$svg$Svg$g,
			{
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$transform(rotate),
				_1: {ctor: '[]'}
			},
			{
				ctor: '::',
				_0: element,
				_1: {ctor: '[]'}
			});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$scaleAbout = F3(
	function (point, scale, element) {
		var _p5 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			A3(_ianmackenzie$acorn_demo$Point2d$scaleAbout, point, scale, _ianmackenzie$acorn_demo$Point2d$origin));
		var px = _p5._0;
		var py = _p5._1;
		var components = A2(
			_elm_lang$core$List$map,
			_elm_lang$core$Basics$toString,
			{
				ctor: '::',
				_0: scale,
				_1: {
					ctor: '::',
					_0: 0,
					_1: {
						ctor: '::',
						_0: 0,
						_1: {
							ctor: '::',
							_0: scale,
							_1: {
								ctor: '::',
								_0: px,
								_1: {
									ctor: '::',
									_0: py,
									_1: {ctor: '[]'}
								}
							}
						}
					}
				}
			});
		var transform = A2(
			_elm_lang$core$Basics_ops['++'],
			'matrix(',
			A2(
				_elm_lang$core$Basics_ops['++'],
				A2(_elm_lang$core$String$join, ' ', components),
				')'));
		return A2(
			_elm_lang$svg$Svg$g,
			{
				ctor: '::',
				_0: _elm_lang$svg$Svg_Attributes$transform(transform),
				_1: {ctor: '[]'}
			},
			{
				ctor: '::',
				_0: element,
				_1: {ctor: '[]'}
			});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$boundingBox2d = F2(
	function (attributes, boundingBox) {
		var _p6 = _ianmackenzie$acorn_demo$BoundingBox2d$extrema(boundingBox);
		var minX = _p6.minX;
		var minY = _p6.minY;
		var maxX = _p6.maxX;
		var maxY = _p6.maxY;
		var x = _elm_lang$svg$Svg_Attributes$x(
			_elm_lang$core$Basics$toString(minX));
		var y = _elm_lang$svg$Svg_Attributes$y(
			_elm_lang$core$Basics$toString(minY));
		var width = _elm_lang$svg$Svg_Attributes$width(
			_elm_lang$core$Basics$toString(maxX - minX));
		var height = _elm_lang$svg$Svg_Attributes$height(
			_elm_lang$core$Basics$toString(maxY - minY));
		return A2(
			_elm_lang$svg$Svg$rect,
			{
				ctor: '::',
				_0: x,
				_1: {
					ctor: '::',
					_0: y,
					_1: {
						ctor: '::',
						_0: width,
						_1: {ctor: '::', _0: height, _1: attributes}
					}
				}
			},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$cubicSpline2d = F2(
	function (attributes, spline) {
		var _p7 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$CubicSpline2d$endPoint(spline));
		var x4 = _p7._0;
		var y4 = _p7._1;
		var _p8 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$CubicSpline2d$endControlPoint(spline));
		var x3 = _p8._0;
		var y3 = _p8._1;
		var _p9 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$CubicSpline2d$startControlPoint(spline));
		var x2 = _p9._0;
		var y2 = _p9._1;
		var _p10 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$CubicSpline2d$startPoint(spline));
		var x1 = _p10._0;
		var y1 = _p10._1;
		var pathComponents = {
			ctor: '::',
			_0: 'M',
			_1: {
				ctor: '::',
				_0: _elm_lang$core$Basics$toString(x1),
				_1: {
					ctor: '::',
					_0: _elm_lang$core$Basics$toString(y1),
					_1: {
						ctor: '::',
						_0: 'C',
						_1: {
							ctor: '::',
							_0: _elm_lang$core$Basics$toString(x2),
							_1: {
								ctor: '::',
								_0: _elm_lang$core$Basics$toString(y2),
								_1: {
									ctor: '::',
									_0: _elm_lang$core$Basics$toString(x3),
									_1: {
										ctor: '::',
										_0: _elm_lang$core$Basics$toString(y3),
										_1: {
											ctor: '::',
											_0: _elm_lang$core$Basics$toString(x4),
											_1: {
												ctor: '::',
												_0: _elm_lang$core$Basics$toString(y4),
												_1: {ctor: '[]'}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		};
		var pathAttribute = _elm_lang$svg$Svg_Attributes$d(
			A2(_elm_lang$core$String$join, ' ', pathComponents));
		return A2(
			_elm_lang$svg$Svg$path,
			{ctor: '::', _0: pathAttribute, _1: attributes},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$quadraticSpline2d = F2(
	function (attributes, spline) {
		var _p11 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$QuadraticSpline2d$endPoint(spline));
		var x3 = _p11._0;
		var y3 = _p11._1;
		var _p12 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$QuadraticSpline2d$controlPoint(spline));
		var x2 = _p12._0;
		var y2 = _p12._1;
		var _p13 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$QuadraticSpline2d$startPoint(spline));
		var x1 = _p13._0;
		var y1 = _p13._1;
		var pathComponents = {
			ctor: '::',
			_0: 'M',
			_1: {
				ctor: '::',
				_0: _elm_lang$core$Basics$toString(x1),
				_1: {
					ctor: '::',
					_0: _elm_lang$core$Basics$toString(y1),
					_1: {
						ctor: '::',
						_0: 'Q',
						_1: {
							ctor: '::',
							_0: _elm_lang$core$Basics$toString(x2),
							_1: {
								ctor: '::',
								_0: _elm_lang$core$Basics$toString(y2),
								_1: {
									ctor: '::',
									_0: _elm_lang$core$Basics$toString(x3),
									_1: {
										ctor: '::',
										_0: _elm_lang$core$Basics$toString(y3),
										_1: {ctor: '[]'}
									}
								}
							}
						}
					}
				}
			}
		};
		var pathAttribute = _elm_lang$svg$Svg_Attributes$d(
			A2(_elm_lang$core$String$join, ' ', pathComponents));
		return A2(
			_elm_lang$svg$Svg$path,
			{ctor: '::', _0: pathAttribute, _1: attributes},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$ellipse2d = F2(
	function (attributes, ellipse) {
		var angle = _ianmackenzie$acorn_demo$Direction2d$toAngle(
			_ianmackenzie$acorn_demo$Ellipse2d$xDirection(ellipse));
		var ry = _elm_lang$svg$Svg_Attributes$ry(
			_elm_lang$core$Basics$toString(
				_ianmackenzie$acorn_demo$Ellipse2d$yRadius(ellipse)));
		var rx = _elm_lang$svg$Svg_Attributes$rx(
			_elm_lang$core$Basics$toString(
				_ianmackenzie$acorn_demo$Ellipse2d$xRadius(ellipse)));
		var centerPoint = _ianmackenzie$acorn_demo$Ellipse2d$centerPoint(ellipse);
		var _p14 = _ianmackenzie$acorn_demo$Point2d$coordinates(centerPoint);
		var x = _p14._0;
		var y = _p14._1;
		var cx = _elm_lang$svg$Svg_Attributes$cx(
			_elm_lang$core$Basics$toString(x));
		var cy = _elm_lang$svg$Svg_Attributes$cy(
			_elm_lang$core$Basics$toString(y));
		return A3(
			_ianmackenzie$acorn_demo$Geometry_Svg$rotateAround,
			centerPoint,
			angle,
			A2(
				_elm_lang$svg$Svg$ellipse,
				{
					ctor: '::',
					_0: cx,
					_1: {
						ctor: '::',
						_0: cy,
						_1: {
							ctor: '::',
							_0: rx,
							_1: {ctor: '::', _0: ry, _1: attributes}
						}
					}
				},
				{ctor: '[]'}));
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$circle2d = F2(
	function (attributes, circle) {
		var r = _elm_lang$svg$Svg_Attributes$r(
			_elm_lang$core$Basics$toString(
				_ianmackenzie$acorn_demo$Circle2d$radius(circle)));
		var _p15 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$Circle2d$centerPoint(circle));
		var x = _p15._0;
		var y = _p15._1;
		var cx = _elm_lang$svg$Svg_Attributes$cx(
			_elm_lang$core$Basics$toString(x));
		var cy = _elm_lang$svg$Svg_Attributes$cy(
			_elm_lang$core$Basics$toString(y));
		return A2(
			_elm_lang$svg$Svg$circle,
			{
				ctor: '::',
				_0: cx,
				_1: {
					ctor: '::',
					_0: cy,
					_1: {ctor: '::', _0: r, _1: attributes}
				}
			},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$ellipticalArc2d = F2(
	function (attributes, arc) {
		var xDirection = _ianmackenzie$acorn_demo$EllipticalArc2d$xDirection(arc);
		var angleString = _elm_lang$core$Basics$toString(
			_elm_community$basics_extra$Basics_Extra$inDegrees(
				_ianmackenzie$acorn_demo$Direction2d$toAngle(xDirection)));
		var yRadius = _ianmackenzie$acorn_demo$EllipticalArc2d$yRadius(arc);
		var yRadiusString = _elm_lang$core$Basics$toString(yRadius);
		var xRadius = _ianmackenzie$acorn_demo$EllipticalArc2d$xRadius(arc);
		var xRadiusString = _elm_lang$core$Basics$toString(xRadius);
		var _p16 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$EllipticalArc2d$startPoint(arc));
		var x0 = _p16._0;
		var y0 = _p16._1;
		var moveCommand = {
			ctor: '::',
			_0: 'M',
			_1: {
				ctor: '::',
				_0: _elm_lang$core$Basics$toString(x0),
				_1: {
					ctor: '::',
					_0: _elm_lang$core$Basics$toString(y0),
					_1: {ctor: '[]'}
				}
			}
		};
		var maxSegmentAngle = (2 * _elm_lang$core$Basics$pi) / 3;
		var sweptAngle = _ianmackenzie$acorn_demo$EllipticalArc2d$sweptAngle(arc);
		var numSegments = 1 + _elm_lang$core$Basics$floor(
			_elm_lang$core$Basics$abs(sweptAngle) / maxSegmentAngle);
		var sweepFlag = (_elm_lang$core$Native_Utils.cmp(sweptAngle, 0) > -1) ? '1' : '0';
		var arcSegment = function (index) {
			var t = _elm_lang$core$Basics$toFloat(index) / _elm_lang$core$Basics$toFloat(numSegments);
			var _p17 = A2(_ianmackenzie$acorn_demo$EllipticalArc2d$pointOn, arc, t);
			if (_p17.ctor === 'Just') {
				var _p18 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p17._0);
				var x = _p18._0;
				var y = _p18._1;
				return {
					ctor: '::',
					_0: 'A',
					_1: {
						ctor: '::',
						_0: xRadiusString,
						_1: {
							ctor: '::',
							_0: yRadiusString,
							_1: {
								ctor: '::',
								_0: angleString,
								_1: {
									ctor: '::',
									_0: '0',
									_1: {
										ctor: '::',
										_0: sweepFlag,
										_1: {
											ctor: '::',
											_0: _elm_lang$core$Basics$toString(x),
											_1: {
												ctor: '::',
												_0: _elm_lang$core$Basics$toString(y),
												_1: {ctor: '[]'}
											}
										}
									}
								}
							}
						}
					}
				};
			} else {
				return {ctor: '[]'};
			}
		};
		var arcSegments = A2(
			_elm_lang$core$List$map,
			arcSegment,
			A2(_elm_lang$core$List$range, 1, numSegments));
		var pathComponents = A2(
			_elm_lang$core$Basics_ops['++'],
			moveCommand,
			_elm_lang$core$List$concat(arcSegments));
		var pathAttribute = _elm_lang$svg$Svg_Attributes$d(
			A2(_elm_lang$core$String$join, ' ', pathComponents));
		return A2(
			_elm_lang$svg$Svg$path,
			{ctor: '::', _0: pathAttribute, _1: attributes},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$arc2d = F2(
	function (attributes, arc) {
		var radius = _ianmackenzie$acorn_demo$Arc2d$radius(arc);
		var radiusString = _elm_lang$core$Basics$toString(radius);
		var _p19 = _ianmackenzie$acorn_demo$Point2d$coordinates(
			_ianmackenzie$acorn_demo$Arc2d$startPoint(arc));
		var x0 = _p19._0;
		var y0 = _p19._1;
		var moveCommand = {
			ctor: '::',
			_0: 'M',
			_1: {
				ctor: '::',
				_0: _elm_lang$core$Basics$toString(x0),
				_1: {
					ctor: '::',
					_0: _elm_lang$core$Basics$toString(y0),
					_1: {ctor: '[]'}
				}
			}
		};
		var maxSegmentAngle = (2 * _elm_lang$core$Basics$pi) / 3;
		var sweptAngle = _ianmackenzie$acorn_demo$Arc2d$sweptAngle(arc);
		var numSegments = 1 + _elm_lang$core$Basics$floor(
			_elm_lang$core$Basics$abs(sweptAngle) / maxSegmentAngle);
		var sweepFlag = (_elm_lang$core$Native_Utils.cmp(sweptAngle, 0) > -1) ? '1' : '0';
		var arcSegment = function (index) {
			var t = _elm_lang$core$Basics$toFloat(index) / _elm_lang$core$Basics$toFloat(numSegments);
			var _p20 = A2(_ianmackenzie$acorn_demo$Arc2d$pointOn, arc, t);
			if (_p20.ctor === 'Just') {
				var _p21 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p20._0);
				var x = _p21._0;
				var y = _p21._1;
				return {
					ctor: '::',
					_0: 'A',
					_1: {
						ctor: '::',
						_0: radiusString,
						_1: {
							ctor: '::',
							_0: radiusString,
							_1: {
								ctor: '::',
								_0: '0',
								_1: {
									ctor: '::',
									_0: '0',
									_1: {
										ctor: '::',
										_0: sweepFlag,
										_1: {
											ctor: '::',
											_0: _elm_lang$core$Basics$toString(x),
											_1: {
												ctor: '::',
												_0: _elm_lang$core$Basics$toString(y),
												_1: {ctor: '[]'}
											}
										}
									}
								}
							}
						}
					}
				};
			} else {
				return {ctor: '[]'};
			}
		};
		var arcSegments = A2(
			_elm_lang$core$List$map,
			arcSegment,
			A2(_elm_lang$core$List$range, 1, numSegments));
		var pathComponents = A2(
			_elm_lang$core$Basics_ops['++'],
			moveCommand,
			_elm_lang$core$List$concat(arcSegments));
		var pathAttribute = _elm_lang$svg$Svg_Attributes$d(
			A2(_elm_lang$core$String$join, ' ', pathComponents));
		return A2(
			_elm_lang$svg$Svg$path,
			{ctor: '::', _0: pathAttribute, _1: attributes},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$polygon2d = F2(
	function (attributes, polygon) {
		var loopString = function (loop) {
			var _p22 = loop;
			if (_p22.ctor === '[]') {
				return '';
			} else {
				var coordinateStrings = A2(
					_elm_lang$core$List$map,
					function (point) {
						var _p23 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
						var x = _p23._0;
						var y = _p23._1;
						return A2(
							_elm_lang$core$Basics_ops['++'],
							_elm_lang$core$Basics$toString(x),
							A2(
								_elm_lang$core$Basics_ops['++'],
								' ',
								_elm_lang$core$Basics$toString(y)));
					},
					loop);
				return A2(
					_elm_lang$core$Basics_ops['++'],
					'M ',
					A2(
						_elm_lang$core$Basics_ops['++'],
						A2(_elm_lang$core$String$join, ' L ', coordinateStrings),
						' Z'));
			}
		};
		var loops = {
			ctor: '::',
			_0: _ianmackenzie$acorn_demo$Polygon2d$outerLoop(polygon),
			_1: _ianmackenzie$acorn_demo$Polygon2d$innerLoops(polygon)
		};
		var pathAttribute = _elm_lang$svg$Svg_Attributes$d(
			A2(
				_elm_lang$core$String$join,
				' ',
				A2(_elm_lang$core$List$map, loopString, loops)));
		return A2(
			_elm_lang$svg$Svg$path,
			{ctor: '::', _0: pathAttribute, _1: attributes},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$rectangle2d = F2(
	function (attributes, rectangle) {
		return A2(
			_ianmackenzie$acorn_demo$Geometry_Svg$polygon2d,
			attributes,
			_ianmackenzie$acorn_demo$Rectangle2d$toPolygon(rectangle));
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$coordinatesString = function (point) {
	var _p24 = _ianmackenzie$acorn_demo$Point2d$coordinates(point);
	var x = _p24._0;
	var y = _p24._1;
	return A2(
		_elm_lang$core$Basics_ops['++'],
		_elm_lang$core$Basics$toString(x),
		A2(
			_elm_lang$core$Basics_ops['++'],
			',',
			_elm_lang$core$Basics$toString(y)));
};
var _ianmackenzie$acorn_demo$Geometry_Svg$pointsAttribute = function (points) {
	return _elm_lang$svg$Svg_Attributes$points(
		A2(
			_elm_lang$core$String$join,
			' ',
			A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Geometry_Svg$coordinatesString, points)));
};
var _ianmackenzie$acorn_demo$Geometry_Svg$lineSegment2d = F2(
	function (attributes, lineSegment) {
		var _p25 = _ianmackenzie$acorn_demo$LineSegment2d$endpoints(lineSegment);
		var p1 = _p25._0;
		var p2 = _p25._1;
		return A2(
			_elm_lang$svg$Svg$polyline,
			{
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Geometry_Svg$pointsAttribute(
					{
						ctor: '::',
						_0: p1,
						_1: {
							ctor: '::',
							_0: p2,
							_1: {ctor: '[]'}
						}
					}),
				_1: attributes
			},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$triangle2d = F2(
	function (attributes, triangle) {
		var _p26 = _ianmackenzie$acorn_demo$Triangle2d$vertices(triangle);
		var p1 = _p26._0;
		var p2 = _p26._1;
		var p3 = _p26._2;
		return A2(
			_elm_lang$svg$Svg$polygon,
			{
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Geometry_Svg$pointsAttribute(
					{
						ctor: '::',
						_0: p1,
						_1: {
							ctor: '::',
							_0: p2,
							_1: {
								ctor: '::',
								_0: p3,
								_1: {ctor: '[]'}
							}
						}
					}),
				_1: attributes
			},
			{ctor: '[]'});
	});
var _ianmackenzie$acorn_demo$Geometry_Svg$polyline2d = F2(
	function (attributes, polyline) {
		var vertices = _ianmackenzie$acorn_demo$Polyline2d$vertices(polyline);
		return A2(
			_elm_lang$svg$Svg$polyline,
			{
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Geometry_Svg$pointsAttribute(vertices),
				_1: attributes
			},
			{ctor: '[]'});
	});

var _ianmackenzie$acorn_demo$Drawing2d_Element$noStrokeAttribute = _elm_lang$svg$Svg_Attributes$stroke('none');
var _ianmackenzie$acorn_demo$Drawing2d_Element$noFillAttribute = _elm_lang$svg$Svg_Attributes$fill('none');
var _ianmackenzie$acorn_demo$Drawing2d_Element$curveAttributes = function (attributes) {
	return {ctor: '::', _0: _ianmackenzie$acorn_demo$Drawing2d_Element$noFillAttribute, _1: attributes};
};
var _ianmackenzie$acorn_demo$Drawing2d_Element$applyAttribute = F2(
	function (attribute, _p0) {
		var _p1 = _p0;
		var _p2 = A3(_ianmackenzie$acorn_demo$Drawing2d_Attribute$apply, attribute, _p1._0, _p1._1);
		var updatedContext = _p2._0;
		var updatedDefs = _p2._1;
		var svgAttributes = _p2._2;
		return {
			ctor: '_Tuple3',
			_0: updatedContext,
			_1: updatedDefs,
			_2: {ctor: '::', _0: svgAttributes, _1: _p1._2}
		};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$applyAttributes = F3(
	function (attributes, context, defs) {
		var _p3 = A3(
			_elm_lang$core$List$foldl,
			_ianmackenzie$acorn_demo$Drawing2d_Element$applyAttribute,
			{
				ctor: '_Tuple3',
				_0: context,
				_1: defs,
				_2: {ctor: '[]'}
			},
			attributes);
		var updatedContext = _p3._0;
		var updatedDefs = _p3._1;
		var accumulatedAttributes = _p3._2;
		return {
			ctor: '_Tuple3',
			_0: updatedContext,
			_1: updatedDefs,
			_2: _elm_lang$core$List$concat(
				_elm_lang$core$List$reverse(accumulatedAttributes))
		};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$drawCurveWith = F6(
	function (parentContext, currentDefs, attributes, draw, placeIn, geometry) {
		var _p4 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyAttributes, attributes, parentContext, currentDefs);
		var localContext = _p4._0;
		var updatedDefs = _p4._1;
		var convertedAttributes = _p4._2;
		var finalAttributes = {ctor: '::', _0: _ianmackenzie$acorn_demo$Drawing2d_Element$noFillAttribute, _1: convertedAttributes};
		var placedGeometry = A2(placeIn, localContext.placementFrame, geometry);
		return {
			ctor: '_Tuple2',
			_0: A2(draw, finalAttributes, placedGeometry),
			_1: updatedDefs
		};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$applyRegionAttributes = F3(
	function (attributes, context, defs) {
		var _p5 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyAttributes, attributes, context, defs);
		var localContext = _p5._0;
		var updatedDefs = _p5._1;
		var convertedAttributes = _p5._2;
		var _p6 = function () {
			if (localContext.bordersEnabled) {
				var _p7 = localContext.borderPosition;
				switch (_p7.ctor) {
					case 'Centered':
						return {ctor: '_Tuple2', _0: convertedAttributes, _1: updatedDefs};
					case 'Inside':
						return _elm_lang$core$Native_Utils.crashCase(
							'Drawing2d.Element',
							{
								start: {line: 118, column: 17},
								end: {line: 126, column: 43}
							},
							_p7)('TODO');
					default:
						return _elm_lang$core$Native_Utils.crashCase(
							'Drawing2d.Element',
							{
								start: {line: 118, column: 17},
								end: {line: 126, column: 43}
							},
							_p7)('TODO');
				}
			} else {
				return {
					ctor: '_Tuple2',
					_0: {ctor: '::', _0: _ianmackenzie$acorn_demo$Drawing2d_Element$noStrokeAttribute, _1: convertedAttributes},
					_1: updatedDefs
				};
			}
		}();
		var finalAttributes = _p6._0;
		var finalDefs = _p6._1;
		return {ctor: '_Tuple3', _0: localContext, _1: finalDefs, _2: finalAttributes};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$drawRegionWith = F6(
	function (parentContext, currentDefs, attributes, draw, placeIn, geometry) {
		var _p10 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyRegionAttributes, attributes, parentContext, currentDefs);
		var localContext = _p10._0;
		var updatedDefs = _p10._1;
		var svgAttributes = _p10._2;
		var placedGeometry = A2(placeIn, localContext.placementFrame, geometry);
		return {
			ctor: '_Tuple2',
			_0: A2(draw, svgAttributes, placedGeometry),
			_1: updatedDefs
		};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$render = F3(
	function (parentContext, currentDefs, element) {
		render:
		while (true) {
			var drawRegion = A2(_ianmackenzie$acorn_demo$Drawing2d_Element$drawRegionWith, parentContext, currentDefs);
			var drawCurve = A2(_ianmackenzie$acorn_demo$Drawing2d_Element$drawCurveWith, parentContext, currentDefs);
			var _p11 = element;
			switch (_p11.ctor) {
				case 'Empty':
					return {
						ctor: '_Tuple2',
						_0: _elm_lang$svg$Svg$text(''),
						_1: currentDefs
					};
				case 'Group':
					var _p12 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyAttributes, _p11._0, parentContext, currentDefs);
					var localContext = _p12._0;
					var postGroupDefs = _p12._1;
					var svgAttributes = _p12._2;
					var processChild = F2(
						function (childElement, _p13) {
							var _p14 = _p13;
							var _p15 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$render, localContext, _p14._1, childElement);
							var childSvgElement = _p15._0;
							var postChildDefs = _p15._1;
							return {
								ctor: '_Tuple2',
								_0: {ctor: '::', _0: childSvgElement, _1: _p14._0},
								_1: postChildDefs
							};
						});
					var _p16 = A3(
						_elm_lang$core$List$foldl,
						processChild,
						{
							ctor: '_Tuple2',
							_0: {ctor: '[]'},
							_1: postGroupDefs
						},
						_p11._1);
					var accumulatedChildElements = _p16._0;
					var postChildrenDefs = _p16._1;
					return {
						ctor: '_Tuple2',
						_0: A2(
							_elm_lang$svg$Svg$g,
							svgAttributes,
							_elm_lang$core$List$reverse(accumulatedChildElements)),
						_1: postChildrenDefs
					};
				case 'PlaceIn':
					var childContext = _elm_lang$core$Native_Utils.update(
						parentContext,
						{
							placementFrame: A2(_ianmackenzie$acorn_demo$Frame2d$placeIn, parentContext.placementFrame, _p11._0)
						});
					var _v4 = childContext,
						_v5 = currentDefs,
						_v6 = _p11._1;
					parentContext = _v4;
					currentDefs = _v5;
					element = _v6;
					continue render;
				case 'LineSegment':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$lineSegment2d, _ianmackenzie$acorn_demo$LineSegment2d$placeIn, _p11._1);
				case 'Triangle':
					return A4(drawRegion, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$triangle2d, _ianmackenzie$acorn_demo$Triangle2d$placeIn, _p11._1);
				case 'Dot':
					var _p17 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyRegionAttributes, _p11._0, parentContext, currentDefs);
					var localContext = _p17._0;
					var updatedDefs = _p17._1;
					var svgAttributes = _p17._2;
					var circle = A2(
						_ianmackenzie$acorn_demo$Circle2d$withRadius,
						localContext.dotRadius,
						A2(_ianmackenzie$acorn_demo$Point2d$placeIn, localContext.placementFrame, _p11._1));
					return {
						ctor: '_Tuple2',
						_0: A2(_ianmackenzie$acorn_demo$Geometry_Svg$circle2d, svgAttributes, circle),
						_1: updatedDefs
					};
				case 'Arc':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$arc2d, _ianmackenzie$acorn_demo$Arc2d$placeIn, _p11._1);
				case 'QuadraticSpline':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$quadraticSpline2d, _ianmackenzie$acorn_demo$QuadraticSpline2d$placeIn, _p11._1);
				case 'CubicSpline':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$cubicSpline2d, _ianmackenzie$acorn_demo$CubicSpline2d$placeIn, _p11._1);
				case 'Circle':
					return A4(drawRegion, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$circle2d, _ianmackenzie$acorn_demo$Circle2d$placeIn, _p11._1);
				case 'Ellipse':
					return A4(drawRegion, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$ellipse2d, _ianmackenzie$acorn_demo$Ellipse2d$placeIn, _p11._1);
				case 'EllipticalArc':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$ellipticalArc2d, _ianmackenzie$acorn_demo$EllipticalArc2d$placeIn, _p11._1);
				case 'Polyline':
					return A4(drawCurve, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$polyline2d, _ianmackenzie$acorn_demo$Polyline2d$placeIn, _p11._1);
				case 'Polygon':
					return A4(drawRegion, _p11._0, _ianmackenzie$acorn_demo$Geometry_Svg$polygon2d, _ianmackenzie$acorn_demo$Polygon2d$placeIn, _p11._1);
				case 'Text':
					var _p20 = _p11._1;
					var strokeAttribute = _elm_lang$svg$Svg_Attributes$stroke('none');
					var fillAttribute = _elm_lang$svg$Svg_Attributes$fill('currentColor');
					var _p18 = _ianmackenzie$acorn_demo$Point2d$coordinates(_p20);
					var x = _p18._0;
					var y = _p18._1;
					var xAttribute = _elm_lang$svg$Svg_Attributes$x(
						_elm_lang$core$Basics$toString(x));
					var yAttribute = _elm_lang$svg$Svg_Attributes$y(
						_elm_lang$core$Basics$toString(y));
					var _p19 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyAttributes, _p11._0, parentContext, currentDefs);
					var localContext = _p19._0;
					var updatedDefs = _p19._1;
					var svgAttributes = _p19._2;
					return {
						ctor: '_Tuple2',
						_0: A2(
							_ianmackenzie$acorn_demo$Geometry_Svg$placeIn,
							localContext.placementFrame,
							A2(
								_ianmackenzie$acorn_demo$Geometry_Svg$mirrorAcross,
								A2(_ianmackenzie$acorn_demo$Axis2d$through, _p20, _ianmackenzie$acorn_demo$Direction2d$x),
								A2(
									_elm_lang$svg$Svg$text_,
									{
										ctor: '::',
										_0: xAttribute,
										_1: {
											ctor: '::',
											_0: yAttribute,
											_1: {
												ctor: '::',
												_0: fillAttribute,
												_1: {ctor: '::', _0: strokeAttribute, _1: svgAttributes}
											}
										}
									},
									{
										ctor: '::',
										_0: _elm_lang$svg$Svg$text(_p11._2),
										_1: {ctor: '[]'}
									}))),
						_1: updatedDefs
					};
				case 'RoundedRectangle':
					var _p23 = _p11._1;
					var lineTo = F2(
						function (x, y) {
							return A2(
								_elm_lang$core$Basics_ops['++'],
								'L ',
								A2(
									_elm_lang$core$Basics_ops['++'],
									x,
									A2(_elm_lang$core$Basics_ops['++'], ' ', y)));
						});
					var moveTo = F2(
						function (x, y) {
							return A2(
								_elm_lang$core$Basics_ops['++'],
								'M ',
								A2(
									_elm_lang$core$Basics_ops['++'],
									x,
									A2(_elm_lang$core$Basics_ops['++'], ' ', y)));
						});
					var radiusString = _elm_lang$core$Basics$toString(_p23);
					var arcTo = F2(
						function (x, y) {
							return A2(
								_elm_lang$core$String$join,
								' ',
								{
									ctor: '::',
									_0: 'A',
									_1: {
										ctor: '::',
										_0: radiusString,
										_1: {
											ctor: '::',
											_0: radiusString,
											_1: {
												ctor: '::',
												_0: '0',
												_1: {
													ctor: '::',
													_0: '0',
													_1: {
														ctor: '::',
														_0: '0',
														_1: {
															ctor: '::',
															_0: x,
															_1: {
																ctor: '::',
																_0: y,
																_1: {ctor: '[]'}
															}
														}
													}
												}
											}
										}
									}
								});
						});
					var _p21 = A3(_ianmackenzie$acorn_demo$Drawing2d_Element$applyRegionAttributes, _p11._0, parentContext, currentDefs);
					var localContext = _p21._0;
					var updatedDefs = _p21._1;
					var svgAttributes = _p21._2;
					var placedRectangle = A2(_ianmackenzie$acorn_demo$Rectangle2d$placeIn, localContext.placementFrame, _p11._2);
					var _p22 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(placedRectangle);
					var width = _p22._0;
					var height = _p22._1;
					var halfWidth = width / 2;
					var halfHeight = height / 2;
					var rectangleAxes = _ianmackenzie$acorn_demo$Rectangle2d$axes(placedRectangle);
					var p0 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: halfWidth - _p23, _1: 0 - halfHeight});
					var x0 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p0));
					var y0 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p0));
					var p1 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: halfWidth, _1: (0 - halfHeight) + _p23});
					var x1 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p1));
					var y1 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p1));
					var p2 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: halfWidth, _1: halfHeight - _p23});
					var x2 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p2));
					var y2 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p2));
					var p3 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: halfWidth - _p23, _1: halfHeight});
					var x3 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p3));
					var y3 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p3));
					var p4 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: (0 - halfWidth) + _p23, _1: halfHeight});
					var x4 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p4));
					var y4 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p4));
					var p5 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: 0 - halfWidth, _1: halfHeight - _p23});
					var x5 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p5));
					var y5 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p5));
					var p6 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: 0 - halfWidth, _1: (0 - halfHeight) + _p23});
					var x6 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p6));
					var y6 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p6));
					var p7 = A2(
						_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
						rectangleAxes,
						{ctor: '_Tuple2', _0: (0 - halfWidth) + _p23, _1: 0 - halfHeight});
					var x7 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$xCoordinate(p7));
					var y7 = _elm_lang$core$Basics$toString(
						_ianmackenzie$acorn_demo$Point2d$yCoordinate(p7));
					var path = A2(
						_elm_lang$core$String$join,
						' ',
						{
							ctor: '::',
							_0: A2(moveTo, x0, y0),
							_1: {
								ctor: '::',
								_0: A2(arcTo, x1, y1),
								_1: {
									ctor: '::',
									_0: A2(lineTo, x2, y2),
									_1: {
										ctor: '::',
										_0: A2(arcTo, x3, y3),
										_1: {
											ctor: '::',
											_0: A2(lineTo, x4, y4),
											_1: {
												ctor: '::',
												_0: A2(arcTo, x5, y5),
												_1: {
													ctor: '::',
													_0: A2(lineTo, x6, y6),
													_1: {
														ctor: '::',
														_0: A2(arcTo, x7, y7),
														_1: {
															ctor: '::',
															_0: 'Z',
															_1: {ctor: '[]'}
														}
													}
												}
											}
										}
									}
								}
							}
						});
					var pathAttribute = _elm_lang$svg$Svg_Attributes$d(path);
					return {
						ctor: '_Tuple2',
						_0: A2(
							_elm_lang$svg$Svg$path,
							{ctor: '::', _0: pathAttribute, _1: svgAttributes},
							{ctor: '[]'}),
						_1: updatedDefs
					};
				default:
					var placedRectangle = A2(_ianmackenzie$acorn_demo$Rectangle2d$placeIn, parentContext.placementFrame, _p11._1);
					var _p24 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(placedRectangle);
					var width = _p24._0;
					var height = _p24._1;
					return {
						ctor: '_Tuple2',
						_0: A2(
							_ianmackenzie$acorn_demo$Geometry_Svg$mirrorAcross,
							_ianmackenzie$acorn_demo$Rectangle2d$xAxis(placedRectangle),
							A2(
								_ianmackenzie$acorn_demo$Geometry_Svg$placeIn,
								_ianmackenzie$acorn_demo$Rectangle2d$axes(placedRectangle),
								A2(
									_elm_lang$svg$Svg$image,
									{
										ctor: '::',
										_0: _elm_lang$svg$Svg_Attributes$xlinkHref(_p11._0),
										_1: {
											ctor: '::',
											_0: _elm_lang$svg$Svg_Attributes$x(
												_elm_lang$core$Basics$toString((0 - width) / 2)),
											_1: {
												ctor: '::',
												_0: _elm_lang$svg$Svg_Attributes$y(
													_elm_lang$core$Basics$toString((0 - height) / 2)),
												_1: {
													ctor: '::',
													_0: _elm_lang$svg$Svg_Attributes$width(
														_elm_lang$core$Basics$toString(width)),
													_1: {
														ctor: '::',
														_0: _elm_lang$svg$Svg_Attributes$height(
															_elm_lang$core$Basics$toString(height)),
														_1: {ctor: '[]'}
													}
												}
											}
										}
									},
									{ctor: '[]'}))),
						_1: currentDefs
					};
			}
		}
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Image = F2(
	function (a, b) {
		return {ctor: 'Image', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$RoundedRectangle = F3(
	function (a, b, c) {
		return {ctor: 'RoundedRectangle', _0: a, _1: b, _2: c};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Text = F3(
	function (a, b, c) {
		return {ctor: 'Text', _0: a, _1: b, _2: c};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$EllipticalArc = F2(
	function (a, b) {
		return {ctor: 'EllipticalArc', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Ellipse = F2(
	function (a, b) {
		return {ctor: 'Ellipse', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Circle = F2(
	function (a, b) {
		return {ctor: 'Circle', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Polygon = F2(
	function (a, b) {
		return {ctor: 'Polygon', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Polyline = F2(
	function (a, b) {
		return {ctor: 'Polyline', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$QuadraticSpline = F2(
	function (a, b) {
		return {ctor: 'QuadraticSpline', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$CubicSpline = F2(
	function (a, b) {
		return {ctor: 'CubicSpline', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Arc = F2(
	function (a, b) {
		return {ctor: 'Arc', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Dot = F2(
	function (a, b) {
		return {ctor: 'Dot', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Triangle = F2(
	function (a, b) {
		return {ctor: 'Triangle', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$LineSegment = F2(
	function (a, b) {
		return {ctor: 'LineSegment', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$PlaceIn = F2(
	function (a, b) {
		return {ctor: 'PlaceIn', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Group = F2(
	function (a, b) {
		return {ctor: 'Group', _0: a, _1: b};
	});
var _ianmackenzie$acorn_demo$Drawing2d_Element$Empty = {ctor: 'Empty'};
var _ianmackenzie$acorn_demo$Drawing2d_Element$map = F2(
	function ($function, element) {
		var mapElement = _ianmackenzie$acorn_demo$Drawing2d_Element$map($function);
		var mapAttributes = _elm_lang$core$List$map(
			_ianmackenzie$acorn_demo$Drawing2d_Attribute$map($function));
		var _p25 = element;
		switch (_p25.ctor) {
			case 'Empty':
				return _ianmackenzie$acorn_demo$Drawing2d_Element$Empty;
			case 'Group':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Group,
					mapAttributes(_p25._0),
					A2(_elm_lang$core$List$map, mapElement, _p25._1));
			case 'PlaceIn':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$PlaceIn,
					_p25._0,
					mapElement(_p25._1));
			case 'LineSegment':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$LineSegment,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Triangle':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Triangle,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Dot':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Dot,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Arc':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Arc,
					mapAttributes(_p25._0),
					_p25._1);
			case 'CubicSpline':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$CubicSpline,
					mapAttributes(_p25._0),
					_p25._1);
			case 'QuadraticSpline':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$QuadraticSpline,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Polyline':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Polyline,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Polygon':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Polygon,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Circle':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Circle,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Ellipse':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Ellipse,
					mapAttributes(_p25._0),
					_p25._1);
			case 'EllipticalArc':
				return A2(
					_ianmackenzie$acorn_demo$Drawing2d_Element$EllipticalArc,
					mapAttributes(_p25._0),
					_p25._1);
			case 'Text':
				return A3(
					_ianmackenzie$acorn_demo$Drawing2d_Element$Text,
					mapAttributes(_p25._0),
					_p25._1,
					_p25._2);
			case 'RoundedRectangle':
				return A3(
					_ianmackenzie$acorn_demo$Drawing2d_Element$RoundedRectangle,
					mapAttributes(_p25._0),
					_p25._1,
					_p25._2);
			default:
				return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Image, _p25._0, _p25._1);
		}
	});

var _ianmackenzie$acorn_demo$Drawing2d$map = _ianmackenzie$acorn_demo$Drawing2d_Element$map;
var _ianmackenzie$acorn_demo$Drawing2d$image = F2(
	function (url, rectangle) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Image, url, rectangle);
	});
var _ianmackenzie$acorn_demo$Drawing2d$textWith = F3(
	function (attributes, point, string) {
		return A3(_ianmackenzie$acorn_demo$Drawing2d_Element$Text, attributes, point, string);
	});
var _ianmackenzie$acorn_demo$Drawing2d$text = _ianmackenzie$acorn_demo$Drawing2d$textWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith = F3(
	function (attributes, radius, rectangle) {
		return A3(_ianmackenzie$acorn_demo$Drawing2d_Element$RoundedRectangle, attributes, radius, rectangle);
	});
var _ianmackenzie$acorn_demo$Drawing2d$roundedRectangle = _ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$ellipseWith = F2(
	function (attributes, ellipse) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Ellipse, attributes, ellipse);
	});
var _ianmackenzie$acorn_demo$Drawing2d$ellipse = _ianmackenzie$acorn_demo$Drawing2d$ellipseWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$ellipticalArcWith = F2(
	function (attributes, ellipticalArc) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$EllipticalArc, attributes, ellipticalArc);
	});
var _ianmackenzie$acorn_demo$Drawing2d$ellipticalArc = _ianmackenzie$acorn_demo$Drawing2d$ellipticalArcWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$circleWith = F2(
	function (attributes, circle) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Circle, attributes, circle);
	});
var _ianmackenzie$acorn_demo$Drawing2d$circle = _ianmackenzie$acorn_demo$Drawing2d$circleWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$polygonWith = F2(
	function (attributes, polygon) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Polygon, attributes, polygon);
	});
var _ianmackenzie$acorn_demo$Drawing2d$rectangleWith = F2(
	function (attributes, rectangle) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$polygonWith,
			attributes,
			_ianmackenzie$acorn_demo$Rectangle2d$toPolygon(rectangle));
	});
var _ianmackenzie$acorn_demo$Drawing2d$rectangle = _ianmackenzie$acorn_demo$Drawing2d$rectangleWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$polygon = _ianmackenzie$acorn_demo$Drawing2d$polygonWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$polylineWith = F2(
	function (attributes, polyline) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Polyline, attributes, polyline);
	});
var _ianmackenzie$acorn_demo$Drawing2d$polyline = _ianmackenzie$acorn_demo$Drawing2d$polylineWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$cubicSplineWith = F2(
	function (attributes, cubicSpline) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$CubicSpline, attributes, cubicSpline);
	});
var _ianmackenzie$acorn_demo$Drawing2d$cubicSpline = _ianmackenzie$acorn_demo$Drawing2d$cubicSplineWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$quadraticSplineWith = F2(
	function (attributes, quadraticSpline) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$QuadraticSpline, attributes, quadraticSpline);
	});
var _ianmackenzie$acorn_demo$Drawing2d$quadraticSpline = _ianmackenzie$acorn_demo$Drawing2d$quadraticSplineWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$arcWith = F2(
	function (attributes, arc) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Arc, attributes, arc);
	});
var _ianmackenzie$acorn_demo$Drawing2d$arc = _ianmackenzie$acorn_demo$Drawing2d$arcWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$dotWith = F2(
	function (attributes, point) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Dot, attributes, point);
	});
var _ianmackenzie$acorn_demo$Drawing2d$dot = _ianmackenzie$acorn_demo$Drawing2d$dotWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$placeIn = F2(
	function (frame, element) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$PlaceIn, frame, element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$relativeTo = F2(
	function (frame, element) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			A2(_ianmackenzie$acorn_demo$Frame2d$relativeTo, frame, _ianmackenzie$acorn_demo$Frame2d$xy),
			element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$translateBy = F2(
	function (displacement, element) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			A2(_ianmackenzie$acorn_demo$Frame2d$translateBy, displacement, _ianmackenzie$acorn_demo$Frame2d$xy),
			element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$translateIn = F3(
	function (direction, distance, element) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$translateBy,
			A2(_ianmackenzie$acorn_demo$Vector2d$withLength, distance, direction),
			element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$rotateAround = F3(
	function (point, angle, element) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			A3(_ianmackenzie$acorn_demo$Frame2d$rotateAround, point, angle, _ianmackenzie$acorn_demo$Frame2d$xy),
			element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$mirrorAcross = F2(
	function (axis, element) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			A2(_ianmackenzie$acorn_demo$Frame2d$mirrorAcross, axis, _ianmackenzie$acorn_demo$Frame2d$xy),
			element);
	});
var _ianmackenzie$acorn_demo$Drawing2d$groupWith = F2(
	function (attributes, elements) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Group, attributes, elements);
	});
var _ianmackenzie$acorn_demo$Drawing2d$dotsWith = F2(
	function (attributes, points) {
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$groupWith,
			attributes,
			A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Drawing2d$dot, points));
	});
var _ianmackenzie$acorn_demo$Drawing2d$dots = _ianmackenzie$acorn_demo$Drawing2d$dotsWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$group = _ianmackenzie$acorn_demo$Drawing2d$groupWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$triangleWith = F2(
	function (attributes, triangle) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$Triangle, attributes, triangle);
	});
var _ianmackenzie$acorn_demo$Drawing2d$triangle = _ianmackenzie$acorn_demo$Drawing2d$triangleWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$lineSegmentWith = F2(
	function (attributes, lineSegment) {
		return A2(_ianmackenzie$acorn_demo$Drawing2d_Element$LineSegment, attributes, lineSegment);
	});
var _ianmackenzie$acorn_demo$Drawing2d$lineSegment = _ianmackenzie$acorn_demo$Drawing2d$lineSegmentWith(
	{ctor: '[]'});
var _ianmackenzie$acorn_demo$Drawing2d$empty = _ianmackenzie$acorn_demo$Drawing2d_Element$Empty;
var _ianmackenzie$acorn_demo$Drawing2d$toHtml = F3(
	function (boundingBox, attributes, elements) {
		var defaultAttributes = {
			ctor: '::',
			_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackStroke,
			_1: {
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(1),
				_1: {
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$whiteFill,
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokedBorder,
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$borderPosition(_ianmackenzie$acorn_demo$Drawing2d_Border$centered),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize(20),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$black),
									_1: {
										ctor: '::',
										_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$bottomLeft),
										_1: {
											ctor: '::',
											_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$dotRadius(3),
											_1: {ctor: '[]'}
										}
									}
								}
							}
						}
					}
				}
			}
		};
		var rootElement = A2(
			_ianmackenzie$acorn_demo$Drawing2d$groupWith,
			A2(_elm_lang$core$Basics_ops['++'], defaultAttributes, attributes),
			elements);
		var _p0 = A3(
			_ianmackenzie$acorn_demo$Drawing2d_Element$render,
			_ianmackenzie$acorn_demo$Drawing2d_Context$init(boundingBox),
			_ianmackenzie$acorn_demo$Drawing2d_Defs$init,
			rootElement);
		var rootSvgElement = _p0._0;
		var defs = _p0._1;
		var _p1 = _ianmackenzie$acorn_demo$BoundingBox2d$dimensions(boundingBox);
		var width = _p1._0;
		var height = _p1._1;
		return A2(
			_elm_lang$html$Html$div,
			{
				ctor: '::',
				_0: _elm_lang$html$Html_Attributes$style(
					{
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 'border', _1: '0'},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 'padding', _1: '0'},
							_1: {
								ctor: '::',
								_0: {ctor: '_Tuple2', _0: 'margin', _1: '0'},
								_1: {
									ctor: '::',
									_0: {ctor: '_Tuple2', _0: 'display', _1: 'inline-block'},
									_1: {ctor: '[]'}
								}
							}
						}
					}),
				_1: {ctor: '[]'}
			},
			{
				ctor: '::',
				_0: A2(
					_elm_lang$svg$Svg$svg,
					{
						ctor: '::',
						_0: _elm_lang$svg$Svg_Attributes$width(
							_elm_lang$core$Basics$toString(width)),
						_1: {
							ctor: '::',
							_0: _elm_lang$svg$Svg_Attributes$height(
								_elm_lang$core$Basics$toString(height)),
							_1: {
								ctor: '::',
								_0: _elm_lang$html$Html_Attributes$style(
									{
										ctor: '::',
										_0: {ctor: '_Tuple2', _0: 'display', _1: 'block'},
										_1: {ctor: '[]'}
									}),
								_1: {ctor: '[]'}
							}
						}
					},
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Defs$toSvgElement(defs),
						_1: {
							ctor: '::',
							_0: rootSvgElement,
							_1: {ctor: '[]'}
						}
					}),
				_1: {ctor: '[]'}
			});
	});

var _ianmackenzie$acorn_demo$PiecewiseCurve$splines = function (_p0) {
	var _p1 = _p0;
	return A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$CubicSpline2d$underlyingSpline, _p1._0.segments);
};
var _ianmackenzie$acorn_demo$PiecewiseCurve$evaluateHelper = F2(
	function (segments, s) {
		evaluateHelper:
		while (true) {
			var _p2 = segments;
			if (_p2.ctor === '::') {
				var _p3 = _p2._0;
				var firstSegmentLength = _ianmackenzie$acorn_demo$CubicSpline2d$arcLength(_p3);
				if (_elm_lang$core$Native_Utils.cmp(s, firstSegmentLength) < 1) {
					return A3(
						_elm_lang$core$Maybe$map2,
						F2(
							function (v0, v1) {
								return {ctor: '_Tuple2', _0: v0, _1: v1};
							}),
						A2(_ianmackenzie$acorn_demo$CubicSpline2d$pointAlong, _p3, s),
						A2(_ianmackenzie$acorn_demo$CubicSpline2d$tangentAlong, _p3, s));
				} else {
					var _v2 = _p2._1,
						_v3 = s - firstSegmentLength;
					segments = _v2;
					s = _v3;
					continue evaluateHelper;
				}
			} else {
				return _elm_lang$core$Maybe$Nothing;
			}
		}
	});
var _ianmackenzie$acorn_demo$PiecewiseCurve$evaluateAlong = F2(
	function (_p4, s) {
		var _p5 = _p4;
		return ((_elm_lang$core$Native_Utils.cmp(s, 0) < 0) || (_elm_lang$core$Native_Utils.cmp(s, _p5._0.arcLength) > 0)) ? _elm_lang$core$Maybe$Nothing : A2(_ianmackenzie$acorn_demo$PiecewiseCurve$evaluateHelper, _p5._0.segments, s);
	});
var _ianmackenzie$acorn_demo$PiecewiseCurve$tangentAlong = F2(
	function (curve, s) {
		return A2(
			_elm_lang$core$Maybe$map,
			_elm_lang$core$Tuple$second,
			A2(_ianmackenzie$acorn_demo$PiecewiseCurve$evaluateAlong, curve, s));
	});
var _ianmackenzie$acorn_demo$PiecewiseCurve$pointAlong = F2(
	function (curve, s) {
		return A2(
			_elm_lang$core$Maybe$map,
			_elm_lang$core$Tuple$first,
			A2(_ianmackenzie$acorn_demo$PiecewiseCurve$evaluateAlong, curve, s));
	});
var _ianmackenzie$acorn_demo$PiecewiseCurve$arcLength = function (_p6) {
	var _p7 = _p6;
	return _p7._0.arcLength;
};
var _ianmackenzie$acorn_demo$PiecewiseCurve$accuracy = _ianmackenzie$acorn_demo$Geometry_Accuracy$maxError(0.1);
var _ianmackenzie$acorn_demo$PiecewiseCurve$PiecewiseCurve = function (a) {
	return {ctor: 'PiecewiseCurve', _0: a};
};
var _ianmackenzie$acorn_demo$PiecewiseCurve$build = function (segments) {
	return _ianmackenzie$acorn_demo$PiecewiseCurve$PiecewiseCurve(
		{
			segments: segments,
			arcLength: _elm_lang$core$List$sum(
				A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$CubicSpline2d$arcLength, segments))
		});
};

var _ianmackenzie$acorn_demo$Track$lineSpeeds = function (_p0) {
	var _p1 = _p0;
	return _p1._0.lineSpeeds;
};
var _ianmackenzie$acorn_demo$Track$curve = function (_p2) {
	var _p3 = _p2;
	return _p3._0.curve;
};
var _ianmackenzie$acorn_demo$Track$length = function (track) {
	return _ianmackenzie$acorn_demo$PiecewiseCurve$arcLength(
		_ianmackenzie$acorn_demo$Track$curve(track));
};
var _ianmackenzie$acorn_demo$Track$pointAlong = F2(
	function (track, distance) {
		return A2(
			_ianmackenzie$acorn_demo$PiecewiseCurve$pointAlong,
			_ianmackenzie$acorn_demo$Track$curve(track),
			distance);
	});
var _ianmackenzie$acorn_demo$Track$tangentAlong = F2(
	function (track, distance) {
		return A2(
			_ianmackenzie$acorn_demo$PiecewiseCurve$tangentAlong,
			_ianmackenzie$acorn_demo$Track$curve(track),
			distance);
	});
var _ianmackenzie$acorn_demo$Track$evaluateAlong = F2(
	function (track, distance) {
		return A2(
			_ianmackenzie$acorn_demo$PiecewiseCurve$evaluateAlong,
			_ianmackenzie$acorn_demo$Track$curve(track),
			distance);
	});
var _ianmackenzie$acorn_demo$Track$draw = function (track) {
	return A2(
		_ianmackenzie$acorn_demo$Drawing2d$groupWith,
		{
			ctor: '::',
			_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(
				A3(_elm_lang$core$Color$rgb, 175, 175, 175)),
			_1: {
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(2),
				_1: {ctor: '[]'}
			}
		},
		A2(
			_elm_lang$core$List$map,
			_ianmackenzie$acorn_demo$Drawing2d$cubicSpline,
			_ianmackenzie$acorn_demo$PiecewiseCurve$splines(
				_ianmackenzie$acorn_demo$Track$curve(track))));
};
var _ianmackenzie$acorn_demo$Track$Track = function (a) {
	return {ctor: 'Track', _0: a};
};
var _ianmackenzie$acorn_demo$Track$build = function (segments) {
	var parameterizedSegments = A2(
		_elm_lang$core$List$map,
		_elm_lang$core$Tuple$mapFirst(
			_ianmackenzie$acorn_demo$CubicSpline2d$arcLengthParameterized(_ianmackenzie$acorn_demo$PiecewiseCurve$accuracy)),
		segments);
	var piecewiseCurve = _ianmackenzie$acorn_demo$PiecewiseCurve$build(
		A2(_elm_lang$core$List$map, _elm_lang$core$Tuple$first, parameterizedSegments));
	var lineSpeeds = A2(
		_elm_lang$core$List$drop,
		1,
		A3(
			_elm_lang$core$List$scanl,
			F2(
				function (_p5, _p4) {
					var _p6 = _p5;
					var _p7 = _p4;
					var arcLength = _ianmackenzie$acorn_demo$CubicSpline2d$arcLength(_p6._0);
					var currentEnd = _ianmackenzie$elm_interval$Interval$maxValue(_p7._0);
					return {
						ctor: '_Tuple2',
						_0: A2(_ianmackenzie$elm_interval$Interval$from, currentEnd, currentEnd + arcLength),
						_1: _p6._1
					};
				}),
			{
				ctor: '_Tuple2',
				_0: A2(_ianmackenzie$elm_interval$Interval$from, 0, 0),
				_1: 0
			},
			parameterizedSegments));
	return _ianmackenzie$acorn_demo$Track$Track(
		{curve: piecewiseCurve, lineSpeeds: lineSpeeds});
};

var _ianmackenzie$acorn_demo$Database$lastEntry = function (_p0) {
	var _p1 = _p0;
	var _p2 = _p1._0;
	return A2(
		_Skinney$elm_array_exploration$Array_Hamt$get,
		_Skinney$elm_array_exploration$Array_Hamt$length(_p2) - 1,
		_p2);
};
var _ianmackenzie$acorn_demo$Database$firstEntry = function (_p3) {
	var _p4 = _p3;
	return A2(_Skinney$elm_array_exploration$Array_Hamt$get, 0, _p4._0);
};
var _ianmackenzie$acorn_demo$Database$orEndpointFor = F4(
	function (distance, database, accessor, maybeValue) {
		return A2(
			_elm_community$maybe_extra$Maybe_Extra$orElseLazy,
			function (_p5) {
				var _p6 = _p5;
				return A2(
					_elm_lang$core$Maybe$map,
					accessor,
					(_elm_lang$core$Native_Utils.cmp(distance, 0) < 0) ? _ianmackenzie$acorn_demo$Database$firstEntry(database) : _ianmackenzie$acorn_demo$Database$lastEntry(database));
			},
			maybeValue);
	});
var _ianmackenzie$acorn_demo$Database$limitBy = F4(
	function (brake, accelerate, _p7, distance) {
		var _p8 = _p7;
		var _p10 = _p8._1;
		var _p9 = _ianmackenzie$elm_interval$Interval$endpoints(_p8._0);
		var startDistance = _p9._0;
		var endDistance = _p9._1;
		if (_elm_lang$core$Native_Utils.cmp(distance, startDistance) < 0) {
			var delta = startDistance - distance;
			return _elm_lang$core$Basics$sqrt(
				(_p10 * _p10) + ((2 * _elm_lang$core$Basics$abs(brake)) * delta));
		} else {
			if (_elm_lang$core$Native_Utils.cmp(distance, endDistance) > 0) {
				var delta = distance - endDistance;
				return _elm_lang$core$Basics$sqrt(
					(_p10 * _p10) + ((2 * _elm_lang$core$Basics$abs(accelerate)) * delta));
			} else {
				return _p10;
			}
		}
	});
var _ianmackenzie$acorn_demo$Database$safeLimit = F3(
	function (config, lineSpeed, distance) {
		return A4(_ianmackenzie$acorn_demo$Database$limitBy, config.brakeAcceleration, config.maxAcceleration, lineSpeed, distance);
	});
var _ianmackenzie$acorn_demo$Database$maxSafeSpeedAlong = F3(
	function (track, config, distance) {
		var capSpeed = F2(
			function (lineSpeed, resultSoFar) {
				return A2(
					_elm_lang$core$Basics$min,
					resultSoFar,
					A3(_ianmackenzie$acorn_demo$Database$safeLimit, config, lineSpeed, distance));
			});
		return A3(
			_elm_lang$core$List$foldl,
			capSpeed,
			1 / 0,
			_ianmackenzie$acorn_demo$Track$lineSpeeds(track));
	});
var _ianmackenzie$acorn_demo$Database$coastableLimit = F3(
	function (config, lineSpeed, distance) {
		return A4(_ianmackenzie$acorn_demo$Database$limitBy, config.coastAcceleration, config.maxAcceleration, lineSpeed, distance);
	});
var _ianmackenzie$acorn_demo$Database$coastableSpeedAlong = F3(
	function (track, config, distance) {
		var capSpeed = F2(
			function (lineSpeed, resultSoFar) {
				return A2(
					_elm_lang$core$Basics$min,
					resultSoFar,
					A3(_ianmackenzie$acorn_demo$Database$coastableLimit, config, lineSpeed, distance));
			});
		return A3(
			_elm_lang$core$List$foldl,
			capSpeed,
			1 / 0,
			_ianmackenzie$acorn_demo$Track$lineSpeeds(track));
	});
var _ianmackenzie$acorn_demo$Database$scheduledSpeedAlong = F3(
	function (track, config, distance) {
		return A2(
			_elm_lang$core$Basics$min,
			config.nominalSpeed,
			0.85 * A3(_ianmackenzie$acorn_demo$Database$coastableSpeedAlong, track, config, distance));
	});
var _ianmackenzie$acorn_demo$Database$createEntry = F4(
	function (config, track, distance, scheduledTime) {
		return {
			distance: distance,
			maxSafeSpeed: A3(_ianmackenzie$acorn_demo$Database$maxSafeSpeedAlong, track, config, distance),
			coastableSpeed: A3(_ianmackenzie$acorn_demo$Database$coastableSpeedAlong, track, config, distance),
			scheduledSpeed: A3(_ianmackenzie$acorn_demo$Database$scheduledSpeedAlong, track, config, distance),
			scheduledTime: scheduledTime
		};
	});
var _ianmackenzie$acorn_demo$Database$stepDistance = 1;
var _ianmackenzie$acorn_demo$Database$entry = F2(
	function (distance, _p11) {
		var _p12 = _p11;
		return A2(
			_Skinney$elm_array_exploration$Array_Hamt$get,
			_elm_lang$core$Basics$floor(distance / _ianmackenzie$acorn_demo$Database$stepDistance),
			_p12._0);
	});
var _ianmackenzie$acorn_demo$Database$maxSafeSpeed = F2(
	function (distance, database) {
		return A2(
			_elm_lang$core$Maybe$withDefault,
			0,
			A4(
				_ianmackenzie$acorn_demo$Database$orEndpointFor,
				distance,
				database,
				function (_) {
					return _.maxSafeSpeed;
				},
				A2(
					_elm_lang$core$Maybe$map,
					function (_) {
						return _.maxSafeSpeed;
					},
					A2(_ianmackenzie$acorn_demo$Database$entry, distance, database))));
	});
var _ianmackenzie$acorn_demo$Database$coastableSpeed = F2(
	function (distance, database) {
		return A2(
			_elm_lang$core$Maybe$withDefault,
			0,
			A4(
				_ianmackenzie$acorn_demo$Database$orEndpointFor,
				distance,
				database,
				function (_) {
					return _.coastableSpeed;
				},
				A2(
					_elm_lang$core$Maybe$map,
					function (_) {
						return _.coastableSpeed;
					},
					A2(_ianmackenzie$acorn_demo$Database$entry, distance, database))));
	});
var _ianmackenzie$acorn_demo$Database$scheduledSpeed = F2(
	function (distance, database) {
		return A4(
			_ianmackenzie$acorn_demo$Database$orEndpointFor,
			distance,
			database,
			function (_) {
				return _.scheduledSpeed;
			},
			A2(
				_elm_lang$core$Maybe$map,
				function (_) {
					return _.scheduledSpeed;
				},
				A2(_ianmackenzie$acorn_demo$Database$entry, distance, database)));
	});
var _ianmackenzie$acorn_demo$Database$scheduledTime = F2(
	function (distance, database) {
		return A2(
			_elm_lang$core$Maybe$map,
			function (entry) {
				return entry.scheduledTime + ((distance - entry.distance) / entry.scheduledSpeed);
			},
			A2(_ianmackenzie$acorn_demo$Database$entry, distance, database));
	});
var _ianmackenzie$acorn_demo$Database$Entry = F5(
	function (a, b, c, d, e) {
		return {distance: a, maxSafeSpeed: b, scheduledSpeed: c, coastableSpeed: d, scheduledTime: e};
	});
var _ianmackenzie$acorn_demo$Database$Config = F4(
	function (a, b, c, d) {
		return {nominalSpeed: a, coastAcceleration: b, brakeAcceleration: c, maxAcceleration: d};
	});
var _ianmackenzie$acorn_demo$Database$Database = function (a) {
	return {ctor: 'Database', _0: a};
};
var _ianmackenzie$acorn_demo$Database$init = F2(
	function (config, track) {
		var initialEntry = A4(_ianmackenzie$acorn_demo$Database$createEntry, config, track, 0, 0);
		var trackLength = _ianmackenzie$acorn_demo$Track$length(track);
		var numEntries = _elm_lang$core$Basics$ceiling(trackLength / _ianmackenzie$acorn_demo$Database$stepDistance) + 1;
		var distances = A2(
			_elm_lang$core$List$map,
			function (index) {
				return _elm_lang$core$Basics$toFloat(index) * _ianmackenzie$acorn_demo$Database$stepDistance;
			},
			A2(_elm_lang$core$List$range, 1, numEntries - 1));
		var entries = A3(
			_elm_lang$core$List$scanl,
			F2(
				function (distance, previousEntry) {
					var scheduledDelta = _ianmackenzie$acorn_demo$Database$stepDistance / previousEntry.scheduledSpeed;
					var scheduledTime = previousEntry.scheduledTime + scheduledDelta;
					return A4(_ianmackenzie$acorn_demo$Database$createEntry, config, track, distance, scheduledTime);
				}),
			initialEntry,
			distances);
		return _ianmackenzie$acorn_demo$Database$Database(
			_Skinney$elm_array_exploration$Array_Hamt$fromList(entries));
	});

var _ianmackenzie$acorn_demo$Train$brakeOffset = 5;
var _ianmackenzie$acorn_demo$Train$brakeOverride = function (_p0) {
	var _p1 = _p0;
	return _p1._0.brakeOverride;
};
var _ianmackenzie$acorn_demo$Train$inputs = function (_p2) {
	var _p3 = _p2;
	return _p3._0.inputs;
};
var _ianmackenzie$acorn_demo$Train$activeBrakes = function (train) {
	return A2(
		_elm_community$maybe_extra$Maybe_Extra$orElse,
		A2(
			_elm_lang$core$Maybe$map,
			function (_) {
				return _.brakes;
			},
			_ianmackenzie$acorn_demo$Train$inputs(train)),
		A2(
			_elm_lang$core$Maybe$map,
			_elm_lang$core$Tuple$first,
			_ianmackenzie$acorn_demo$Train$brakeOverride(train)));
};
var _ianmackenzie$acorn_demo$Train$database = function (_p4) {
	var _p5 = _p4;
	return _p5._0.database;
};
var _ianmackenzie$acorn_demo$Train$age = function (_p6) {
	var _p7 = _p6;
	return _p7._0.age;
};
var _ianmackenzie$acorn_demo$Train$type_ = function (_p8) {
	var _p9 = _p8;
	return _p9._0.type_;
};
var _ianmackenzie$acorn_demo$Train$direction = function (_p10) {
	var _p11 = _p10;
	return _p11._0.direction;
};
var _ianmackenzie$acorn_demo$Train$position = function (_p12) {
	var _p13 = _p12;
	return _p13._0.position;
};
var _ianmackenzie$acorn_demo$Train$speed = function (_p14) {
	var _p15 = _p14;
	return _p15._0.speed;
};
var _ianmackenzie$acorn_demo$Train$headway = function (_p16) {
	var _p17 = _p16;
	return _p17._0.headway;
};
var _ianmackenzie$acorn_demo$Train$distanceAlongTrack = function (_p18) {
	var _p19 = _p18;
	return _p19._0.distanceAlongTrack;
};
var _ianmackenzie$acorn_demo$Train$maxSafeSpeed = function (train) {
	return A2(
		_ianmackenzie$acorn_demo$Database$maxSafeSpeed,
		_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train),
		_ianmackenzie$acorn_demo$Train$database(train));
};
var _ianmackenzie$acorn_demo$Train$scheduledSpeed = function (train) {
	return A2(
		_ianmackenzie$acorn_demo$Database$scheduledSpeed,
		_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train),
		_ianmackenzie$acorn_demo$Train$database(train));
};
var _ianmackenzie$acorn_demo$Train$coastableSpeed = function (train) {
	return A2(
		_ianmackenzie$acorn_demo$Database$coastableSpeed,
		_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train),
		_ianmackenzie$acorn_demo$Train$database(train));
};
var _ianmackenzie$acorn_demo$Train$deviationFromSchedule = function (train) {
	return A2(
		_elm_lang$core$Maybe$withDefault,
		0,
		A2(
			_elm_lang$core$Maybe$map,
			function (scheduledTime) {
				return scheduledTime - _ianmackenzie$acorn_demo$Train$age(train);
			},
			A2(
				_ianmackenzie$acorn_demo$Database$scheduledTime,
				_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train),
				_ianmackenzie$acorn_demo$Train$database(train))));
};
var _ianmackenzie$acorn_demo$Train$track = function (_p20) {
	var _p21 = _p20;
	return _p21._0.track;
};
var _ianmackenzie$acorn_demo$Train$id = function (_p22) {
	var _p23 = _p22;
	return _p23._0.id;
};
var _ianmackenzie$acorn_demo$Train$width = 16;
var _ianmackenzie$acorn_demo$Train$length = 48;
var _ianmackenzie$acorn_demo$Train$draw = F2(
	function (attributes, train) {
		var numberString = A3(
			_elm_lang$core$String$padLeft,
			3,
			_elm_lang$core$Native_Utils.chr('0'),
			_elm_lang$core$Basics$toString(
				_ianmackenzie$acorn_demo$Train$id(train)));
		var localFrame = A2(
			_ianmackenzie$acorn_demo$Frame2d$withXDirection,
			_ianmackenzie$acorn_demo$Train$direction(train),
			_ianmackenzie$acorn_demo$Train$position(train));
		var litBrakes = function (color) {
			return A2(
				_ianmackenzie$acorn_demo$Drawing2d$dotsWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(color),
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noBorder,
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$dotRadius(3),
							_1: {ctor: '[]'}
						}
					}
				},
				A2(
					_elm_lang$core$List$map,
					_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn(localFrame),
					{
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: _ianmackenzie$acorn_demo$Train$length / 2, _1: _ianmackenzie$acorn_demo$Train$width / 4},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: _ianmackenzie$acorn_demo$Train$length / 2, _1: (0 - _ianmackenzie$acorn_demo$Train$width) / 4},
							_1: {
								ctor: '::',
								_0: {ctor: '_Tuple2', _0: (0 - _ianmackenzie$acorn_demo$Train$length) / 2, _1: _ianmackenzie$acorn_demo$Train$width / 4},
								_1: {
									ctor: '::',
									_0: {ctor: '_Tuple2', _0: (0 - _ianmackenzie$acorn_demo$Train$length) / 2, _1: (0 - _ianmackenzie$acorn_demo$Train$width) / 4},
									_1: {ctor: '[]'}
								}
							}
						}
					}));
		};
		var brakeLights = function () {
			var _p24 = _ianmackenzie$acorn_demo$Train$activeBrakes(train);
			if (_p24.ctor === 'Just') {
				if (_p24._0.ctor === 'EmergencyBrakes') {
					return litBrakes(_elm_lang$core$Color$red);
				} else {
					return (_elm_lang$core$Native_Utils.cmp(_p24._0._0, 0) > 0) ? litBrakes(_elm_lang$core$Color$yellow) : _ianmackenzie$acorn_demo$Drawing2d$empty;
				}
			} else {
				return _ianmackenzie$acorn_demo$Drawing2d$empty;
			}
		}();
		return _ianmackenzie$acorn_demo$Drawing2d$group(
			{
				ctor: '::',
				_0: brakeLights,
				_1: {
					ctor: '::',
					_0: A2(
						_ianmackenzie$acorn_demo$Drawing2d$rectangleWith,
						attributes,
						A2(
							_ianmackenzie$acorn_demo$Rectangle2d$centeredOn,
							localFrame,
							{ctor: '_Tuple2', _0: _ianmackenzie$acorn_demo$Train$length, _1: _ianmackenzie$acorn_demo$Train$width})),
					_1: {
						ctor: '::',
						_0: A2(
							_ianmackenzie$acorn_demo$Drawing2d$placeIn,
							localFrame,
							A3(
								_ianmackenzie$acorn_demo$Drawing2d$textWith,
								{
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$center),
									_1: {ctor: '[]'}
								},
								_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
									{ctor: '_Tuple2', _0: 0, _1: -1}),
								numberString)),
						_1: {ctor: '[]'}
					}
				}
			});
	});
var _ianmackenzie$acorn_demo$Train$emergencyBrakeAcceleration = -12;
var _ianmackenzie$acorn_demo$Train$emergencyBrakingDistance = function (train) {
	var trainSpeed = _ianmackenzie$acorn_demo$Train$speed(train);
	return (trainSpeed * trainSpeed) / (2 * _elm_lang$core$Basics$abs(_ianmackenzie$acorn_demo$Train$emergencyBrakeAcceleration));
};
var _ianmackenzie$acorn_demo$Train$normalBrakeAcceleration = -6;
var _ianmackenzie$acorn_demo$Train$brakingDistance = function (train) {
	var trainSpeed = _ianmackenzie$acorn_demo$Train$speed(train);
	return (trainSpeed * trainSpeed) / (2 * _elm_lang$core$Basics$abs(_ianmackenzie$acorn_demo$Train$normalBrakeAcceleration));
};
var _ianmackenzie$acorn_demo$Train$headwayFractions = function (train) {
	var trainHeadway = _ianmackenzie$acorn_demo$Train$headway(train);
	if (_elm_lang$core$Basics$isInfinite(trainHeadway)) {
		return {
			red: _elm_lang$core$Maybe$Nothing,
			yellow: _elm_lang$core$Maybe$Nothing,
			green: _elm_lang$core$Maybe$Just(
				A2(_ianmackenzie$elm_interval$Interval$from, 0, 1))
		};
	} else {
		var redLimit = _ianmackenzie$acorn_demo$Train$emergencyBrakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset;
		var redStart = A2(_elm_lang$core$Basics$max, 0, 1 - (redLimit / trainHeadway));
		var red = _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$elm_interval$Interval$from, redStart, 1));
		var yellowLimit = _ianmackenzie$acorn_demo$Train$brakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset;
		var yellowStart = A2(_elm_lang$core$Basics$max, 0, 1 - (yellowLimit / trainHeadway));
		var yellow = (_elm_lang$core$Native_Utils.cmp(trainHeadway, redLimit) > 0) ? _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$elm_interval$Interval$from, yellowStart, redStart)) : _elm_lang$core$Maybe$Nothing;
		var green = (_elm_lang$core$Native_Utils.cmp(trainHeadway, yellowLimit) > 0) ? _elm_lang$core$Maybe$Just(
			A2(_ianmackenzie$elm_interval$Interval$from, 0, yellowStart)) : _elm_lang$core$Maybe$Nothing;
		return {red: red, yellow: yellow, green: green};
	}
};
var _ianmackenzie$acorn_demo$Train$maxAcceleration = 9;
var _ianmackenzie$acorn_demo$Train$coastAcceleration = -3;
var _ianmackenzie$acorn_demo$Train$acceleration = F2(
	function (train, inputs) {
		var _p25 = _ianmackenzie$acorn_demo$Train$brakeOverride(train);
		if (_p25.ctor === 'Just') {
			if (_p25._0._0.ctor === 'EmergencyBrakes') {
				return _ianmackenzie$acorn_demo$Train$emergencyBrakeAcceleration;
			} else {
				return _p25._0._0._0 * _ianmackenzie$acorn_demo$Train$normalBrakeAcceleration;
			}
		} else {
			var _p26 = inputs;
			if (_p26.ctor === 'Just') {
				var brakeAcceleration = function () {
					var _p27 = _p26._0.brakes;
					if (_p27.ctor === 'Brakes') {
						return _p27._0 * _ianmackenzie$acorn_demo$Train$normalBrakeAcceleration;
					} else {
						return _ianmackenzie$acorn_demo$Train$emergencyBrakeAcceleration;
					}
				}();
				var throttleAcceleration = _p26._0.throttle * _ianmackenzie$acorn_demo$Train$maxAcceleration;
				return throttleAcceleration + brakeAcceleration;
			} else {
				var windowSize = 0.5;
				var deviation = _ianmackenzie$acorn_demo$Train$deviationFromSchedule(train);
				return (_elm_lang$core$Native_Utils.cmp(
					_ianmackenzie$acorn_demo$Train$headway(train),
					1.2 * (_ianmackenzie$acorn_demo$Train$brakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset)) < 0) ? _ianmackenzie$acorn_demo$Train$coastAcceleration : (((_elm_lang$core$Native_Utils.cmp(deviation, 0) < 0) && (_elm_lang$core$Native_Utils.cmp(
					_ianmackenzie$acorn_demo$Train$speed(train),
					0.9 * _ianmackenzie$acorn_demo$Train$coastableSpeed(train)) < 0)) ? ((_elm_lang$core$Native_Utils.cmp(
					_elm_lang$core$Basics$abs(deviation),
					windowSize) > 0) ? _ianmackenzie$acorn_demo$Train$maxAcceleration : ((_ianmackenzie$acorn_demo$Train$maxAcceleration * _elm_lang$core$Basics$abs(deviation)) / windowSize)) : ((_elm_lang$core$Native_Utils.cmp(
					_ianmackenzie$acorn_demo$Train$speed(train),
					0.8 * A2(
						_elm_lang$core$Maybe$withDefault,
						0,
						_ianmackenzie$acorn_demo$Train$scheduledSpeed(train))) > 0) ? _ianmackenzie$acorn_demo$Train$coastAcceleration : 0));
			}
		}
	});
var _ianmackenzie$acorn_demo$Train$topSpeed = 80;
var _ianmackenzie$acorn_demo$Train$expressSpeed = 45.6698;
var _ianmackenzie$acorn_demo$Train$localSpeed = 27.23652;
var _ianmackenzie$acorn_demo$Train$speedForType = function (type_) {
	var _p28 = type_;
	if (_p28.ctor === 'Local') {
		return _ianmackenzie$acorn_demo$Train$localSpeed;
	} else {
		return _ianmackenzie$acorn_demo$Train$expressSpeed;
	}
};
var _ianmackenzie$acorn_demo$Train$initDatabase = F2(
	function (type_, track) {
		return A2(
			_ianmackenzie$acorn_demo$Database$init,
			{
				nominalSpeed: _ianmackenzie$acorn_demo$Train$speedForType(type_),
				coastAcceleration: _ianmackenzie$acorn_demo$Train$coastAcceleration,
				brakeAcceleration: _ianmackenzie$acorn_demo$Train$normalBrakeAcceleration,
				maxAcceleration: _ianmackenzie$acorn_demo$Train$maxAcceleration
			},
			track);
	});
var _ianmackenzie$acorn_demo$Train$Inputs = F2(
	function (a, b) {
		return {throttle: a, brakes: b};
	});
var _ianmackenzie$acorn_demo$Train$Train = function (a) {
	return {ctor: 'Train', _0: a};
};
var _ianmackenzie$acorn_demo$Train$spawn = F5(
	function (type_, id, track, database, headway_) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (_p29) {
				var _p30 = _p29;
				var train = _ianmackenzie$acorn_demo$Train$Train(
					{
						track: track,
						type_: type_,
						id: id,
						distanceAlongTrack: 0,
						position: _p30._0,
						direction: _p30._1,
						speed: _ianmackenzie$acorn_demo$Train$speedForType(type_),
						age: 0,
						inputs: _elm_lang$core$Maybe$Nothing,
						headway: headway_,
						database: database,
						brakeOverride: _elm_lang$core$Maybe$Nothing
					});
				return (_elm_lang$core$Native_Utils.cmp(
					_ianmackenzie$acorn_demo$Train$headway(train),
					_ianmackenzie$acorn_demo$Train$brakingDistance(train)) > 0) ? _elm_lang$core$Maybe$Just(train) : _elm_lang$core$Maybe$Nothing;
			},
			A2(_ianmackenzie$acorn_demo$Track$evaluateAlong, track, 0));
	});
var _ianmackenzie$acorn_demo$Train$EmergencyBrakes = {ctor: 'EmergencyBrakes'};
var _ianmackenzie$acorn_demo$Train$Brakes = function (a) {
	return {ctor: 'Brakes', _0: a};
};
var _ianmackenzie$acorn_demo$Train$Overspeed = {ctor: 'Overspeed'};
var _ianmackenzie$acorn_demo$Train$HeadwayInfringement = {ctor: 'HeadwayInfringement'};
var _ianmackenzie$acorn_demo$Train$updatedBrakeOverride = function (train) {
	var trainHeadway = _ianmackenzie$acorn_demo$Train$headway(train);
	if (_elm_lang$core$Native_Utils.cmp(
		_ianmackenzie$acorn_demo$Train$headway(train),
		_ianmackenzie$acorn_demo$Train$emergencyBrakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset) < 1) {
		return _elm_lang$core$Maybe$Just(
			{ctor: '_Tuple2', _0: _ianmackenzie$acorn_demo$Train$EmergencyBrakes, _1: _ianmackenzie$acorn_demo$Train$HeadwayInfringement});
	} else {
		if (_elm_lang$core$Native_Utils.cmp(
			_ianmackenzie$acorn_demo$Train$headway(train),
			_ianmackenzie$acorn_demo$Train$brakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset) < 1) {
			return _elm_lang$core$Maybe$Just(
				{
					ctor: '_Tuple2',
					_0: _ianmackenzie$acorn_demo$Train$Brakes(1),
					_1: _ianmackenzie$acorn_demo$Train$HeadwayInfringement
				});
		} else {
			if (_elm_lang$core$Native_Utils.cmp(
				_ianmackenzie$acorn_demo$Train$speed(train),
				_ianmackenzie$acorn_demo$Train$maxSafeSpeed(train)) > 0) {
				return _elm_lang$core$Maybe$Just(
					{
						ctor: '_Tuple2',
						_0: _ianmackenzie$acorn_demo$Train$Brakes(1),
						_1: _ianmackenzie$acorn_demo$Train$Overspeed
					});
			} else {
				var _p31 = _ianmackenzie$acorn_demo$Train$brakeOverride(train);
				if (_p31.ctor === 'Just') {
					if (_p31._0._1.ctor === 'HeadwayInfringement') {
						if (_p31._0._0.ctor === 'EmergencyBrakes') {
							return _elm_lang$core$Native_Utils.eq(
								_ianmackenzie$acorn_demo$Train$speed(train),
								0) ? _elm_lang$core$Maybe$Nothing : _elm_lang$core$Maybe$Just(
								{ctor: '_Tuple2', _0: _ianmackenzie$acorn_demo$Train$EmergencyBrakes, _1: _ianmackenzie$acorn_demo$Train$HeadwayInfringement});
						} else {
							return (_elm_lang$core$Native_Utils.cmp(
								_ianmackenzie$acorn_demo$Train$headway(train),
								1.2 * (_ianmackenzie$acorn_demo$Train$brakingDistance(train) + _ianmackenzie$acorn_demo$Train$brakeOffset)) > 0) ? _elm_lang$core$Maybe$Nothing : _elm_lang$core$Maybe$Just(
								{
									ctor: '_Tuple2',
									_0: _ianmackenzie$acorn_demo$Train$Brakes(1),
									_1: _ianmackenzie$acorn_demo$Train$HeadwayInfringement
								});
						}
					} else {
						return (_elm_lang$core$Native_Utils.cmp(
							_ianmackenzie$acorn_demo$Train$speed(train),
							_ianmackenzie$acorn_demo$Train$maxSafeSpeed(train) - 5) < 0) ? _elm_lang$core$Maybe$Nothing : _elm_lang$core$Maybe$Just(
							{ctor: '_Tuple2', _0: _p31._0._0, _1: _ianmackenzie$acorn_demo$Train$Overspeed});
					}
				} else {
					return _elm_lang$core$Maybe$Nothing;
				}
			}
		}
	}
};
var _ianmackenzie$acorn_demo$Train$update = F4(
	function (delta, inputs, headway, train) {
		var currentSpeed = _ianmackenzie$acorn_demo$Train$speed(train);
		var updatedDistance = _ianmackenzie$acorn_demo$Train$distanceAlongTrack(train) + (delta * currentSpeed);
		var updatedSpeed = A3(
			_elm_lang$core$Basics$clamp,
			0,
			_ianmackenzie$acorn_demo$Train$topSpeed,
			currentSpeed + (delta * A2(_ianmackenzie$acorn_demo$Train$acceleration, train, inputs)));
		var trainTrack = _ianmackenzie$acorn_demo$Train$track(train);
		return A2(
			_elm_lang$core$Maybe$map,
			function (_p32) {
				var _p33 = _p32;
				return _ianmackenzie$acorn_demo$Train$Train(
					{
						id: _ianmackenzie$acorn_demo$Train$id(train),
						track: trainTrack,
						type_: _ianmackenzie$acorn_demo$Train$type_(train),
						distanceAlongTrack: updatedDistance,
						speed: updatedSpeed,
						position: _p33._0,
						direction: _p33._1,
						age: _ianmackenzie$acorn_demo$Train$age(train) + delta,
						inputs: inputs,
						headway: headway,
						database: _ianmackenzie$acorn_demo$Train$database(train),
						brakeOverride: _ianmackenzie$acorn_demo$Train$updatedBrakeOverride(train)
					});
			},
			A2(_ianmackenzie$acorn_demo$Track$evaluateAlong, trainTrack, updatedDistance));
	});
var _ianmackenzie$acorn_demo$Train$Local = {ctor: 'Local'};
var _ianmackenzie$acorn_demo$Train$Express = {ctor: 'Express'};

var _ianmackenzie$acorn_demo$Controller$inputs = function (_p0) {
	var _p1 = _p0;
	var _p2 = _p1._0;
	return {
		throttle: _p2.throttle,
		brakes: _p2.emergencyBrake ? _ianmackenzie$acorn_demo$Train$EmergencyBrakes : _ianmackenzie$acorn_demo$Train$Brakes(_p2.brake)
	};
};
var _ianmackenzie$acorn_demo$Controller$MoveDown = {ctor: 'MoveDown'};
var _ianmackenzie$acorn_demo$Controller$MoveUp = {ctor: 'MoveUp'};
var _ianmackenzie$acorn_demo$Controller$MoveRight = {ctor: 'MoveRight'};
var _ianmackenzie$acorn_demo$Controller$MoveLeft = {ctor: 'MoveLeft'};
var _ianmackenzie$acorn_demo$Controller$events = F2(
	function (_p4, _p3) {
		var _p5 = _p4;
		var _p8 = _p5._0;
		var _p6 = _p3;
		var _p7 = _p6._0;
		var moveDownEvent = (_p7.downPressed && (!_p8.downPressed)) ? _elm_lang$core$Maybe$Just(_ianmackenzie$acorn_demo$Controller$MoveDown) : _elm_lang$core$Maybe$Nothing;
		var moveUpEvent = (_p7.upPressed && (!_p8.upPressed)) ? _elm_lang$core$Maybe$Just(_ianmackenzie$acorn_demo$Controller$MoveUp) : _elm_lang$core$Maybe$Nothing;
		var moveRightEvent = (_p7.rightPressed && (!_p8.rightPressed)) ? _elm_lang$core$Maybe$Just(_ianmackenzie$acorn_demo$Controller$MoveRight) : _elm_lang$core$Maybe$Nothing;
		var moveLeftEvent = (_p7.leftPressed && (!_p8.leftPressed)) ? _elm_lang$core$Maybe$Just(_ianmackenzie$acorn_demo$Controller$MoveLeft) : _elm_lang$core$Maybe$Nothing;
		return _elm_community$maybe_extra$Maybe_Extra$values(
			{
				ctor: '::',
				_0: moveLeftEvent,
				_1: {
					ctor: '::',
					_0: moveRightEvent,
					_1: {
						ctor: '::',
						_0: moveUpEvent,
						_1: {
							ctor: '::',
							_0: moveDownEvent,
							_1: {ctor: '[]'}
						}
					}
				}
			});
	});
var _ianmackenzie$acorn_demo$Controller$Controller = function (a) {
	return {ctor: 'Controller', _0: a};
};
var _ianmackenzie$acorn_demo$Controller$fromGamepad = function (gamepad) {
	return _ianmackenzie$acorn_demo$Controller$Controller(
		{
			upPressed: _xarvh$elm_gamepad$Gamepad$dpadUpIsPressed(gamepad),
			downPressed: _xarvh$elm_gamepad$Gamepad$dpadDownIsPressed(gamepad),
			leftPressed: _xarvh$elm_gamepad$Gamepad$dpadLeftIsPressed(gamepad),
			rightPressed: _xarvh$elm_gamepad$Gamepad$dpadRightIsPressed(gamepad),
			throttle: A2(
				_elm_lang$core$Basics$max,
				0,
				_xarvh$elm_gamepad$Gamepad$rightY(gamepad)),
			brake: _xarvh$elm_gamepad$Gamepad$rightTriggerValue(gamepad),
			emergencyBrake: _xarvh$elm_gamepad$Gamepad$bIsPressed(gamepad)
		});
};
var _ianmackenzie$acorn_demo$Controller$init = _ianmackenzie$acorn_demo$Controller$fromGamepad;
var _ianmackenzie$acorn_demo$Controller$update = F2(
	function (gamepad, controller) {
		var updatedController = _ianmackenzie$acorn_demo$Controller$fromGamepad(gamepad);
		return {
			ctor: '_Tuple2',
			_0: updatedController,
			_1: A2(_ianmackenzie$acorn_demo$Controller$events, controller, updatedController)
		};
	});

var _ianmackenzie$acorn_demo$HeadwayIndicator$draw = function (_p0) {
	var _p1 = _p0;
	var _p7 = _p1.startPoint;
	var _p6 = _p1.endPoint;
	var _p2 = A2(_ianmackenzie$acorn_demo$Direction2d$from, _p7, _p6);
	if (_p2.ctor === 'Just') {
		var _p5 = _p2._0;
		var headwayFractions = _ianmackenzie$acorn_demo$Train$headwayFractions(_p1.train);
		var gradientAxis = A2(_ianmackenzie$acorn_demo$Axis2d$through, _p7, _p5);
		var halfWidth = _p1.width / 2;
		var frame = A2(_ianmackenzie$acorn_demo$Frame2d$withXDirection, _p5, _p7);
		var length = A2(_ianmackenzie$acorn_demo$Point2d$distanceFrom, _p7, _p6);
		var colorStops = F2(
			function (color, fraction) {
				var _p3 = fraction;
				if (_p3.ctor === 'Just') {
					var _p4 = _p3._0;
					return {
						ctor: '::',
						_0: {
							ctor: '_Tuple2',
							_0: length * _ianmackenzie$elm_interval$Interval$minValue(_p4),
							_1: color
						},
						_1: {
							ctor: '::',
							_0: {
								ctor: '_Tuple2',
								_0: length * _ianmackenzie$elm_interval$Interval$maxValue(_p4),
								_1: color
							},
							_1: {ctor: '[]'}
						}
					};
				} else {
					return {ctor: '[]'};
				}
			});
		var gradientStops = _elm_lang$core$List$concat(
			{
				ctor: '::',
				_0: A2(colorStops, _elm_lang$core$Color$darkGreen, headwayFractions.green),
				_1: {
					ctor: '::',
					_0: A2(colorStops, _elm_lang$core$Color$darkYellow, headwayFractions.yellow),
					_1: {
						ctor: '::',
						_0: A2(colorStops, _elm_lang$core$Color$darkRed, headwayFractions.red),
						_1: {ctor: '[]'}
					}
				}
			});
		return A3(
			_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
			{
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackStroke,
				_1: {
					ctor: '::',
					_0: A2(_ianmackenzie$acorn_demo$Drawing2d_Attributes$gradientFillAlong, gradientAxis, gradientStops),
					_1: {ctor: '[]'}
				}
			},
			_p1.cornerRadius,
			A2(
				_ianmackenzie$acorn_demo$Rectangle2d$fromExtremaIn,
				frame,
				{minX: 0, maxX: length, minY: 0 - halfWidth, maxY: halfWidth}));
	} else {
		return _ianmackenzie$acorn_demo$Drawing2d$empty;
	}
};

var _ianmackenzie$acorn_demo$Line$trackOffset = 15;
var _ianmackenzie$acorn_demo$Line$offsetControlPoint = F4(
	function (offset, point, firstDerivative, secondDerivative) {
		var normalizedDerivative = _ianmackenzie$acorn_demo$Vector2d$normalize(firstDerivative);
		var radialVector = A2(
			_ianmackenzie$acorn_demo$Vector2d$scaleBy,
			offset,
			_ianmackenzie$acorn_demo$Vector2d$rotateCounterclockwise(normalizedDerivative));
		var offsetPoint = A2(_ianmackenzie$acorn_demo$Point2d$translateBy, radialVector, point);
		var rotationRate = A2(_ianmackenzie$acorn_demo$Vector2d$crossProduct, firstDerivative, secondDerivative) / _ianmackenzie$acorn_demo$Vector2d$squaredLength(firstDerivative);
		var offsetDerivative = A2(
			_ianmackenzie$acorn_demo$Vector2d$sum,
			firstDerivative,
			A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, (0 - rotationRate) * offset, normalizedDerivative));
		return {ctor: '_Tuple2', _0: offsetPoint, _1: offsetDerivative};
	});
var _ianmackenzie$acorn_demo$Line$offsetBy = F2(
	function (offset, spline) {
		var numSegments = 8;
		var parameterValues = _ianmackenzie$acorn_demo$Geometry_Parameter$numSteps(numSegments);
		var points = A2(_ianmackenzie$acorn_demo$CubicSpline2d$pointsOn, spline, parameterValues);
		var firstDerivatives = A2(_ianmackenzie$acorn_demo$CubicSpline2d$derivatives, spline, parameterValues);
		var secondDerivatives = A2(_ianmackenzie$acorn_demo$CubicSpline2d$secondDerivatives, spline, parameterValues);
		var offsetControlPoints = A4(
			_elm_lang$core$List$map3,
			_ianmackenzie$acorn_demo$Line$offsetControlPoint(offset),
			points,
			firstDerivatives,
			secondDerivatives);
		var createSpline = F2(
			function (startControlPoint, endControlPoint) {
				var _p0 = endControlPoint;
				var endPoint = _p0._0;
				var endDerivative = _p0._1;
				var _p1 = startControlPoint;
				var startPoint = _p1._0;
				var startDerivative = _p1._1;
				return _ianmackenzie$acorn_demo$CubicSpline2d$fromEndpoints(
					{
						startPoint: startPoint,
						endPoint: endPoint,
						startDerivative: A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, 1 / numSegments, startDerivative),
						endDerivative: A2(_ianmackenzie$acorn_demo$Vector2d$scaleBy, 1 / numSegments, endDerivative)
					});
			});
		return A3(
			_elm_lang$core$List$map2,
			createSpline,
			offsetControlPoints,
			A2(_elm_lang$core$List$drop, 1, offsetControlPoints));
	});
var _ianmackenzie$acorn_demo$Line$build = function (segments) {
	var offsetSegments = function (distance) {
		return _elm_lang$core$List$concat(
			A2(
				_elm_lang$core$List$map,
				function (_p2) {
					var _p3 = _p2;
					return A2(
						_elm_lang$core$List$map,
						function (offsetSpline) {
							return {ctor: '_Tuple2', _0: offsetSpline, _1: _p3._1};
						},
						A2(_ianmackenzie$acorn_demo$Line$offsetBy, distance, _p3._0));
				},
				segments));
	};
	return {
		expressTrack: _ianmackenzie$acorn_demo$Track$build(
			offsetSegments(0 - _ianmackenzie$acorn_demo$Line$trackOffset)),
		localTrack: _ianmackenzie$acorn_demo$Track$build(
			offsetSegments(_ianmackenzie$acorn_demo$Line$trackOffset))
	};
};
var _ianmackenzie$acorn_demo$Line$workZoneSpeed = 15;
var _ianmackenzie$acorn_demo$Line$segment = function (_p4) {
	var _p5 = _p4;
	var endPoint = _ianmackenzie$acorn_demo$Point2d$fromCoordinates(_p5._1);
	var startPoint = _ianmackenzie$acorn_demo$Point2d$fromCoordinates(_p5._0);
	var dx = _ianmackenzie$acorn_demo$Vector2d$xComponent(
		A2(_ianmackenzie$acorn_demo$Vector2d$from, startPoint, endPoint));
	var derivativeVector = _ianmackenzie$acorn_demo$Vector2d$fromComponents(
		{ctor: '_Tuple2', _0: dx, _1: 0});
	var spline = _ianmackenzie$acorn_demo$CubicSpline2d$fromEndpoints(
		{startPoint: startPoint, endPoint: endPoint, startDerivative: derivativeVector, endDerivative: derivativeVector});
	return {ctor: '_Tuple2', _0: spline, _1: _p5._2};
};
var _ianmackenzie$acorn_demo$Line$init = function () {
	var mediumSpeed = 50;
	var highSpeed = 60;
	var c7 = {ctor: '_Tuple2', _0: 1790, _1: 500};
	var c6 = {ctor: '_Tuple2', _0: 1600, _1: 500};
	var c5 = {ctor: '_Tuple2', _0: 1300, _1: 380};
	var postSegments = A2(
		_elm_lang$core$List$map,
		_ianmackenzie$acorn_demo$Line$segment,
		{
			ctor: '::',
			_0: {ctor: '_Tuple3', _0: c5, _1: c6, _2: mediumSpeed},
			_1: {
				ctor: '::',
				_0: {ctor: '_Tuple3', _0: c6, _1: c7, _2: highSpeed},
				_1: {ctor: '[]'}
			}
		});
	var c4 = {ctor: '_Tuple2', _0: 950, _1: 240};
	var _p6 = _ianmackenzie$acorn_demo$Line$segment(
		{ctor: '_Tuple3', _0: c4, _1: c5, _2: 0});
	var tempSpline = _p6._0;
	var _p7 = _ianmackenzie$acorn_demo$CubicSpline2d$bisect(tempSpline);
	var firstHalf = _p7._0;
	var secondHalf = _p7._1;
	var _p8 = _ianmackenzie$acorn_demo$CubicSpline2d$bisect(firstHalf);
	var firstQuarter = _p8._0;
	var secondQuarter = _p8._1;
	var _p9 = _ianmackenzie$acorn_demo$CubicSpline2d$bisect(secondHalf);
	var thirdQuarter = _p9._0;
	var fourthQuarter = _p9._1;
	var midSegments = {
		ctor: '::',
		_0: {ctor: '_Tuple2', _0: firstQuarter, _1: mediumSpeed},
		_1: {
			ctor: '::',
			_0: {ctor: '_Tuple2', _0: secondQuarter, _1: _ianmackenzie$acorn_demo$Line$workZoneSpeed},
			_1: {
				ctor: '::',
				_0: {ctor: '_Tuple2', _0: thirdQuarter, _1: _ianmackenzie$acorn_demo$Line$workZoneSpeed},
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: fourthQuarter, _1: mediumSpeed},
					_1: {ctor: '[]'}
				}
			}
		}
	};
	var workZone = _ianmackenzie$acorn_demo$CubicSpline2d$fromEndpoints(
		{
			startPoint: _ianmackenzie$acorn_demo$CubicSpline2d$startPoint(secondQuarter),
			endPoint: _ianmackenzie$acorn_demo$CubicSpline2d$endPoint(thirdQuarter),
			startDerivative: A2(
				_ianmackenzie$acorn_demo$Vector2d$scaleBy,
				2,
				_ianmackenzie$acorn_demo$CubicSpline2d$startDerivative(secondQuarter)),
			endDerivative: A2(
				_ianmackenzie$acorn_demo$Vector2d$scaleBy,
				2,
				_ianmackenzie$acorn_demo$CubicSpline2d$endDerivative(thirdQuarter))
		});
	var c3 = {ctor: '_Tuple2', _0: 600, _1: 240};
	var c2 = {ctor: '_Tuple2', _0: 300, _1: 380};
	var c1 = {ctor: '_Tuple2', _0: 130, _1: 380};
	var preSegments = A2(
		_elm_lang$core$List$map,
		_ianmackenzie$acorn_demo$Line$segment,
		{
			ctor: '::',
			_0: {ctor: '_Tuple3', _0: c1, _1: c2, _2: highSpeed},
			_1: {
				ctor: '::',
				_0: {ctor: '_Tuple3', _0: c2, _1: c3, _2: mediumSpeed},
				_1: {
					ctor: '::',
					_0: {ctor: '_Tuple3', _0: c3, _1: c4, _2: highSpeed},
					_1: {ctor: '[]'}
				}
			}
		});
	var segments = A2(
		_elm_lang$core$Basics_ops['++'],
		preSegments,
		A2(_elm_lang$core$Basics_ops['++'], midSegments, postSegments));
	var _p10 = _ianmackenzie$acorn_demo$Line$build(segments);
	var expressTrack = _p10.expressTrack;
	var localTrack = _p10.localTrack;
	return {localTrack: localTrack, expressTrack: expressTrack, workZone: workZone};
}();

var _ianmackenzie$acorn_demo$ScreenBackground$draw = function (rectangle) {
	var axes = _ianmackenzie$acorn_demo$Rectangle2d$axes(rectangle);
	var boxHeight = 30;
	var _p0 = _ianmackenzie$acorn_demo$Rectangle2d$dimensions(rectangle);
	var width = _p0._0;
	var height = _p0._1;
	var numSegments = _elm_lang$core$Basics$round(width / boxHeight);
	var verticalBarCoordinates = A2(
		_elm_lang$core$List$map,
		function (i) {
			return ((0 - width) / 2) + ((width * _elm_lang$core$Basics$toFloat(i)) / _elm_lang$core$Basics$toFloat(numSegments));
		},
		A2(_elm_lang$core$List$range, 1, numSegments - 1));
	return _ianmackenzie$acorn_demo$Drawing2d$group(
		{
			ctor: '::',
			_0: A3(
				_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(
						A3(_elm_lang$core$Color$rgb, 102, 102, 102)),
					_1: {ctor: '[]'}
				},
				5,
				rectangle),
			_1: {
				ctor: '::',
				_0: A2(
					_ianmackenzie$acorn_demo$Drawing2d$groupWith,
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(
							A3(_elm_lang$core$Color$rgb, 11, 11, 11)),
						_1: {ctor: '[]'}
					},
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d$lineSegment(
							_ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
								{
									ctor: '_Tuple2',
									_0: A2(
										_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
										axes,
										{ctor: '_Tuple2', _0: (0 - width) / 2, _1: ((0 - height) / 2) + boxHeight}),
									_1: A2(
										_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
										axes,
										{ctor: '_Tuple2', _0: width / 2, _1: ((0 - height) / 2) + boxHeight})
								})),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d$group(
								A2(
									_elm_lang$core$List$map,
									function (x) {
										return _ianmackenzie$acorn_demo$Drawing2d$lineSegment(
											_ianmackenzie$acorn_demo$LineSegment2d$fromEndpoints(
												{
													ctor: '_Tuple2',
													_0: A2(
														_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
														axes,
														{ctor: '_Tuple2', _0: x, _1: (0 - height) / 2}),
													_1: A2(
														_ianmackenzie$acorn_demo$Point2d$fromCoordinatesIn,
														axes,
														{ctor: '_Tuple2', _0: x, _1: ((0 - height) / 2) + boxHeight})
												}));
									},
									verticalBarCoordinates)),
							_1: {ctor: '[]'}
						}
					}),
				_1: {ctor: '[]'}
			}
		});
};

var _ianmackenzie$acorn_demo$World$isNotControlled = F2(
	function (controlledIds, train) {
		return !A2(
			_elm_lang$core$List$member,
			_ianmackenzie$acorn_demo$Train$id(train),
			controlledIds);
	});
var _ianmackenzie$acorn_demo$World$findTrain = F2(
	function (id, world) {
		var isTarget = function (train) {
			return _elm_lang$core$Native_Utils.eq(
				_ianmackenzie$acorn_demo$Train$id(train),
				id);
		};
		return A2(
			_elm_community$maybe_extra$Maybe_Extra$orElse,
			A2(_elm_community$list_extra$List_Extra$find, isTarget, world.expressTrains),
			A2(_elm_community$list_extra$List_Extra$find, isTarget, world.localTrains));
	});
var _ianmackenzie$acorn_demo$World$drawTrain = F3(
	function (trainColors, track, train) {
		var trainId = _ianmackenzie$acorn_demo$Train$id(train);
		var fillColor = A2(
			_elm_lang$core$Maybe$withDefault,
			_elm_lang$core$Color$black,
			A2(_elm_lang$core$Dict$get, trainId, trainColors));
		var attributes = {
			ctor: '::',
			_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(fillColor),
			_1: {
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$whiteStroke,
				_1: {ctor: '[]'}
			}
		};
		return A2(_ianmackenzie$acorn_demo$Train$draw, attributes, train);
	});
var _ianmackenzie$acorn_demo$World$draw = F2(
	function (trainColors, world) {
		var workZoneLabel = A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			A2(
				_ianmackenzie$acorn_demo$Frame2d$rotateBy,
				_elm_lang$core$Basics$degrees(30),
				_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
					{ctor: '_Tuple2', _0: 1122, _1: 308})),
			A3(
				_ianmackenzie$acorn_demo$Drawing2d$textWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize(12),
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$center),
						_1: {ctor: '[]'}
					}
				},
				_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
					{ctor: '_Tuple2', _0: 0, _1: -42}),
				A2(
					_elm_lang$core$Basics_ops['++'],
					'TEMPORARY WORK ZONE: ',
					A2(
						_elm_lang$core$Basics_ops['++'],
						_elm_lang$core$Basics$toString(_ianmackenzie$acorn_demo$Line$workZoneSpeed),
						' MPH'))));
		return _ianmackenzie$acorn_demo$Drawing2d$group(
			{
				ctor: '::',
				_0: A2(
					_ianmackenzie$acorn_demo$Drawing2d$cubicSplineWith,
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(60),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(
								A4(_elm_lang$core$Color$rgba, 255, 255, 0, 0.2)),
							_1: {ctor: '[]'}
						}
					},
					world.workZone),
				_1: {
					ctor: '::',
					_0: workZoneLabel,
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Track$draw(world.localTrack),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Track$draw(world.expressTrack),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d$group(
									A2(
										_elm_lang$core$List$map,
										A2(_ianmackenzie$acorn_demo$World$drawTrain, trainColors, world.localTrack),
										world.localTrains)),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d$group(
										A2(
											_elm_lang$core$List$map,
											A2(_ianmackenzie$acorn_demo$World$drawTrain, trainColors, world.expressTrack),
											world.expressTrains)),
									_1: {ctor: '[]'}
								}
							}
						}
					}
				}
			});
	});
var _ianmackenzie$acorn_demo$World$trainsByType = F2(
	function (trainType, world) {
		var _p0 = trainType;
		if (_p0.ctor === 'Local') {
			return world.localTrains;
		} else {
			return world.expressTrains;
		}
	});
var _ianmackenzie$acorn_demo$World$findFirst = F3(
	function (trainType, controlledIds, world) {
		return A2(
			_elm_lang$core$Maybe$map,
			_ianmackenzie$acorn_demo$Train$id,
			A2(
				_elm_community$list_extra$List_Extra$minimumBy,
				_ianmackenzie$acorn_demo$Train$distanceAlongTrack,
				A2(
					_elm_lang$core$List$filter,
					_ianmackenzie$acorn_demo$World$isNotControlled(controlledIds),
					A2(_ianmackenzie$acorn_demo$World$trainsByType, trainType, world))));
	});
var _ianmackenzie$acorn_demo$World$findLast = F3(
	function (trainType, controlledIds, world) {
		return A2(
			_elm_lang$core$Maybe$map,
			_ianmackenzie$acorn_demo$Train$id,
			A2(
				_elm_community$list_extra$List_Extra$maximumBy,
				_ianmackenzie$acorn_demo$Train$distanceAlongTrack,
				A2(
					_elm_lang$core$List$filter,
					_ianmackenzie$acorn_demo$World$isNotControlled(controlledIds),
					A2(_ianmackenzie$acorn_demo$World$trainsByType, trainType, world))));
	});
var _ianmackenzie$acorn_demo$World$trackByType = F2(
	function (trainType, world) {
		var _p1 = trainType;
		if (_p1.ctor === 'Local') {
			return world.localTrack;
		} else {
			return world.expressTrack;
		}
	});
var _ianmackenzie$acorn_demo$World$trackOf = F2(
	function (train, world) {
		return A2(
			_ianmackenzie$acorn_demo$World$trackByType,
			_ianmackenzie$acorn_demo$Train$type_(train),
			world);
	});
var _ianmackenzie$acorn_demo$World$findBeside = F3(
	function (trainId, controlledIds, world) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (train) {
				var trainType = _ianmackenzie$acorn_demo$Train$type_(train);
				var otherType = function () {
					var _p2 = trainType;
					if (_p2.ctor === 'Local') {
						return _ianmackenzie$acorn_demo$Train$Express;
					} else {
						return _ianmackenzie$acorn_demo$Train$Local;
					}
				}();
				var otherTrack = A2(_ianmackenzie$acorn_demo$World$trackByType, otherType, world);
				var trainTrack = A2(_ianmackenzie$acorn_demo$World$trackByType, trainType, world);
				return A2(
					_elm_lang$core$Maybe$andThen,
					function (xCoordinate) {
						return A2(
							_elm_lang$core$Maybe$map,
							function (_p3) {
								return _ianmackenzie$acorn_demo$Train$id(
									_elm_lang$core$Tuple$first(_p3));
							},
							A2(
								_elm_community$list_extra$List_Extra$minimumBy,
								_elm_lang$core$Tuple$second,
								A2(
									_elm_lang$core$List$filterMap,
									function (otherTrain) {
										return A2(
											_elm_lang$core$Maybe$map,
											function (otherPoint) {
												var otherXCoordinate = _ianmackenzie$acorn_demo$Point2d$xCoordinate(otherPoint);
												var distance = _elm_lang$core$Basics$abs(otherXCoordinate - xCoordinate);
												return {ctor: '_Tuple2', _0: otherTrain, _1: distance};
											},
											A2(
												_ianmackenzie$acorn_demo$Track$pointAlong,
												otherTrack,
												_ianmackenzie$acorn_demo$Train$distanceAlongTrack(otherTrain)));
									},
									A2(
										_elm_lang$core$List$filter,
										_ianmackenzie$acorn_demo$World$isNotControlled(controlledIds),
										A2(_ianmackenzie$acorn_demo$World$trainsByType, otherType, world)))));
					},
					A2(
						_elm_lang$core$Maybe$map,
						_ianmackenzie$acorn_demo$Point2d$xCoordinate,
						A2(
							_ianmackenzie$acorn_demo$Track$pointAlong,
							trainTrack,
							_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train))));
			},
			A2(_ianmackenzie$acorn_demo$World$findTrain, trainId, world));
	});
var _ianmackenzie$acorn_demo$World$findNext = F3(
	function (trainId, controlledIds, world) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (train) {
				var trainType = _ianmackenzie$acorn_demo$Train$type_(train);
				var track = _ianmackenzie$acorn_demo$World$trackByType(trainType);
				return A2(
					_elm_lang$core$Maybe$map,
					_ianmackenzie$acorn_demo$Train$id,
					A2(
						_elm_community$list_extra$List_Extra$minimumBy,
						_ianmackenzie$acorn_demo$Train$distanceAlongTrack,
						A2(
							_elm_lang$core$List$filter,
							function (otherTrain) {
								return A2(_ianmackenzie$acorn_demo$World$isNotControlled, controlledIds, otherTrain) && (_elm_lang$core$Native_Utils.cmp(
									_ianmackenzie$acorn_demo$Train$distanceAlongTrack(otherTrain),
									_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train)) > 0);
							},
							A2(_ianmackenzie$acorn_demo$World$trainsByType, trainType, world))));
			},
			A2(_ianmackenzie$acorn_demo$World$findTrain, trainId, world));
	});
var _ianmackenzie$acorn_demo$World$findPrevious = F3(
	function (trainId, controlledIds, world) {
		return A2(
			_elm_lang$core$Maybe$andThen,
			function (train) {
				var trainType = _ianmackenzie$acorn_demo$Train$type_(train);
				var track = _ianmackenzie$acorn_demo$World$trackByType(trainType);
				return A2(
					_elm_lang$core$Maybe$map,
					_ianmackenzie$acorn_demo$Train$id,
					A2(
						_elm_community$list_extra$List_Extra$maximumBy,
						_ianmackenzie$acorn_demo$Train$distanceAlongTrack,
						A2(
							_elm_lang$core$List$filter,
							function (otherTrain) {
								return A2(_ianmackenzie$acorn_demo$World$isNotControlled, controlledIds, otherTrain) && (_elm_lang$core$Native_Utils.cmp(
									_ianmackenzie$acorn_demo$Train$distanceAlongTrack(otherTrain),
									_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train)) < 0);
							},
							A2(_ianmackenzie$acorn_demo$World$trainsByType, trainType, world))));
			},
			A2(_ianmackenzie$acorn_demo$World$findTrain, trainId, world));
	});
var _ianmackenzie$acorn_demo$World$removedTrainIds = function (updateResults) {
	return A2(
		_elm_lang$core$List$filterMap,
		function (updateResult) {
			var _p4 = updateResult;
			if (_p4.ctor === 'Updated') {
				return _elm_lang$core$Maybe$Nothing;
			} else {
				return _elm_lang$core$Maybe$Just(_p4._0);
			}
		},
		updateResults);
};
var _ianmackenzie$acorn_demo$World$updatedTrains = function (updateResults) {
	return A2(
		_elm_lang$core$List$filterMap,
		function (updateResult) {
			var _p5 = updateResult;
			if (_p5.ctor === 'Updated') {
				return _elm_lang$core$Maybe$Just(_p5._0);
			} else {
				return _elm_lang$core$Maybe$Nothing;
			}
		},
		updateResults);
};
var _ianmackenzie$acorn_demo$World$headway = F3(
	function (trainType, positionAlongTrack, world) {
		var trains = function () {
			var _p6 = trainType;
			if (_p6.ctor === 'Express') {
				return world.expressTrains;
			} else {
				return world.localTrains;
			}
		}();
		return A2(
			_elm_lang$core$Maybe$withDefault,
			1 / 0,
			A2(
				_elm_lang$core$Maybe$map,
				function (distance) {
					return (distance - positionAlongTrack) - _ianmackenzie$acorn_demo$Train$length;
				},
				_elm_lang$core$List$minimum(
					A2(
						_elm_lang$core$List$filter,
						function (distance) {
							return _elm_lang$core$Native_Utils.cmp(distance, positionAlongTrack) > 0;
						},
						A2(_elm_lang$core$List$map, _ianmackenzie$acorn_demo$Train$distanceAlongTrack, trains)))));
	});
var _ianmackenzie$acorn_demo$World$init = function () {
	var _p7 = _ianmackenzie$acorn_demo$Line$init;
	var localTrack = _p7.localTrack;
	var expressTrack = _p7.expressTrack;
	var workZone = _p7.workZone;
	return {
		localTrack: localTrack,
		expressTrack: expressTrack,
		localDatabase: A2(_ianmackenzie$acorn_demo$Train$initDatabase, _ianmackenzie$acorn_demo$Train$Local, localTrack),
		expressDatabase: A2(_ianmackenzie$acorn_demo$Train$initDatabase, _ianmackenzie$acorn_demo$Train$Express, expressTrack),
		localTrains: {ctor: '[]'},
		expressTrains: {ctor: '[]'},
		workZone: workZone
	};
}();
var _ianmackenzie$acorn_demo$World$World = F7(
	function (a, b, c, d, e, f, g) {
		return {localTrack: a, expressTrack: b, localDatabase: c, expressDatabase: d, localTrains: e, expressTrains: f, workZone: g};
	});
var _ianmackenzie$acorn_demo$World$CouldNotSpawnTrain = {ctor: 'CouldNotSpawnTrain'};
var _ianmackenzie$acorn_demo$World$spawnLocalTrain = F2(
	function (id, world) {
		var trainHeadway = A3(_ianmackenzie$acorn_demo$World$headway, _ianmackenzie$acorn_demo$Train$Local, 0, world);
		var _p8 = A5(_ianmackenzie$acorn_demo$Train$spawn, _ianmackenzie$acorn_demo$Train$Local, id, world.localTrack, world.localDatabase, trainHeadway);
		if (_p8.ctor === 'Just') {
			return _elm_lang$core$Result$Ok(
				_elm_lang$core$Native_Utils.update(
					world,
					{
						localTrains: {ctor: '::', _0: _p8._0, _1: world.localTrains}
					}));
		} else {
			return _elm_lang$core$Result$Err(_ianmackenzie$acorn_demo$World$CouldNotSpawnTrain);
		}
	});
var _ianmackenzie$acorn_demo$World$spawnExpressTrain = F2(
	function (id, world) {
		var trainHeadway = A3(_ianmackenzie$acorn_demo$World$headway, _ianmackenzie$acorn_demo$Train$Express, 0, world);
		var _p9 = A5(_ianmackenzie$acorn_demo$Train$spawn, _ianmackenzie$acorn_demo$Train$Express, id, world.expressTrack, world.expressDatabase, trainHeadway);
		if (_p9.ctor === 'Just') {
			return _elm_lang$core$Result$Ok(
				_elm_lang$core$Native_Utils.update(
					world,
					{
						expressTrains: {ctor: '::', _0: _p9._0, _1: world.expressTrains}
					}));
		} else {
			return _elm_lang$core$Result$Err(_ianmackenzie$acorn_demo$World$CouldNotSpawnTrain);
		}
	});
var _ianmackenzie$acorn_demo$World$Removed = function (a) {
	return {ctor: 'Removed', _0: a};
};
var _ianmackenzie$acorn_demo$World$Updated = function (a) {
	return {ctor: 'Updated', _0: a};
};
var _ianmackenzie$acorn_demo$World$update = F3(
	function (time, inputs, world) {
		var updateTrain = function (train) {
			var trainType = _ianmackenzie$acorn_demo$Train$type_(train);
			var trainHeadway = A3(
				_ianmackenzie$acorn_demo$World$headway,
				trainType,
				_ianmackenzie$acorn_demo$Train$distanceAlongTrack(train),
				world);
			var trainId = _ianmackenzie$acorn_demo$Train$id(train);
			var trainInputs = A2(_elm_lang$core$Dict$get, trainId, inputs);
			var _p10 = A4(_ianmackenzie$acorn_demo$Train$update, time, trainInputs, trainHeadway, train);
			if (_p10.ctor === 'Just') {
				return _ianmackenzie$acorn_demo$World$Updated(_p10._0);
			} else {
				return _ianmackenzie$acorn_demo$World$Removed(trainId);
			}
		};
		var localUpdates = A2(_elm_lang$core$List$map, updateTrain, world.localTrains);
		var remainingLocalTrains = _ianmackenzie$acorn_demo$World$updatedTrains(localUpdates);
		var removedLocalTrainIds = _ianmackenzie$acorn_demo$World$removedTrainIds(localUpdates);
		var expressUpdates = A2(_elm_lang$core$List$map, updateTrain, world.expressTrains);
		var remainingExpressTrains = _ianmackenzie$acorn_demo$World$updatedTrains(expressUpdates);
		var updatedWorld = _elm_lang$core$Native_Utils.update(
			world,
			{localTrains: remainingLocalTrains, expressTrains: remainingExpressTrains});
		var removedExpressTrainIds = _ianmackenzie$acorn_demo$World$removedTrainIds(expressUpdates);
		var allRemovedIds = _elm_lang$core$List$concat(
			{
				ctor: '::',
				_0: removedLocalTrainIds,
				_1: {
					ctor: '::',
					_0: removedExpressTrainIds,
					_1: {ctor: '[]'}
				}
			});
		return {ctor: '_Tuple2', _0: updatedWorld, _1: allRemovedIds};
	});

var _ianmackenzie$acorn_demo$RouteControlScreen$draw = F2(
	function (world, selectedTrains) {
		var inset = 50;
		var cropRadius = 6;
		var actualHeight = 491;
		var actualWidth = 1824;
		var cropRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: 0 - cropRadius, minY: 0 - cropRadius, maxX: actualWidth + cropRadius, maxY: actualHeight + cropRadius});
		var borderRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: 0, minY: 0, maxX: actualWidth, maxY: actualHeight});
		var imageRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: -7, minY: -8, maxX: 1830, maxY: 497});
		return _ianmackenzie$acorn_demo$Drawing2d$group(
			{
				ctor: '::',
				_0: A2(_ianmackenzie$acorn_demo$Drawing2d$image, 'images/screen_rcc.png', imageRectangle),
				_1: {
					ctor: '::',
					_0: A3(
						_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noFill,
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_ianmackenzie$acorn_demo$Background$color),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(2 * cropRadius),
									_1: {ctor: '[]'}
								}
							}
						},
						2 * cropRadius,
						cropRectangle),
					_1: {
						ctor: '::',
						_0: A3(
							_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
							{
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noFill,
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(
										_ianmackenzie$acorn_demo$Background$colorWith(
											{alpha: 0.5})),
									_1: {
										ctor: '::',
										_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(1.5),
										_1: {ctor: '[]'}
									}
								}
							},
							cropRadius,
							borderRectangle),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$ScreenBackground$draw(
								_ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
									{minX: inset, minY: inset, maxX: actualWidth - inset, maxY: actualHeight - inset})),
							_1: {ctor: '[]'}
						}
					}
				}
			});
	});

var _ianmackenzie$acorn_demo$ScheduleIndicator$arrow = A2(
	_ianmackenzie$acorn_demo$Drawing2d$groupWith,
	{
		ctor: '::',
		_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$black),
		_1: {ctor: '[]'}
	},
	{
		ctor: '::',
		_0: _ianmackenzie$acorn_demo$Drawing2d$circle(
			A2(_ianmackenzie$acorn_demo$Circle2d$withRadius, 10, _ianmackenzie$acorn_demo$Point2d$origin)),
		_1: {
			ctor: '::',
			_0: A2(
				_ianmackenzie$acorn_demo$Drawing2d$lineSegmentWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_elm_lang$core$Color$black),
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(15),
						_1: {ctor: '[]'}
					}
				},
				A3(_ianmackenzie$acorn_demo$LineSegment2d$along, _ianmackenzie$acorn_demo$Axis2d$x, 0, 55)),
			_1: {
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Drawing2d$triangle(
					_ianmackenzie$acorn_demo$Triangle2d$fromVertices(
						{
							ctor: '_Tuple3',
							_0: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
								{ctor: '_Tuple2', _0: 55, _1: -15}),
							_1: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
								{ctor: '_Tuple2', _0: 75, _1: 0}),
							_2: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
								{ctor: '_Tuple2', _0: 55, _1: 15})
						})),
				_1: {ctor: '[]'}
			}
		}
	});
var _ianmackenzie$acorn_demo$ScheduleIndicator$greenPolygon = function () {
	var arc = _ianmackenzie$acorn_demo$Arc2d$with(
		{
			centerPoint: _ianmackenzie$acorn_demo$Point2d$origin,
			startAngle: _elm_lang$core$Basics$degrees(0),
			sweptAngle: _elm_lang$core$Basics$degrees(120),
			radius: 75
		});
	var vertices = _ianmackenzie$acorn_demo$Polyline2d$vertices(
		A2(
			_ianmackenzie$acorn_demo$Arc2d$toPolyline,
			_ianmackenzie$acorn_demo$Geometry_Accuracy$maxError(0.1),
			arc));
	return _ianmackenzie$acorn_demo$Polygon2d$singleLoop(
		{ctor: '::', _0: _ianmackenzie$acorn_demo$Point2d$origin, _1: vertices});
}();
var _ianmackenzie$acorn_demo$ScheduleIndicator$redPolygon = A3(
	_ianmackenzie$acorn_demo$Polygon2d$rotateAround,
	_ianmackenzie$acorn_demo$Point2d$origin,
	_elm_lang$core$Basics$degrees(-120),
	_ianmackenzie$acorn_demo$ScheduleIndicator$greenPolygon);
var _ianmackenzie$acorn_demo$ScheduleIndicator$darkGreyPolygon = A3(
	_ianmackenzie$acorn_demo$Polygon2d$rotateAround,
	_ianmackenzie$acorn_demo$Point2d$origin,
	_elm_lang$core$Basics$degrees(120),
	_ianmackenzie$acorn_demo$ScheduleIndicator$greenPolygon);
var _ianmackenzie$acorn_demo$ScheduleIndicator$draw = function (deviationFromSchedule) {
	var angleMagnitude = _elm_lang$core$Basics$degrees(20) * A2(
		_elm_lang$core$Basics$logBase,
		2,
		1 + _elm_lang$core$Basics$abs(deviationFromSchedule));
	var angle = (_elm_lang$core$Native_Utils.cmp(deviationFromSchedule, 0) > 0) ? angleMagnitude : (0 - angleMagnitude);
	return _ianmackenzie$acorn_demo$Drawing2d$group(
		{
			ctor: '::',
			_0: A2(
				_ianmackenzie$acorn_demo$Drawing2d$polygonWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$darkGreen),
					_1: {ctor: '[]'}
				},
				_ianmackenzie$acorn_demo$ScheduleIndicator$greenPolygon),
			_1: {
				ctor: '::',
				_0: A2(
					_ianmackenzie$acorn_demo$Drawing2d$polygonWith,
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$darkRed),
						_1: {ctor: '[]'}
					},
					_ianmackenzie$acorn_demo$ScheduleIndicator$redPolygon),
				_1: {
					ctor: '::',
					_0: A2(
						_ianmackenzie$acorn_demo$Drawing2d$polygonWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(
								A3(_elm_lang$core$Color$rgb, 51, 51, 51)),
							_1: {ctor: '[]'}
						},
						_ianmackenzie$acorn_demo$ScheduleIndicator$darkGreyPolygon),
					_1: {
						ctor: '::',
						_0: A3(_ianmackenzie$acorn_demo$Drawing2d$rotateAround, _ianmackenzie$acorn_demo$Point2d$origin, angle, _ianmackenzie$acorn_demo$ScheduleIndicator$arrow),
						_1: {ctor: '[]'}
					}
				}
			}
		});
};

var _ianmackenzie$acorn_demo$Speedometer$toAngle = function (speed) {
	var fullAngle = _elm_lang$core$Basics$degrees(-15.3);
	var zeroAngle = _elm_lang$core$Basics$degrees(195.3);
	return zeroAngle + ((speed / 140) * (fullAngle - zeroAngle));
};
var _ianmackenzie$acorn_demo$Speedometer$drawTriangle = F3(
	function (radius, color, maybeSpeed) {
		var _p0 = A2(_elm_lang$core$Maybe$map, _ianmackenzie$acorn_demo$Speedometer$toAngle, maybeSpeed);
		if (_p0.ctor === 'Just') {
			var triangle = _ianmackenzie$acorn_demo$Triangle2d$fromVertices(
				{
					ctor: '_Tuple3',
					_0: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
						{ctor: '_Tuple2', _0: radius, _1: 0}),
					_1: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
						{ctor: '_Tuple2', _0: radius + 15, _1: -7.5}),
					_2: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
						{ctor: '_Tuple2', _0: radius + 15, _1: 7.5})
				});
			return A2(
				_ianmackenzie$acorn_demo$Drawing2d$triangleWith,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(color),
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noBorder,
						_1: {ctor: '[]'}
					}
				},
				A3(_ianmackenzie$acorn_demo$Triangle2d$rotateAround, _ianmackenzie$acorn_demo$Point2d$origin, _p0._0, triangle));
		} else {
			return _ianmackenzie$acorn_demo$Drawing2d$empty;
		}
	});
var _ianmackenzie$acorn_demo$Speedometer$backgroundColor = A3(_elm_lang$core$Color$rgb, 186, 186, 186);
var _ianmackenzie$acorn_demo$Speedometer$backgroundPolygon = function () {
	var arc = A3(
		_ianmackenzie$acorn_demo$Arc2d$from,
		_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{ctor: '_Tuple2', _0: 135, _1: -30}),
		_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{ctor: '_Tuple2', _0: -135, _1: -30}),
		_elm_lang$core$Basics$degrees(180));
	return _ianmackenzie$acorn_demo$Polygon2d$singleLoop(
		_ianmackenzie$acorn_demo$Polyline2d$vertices(
			A2(
				_ianmackenzie$acorn_demo$Arc2d$toPolyline,
				_ianmackenzie$acorn_demo$Geometry_Accuracy$maxError(0.1),
				arc)));
}();
var _ianmackenzie$acorn_demo$Speedometer$scale = 2 / 3;
var _ianmackenzie$acorn_demo$Speedometer$drawNeedle = function () {
	var needleFrame = A2(
		_ianmackenzie$acorn_demo$Frame2d$rotateBy,
		_elm_lang$core$Basics$degrees(153.7),
		_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
			{ctor: '_Tuple2', _0: 93, _1: -57.25}));
	var imageRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
		{minX: 0, maxX: 115, maxY: 0, minY: -86});
	var baseElement = _ianmackenzie$acorn_demo$Drawing2d$group(
		{
			ctor: '::',
			_0: A2(
				_ianmackenzie$acorn_demo$Drawing2d$image,
				'images/speedometer_needle.png',
				A3(
					_ianmackenzie$acorn_demo$Rectangle2d$scaleAbout,
					_ianmackenzie$acorn_demo$Point2d$origin,
					_ianmackenzie$acorn_demo$Speedometer$scale,
					A2(_ianmackenzie$acorn_demo$Rectangle2d$relativeTo, needleFrame, imageRectangle))),
			_1: {ctor: '[]'}
		});
	return function (speed) {
		return A3(
			_ianmackenzie$acorn_demo$Drawing2d$rotateAround,
			_ianmackenzie$acorn_demo$Point2d$origin,
			_ianmackenzie$acorn_demo$Speedometer$toAngle(speed),
			baseElement);
	};
}();
var _ianmackenzie$acorn_demo$Speedometer$draw = F2(
	function (centerPoint, train) {
		var imageRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: 0, minY: 0, maxX: 283, maxY: 213});
		return A2(
			_ianmackenzie$acorn_demo$Drawing2d$placeIn,
			_ianmackenzie$acorn_demo$Frame2d$atPoint(centerPoint),
			_ianmackenzie$acorn_demo$Drawing2d$group(
				{
					ctor: '::',
					_0: A2(
						_ianmackenzie$acorn_demo$Drawing2d$polygonWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_ianmackenzie$acorn_demo$Speedometer$backgroundColor),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_elm_lang$core$Color$black),
								_1: {ctor: '[]'}
							}
						},
						_ianmackenzie$acorn_demo$Speedometer$backgroundPolygon),
					_1: {
						ctor: '::',
						_0: A2(
							_ianmackenzie$acorn_demo$Drawing2d$image,
							'images/speedometer_background.png',
							A3(
								_ianmackenzie$acorn_demo$Rectangle2d$scaleAbout,
								_ianmackenzie$acorn_demo$Point2d$origin,
								_ianmackenzie$acorn_demo$Speedometer$scale,
								A2(
									_ianmackenzie$acorn_demo$Rectangle2d$relativeTo,
									_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
										{ctor: '_Tuple2', _0: 140.5, _1: 66}),
									imageRectangle))),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Speedometer$drawNeedle(
								_ianmackenzie$acorn_demo$Train$speed(train)),
							_1: {
								ctor: '::',
								_0: A3(
									_ianmackenzie$acorn_demo$Speedometer$drawTriangle,
									85,
									_elm_lang$core$Color$darkGreen,
									_ianmackenzie$acorn_demo$Train$scheduledSpeed(train)),
								_1: {
									ctor: '::',
									_0: A3(
										_ianmackenzie$acorn_demo$Speedometer$drawTriangle,
										85,
										_elm_lang$core$Color$darkRed,
										_elm_lang$core$Maybe$Just(
											_ianmackenzie$acorn_demo$Train$maxSafeSpeed(train))),
									_1: {ctor: '[]'}
								}
							}
						}
					}
				}));
	});

var _ianmackenzie$acorn_demo$Main$selectedTrain = F2(
	function (player, model) {
		return A3(
			_elm_lang$core$Dict$foldl,
			F3(
				function (controllerIndex, controllerState, currentResult) {
					if (_elm_lang$core$Native_Utils.eq(controllerState.player, player)) {
						var _p0 = controllerState.selection;
						if (_p0.ctor === 'SelectedTrain') {
							return A2(_ianmackenzie$acorn_demo$World$findTrain, _p0._0, model.world);
						} else {
							return _elm_lang$core$Maybe$Nothing;
						}
					} else {
						return currentResult;
					}
				}),
			_elm_lang$core$Maybe$Nothing,
			model.controllers);
	});
var _ianmackenzie$acorn_demo$Main$otherTrainType = function (trainType) {
	var _p1 = trainType;
	if (_p1.ctor === 'Local') {
		return _ianmackenzie$acorn_demo$Train$Express;
	} else {
		return _ianmackenzie$acorn_demo$Train$Local;
	}
};
var _ianmackenzie$acorn_demo$Main$playerColor = function (player) {
	var _p2 = player;
	if (_p2.ctor === 'PlayerOne') {
		return _elm_lang$core$Color$blue;
	} else {
		return _elm_lang$core$Color$purple;
	}
};
var _ianmackenzie$acorn_demo$Main$trainColors = function (model) {
	var handleController = F3(
		function (controllerId, _p3, currentColors) {
			var _p4 = _p3;
			var _p5 = _p4.selection;
			if (_p5.ctor === 'SelectedTrain') {
				return A3(
					_elm_lang$core$Dict$insert,
					_p5._0,
					_ianmackenzie$acorn_demo$Main$playerColor(_p4.player),
					currentColors);
			} else {
				return currentColors;
			}
		});
	return A3(_elm_lang$core$Dict$foldl, handleController, _elm_lang$core$Dict$empty, model.controllers);
};
var _ianmackenzie$acorn_demo$Main$drawTrainControls = F2(
	function (model, player) {
		var controlsBackground = _ianmackenzie$acorn_demo$ScreenBackground$draw(
			_ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
				{minX: 0, minY: 0, maxX: 328, maxY: 241}));
		var trainIconAt = function (coordinates) {
			var scale = 0.5;
			var axes = _ianmackenzie$acorn_demo$Frame2d$atCoordinates(coordinates);
			var rectangle = A2(
				_ianmackenzie$acorn_demo$Rectangle2d$centeredOn,
				axes,
				{ctor: '_Tuple2', _0: 60 * scale, _1: 59 * scale});
			return A2(_ianmackenzie$acorn_demo$Drawing2d$image, 'images/train_icon_lightened.png', rectangle);
		};
		var cropRadius = 10;
		var imageHeight = 372;
		var imageWidth = 900;
		var imageRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: 0, maxX: imageWidth, minY: 0, maxY: imageHeight});
		var cropRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
			{minX: 0 - cropRadius, maxX: imageWidth + cropRadius, minY: 0 - cropRadius, maxY: imageHeight + cropRadius});
		var speedometerCenter = _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
			{ctor: '_Tuple2', _0: 672, _1: 155});
		var modeIndicator = _ianmackenzie$acorn_demo$Drawing2d$group(
			{
				ctor: '::',
				_0: A3(
					_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
					{
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_ianmackenzie$acorn_demo$Speedometer$backgroundColor),
						_1: {ctor: '[]'}
					},
					10,
					A2(
						_ianmackenzie$acorn_demo$Rectangle2d$centeredOn,
						_ianmackenzie$acorn_demo$Frame2d$atPoint(
							A3(_ianmackenzie$acorn_demo$Point2d$translateIn, _ianmackenzie$acorn_demo$Direction2d$y, 130, speedometerCenter)),
						{ctor: '_Tuple2', _0: 200, _1: 25})),
				_1: {
					ctor: '::',
					_0: A3(
						_ianmackenzie$acorn_demo$Drawing2d$textWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$black),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$centerLeft),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize(18),
									_1: {ctor: '[]'}
								}
							}
						},
						_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
							{ctor: '_Tuple2', _0: 600, _1: 283}),
						'MODE'),
					_1: {
						ctor: '::',
						_0: A2(
							_ianmackenzie$acorn_demo$Drawing2d$groupWith,
							{
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$black),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$centerLeft),
									_1: {
										ctor: '::',
										_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize(22),
										_1: {ctor: '[]'}
									}
								}
							},
							{
								ctor: '::',
								_0: A2(
									_ianmackenzie$acorn_demo$Drawing2d$text,
									_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
										{ctor: '_Tuple2', _0: 660, _1: 283}),
									'1'),
								_1: {
									ctor: '::',
									_0: A2(
										_ianmackenzie$acorn_demo$Drawing2d$circleWith,
										{
											ctor: '::',
											_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_elm_lang$core$Color$black),
											_1: {
												ctor: '::',
												_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noBorder,
												_1: {ctor: '[]'}
											}
										},
										A2(
											_ianmackenzie$acorn_demo$Circle2d$withRadius,
											11,
											_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
												{ctor: '_Tuple2', _0: 706, _1: 285}))),
									_1: {
										ctor: '::',
										_0: A3(
											_ianmackenzie$acorn_demo$Drawing2d$textWith,
											{
												ctor: '::',
												_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$white),
												_1: {ctor: '[]'}
											},
											_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
												{ctor: '_Tuple2', _0: 700, _1: 283}),
											'2'),
										_1: {
											ctor: '::',
											_0: A2(
												_ianmackenzie$acorn_demo$Drawing2d$text,
												_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
													{ctor: '_Tuple2', _0: 740, _1: 283}),
												'3'),
											_1: {ctor: '[]'}
										}
									}
								}
							}),
						_1: {ctor: '[]'}
					}
				}
			});
		return _ianmackenzie$acorn_demo$Drawing2d$group(
			{
				ctor: '::',
				_0: A2(_ianmackenzie$acorn_demo$Drawing2d$image, 'images/screens_black.png', imageRectangle),
				_1: {
					ctor: '::',
					_0: A3(
						_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noFill,
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(_ianmackenzie$acorn_demo$Background$color),
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(2 * cropRadius),
									_1: {ctor: '[]'}
								}
							}
						},
						2 * cropRadius,
						cropRectangle),
					_1: {
						ctor: '::',
						_0: A3(
							_ianmackenzie$acorn_demo$Drawing2d$roundedRectangleWith,
							{
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$noFill,
								_1: {
									ctor: '::',
									_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeColor(
										_ianmackenzie$acorn_demo$Main$playerColor(player)),
									_1: {
										ctor: '::',
										_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$strokeWidth(8),
										_1: {ctor: '[]'}
									}
								}
							},
							cropRadius,
							imageRectangle),
						_1: {
							ctor: '::',
							_0: function () {
								var _p6 = A2(_ianmackenzie$acorn_demo$Main$selectedTrain, player, model);
								if (_p6.ctor === 'Just') {
									var _p9 = _p6._0;
									return _ianmackenzie$acorn_demo$Drawing2d$group(
										{
											ctor: '::',
											_0: A2(
												_ianmackenzie$acorn_demo$Drawing2d$placeIn,
												_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
													{ctor: '_Tuple2', _0: 65, _1: 68}),
												controlsBackground),
											_1: {
												ctor: '::',
												_0: A2(
													_ianmackenzie$acorn_demo$Drawing2d$placeIn,
													_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
														{ctor: '_Tuple2', _0: 505, _1: 68}),
													controlsBackground),
												_1: {
													ctor: '::',
													_0: A3(
														_ianmackenzie$acorn_demo$Drawing2d$textWith,
														{
															ctor: '::',
															_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$topLeft),
															_1: {ctor: '[]'}
														},
														_ianmackenzie$acorn_demo$Point2d$fromCoordinates(
															{ctor: '_Tuple2', _0: 73, _1: 300}),
														A2(
															_elm_lang$core$Basics_ops['++'],
															'TRAIN ',
															A3(
																_elm_lang$core$String$padLeft,
																3,
																_elm_lang$core$Native_Utils.chr('0'),
																_elm_lang$core$Basics$toString(
																	_ianmackenzie$acorn_demo$Train$id(_p9))))),
													_1: {
														ctor: '::',
														_0: A2(
															_ianmackenzie$acorn_demo$Drawing2d$placeIn,
															_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
																{ctor: '_Tuple2', _0: 200, _1: 200}),
															_ianmackenzie$acorn_demo$ScheduleIndicator$draw(
																_ianmackenzie$acorn_demo$Train$deviationFromSchedule(_p9))),
														_1: {
															ctor: '::',
															_0: A2(_ianmackenzie$acorn_demo$Speedometer$draw, speedometerCenter, _p9),
															_1: {
																ctor: '::',
																_0: modeIndicator,
																_1: {
																	ctor: '::',
																	_0: function () {
																		var _p7 = _ianmackenzie$acorn_demo$Train$brakeOverride(_p9);
																		if (_p7.ctor === 'Just') {
																			return A3(
																				_ianmackenzie$acorn_demo$Drawing2d$textWith,
																				{
																					ctor: '::',
																					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textAnchor(_ianmackenzie$acorn_demo$Drawing2d_Text$center),
																					_1: {ctor: '[]'}
																				},
																				A3(_ianmackenzie$acorn_demo$Point2d$translateIn, _ianmackenzie$acorn_demo$Direction2d$negativeY, 45, speedometerCenter),
																				function () {
																					var _p8 = _p7._0._1;
																					if (_p8.ctor === 'HeadwayInfringement') {
																						return 'HEADWAY INFRINGEMENT';
																					} else {
																						return 'OVERSPEED';
																					}
																				}());
																		} else {
																			return _ianmackenzie$acorn_demo$Drawing2d$empty;
																		}
																	}(),
																	_1: {
																		ctor: '::',
																		_0: trainIconAt(
																			{ctor: '_Tuple2', _0: 355, _1: 120}),
																		_1: {
																			ctor: '::',
																			_0: trainIconAt(
																				{ctor: '_Tuple2', _0: 355, _1: 285}),
																			_1: {
																				ctor: '::',
																				_0: _ianmackenzie$acorn_demo$HeadwayIndicator$draw(
																					{
																						startPoint: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
																							{ctor: '_Tuple2', _0: 355, _1: 140}),
																						endPoint: _ianmackenzie$acorn_demo$Point2d$fromCoordinates(
																							{ctor: '_Tuple2', _0: 355, _1: 265}),
																						width: 40,
																						cornerRadius: 10,
																						train: _p9
																					}),
																				_1: {ctor: '[]'}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										});
								} else {
									return _ianmackenzie$acorn_demo$Drawing2d$empty;
								}
							}(),
							_1: {ctor: '[]'}
						}
					}
				}
			});
	});
var _ianmackenzie$acorn_demo$Main$trainInputs = function (model) {
	var handleController = F3(
		function (controllerId, _p10, currentInputs) {
			var _p11 = _p10;
			var _p12 = _p11.selection;
			if (_p12.ctor === 'SelectedTrain') {
				return A3(
					_elm_lang$core$Dict$insert,
					_p12._0,
					_ianmackenzie$acorn_demo$Controller$inputs(_p11.controller),
					currentInputs);
			} else {
				return currentInputs;
			}
		});
	return A3(_elm_lang$core$Dict$foldl, handleController, _elm_lang$core$Dict$empty, model.controllers);
};
var _ianmackenzie$acorn_demo$Main$popNextId = function (model) {
	var _p13 = model.availableIds;
	if (_p13.ctor === '::') {
		return {
			ctor: '_Tuple2',
			_0: _p13._0,
			_1: _elm_lang$core$Native_Utils.update(
				model,
				{availableIds: _p13._1})
		};
	} else {
		return {
			ctor: '_Tuple2',
			_0: model.nextNewId,
			_1: _elm_lang$core$Native_Utils.update(
				model,
				{nextNewId: model.nextNewId + 1})
		};
	}
};
var _ianmackenzie$acorn_demo$Main$spawnLocalTrain = F2(
	function (delta, model) {
		var updatedTime = model.timeSinceLocalSpawned + delta;
		if (_elm_lang$core$Native_Utils.cmp(updatedTime, 9.125098) > 0) {
			var _p14 = _ianmackenzie$acorn_demo$Main$popNextId(model);
			var id = _p14._0;
			var modelWithIdPopped = _p14._1;
			var _p15 = A2(_ianmackenzie$acorn_demo$World$spawnLocalTrain, id, model.world);
			if (_p15.ctor === 'Ok') {
				return _elm_lang$core$Native_Utils.update(
					modelWithIdPopped,
					{world: _p15._0, timeSinceLocalSpawned: 0});
			} else {
				return _elm_lang$core$Native_Utils.update(
					model,
					{timeSinceLocalSpawned: 0});
			}
		} else {
			return _elm_lang$core$Native_Utils.update(
				model,
				{timeSinceLocalSpawned: updatedTime});
		}
	});
var _ianmackenzie$acorn_demo$Main$spawnExpressTrain = F2(
	function (delta, model) {
		var updatedTime = model.timeSinceExpressSpawned + delta;
		if (_elm_lang$core$Native_Utils.cmp(updatedTime, 11.34636) > 0) {
			var _p16 = _ianmackenzie$acorn_demo$Main$popNextId(model);
			var id = _p16._0;
			var modelWithIdPopped = _p16._1;
			var _p17 = A2(_ianmackenzie$acorn_demo$World$spawnExpressTrain, id, model.world);
			if (_p17.ctor === 'Ok') {
				return _elm_lang$core$Native_Utils.update(
					modelWithIdPopped,
					{world: _p17._0, timeSinceExpressSpawned: 0});
			} else {
				return _elm_lang$core$Native_Utils.update(
					model,
					{timeSinceExpressSpawned: 0});
			}
		} else {
			return _elm_lang$core$Native_Utils.update(
				model,
				{timeSinceExpressSpawned: updatedTime});
		}
	});
var _ianmackenzie$acorn_demo$Main$init = function () {
	var initialModel = {
		world: _ianmackenzie$acorn_demo$World$init,
		nextNewId: 1,
		availableIds: {ctor: '[]'},
		running: true,
		controllers: _elm_lang$core$Dict$empty,
		timeSinceLocalSpawned: 1 / 0,
		timeSinceExpressSpawned: 1 / 0
	};
	var model = A2(
		_ianmackenzie$acorn_demo$Main$spawnExpressTrain,
		0,
		A2(_ianmackenzie$acorn_demo$Main$spawnLocalTrain, 0, initialModel));
	return {ctor: '_Tuple2', _0: model, _1: _elm_lang$core$Platform_Cmd$none};
}();
var _ianmackenzie$acorn_demo$Main$gamepadEvents = _elm_lang$core$Native_Platform.incomingPort(
	'gamepadEvents',
	A2(
		_elm_lang$core$Json_Decode$andThen,
		function (x0) {
			return A2(
				_elm_lang$core$Json_Decode$andThen,
				function (x1) {
					return _elm_lang$core$Json_Decode$succeed(
						{ctor: '_Tuple2', _0: x0, _1: x1});
				},
				A2(
					_elm_lang$core$Json_Decode$index,
					1,
					_elm_lang$core$Json_Decode$list(
						_elm_lang$core$Json_Decode$oneOf(
							{
								ctor: '::',
								_0: _elm_lang$core$Json_Decode$null(_elm_lang$core$Maybe$Nothing),
								_1: {
									ctor: '::',
									_0: A2(
										_elm_lang$core$Json_Decode$map,
										_elm_lang$core$Maybe$Just,
										A2(
											_elm_lang$core$Json_Decode$andThen,
											function (axes) {
												return A2(
													_elm_lang$core$Json_Decode$andThen,
													function (buttons) {
														return A2(
															_elm_lang$core$Json_Decode$andThen,
															function (connected) {
																return A2(
																	_elm_lang$core$Json_Decode$andThen,
																	function (id) {
																		return A2(
																			_elm_lang$core$Json_Decode$andThen,
																			function (index) {
																				return A2(
																					_elm_lang$core$Json_Decode$andThen,
																					function (mapping) {
																						return A2(
																							_elm_lang$core$Json_Decode$andThen,
																							function (timestamp) {
																								return _elm_lang$core$Json_Decode$succeed(
																									{axes: axes, buttons: buttons, connected: connected, id: id, index: index, mapping: mapping, timestamp: timestamp});
																							},
																							A2(_elm_lang$core$Json_Decode$field, 'timestamp', _elm_lang$core$Json_Decode$float));
																					},
																					A2(_elm_lang$core$Json_Decode$field, 'mapping', _elm_lang$core$Json_Decode$string));
																			},
																			A2(_elm_lang$core$Json_Decode$field, 'index', _elm_lang$core$Json_Decode$int));
																	},
																	A2(_elm_lang$core$Json_Decode$field, 'id', _elm_lang$core$Json_Decode$string));
															},
															A2(_elm_lang$core$Json_Decode$field, 'connected', _elm_lang$core$Json_Decode$bool));
													},
													A2(
														_elm_lang$core$Json_Decode$field,
														'buttons',
														_elm_lang$core$Json_Decode$array(
															A2(
																_elm_lang$core$Json_Decode$andThen,
																function (x0) {
																	return A2(
																		_elm_lang$core$Json_Decode$andThen,
																		function (x1) {
																			return _elm_lang$core$Json_Decode$succeed(
																				{ctor: '_Tuple2', _0: x0, _1: x1});
																		},
																		A2(_elm_lang$core$Json_Decode$index, 1, _elm_lang$core$Json_Decode$float));
																},
																A2(_elm_lang$core$Json_Decode$index, 0, _elm_lang$core$Json_Decode$bool)))));
											},
											A2(
												_elm_lang$core$Json_Decode$field,
												'axes',
												_elm_lang$core$Json_Decode$array(_elm_lang$core$Json_Decode$float)))),
									_1: {ctor: '[]'}
								}
							}))));
		},
		A2(_elm_lang$core$Json_Decode$index, 0, _elm_lang$core$Json_Decode$float)));
var _ianmackenzie$acorn_demo$Main$ControllerState = F3(
	function (a, b, c) {
		return {controller: a, player: b, selection: c};
	});
var _ianmackenzie$acorn_demo$Main$Model = F7(
	function (a, b, c, d, e, f, g) {
		return {world: a, availableIds: b, nextNewId: c, running: d, controllers: e, timeSinceExpressSpawned: f, timeSinceLocalSpawned: g};
	});
var _ianmackenzie$acorn_demo$Main$PlayerTwo = {ctor: 'PlayerTwo'};
var _ianmackenzie$acorn_demo$Main$PlayerOne = {ctor: 'PlayerOne'};
var _ianmackenzie$acorn_demo$Main$OffTrack = function (a) {
	return {ctor: 'OffTrack', _0: a};
};
var _ianmackenzie$acorn_demo$Main$SelectedTrain = function (a) {
	return {ctor: 'SelectedTrain', _0: a};
};
var _ianmackenzie$acorn_demo$Main$clearSelection = F3(
	function (world, trainId, controllers) {
		return A2(
			_elm_lang$core$Dict$map,
			F2(
				function (controllerId, controllerState) {
					if (_elm_lang$core$Native_Utils.eq(
						controllerState.selection,
						_ianmackenzie$acorn_demo$Main$SelectedTrain(trainId))) {
						var _p18 = A2(_ianmackenzie$acorn_demo$World$findTrain, trainId, world);
						if (_p18.ctor === 'Just') {
							return _elm_lang$core$Native_Utils.update(
								controllerState,
								{
									selection: _ianmackenzie$acorn_demo$Main$OffTrack(
										_ianmackenzie$acorn_demo$Train$type_(_p18._0))
								});
						} else {
							var _p19 = A2(_elm_lang$core$Debug$log, 'Selected train not found', trainId);
							return controllerState;
						}
					} else {
						return controllerState;
					}
				}),
			controllers);
	});
var _ianmackenzie$acorn_demo$Main$moveTrains = F2(
	function (time, model) {
		var _p20 = A3(
			_ianmackenzie$acorn_demo$World$update,
			time,
			_ianmackenzie$acorn_demo$Main$trainInputs(model),
			model.world);
		var updatedWorld = _p20._0;
		var removedIds = _p20._1;
		var updatedControllers = A3(
			_elm_lang$core$List$foldl,
			_ianmackenzie$acorn_demo$Main$clearSelection(model.world),
			model.controllers,
			removedIds);
		return _elm_lang$core$Native_Utils.update(
			model,
			{
				world: updatedWorld,
				availableIds: _elm_lang$core$List$concat(
					{
						ctor: '::',
						_0: model.availableIds,
						_1: {
							ctor: '::',
							_0: removedIds,
							_1: {ctor: '[]'}
						}
					}),
				controllers: updatedControllers
			});
	});
var _ianmackenzie$acorn_demo$Main$updateSelection = F3(
	function (model, event, selection) {
		var controlledIds = A2(
			_elm_lang$core$List$filterMap,
			function (controllerState) {
				var _p21 = controllerState.selection;
				if (_p21.ctor === 'SelectedTrain') {
					return _elm_lang$core$Maybe$Just(_p21._0);
				} else {
					return _elm_lang$core$Maybe$Nothing;
				}
			},
			_elm_lang$core$Dict$values(model.controllers));
		var withSelectedTrain = F2(
			function (id, handleTrain) {
				var _p22 = A2(_ianmackenzie$acorn_demo$World$findTrain, id, model.world);
				if (_p22.ctor === 'Just') {
					return handleTrain(_p22._0);
				} else {
					return _ianmackenzie$acorn_demo$Main$SelectedTrain(
						A2(_elm_lang$core$Debug$log, 'Could not find selected train', id));
				}
			});
		var _p23 = {ctor: '_Tuple2', _0: event, _1: selection};
		if (_p23._1.ctor === 'SelectedTrain') {
			switch (_p23._0.ctor) {
				case 'MoveUp':
					var _p26 = _p23._1._0;
					return A2(
						withSelectedTrain,
						_p26,
						function (train) {
							var _p24 = _ianmackenzie$acorn_demo$Train$type_(train);
							if (_p24.ctor === 'Express') {
								var _p25 = A3(_ianmackenzie$acorn_demo$World$findBeside, _p26, controlledIds, model.world);
								if (_p25.ctor === 'Just') {
									return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p25._0);
								} else {
									return _ianmackenzie$acorn_demo$Main$OffTrack(_ianmackenzie$acorn_demo$Train$Local);
								}
							} else {
								return selection;
							}
						});
				case 'MoveDown':
					var _p29 = _p23._1._0;
					return A2(
						withSelectedTrain,
						_p29,
						function (train) {
							var _p27 = _ianmackenzie$acorn_demo$Train$type_(train);
							if (_p27.ctor === 'Local') {
								var _p28 = A3(_ianmackenzie$acorn_demo$World$findBeside, _p29, controlledIds, model.world);
								if (_p28.ctor === 'Just') {
									return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p28._0);
								} else {
									return _ianmackenzie$acorn_demo$Main$OffTrack(_ianmackenzie$acorn_demo$Train$Express);
								}
							} else {
								return selection;
							}
						});
				case 'MoveLeft':
					var _p31 = _p23._1._0;
					return A2(
						withSelectedTrain,
						_p31,
						function (train) {
							var _p30 = A3(_ianmackenzie$acorn_demo$World$findPrevious, _p31, controlledIds, model.world);
							if (_p30.ctor === 'Just') {
								return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p30._0);
							} else {
								return _ianmackenzie$acorn_demo$Main$OffTrack(
									_ianmackenzie$acorn_demo$Train$type_(train));
							}
						});
				default:
					var _p33 = _p23._1._0;
					return A2(
						withSelectedTrain,
						_p33,
						function (train) {
							var _p32 = A3(_ianmackenzie$acorn_demo$World$findNext, _p33, controlledIds, model.world);
							if (_p32.ctor === 'Just') {
								return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p32._0);
							} else {
								return _ianmackenzie$acorn_demo$Main$OffTrack(
									_ianmackenzie$acorn_demo$Train$type_(train));
							}
						});
			}
		} else {
			switch (_p23._0.ctor) {
				case 'MoveUp':
					if (_p23._1._0.ctor === 'Local') {
						return selection;
					} else {
						return _ianmackenzie$acorn_demo$Main$OffTrack(_ianmackenzie$acorn_demo$Train$Local);
					}
				case 'MoveDown':
					if (_p23._1._0.ctor === 'Local') {
						return _ianmackenzie$acorn_demo$Main$OffTrack(_ianmackenzie$acorn_demo$Train$Express);
					} else {
						return selection;
					}
				case 'MoveLeft':
					var _p34 = A3(_ianmackenzie$acorn_demo$World$findLast, _p23._1._0, controlledIds, model.world);
					if (_p34.ctor === 'Just') {
						return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p34._0);
					} else {
						return selection;
					}
				default:
					var _p35 = A3(_ianmackenzie$acorn_demo$World$findFirst, _p23._1._0, controlledIds, model.world);
					if (_p35.ctor === 'Just') {
						return _ianmackenzie$acorn_demo$Main$SelectedTrain(_p35._0);
					} else {
						return selection;
					}
			}
		}
	});
var _ianmackenzie$acorn_demo$Main$handleGamepadInput = F2(
	function (gamepad, model) {
		var gamepadIndex = _xarvh$elm_gamepad$Gamepad$getIndex(gamepad);
		var _p36 = A2(_elm_lang$core$Dict$get, gamepadIndex, model.controllers);
		if (_p36.ctor === 'Just') {
			var _p37 = A2(_ianmackenzie$acorn_demo$Controller$update, gamepad, _p36._0.controller);
			var updatedController = _p37._0;
			var events = _p37._1;
			var updatedSelection = A3(
				_elm_lang$core$List$foldl,
				_ianmackenzie$acorn_demo$Main$updateSelection(model),
				_p36._0.selection,
				events);
			return _elm_lang$core$Native_Utils.update(
				model,
				{
					controllers: A3(
						_elm_lang$core$Dict$insert,
						gamepadIndex,
						{controller: updatedController, player: _p36._0.player, selection: updatedSelection},
						model.controllers)
				});
		} else {
			return _elm_lang$core$Native_Utils.update(
				model,
				{
					controllers: A3(
						_elm_lang$core$Dict$insert,
						gamepadIndex,
						{
							controller: _ianmackenzie$acorn_demo$Controller$init(gamepad),
							selection: _ianmackenzie$acorn_demo$Main$OffTrack(_ianmackenzie$acorn_demo$Train$Local),
							player: _elm_lang$core$Dict$isEmpty(model.controllers) ? _ianmackenzie$acorn_demo$Main$PlayerOne : _ianmackenzie$acorn_demo$Main$PlayerTwo
						},
						model.controllers)
				});
		}
	});
var _ianmackenzie$acorn_demo$Main$update = F2(
	function (message, model) {
		var _p38 = message;
		switch (_p38.ctor) {
			case 'GamepadEvent':
				var delta = model.running ? _elm_lang$core$Time$inSeconds(_p38._0._0) : 0;
				var gamepads = A2(_xarvh$elm_gamepad$Gamepad$getGamepads, _xarvh$elm_gamepad$Gamepad$emptyDatabase, _p38._0._1);
				return {
					ctor: '_Tuple2',
					_0: A2(
						_ianmackenzie$acorn_demo$Main$moveTrains,
						delta,
						A2(
							_ianmackenzie$acorn_demo$Main$spawnExpressTrain,
							delta,
							A2(
								_ianmackenzie$acorn_demo$Main$spawnLocalTrain,
								delta,
								A3(_elm_lang$core$List$foldl, _ianmackenzie$acorn_demo$Main$handleGamepadInput, model, gamepads)))),
					_1: _elm_lang$core$Platform_Cmd$none
				};
			case 'KeyPress':
				return {
					ctor: '_Tuple2',
					_0: _elm_lang$core$Native_Utils.update(
						model,
						{running: !model.running}),
					_1: _elm_lang$core$Platform_Cmd$none
				};
			default:
				return _ianmackenzie$acorn_demo$Main$init;
		}
	});
var _ianmackenzie$acorn_demo$Main$Reset = {ctor: 'Reset'};
var _ianmackenzie$acorn_demo$Main$view = function (model) {
	var logoRectangle = A3(
		_ianmackenzie$acorn_demo$Rectangle2d$translateIn,
		_ianmackenzie$acorn_demo$Direction2d$y,
		20,
		A3(
			_ianmackenzie$acorn_demo$Rectangle2d$translateIn,
			_ianmackenzie$acorn_demo$Direction2d$x,
			-5,
			_ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
				{minX: 0, maxX: 833, maxY: 1080, minY: 1080 - 170})));
	var backgroundRectangle = _ianmackenzie$acorn_demo$Rectangle2d$fromExtrema(
		{minX: 0, maxX: 1920, minY: 0, maxY: 1080});
	var renderBounds = _ianmackenzie$acorn_demo$BoundingBox2d$fromExtrema(
		{minX: 0, minY: 0, maxX: 1920, maxY: 1080});
	return A2(
		_elm_lang$html$Html$div,
		{
			ctor: '::',
			_0: _elm_lang$html$Html_Attributes$style(
				{
					ctor: '::',
					_0: {ctor: '_Tuple2', _0: 'overflow', _1: 'hidden'},
					_1: {
						ctor: '::',
						_0: {ctor: '_Tuple2', _0: 'max-height', _1: '1080px'},
						_1: {
							ctor: '::',
							_0: {ctor: '_Tuple2', _0: 'max-width', _1: '1920px'},
							_1: {ctor: '[]'}
						}
					}
				}),
			_1: {ctor: '[]'}
		},
		{
			ctor: '::',
			_0: A3(
				_ianmackenzie$acorn_demo$Drawing2d$toHtml,
				renderBounds,
				{
					ctor: '::',
					_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$blackStroke,
					_1: {
						ctor: '::',
						_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontSize(14),
						_1: {
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$textColor(_elm_lang$core$Color$white),
							_1: {
								ctor: '::',
								_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fontFamily(
									{
										ctor: '::',
										_0: 'monospace',
										_1: {ctor: '[]'}
									}),
								_1: {ctor: '[]'}
							}
						}
					}
				},
				{
					ctor: '::',
					_0: A2(
						_ianmackenzie$acorn_demo$Drawing2d$rectangleWith,
						{
							ctor: '::',
							_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$fillColor(_ianmackenzie$acorn_demo$Background$color),
							_1: {ctor: '[]'}
						},
						backgroundRectangle),
					_1: {
						ctor: '::',
						_0: A2(
							_ianmackenzie$acorn_demo$Drawing2d$placeIn,
							_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
								{ctor: '_Tuple2', _0: 45, _1: 455}),
							A2(
								_ianmackenzie$acorn_demo$RouteControlScreen$draw,
								model.world,
								{ctor: '[]'})),
						_1: {
							ctor: '::',
							_0: A2(
								_ianmackenzie$acorn_demo$Drawing2d$placeIn,
								_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
									{ctor: '_Tuple2', _0: 0, _1: 350}),
								A2(
									_ianmackenzie$acorn_demo$World$draw,
									_ianmackenzie$acorn_demo$Main$trainColors(model),
									model.world)),
							_1: {
								ctor: '::',
								_0: A2(
									_ianmackenzie$acorn_demo$Drawing2d$placeIn,
									_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
										{ctor: '_Tuple2', _0: 45, _1: 38}),
									A2(_ianmackenzie$acorn_demo$Main$drawTrainControls, model, _ianmackenzie$acorn_demo$Main$PlayerOne)),
								_1: {
									ctor: '::',
									_0: A2(
										_ianmackenzie$acorn_demo$Drawing2d$placeIn,
										_ianmackenzie$acorn_demo$Frame2d$atCoordinates(
											{ctor: '_Tuple2', _0: 970, _1: 38}),
										A2(_ianmackenzie$acorn_demo$Main$drawTrainControls, model, _ianmackenzie$acorn_demo$Main$PlayerTwo)),
									_1: {
										ctor: '::',
										_0: A2(
											_ianmackenzie$acorn_demo$Drawing2d$groupWith,
											{
												ctor: '::',
												_0: _ianmackenzie$acorn_demo$Drawing2d_Attributes$onClick(_ianmackenzie$acorn_demo$Main$Reset),
												_1: {ctor: '[]'}
											},
											{
												ctor: '::',
												_0: A2(_ianmackenzie$acorn_demo$Drawing2d$image, 'images/ACORN-by-Arup_TM-logo_white.svg', logoRectangle),
												_1: {ctor: '[]'}
											}),
										_1: {ctor: '[]'}
									}
								}
							}
						}
					}
				}),
			_1: {ctor: '[]'}
		});
};
var _ianmackenzie$acorn_demo$Main$GamepadEvent = function (a) {
	return {ctor: 'GamepadEvent', _0: a};
};
var _ianmackenzie$acorn_demo$Main$KeyPress = function (a) {
	return {ctor: 'KeyPress', _0: a};
};
var _ianmackenzie$acorn_demo$Main$subscriptions = function (model) {
	return _elm_lang$core$Platform_Sub$batch(
		{
			ctor: '::',
			_0: _elm_lang$keyboard$Keyboard$presses(_ianmackenzie$acorn_demo$Main$KeyPress),
			_1: {
				ctor: '::',
				_0: _ianmackenzie$acorn_demo$Main$gamepadEvents(_ianmackenzie$acorn_demo$Main$GamepadEvent),
				_1: {ctor: '[]'}
			}
		});
};
var _ianmackenzie$acorn_demo$Main$main = _elm_lang$html$Html$program(
	{init: _ianmackenzie$acorn_demo$Main$init, view: _ianmackenzie$acorn_demo$Main$view, update: _ianmackenzie$acorn_demo$Main$update, subscriptions: _ianmackenzie$acorn_demo$Main$subscriptions})();

var Elm = {};
Elm['Main'] = Elm['Main'] || {};
if (typeof _ianmackenzie$acorn_demo$Main$main !== 'undefined') {
    _ianmackenzie$acorn_demo$Main$main(Elm['Main'], 'Main', undefined);
}

if (typeof define === "function" && define['amd'])
{
  define([], function() { return Elm; });
  return;
}

if (typeof module === "object")
{
  module['exports'] = Elm;
  return;
}

var globalElm = this['Elm'];
if (typeof globalElm === "undefined")
{
  this['Elm'] = Elm;
  return;
}

for (var publicModule in Elm)
{
  if (publicModule in globalElm)
  {
    throw new Error('There are two Elm modules called `' + publicModule + '` on this page! Rename one of them.');
  }
  globalElm[publicModule] = Elm[publicModule];
}

}).call(this);

