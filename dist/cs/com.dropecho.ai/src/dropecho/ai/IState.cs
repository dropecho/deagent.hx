using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace dropecho.ai {
	public interface IState {
		
		string getName();
		
		void onEnter();
		
		void onExit();
		
		void tick();
		
	}
}


