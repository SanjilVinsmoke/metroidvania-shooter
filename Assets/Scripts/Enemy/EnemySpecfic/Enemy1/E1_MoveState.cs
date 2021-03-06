

public class E1_MoveState : MoveState
{
	private Enemy1 enemy;
	private D_MoveState moveStateData;


	public E1_MoveState(Entity entity, FiniteStateMachine stateMachine, int animBoolName, D_MoveState stateData, Enemy1 enemy) : base(entity, stateMachine, animBoolName, stateData)
	{
		this.enemy = enemy;
		
	}
	public override void Enter()
	{
		base.Enter();
	}

	public override void Exit()
	{
		base.Exit();
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();
		if (!isDetectingLedge|| isDetectingWall)
		{
			enemy.idleState.SetFlipAfterIdle(true);
			//Changing State to enemy idle
			stateMachine.ChangeState(enemy.idleState);
		}
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
	}
}
