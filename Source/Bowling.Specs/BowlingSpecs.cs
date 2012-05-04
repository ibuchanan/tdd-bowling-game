using System.Collections.Generic;
using Bowling;
using Bowling.Specs.Infrastructure;

namespace specs_for_bowling
{
	public class when_everything_is_wired_up : concerns
	{
		private bool _itWorked;

		protected override void context()
		{
			_itWorked = true;
		}

		[Specification]
		public void it_works()
		{
			_itWorked.should_be_true("we're ready to roll!");
		}

        [Specification]
        public void InitialScoreIsZeroTest()
        {
            var target = new Game();
            target.Score().should_equal(0);
        }

        [Specification]
        public void FrameOneLessThanTenTest()
        {
            var target = new Game();
            target.Roll(1);
            target.Roll(4);
            target.Score().should_equal(5);
        }

        [Specification]
        public void InitializeGameTest()
        {
            var target = new Game(new [] {1, 4});
            target.Score().should_equal(5);
        }

        [Specification]
        public void FrameTwoScoreTest()
        {
            var target = new Game(new[] { 1, 4 });
            target.Roll(4);
            target.Roll(5);
            target.Score().should_equal(14);
        }

        [Specification]
        public void FrameThreeScoreTest()
        {
            var target = new Game(new[] { 1, 4, 4, 5 });
            target.Roll(6);
            target.Roll(4);
            target.Score().should_equal(24);
        }

        [Specification]
        public void FrameFourScoreTest()
        {
            var target = new Game(new[] {1, 4, 4, 5, 6, 4});
            target.Roll(5);
            target.Roll(5);
            target.Score().should_equal(44);
        }

	}
}