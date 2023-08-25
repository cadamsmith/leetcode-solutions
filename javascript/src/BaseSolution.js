export class BaseSolution {
	execute(parameters) {
		return solve(...parameters);
	}

	solve() {
		throw new Error('method not implemented');
	}
}
