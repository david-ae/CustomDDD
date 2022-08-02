namespace CustomDDD.API
{
    public class FakePupilStore
    {
        private static List<Pupil> _pupils;

        public FakePupilStore()
        {
            _pupils = new()
            {
                new Pupil{Id = 1, Name = "Test Pupil 1"},
                new Pupil{Id = 2, Name = "Test Pupil 2"},
                new Pupil{Id = 3, Name = "Test Pupil 3"},
            };
        }

        public async Task AddPupil(Pupil pupli)
        {
            _pupils.Add(pupli);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Pupil>> GetAllPupils() => await Task.FromResult(_pupils);
        public async Task<Pupil> GetPupilById(int Id) => await Task.FromResult(_pupils.Single(p => p.Id == Id));
        public async Task EventOccurred(Pupil pupil, string evt)
        {
            _pupils.Single(p => p.Id == pupil.Id).Name = $"{pupil.Name} evt: {evt}";
            await Task.CompletedTask;
        }
    }
}
