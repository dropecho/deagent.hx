package deagent.ai.bt.node.composite;

using Lambda;


@:expose("de.bt.SequenceNode")
class SequenceNode extends CompositeNode {
	public function new(children : Array<Node>){
		super(children);
	}

	public override function execute() : NODE_STATUS {
		var status = this.childIterator.current().execute();

		if(NODE_STATUS.SUCCESS == status){
			if(this.childIterator.hasNext()){
				this.childIterator.next();
				return NODE_STATUS.RUNNING;
			}

			return NODE_STATUS.SUCCESS;
		}

		if(NODE_STATUS.FAILURE == status){
			this.childIterator.reset();
		}

		return status;
	}
}


