using DG.Tweening;
using DoodleJump.Abstarcts;

public class StaticEnemy : Enemy
{
    private void Start()
    {
        transform.DOMoveY(transform.position.y + 1, 1, false).SetLoops(-1, LoopType.Yoyo);
    }
}
