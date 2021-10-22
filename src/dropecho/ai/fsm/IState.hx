package dropecho.ai.fsm;

@:expose("fsm.State")
@:nativeChildren
interface IState {
  public function getName():String;
  public function onEnter():Void;
  public function onExit():Void;
  public function tick():Void;
}
