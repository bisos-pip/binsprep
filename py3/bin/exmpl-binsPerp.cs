#!/bisos/venv/py3/dev-bisos3/bin/python


from bisos.binsprep import interface

interface.setFunc("FROM MINI")

__file__ = '/bisos/git/bxRepos/bisos-pip/binsprep/py3/bin/seedBinsPrep.cs'
with open(__file__) as f:
    exec(compile(f.read(), __file__, 'exec'))
