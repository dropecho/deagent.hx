package dropecho.ai.bt.node.composite;
using Lambda;

import dropecho.ai.bt.node.Node;

@:expose("bt.SelectorNode")
class SelectorNode extends CompositeNode {
	public function new(children : Array<Node>){
		super(children);
	}

	public override function execute() : NODE_STATUS {
		var status = this.childIterator.current().execute();

		if(status == NODE_STATUS.SUCCESS) {
			this.childIterator.reset();
			return NODE_STATUS.SUCCESS;
		}

		if(status == NODE_STATUS.FAILURE) {
			if(!this.childIterator.hasNext()){
				this.childIterator.reset();
				return NODE_STATUS.FAILURE;
			}

			this.childIterator.next();
		}

		return NODE_STATUS.RUNNING;
	}
}


