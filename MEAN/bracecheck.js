function bracecheck(str) {
	var parentheses = 0;
	var squares = 0;
	var curlies = 0;
	for (var i = 0; i < str.length; i++) {
		if (str[i] === '(') {
			parentheses++;
		}
		if (str[i] === '[') {
			squares++;
		}
		if (str[i] === '{') {
			curlies++;
		}
		if (str[i] === ')') {
			parentheses--;
			if (parentheses < 0) {
				return false;
			}
		}
		if (str[i] === ']') {
			squares--;
			if (squares < 0) {
				return false;
			}
		}
		if (str[i] === '}') {
			curlies--;
			if (curlies < 0) {
				return false;
			}
		}
	}
	console.log(parentheses, squares, curlies);
	if (parentheses == 0 && squares == 0 && curlies == 0) {
		return true;
	}
	return false;
}

console.log(bracecheck('asdfasdf}sdf(('));
