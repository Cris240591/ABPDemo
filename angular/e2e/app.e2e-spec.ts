import { ABMExampleTemplatePage } from './app.po';

describe('ABMExample App', function() {
  let page: ABMExampleTemplatePage;

  beforeEach(() => {
    page = new ABMExampleTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
