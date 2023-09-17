/**
 * @param {number} num
 * @return {string}
 */
function intToRoman(num) {
    const numeralBases = new Map([
        ["M", 1000],
        ["CM", 900],
        ["D", 500],
        ["CD", 400],
        ["C", 100],
        ["XC", 90],
        ["L", 50],
        ["XL", 40],
        ["X", 10],
        ["IX", 9],
        ["V", 5],
        ["IV", 4],
        ["I", 1],
    ]);

    let result = '';

    for (const [numeral, baseValue] of numeralBases) {
        while (num >= baseValue) {
            num -= baseValue;
            result += numeral;
        }
    }

    return result;
}