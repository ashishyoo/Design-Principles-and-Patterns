namespace CharacterDecorator
{
    public interface ICharacter
    {
        string GetAbilities();
    }

    public class Mario : ICharacter
    {
        public string GetAbilities()
        {
            return $"Mario";
        }
    }

    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;

        public CharacterDecorator(ICharacter character)
        {
            _character = character;
        }

        public virtual string GetAbilities()
        {
            return _character.GetAbilities();
        }
    }

    public class HeightPower : CharacterDecorator
    {
        public HeightPower(ICharacter character) : base(character) { }

        public override string GetAbilities()
        {
            return _character.GetAbilities() + " with Height power";
        }
    }

    public class GunPower : CharacterDecorator
    {
        public GunPower(ICharacter character) : base(character) { }

        public override string GetAbilities()
        {
            return _character.GetAbilities() + " with Gun power";
        }
    }
}