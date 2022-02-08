describe('My First Test', () => {
  it('Does not do much!', () => {
    expect(true).to.equal(true)
  })
})
describe('My First Test', () => {
  it('Visits myAngular', () => {
    cy.visit('http://localhost:4200/main')
    cy.contains('Exercices').click()
    cy.get('app-exercices-view > p')
      .should('have.text', 'exercices-view works!')

   // cy.contains('Création utilisateur').click()
  })
})
