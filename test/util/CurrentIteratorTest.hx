package util;

import massive.munit.Assert;
import dropecho.util.CurrentIterator;

class CurrentIteratorTest {
	private var array : Array<Int>;
	private var iter : CurrentIterator<Int>;

	@Before public function setup(){
		array = new Array<Int>();

		array.push(0);
		array.push(1);
		array.push(2);
		array.push(3);

		iter = new CurrentIterator<Int>(array);
	}

	@Test public function current_iterator_should_start_at_first_node() {
		Assert.areEqual(0, iter.current());
	}

	@Test public function current_iterator_next_should_give_first_item() {
		Assert.areEqual(0, iter.next());
	}

	@Test public function calling_next_should_increment_item_given_by_current() {
		iter.next();
		Assert.areEqual(1, iter.current());
	}

	@Test public function has_next_should_return_true_when_iterator_is_not_at_end_of_array(){
		Assert.isTrue(iter.hasNext());
	}

	@Test public function has_next_should_return_false_when_iterator_is_at_end_of_array(){
		iter.next();
		iter.next();
		iter.next();
		iter.next();
		Assert.isFalse(iter.hasNext());
	}

}
